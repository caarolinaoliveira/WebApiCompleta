
using AutoMapper;
using DevIO.Api.ViewModels;
using Dev.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Dev.Business.Notificacoes;

namespace DevIO.Api.Controllers
{

    [ApiController]
    public abstract class MainController : ControllerBase
    {
        // validação de notificação de erro
        private readonly INotificador _notificador;
        public MainController(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected bool OperacaoValida()
        {
            return !_notificador.TemNotificacao();  
        }

        protected ActionResult CustomResponse(object result = null)
        {
            if (OperacaoValida())
            {
                return Ok(new
                {
                    success = true,
                    data = result
                });
            }
            return BadRequest( new
            {
                success = false,
                errors = _notificador.ObterNotificacoes().Select(n => n.Mensagem)
            });
        }
        protected ActionResult CustomResponse(ModelStateDictionary modelState)
        {
            if (!ModelState.IsValid) NotificarErroModelInvalid(modelState);
            return CustomResponse();
        }

        protected void NotificarErroModelInvalid(ModelStateDictionary modelState)
        {
            var errors = modelState.Values.SelectMany(v => v.Errors);
            foreach (var error in errors)
            {
                var erroMsg = error.Exception == null ? error.ErrorMessage : error.Exception.Message;
                NotificarErro(erroMsg);
            }
        }

        protected void NotificarErro(string mensagem)
        {
            _notificador.Handle(new Notificacao(mensagem));
        }

    }

}



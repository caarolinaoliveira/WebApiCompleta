import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";

import { Observable } from "rxjs";
import { catchError, map } from "rxjs/operators";
import { User } from './user';
import { BaseService } from '../base/baseService';


@Injectable()
export class UserService extends BaseService {

    constructor(private http: HttpClient) { super() }

    login(user: User): Observable<User> {

        return this.http
            .post('http://localhost:5241/api/conta/entrar', user, super.ObterHeaderJson())
            .pipe(
                map(super.extractData),
                catchError(super.serviceError)
            );
    }

    persistirUserApp(response: any){
        localStorage.setItem('app.token', response.accessToken);
        localStorage.setItem('app.user', JSON.stringify(response.userToken));
    }
}
import { Injectable } from '@angular/core';
import {
  Request,
  XHRBackend,
  RequestOptions,
  Response,
  Http,
  RequestOptionsArgs,
  Headers
} from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';
import { Router } from '@angular/router';
import { BaseAuthenticatedHttpService } from '../../../common/services/base-authenticated-http-service';
import { AdminNavigationService } from './../services/navigation/admin-navigation.service';

@Injectable()
export class AuthenticatedHttpService extends BaseAuthenticatedHttpService {
  constructor(
    public backend: XHRBackend,
    public defaultOptions: RequestOptions,
    public navigation: AdminNavigationService
  ) {
    super(backend, defaultOptions, navigation);
  }

  request(
    url: string | Request,
    options?: RequestOptionsArgs
  ): Observable<Response> {
    return super.request(url, options).catch((error: Response) => {
      if (
        (error.status === 401 || error.status === 403) &&
        (window.location.href.match(/\?/g) || []).length < 2
      ) {
        this.navigation.goToLogin();
      }
      return Observable.throw(error);
    });
  }
}

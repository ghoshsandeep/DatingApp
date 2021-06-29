import { Component, OnInit } from '@angular/core';
import { error } from 'protractor';
import { Observable } from 'rxjs';
import { User } from '../_models/user';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
model: any = {}
//loogedin:boolean;
currentUser$:Observable<User>;

  constructor(private accountService:AccountService) { }

  ngOnInit(): void {
    //this.getCurrentUser();
    this.currentUser$=this.accountService.currentUser$;

  }

  login()
  {
    this.accountService.login(this.model).subscribe(response =>{
      console.log(response);
     // this.loogedin= true;
    },error=>{
    console.log(error);
    })
  }

  logout()
  {
    this.accountService.logout();
    //this.loogedin=false
  }

  /*getCurrentUser()
  {
    this.accountService.currentUser$.subscribe(user=>{
      this.loogedin=!!user;
    },error =>{
      console.log(error);
    })
  }*/

}

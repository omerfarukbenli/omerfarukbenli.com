import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-logins',
  templateUrl: './logins.component.html',
  styleUrls: ['./logins.component.css']
})
export class LoginsComponent {
  invalidLogin:boolean;
  constructor(private router:Router, private http:HttpClient) { }

  login(form:NgForm){
    const credentials = {
      'username': form.value.username,
      'password': form.value.password,
    }

    this.http.post("http://omerfarukbenli.com/home/api/Auth/login", credentials).subscribe(response => {
      const token = (<any>response).token;
      localStorage.setItem("jwt", token);
      this.invalidLogin = false;
      this.router.navigate(["admin/posts"]);

    },err => {
      this.invalidLogin = true;
    })


  }
}


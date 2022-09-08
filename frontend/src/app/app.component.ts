import { Component, OnInit } from '@angular/core';
import { About } from './models/about';
import { Home } from './models/home';
import { Link } from './models/link';
import { Repo } from './models/repo';
import { Url } from './models/url';

import { HomeService } from './services/home.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {



  home:Home[];
  about:About[];
  repo:Repo[];
  link:Link[];
  url:Url[];
  id:number;


  constructor(private homeService:HomeService) { }

  //home
  ngOnInit(): void {
    this.homeService.HomeGet().subscribe(result =>{
      this.home = result;
    })

    //about
    this.homeService.AboutGet().subscribe(result =>{
      this.about = result;
    })

    //repo
    this.homeService.RepoGet().subscribe(result =>{
      this.repo = result;
    })

   //link
   this.homeService.LinkGet().subscribe(result =>{
    this.link = result;
  })
  //url
  this.homeService.UrlGet().subscribe(result =>{
    this.url = result;
  })
  }

}

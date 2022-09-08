import { Component, OnInit } from '@angular/core';
import { About } from 'src/app/models/about';
import { Home } from 'src/app/models/home';
import { Link } from 'src/app/models/link';
import { Repo } from 'src/app/models/repo';
import { Url } from 'src/app/models/url';
import { HomeService } from 'src/app/services/home.service';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

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

import { Component, OnInit } from '@angular/core';
import { Post } from 'src/app/models/post.model';
import { PostService } from 'src/app/services/post.service';

@Component({
  selector: 'app-posts',
  templateUrl: './posts.component.html',
  styleUrls: ['./posts.component.css']
})
export class PostsComponent implements OnInit {

  constructor(private postService:PostService) { }










  posts:Post[] = [];
  post:Post |undefined;




    ngOnInit(): void {
      this.postService.getAllPosts()
      .subscribe(
        response => {
       this.posts = response;
       this.post = this.posts[0];
        }
      )
    }


     newPage()
    {
     window.location.assign("http://omerfarukbenli.com/")
     //bu http://omerfarukbenli.com/ olacak
     //http://localhost:4200/
    }


  }


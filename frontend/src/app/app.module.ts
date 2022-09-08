import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';

import { HomeComponent } from './components/home/home.component';
import { PostComponent } from './components/post/post.component';
import { PostsComponent } from './components/posts/posts.component';
import { AdminAddPostComponent } from './components/admin/admin-add-post/admin-add-post.component';
import { AdminPostsComponent } from './components/admin/admin-posts/admin-post.component';
import { AdminViewPostComponent } from './components/admin/admin-view-post/admin-view-post.component';
import { FormsModule } from '@angular/forms';
import { LoginsComponent } from './components/logins/logins.component';



@NgModule({
  declarations: [
    AppComponent,

    HomeComponent,
    PostComponent,
    PostsComponent,
    AdminAddPostComponent,
    AdminPostsComponent,
    AdminViewPostComponent,
    LoginsComponent,


  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

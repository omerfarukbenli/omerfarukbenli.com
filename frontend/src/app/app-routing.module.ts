import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminAddPostComponent } from './components/admin/admin-add-post/admin-add-post.component';
import { AdminPostsComponent } from './components/admin/admin-posts/admin-post.component';
import { AdminViewPostComponent } from './components/admin/admin-view-post/admin-view-post.component';

import { HomeComponent } from './components/home/home.component';
import { LoginsComponent } from './components/logins/logins.component';
import { PostComponent } from './components/post/post.component';
import { PostsComponent } from './components/posts/posts.component';



const routes: Routes = [

    {path:'', component:HomeComponent},
  


    {path:'posts', component:PostsComponent},
    {path:'post/:id', component:PostComponent},
    {path:'admin/posts', component:AdminPostsComponent},
    {path:'admin/posts/add', component:AdminAddPostComponent},
    {path:'admin/posts/:id', component:AdminViewPostComponent},
    {path:'login', component:LoginsComponent},


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

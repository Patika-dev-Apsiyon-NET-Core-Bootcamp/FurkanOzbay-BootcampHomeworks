using AutoMapper;
using CleanArchitecture.Application.ViewModel;
using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Profiles
{
    public class BlogProfile:Profile
    {
        public BlogProfile()
        {
            CreateMap<BlogViewModel, Blog>();
            CreateMap<Blog, BlogViewModel>();
        }
    }
}

using AutoMapper;
using InfinityMeshExam.DAL.Domain;
using InfinityMeshExam.DAL.Requests;
using InfinityMeshExam.DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfinityMeshExam.DAL.Mapper
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<User, UserViewModel>().ReverseMap();
            CreateMap<User, UserUpsertRequest>().ReverseMap();
            CreateMap<Blog, BlogViewModel>().ReverseMap();
            CreateMap<Blog, BlogUpsertRequest>().ReverseMap();

        }
    }
}

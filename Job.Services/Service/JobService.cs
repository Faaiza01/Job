﻿using Job.Data.DAO;
using Job.Data.IDAO;
using Job.Data.Models.Domain;
using Job.Data.Repository;
using Job.Services.IService;
using Job.Services.Models;
using System.Collections.Generic;

namespace Job.Services.Service
{
    public class JobService : IJobService
    {
        private IJobDAO JobDAO;
  
        public JobService()
        {
            JobDAO = new JobDAO();
        }

        public void DeleteJob(int id)
        {
            using (var context = new JobContext())
            {
                JobDAO.DeleteJob(context, id);
            }
        }

        public void SaveJob(SavedJobs savedJobs)
        {
            using (var context = new JobContext())
            {
                JobDAO.SaveJob(context, savedJobs);
            }
        }

        public void AddJob(PostJobDto postJobDto, string userId)
        {      
            Employer newEmployer = new Employer()
            {
                JobTitle = postJobDto.JobTitle,
                JobDescription = postJobDto.JobDescription,
                JobCategory = postJobDto.JobCategory,
                Salary = postJobDto.Salary,
                CompanyName = postJobDto.CompanyName,
                CompanyAddress = postJobDto.CompanyAddress,
                ComapanyEmail = postJobDto.ComapanyEmail,
                CompanyWebsite = postJobDto.CompanyWebsite
            };
         
            using (var context = new JobContext())
            {   
                JobDAO.AddJob(context, newEmployer);//Add job
                context.SaveChanges();
            }  
        }

        public void ApplyJob(AppliedJobs appliedJobs)
        {         
            using (var context = new JobContext())
            {   
                JobDAO.ApplyJob(context, appliedJobs);//Apply for a job
                context.SaveChanges();
            }   
        }

        public void AddUser(App_User app_User)
        {

            using (var context = new JobContext())
            {   
                JobDAO.AddUser(context, app_User);//Add user
                context.SaveChanges();
            }   
        }

        public void EditJob(PostJobDto postJobDto, string userId, int id)
        {
            using (var context = new JobContext())
            {
                Employer employer =new Employer();
                employer.JobTitle = postJobDto.JobTitle;
                employer.JobDescription = postJobDto.JobDescription;
                employer.JobCategory = postJobDto.JobCategory;
                employer.Salary = postJobDto.Salary;
                employer.CompanyName = postJobDto.CompanyName;
                employer.CompanyAddress = postJobDto.CompanyAddress;
                employer.ComapanyEmail = postJobDto.ComapanyEmail;
                employer.CompanyWebsite = postJobDto.CompanyWebsite;

                JobDAO.EditJob(context, employer, id);//Update existing job         
                context.SaveChanges();
            }
        }

        public Employer GetJob(int id)
        {
            using (var context = new JobContext())
            {
                return JobDAO.GetJob(context, id);
            }
        }

        public App_User GetUserData(string id)
        {
            using (var context = new JobContext())
            {
                return JobDAO.GetUserData(context, id);
            }
        }
        public void RemoveUser(string id)
        {
            using (var context = new JobContext())
            {
                JobDAO.RemoveUser(context, id);
            }
        }
        public IList<App_User> GetUsers()
        {
            using (var context = new JobContext())
            {
                return JobDAO.GetUsers(context);
            }
        }
    }
}

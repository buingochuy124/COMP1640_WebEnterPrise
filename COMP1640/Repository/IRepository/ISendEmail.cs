using System;
using System.Threading.Tasks;
using COMP1640.ViewModels.Response;

namespace COMP1640.Repository.IRepository
{
	public interface ISendEmail
	{
        public void SendEMail(string email, string subject, string message);
       
    }
}


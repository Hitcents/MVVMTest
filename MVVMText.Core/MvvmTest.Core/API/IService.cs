using System;
using System.Threading.Tasks;

namespace MvvmTest.Core
{
    public interface IService
    {
		Task Login(string username, string password);
    }
}


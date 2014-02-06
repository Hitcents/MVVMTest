using System;
using System.Threading.Tasks;

namespace MvvmTest.Core
{
	public class FakeService : IService
    {
		private int sleep = 500;
		public bool ShouldFail = false;

        public FakeService()
        {
        }

		public async Task Login(string username, string password)
		{
			await SleepTask();

			if (string.IsNullOrEmpty(username))
				throw new Exception("Username cannot be empty!");
			if (string.IsNullOrEmpty(password))
				throw new Exception("Password cannot be empty!");
		}

		private async Task SleepTask()
		{
			await Task.Delay(sleep);

			if (ShouldFail)
				throw new Exception("Service failure.");
		}
    }
}


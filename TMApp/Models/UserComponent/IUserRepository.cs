using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMApp.Models.UserComponent
{
    interface IUserRepository:IDisposable
    {
        void RegisterUser(Register newUser);
        Register GetProfile(string Email);
        //IEnumerator <ScheduleSet> TaskList(string Email);
        void UpdateUser(string Email);

    }
}

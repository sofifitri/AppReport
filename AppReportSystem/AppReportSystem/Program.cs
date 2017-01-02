using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentController intrStu = new StudentController();
            //intrStu.inputStudent(); //untuk input
            //intrStu.printStudent(); //cetak
            //intrStu.editStudent(); //edit
            intrStu.delStudent(); //delete

        }
    }
}

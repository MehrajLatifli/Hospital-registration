using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_registration
{
    class Database
    {
        List<User> users = new List<User>();
        List<Doctor> doctors2 = new List<Doctor>();
        List<Doctor> doctors3 = new List<Doctor>();

        public void ListDoctor() { }


        List<Doctor> doctors = new List<Doctor>();
  




        static string Departmentchoose(string workerdepartment)
        {
            return $"{workerdepartment}";
        }



        static DateTime RegTimeBlock(DateTime regtime)
        {
            return regtime;
        }

      
  


          
        public void AddDoctortoList(string name, string surName, decimal workexperience)
        {
            Console.Write($@" 
 1 <- Pediatriya 
 2 <- Travmatologiya 



"                           );
            Console.Write($"\n Add Department: ");
          string choose = Console.ReadLine();

            if (choose == "1")
            {


              
                    doctors.Add(new Doctor()
                    {
                        Name = name,
                        SurName = surName,
                        Workexperience = workexperience,
                        Workerdepartment = Departmentchoose(Department.Pediatriya),
                     


                    });
                 
                
                  
               

            }

            if (choose == "2")
            {
                doctors.Add(new Doctor()
                {
                    Name = name,
                    SurName = surName,
                    Workexperience = workexperience,
                    Workerdepartment = Departmentchoose(Department.Travmatologiya)
                });
            }


          
        }

        public void ShowDoctortoList()
        {
            foreach (var item in doctors)
            {
                item.HumanShow();
                item.WorkerShow();
           
           
                item.DoctorTimeShow();
               
            }
        }



 
        static DateTime RegTimechoose(DateTime regtime)
        {
            return regtime;
        }

      
        int counteruser = 2;
        int counteruser2 = 2;
        public void AddUsertoList(string name, string surName, string email, long mobile, string selectName)
        {
       
                Console.Write($@" 
 1 <- 09:00 
 2 <- 09:30 
 




");


                Console.Write($"\n Add Time: ");
                string chooseTime = Console.ReadLine();



                if (chooseTime == "1")
                {
                    for (int i = 0; i < counteruser; i++)
                    {
                        counteruser--;


                        if (counteruser != 0)
                        {





                            users.Add(new User()
                            {
                                Name = name,
                                SurName = surName,
                                Email = email,
                                Mobile = mobile,
                                SelectDoctorname = selectName,
                                RegTime = RegTimechoose(RegistrationTime.time1)

                            }); ;



                            doctors2 = doctors.Where(c => c.DoctorRegTime == default || c.DoctorRegTime == RegTimechoose(RegistrationTime.time2)).ToList();
                            doctors2.ForEach(c => c.DoctorRegTime = RegTimechoose(RegistrationTime.time1));





                        }
                    }

                    if (counteruser <= 0)
                    {
                        Console.WriteLine(" This time is rezerving.");
                    }

                }




                if (chooseTime == "2")
                {
                    for (int i = 0; i < counteruser2; i++)
                    {
                        counteruser2--;


                        if (counteruser2 != 0)
                        {

                            users.Add(new User()
                            {
                                Name = name,
                                SurName = surName,
                                Email = email,
                                Mobile = mobile,
                                SelectDoctorname = selectName,
                                RegTime = RegTimechoose(RegistrationTime.time2),
                            });



                            doctors3 = doctors.Where(c => c.DoctorRegTime == RegTimechoose(RegistrationTime.time1) || c.DoctorRegTime == default).ToList();
                            doctors3.ForEach(c => c.DoctorRegTime = RegTimechoose(RegistrationTime.time2));

                        }

                    }

                    if (counteruser2 <= 0)
                    {
                        Console.WriteLine(" This time is rezerving.");
                    }
                }




            

        }

        public void ShowUsertoList()
        {

            foreach (var item in users)
            {
                item.HumanShow();

            }
        }
    }
}

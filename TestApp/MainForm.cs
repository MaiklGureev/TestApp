using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            var db = new MyModelContainer();

            
            //DBCC CHECKIDENT(StudentSet, RESEED, 0)
            //DBCC CHECKIDENT(SpecialtySet, RESEED, 0)
            //DBCC CHECKIDENT(FacultySet, RESEED, 0)
            db.Database.ExecuteSqlCommand("DBCC CHECKIDENT (StudentSet, RESEED, 0)");
            db.Database.ExecuteSqlCommand("DBCC CHECKIDENT (SpecialtySet, RESEED, 0)");
            db.Database.ExecuteSqlCommand("DBCC CHECKIDENT (FacultySet, RESEED, 0)");
            db.SaveChanges();
            //очистка содержимого
            db.StudentSet.RemoveRange(db.StudentSet);
            db.SpecialtySet.RemoveRange(db.SpecialtySet);
            db.FacultySet.RemoveRange(db.FacultySet);
            db.SaveChanges();

            
        }

        
        private void addTestDataButton_Click(object sender, EventArgs e)
        {
            var db = new MyModelContainer();

            var fac1 = new Faculty() { Id = 1, Name = "fac1" };
            var fac2 = new Faculty() { Id = 2, Name = "fac2" };

            var specialty1 = new Specialty() { Faculty = fac1, Name = "specialty1" };
            var specialty2 = new Specialty() { Faculty = fac1, Name = "specialty2" };
            var specialty3 = new Specialty() { Faculty = fac2, Name = "specialty3" };

            var student1 = new Student() { Adr = "adr1", Fio = "fio1", Phone = "phone1", Year = "2001", Specialty = specialty1 };
            var student2 = new Student() { Adr = "adr2", Fio = "fio2", Phone = "phone2", Year = "2001", Specialty = specialty1 };
            var student3 = new Student() { Adr = "adr3", Fio = "fio3", Phone = "phone3", Year = "2002", Specialty = specialty1 };

            var student4 = new Student() { Adr = "adr4", Fio = "fio4", Phone = "phone4", Year = "2003", Specialty = specialty2 };
            var student5 = new Student() { Adr = "adr5", Fio = "fio5", Phone = "phone4", Year = "2002", Specialty = specialty2 };

            var student6 = new Student() { Adr = "adr6", Fio = "fio6", Phone = "phone6", Year = "2002", Specialty = specialty3 };
            var student7 = new Student() { Adr = "adr7", Fio = "fio7", Phone = "phone7", Year = "2002", Specialty = specialty3 };

            db.StudentSet.Add(student1);
            db.StudentSet.Add(student2);
            db.StudentSet.Add(student3);
            db.StudentSet.Add(student4);
            db.StudentSet.Add(student5);
            db.StudentSet.Add(student6);
            db.StudentSet.Add(student7);

            db.SaveChanges();

            
        }


        private void doReportButton_Click(object sender, EventArgs e)
        {
            using (var db = new MyModelContainer()) {

                string query = "SELECT st.year, f.name, COUNT(st.Id) as total \r\n" +
                "FROM FacultySet f " +
                "JOIN SpecialtySet sp on f.Id = sp.Faculty_Id \r\n" +
                "JOIN StudentSet st on st.Specialty_Id = sp.Id \r\n" +
                "GROUP BY \r\n" +
                "ROLLUP(st.year, f.name)";
                

            

                var res = db.Database.SqlQuery<Report>(query);



                //SELECT st.year, f.name, COUNT(st.Id) as total
                //FROM FacultySet f
                //JOIN SpecialtySet sp on f.Id = sp.Faculty_Id
                //JOIN StudentSet st on st.Specialty_Id = sp.Id
                //GROUP BY
                //rollup(st.year, f.name)


                string year, fac;
                int count;

                console.Text += "\r\n" + query;
                console.Text += "\r\n";
                console.Text += "\r\n ---Report--- \r\n";
                foreach (var r in res)
                {
                    year = r.Year;
                    fac = r.name;
                    count = r.total;

                    if (fac == null)
                    {
                        console.Text += year + " Total: " + count;
                    }
                    else if (fac == null && year == null)
                    {
                        console.Text += "Total: " + count;
                    }
                    else 
                        console.Text += r.Year+" "+r.name+" "+r.total;

                    console.Text += "\r\n";
                }

                


                //foreach (var q in facResCount)
                //{
                //    console.Text += q.Key + " " + q.Count() + "\r\n";
                //    //console.Text += q.Year + " " + q.Name +" " +q.Count + "\r\n";

                //}


                console.Text += "------------------------------------------------------\r\n";


                
            }

            
        }

        private void getStud_button_Click(object sender, EventArgs e)
        {
            using (var db = new MyModelContainer())
            {
                var query = from s in db.StudentSet
                            select s;

                console.Text += "\r\n" + query;
                console.Text += "\r\n";
                console.Text += "\r\n ---Students--- \r\n";
                foreach (var st in query) {
                    console.Text += st.Id+" "+st.Year+" "+st.Fio + "\r\n";
                }
                console.Text += "------------------------------------------------------\r\n";
            } 
        }

        private void getSpec_button_Click(object sender, EventArgs e)
        {
            using (var db = new MyModelContainer())
            {
                var query = from s in db.SpecialtySet
                            select s;

                console.Text += "\r\n"+query;
                console.Text += "\r\n";
                console.Text += "\r\n ---Specialtys--- \r\n";

                foreach (var sp in query)
                {
                    console.Text += sp.Id + " " + sp.Name +"\r\n";
                }
                console.Text += "------------------------------------------------------\r\n";
            }
        }

        private void getFac_button_Click(object sender, EventArgs e)
        {
            using (var db = new MyModelContainer())
            {
                var query = from f in db.FacultySet
                            select f;

                console.Text += "\r\n" + query;
                console.Text += "\r\n";
                console.Text += "\r\n ---Facultys--- \r\n";
                foreach (var fac in query)
                {
                    console.Text += fac.Id + " " + fac.Name + "\r\n";
                }
                console.Text += "------------------------------------------------------\r\n";
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            console.Clear();
        }

        private void console_TextChanged(object sender, EventArgs e)
        {
            console.SelectionStart = console.Text.Length;
            console.ScrollToCaret();
            console.Refresh();
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            
            string filename = saveFileDialog1.FileName;
            
            System.IO.File.WriteAllText(filename, console.Text);
            MessageBox.Show("Файл сохранен!");
        }
    }
}




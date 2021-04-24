using System;

namespace Arboles
{
    class Program
    {
        static void Main(string[] args)
        {
            Position rectorPosition = new Position();
            rectorPosition.Name = "rector";
            rectorPosition.Salary = 1000;

            Position vicFinPosition = new Position();
            vicFinPosition.Name = "vicerector financiero";
            vicFinPosition.Salary = 750;

            Position contadorPosition = new Position();
            contadorPosition.Name = "Contador";
            contadorPosition.Salary = 500;

            Position jefeFinPosition = new Position();
            jefeFinPosition.Name = "Jefe Financiero";
            jefeFinPosition.Salary = 610;

            Position secFin1Position = new Position();
            secFin1Position.Name = "Secretaria financiera 1";
            secFin1Position.Salary = 350;

            Position secFin2Position = new Position();
            secFin2Position.Name = "Secretaria financiera 2";
            secFin2Position.Salary = 310;

            Position vicAcaPosition = new Position();
            vicAcaPosition.Name = "vicerector academico";
            vicAcaPosition.Salary = 780;

            Position jefeRegisPosition = new Position();
            jefeRegisPosition.Name = "Jefe de registro academico";
            jefeRegisPosition.Salary = 640;

            Position secGest2Position = new Position();
            secGest2Position.Name = "Secretario de gestion 2";
            secGest2Position.Salary = 360;

            Position secGest1Position = new Position();
            secGest1Position.Name = "Secretario de gestion 1";
            secGest1Position.Salary = 400;

            Position asist2Position = new Position();
            asist2Position.Name = "Asistente 2";
            asist2Position.Salary = 170;

            Position mensajeroPosition = new Position();
            mensajeroPosition.Name = "Mensajero";
            mensajeroPosition.Salary = 90;

            Position asist1Position = new Position();
            asist1Position.Name = "Asistente 1";
            asist1Position.Salary = 250;




            UniversityTree universityTree = new UniversityTree();
            universityTree.CreatePosition(null, rectorPosition, null);
            universityTree.CreatePosition( universityTree.Root, vicFinPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, contadorPosition, vicFinPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin1Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin2Position, contadorPosition.Name);

            universityTree.CreatePosition(universityTree.Root, jefeFinPosition, vicFinPosition.Name);

            universityTree.CreatePosition(universityTree.Root, vicAcaPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeRegisPosition, vicAcaPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secGest2Position, jefeRegisPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secGest1Position, jefeRegisPosition.Name);
            universityTree.CreatePosition(universityTree.Root, asist2Position, secGest1Position.Name);
            universityTree.CreatePosition(universityTree.Root, mensajeroPosition, asist2Position.Name);

            universityTree.CreatePosition(universityTree.Root, asist1Position, secGest1Position.Name);


            universityTree.PrintTree(universityTree.Root);
            float totalSalary = universityTree.Addsalaries(universityTree.Root);
            Console.WriteLine($"Total Salaries: { totalSalary}");
            Console.ReadLine();
        }
    }
}

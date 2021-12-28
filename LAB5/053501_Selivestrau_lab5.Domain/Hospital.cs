using System;

namespace _053501_Selivestrau_lab5.Domain
{
    [Serializable]
    public class Hospital
    {
        string Name { get; set; }

        public Hospital() { }

        public ReceptionDepartament RD { get; set; }

        public Hospital(string name)
        {
            Name = name;
            RD = new ReceptionDepartament();
        }

        public void AddPatient(Patient patient)
        {
            RD.Add(patient);
        }
    }
}

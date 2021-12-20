using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIOWindowsFormApp
{
    public class DataOperations
    {
        public List<Personnel> BringAllPersonnel()
        {
            List<Personnel> personnelList = new List<Personnel>();
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    Personnel personnel = new Personnel()
                    {
                        Name = FakeData.NameData.GetFirstName(),
                        Surname = FakeData.NameData.GetSurname(),
                        Email = FakeData.NetworkData.GetEmail(),
                        Company = FakeData.NameData.GetCompanyName(),
                        Country = FakeData.PlaceData.GetCountry()
                    };
                    personnelList.Add(personnel);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return personnelList;
        }

        public bool SavePersonnel(string path, Personnel personnel, out string savedPath)
        {
            bool result = false;

            try
            {
                DirectoryInfo countryInfo = null;
                //  C:\\Directory\\Italy

                if (Directory.Exists(path + "\\" + personnel.Country))
                {
                    countryInfo = new DirectoryInfo(path + "\\" + personnel.Country);
                }
                else
                {
                    countryInfo = Directory.CreateDirectory(path + "\\" + personnel.Country);
                }

                FileStream fileStream = File.Create(countryInfo.FullName + "\\" + personnel.Name + "_" + personnel.Surname + ".txt");
                savedPath = countryInfo.FullName + "\\" + personnel.Name + "_" + personnel.Surname + ".txt";
                //  C:\\Directory\\Italy\\Michele_Brown.txt

                byte[] personnelInformation = new UTF8Encoding(true).GetBytes(personnel.GetPersonnelInformationDetails());
                fileStream.Write(personnelInformation, 0, personnelInformation.Length);
                fileStream.Close();
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }       
           return result;
        }
    }
}

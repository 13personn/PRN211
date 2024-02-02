using BusinessObject;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace DataAccess
{
    public class MemberDao
    {
        //singleton
        private static MemberDao instance = null;
        private static readonly object instanceLock = new object();
        private MemberDao() { }
        public static MemberDao Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDao();
                    }
                    return instance;
                }
            }
        }
        //end-singleton

        private static List<Member> listMem = new List<Member>()
        {
        new Member{MemberID=1,MemberName="khuong",Email="khuong@fstore.com",Password="123",City="hanoi",Country="vietnam" }, 
        new Member{MemberID=2,MemberName="minh",Email="minh@fstore.com",Password="123",City="hanoi",Country="vietnam" },
        new Member{MemberID=3,MemberName="hoang",Email="hoang@fstore.com",Password="123",City="hanoi",Country="vietnam" },
       
        };

        /*List<Member> listMem = new List<Member>();*/

        public List<Member> GetMemberList => listMem;
        public Member GetMemberByID(int id)
        {
            Member member = listMem.SingleOrDefault(mem => mem.MemberID == id);
            return member;
        }

        public Member GetMemberByName(string name)
        {
            Member member = listMem.SingleOrDefault(mem => mem.MemberName == name);
            return member;
        }  public Member GetMemberByCity(string city)
        {
            Member member = listMem.SingleOrDefault(mem => mem.MemberName == city);
            return member;
        }  public Member GetMemberByCountry(string country)
        {
            Member member = listMem.SingleOrDefault(mem => mem.MemberName == country);
            return member;
        }

        public Member GetMemberByEmail(string email)
        {
            Member member = listMem.SingleOrDefault(member => member.Email == email);
            return member;
        }

        public void AddNew(Member member) 
        {
            if (GetMemberByID(member.MemberID) == null)
            {
                listMem.Add(member);
            }
            else 
            {
                throw new Exception("this member is already exist ");
            }
        }

        public void Update(Member member) 
        {
            Member mem = GetMemberByID(member.MemberID);
            if (mem != null)
            {
                /*var index = listMem.IndexOf(mem);
                listMem[index] = member;*/
                mem.MemberName = member.MemberName ??= mem.MemberName;
                mem.Email=member.Email??= mem.Email;
                mem.Password = member.Password ??= mem.Password;
                mem.City = member.City ??= mem.City;
                mem.Country = member.Country ?? mem.Country;
            }
            else 
            {
                throw (new Exception("this member isn't exist."));
            }

           
        }

        public void Remove(int memberID)
        {
            var mem = GetMemberByID(memberID);
            if (mem != null)
            {
                GetMemberList.Remove(mem);
            }
            else 
            {
                throw (new Exception("this member isn't exist"));
            }
        }



        public   bool CheckEmailLogin(string email)
        {
            int countvalid = 0;
            int countInvalid = 0;
            string specialChar = "[^a-zA-Z0-9]";
            MatchCollection specialCharList = Regex.Matches(email, specialChar);
            foreach (Match match in specialCharList)
            {
                if (!match.Equals("@"))
                {
                    countInvalid++;
                }
                if (match.Equals("@"))
                {
                    countvalid++;
                }
            }
            String regexPattern = $"{"@fstore.com"}$";
            if (countvalid == 1 && countInvalid == 0)
            {
                return Regex.IsMatch(email, regexPattern);
            }
            return false;
        }

        public bool Login(string email, string password)
        {

            if (CheckEmailLogin(email))
            {
              Member mem = GetMemberByEmail(email);
                if (mem != null)
                {
                    if(mem.Password==password) 
                    {
                        return true;
                    }
                    throw (new Exception("Wrong passord!!!"));
                    return false;
                }
                else 
                {
                    throw new Exception("this account isn't exist");
                    return false;
                }
               
               }
            throw (new Exception("email must be @fstore.com!!"));
            return false;
        }

        public List<Member> sortByDecendingName()
        {
            var sortedList = from member in GetMemberList orderby member.MemberName descending select member;
            return sortedList.ToList();
    }

        public List<Member> FilterByCity(string city,string country) 
        {
            List<Member> filtedlist = 
                GetMemberList.FindAll(member => member.City == city && member.Country == country);
            return filtedlist.ToList();
        } 
        
        public List<Member> FilterByCountry(string country) 
        {
            List<Member> filtedlist = 
                GetMemberList.FindAll(member =>member.Country == country);
            return filtedlist.ToList();
        }

        public List<string> GetListCity(string country) 
        {
        var listCity = GetMemberList.Where(member =>member.Country.Equals(country,StringComparison.OrdinalIgnoreCase))
                .Select(member=>member.City).Distinct().ToList();
            return listCity;
        }

        public List<string> GetListCountry() 
        {
        var listCountry = GetMemberList.Select(member=>member.Country).Distinct().ToList();
            return listCountry;
        }

        public List<Member> FindMemberByName(string name) 
        {
        List<Member> listmember = new List<Member>();
            foreach (var member in GetMemberList) 
            {
                if (member.MemberName.Contains(name)) 
                {
                listmember.Add(member);
                }
            }
            return listmember;
        }


    }

 


    }


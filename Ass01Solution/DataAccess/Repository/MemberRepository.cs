using BusinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccess.MemberDao;
namespace Ass01Solution.Repository
{
    public class MemberRepository : Ass01Solution.Repository.IMemberRepository
    {
        public bool CheckEmailValid(string email) => MemberDao.Instance.CheckEmailLogin(email);

        public bool CheckLogin(string email, string password) => MemberDao.Instance.Login(email, password);

        public void DeleteMember(int id) => MemberDao.Instance.Remove(id);

        public Member GetMemberByEmail(string email) => MemberDao.Instance.GetMemberByEmail(email);

        public Member GetMemberByID(int id) => MemberDao.Instance.GetMemberByID(id);

        public Member GetMemberByName(string name) => MemberDao.Instance.GetMemberByName(name);
        public Member GetMemberByCity(string city) => MemberDao.Instance.GetMemberByName(city); 
        public Member GetMemberByCountry(string country) => MemberDao.Instance.GetMemberByName(country);

        public IEnumerable<Member> GetMembers() => MemberDao.Instance.GetMemberList;

        public void InsertMember(Member member) => MemberDao.Instance.AddNew(member);

        public void UpdateMember(Member member) => MemberDao.Instance.Update(member);

        public List<Member> SortDecending() => MemberDao.Instance.sortByDecendingName();

        public List<Member> FilterByCity(string city, string country)=>MemberDao.Instance.FilterByCity(city, country);

        public List<Member> FilterByCountry(string country)=>MemberDao.Instance.FilterByCountry(country);

        public List<string> GetListCity(string country)=>MemberDao.Instance.GetListCity(country);

        public List<string> GetListCountry()=>MemberDao.Instance.GetListCountry();

        public List<Member> FindMemberByName(string name)=>MemberDao.Instance.FindMemberByName(name);
    }
}
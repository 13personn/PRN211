using BusinessObject;
using System;
using System.Data.SqlTypes;
using static DataAccess.MemberDao;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ass01Solution.Repository
{
	public interface IMemberRepository
	{

		IEnumerable<Member> GetMembers();
		Member GetMemberByID(int id);
		Member GetMemberByEmail(string email);
		Member GetMemberByName(string name);
		Member GetMemberByCity(string city);
		Member GetMemberByCountry(string country);
		void InsertMember(Member member);
		void UpdateMember(Member member);
		void DeleteMember(int id);
		bool CheckEmailValid(string email);
		bool CheckLogin(string email, string password);
		List<Member> SortDecending();
		List<Member> FilterByCity(string city,string country);
		List<Member> FilterByCountry(string country);
		List<string> GetListCity(string country);
		List<string> GetListCountry();
		List<Member> FindMemberByName(string name);
	}
}
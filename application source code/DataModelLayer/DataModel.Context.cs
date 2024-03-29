﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModelLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Music_Academy_ManagementEntities : DbContext
    {
        public Music_Academy_ManagementEntities()
            : base("name=Music_Academy_ManagementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<academy> academies { get; set; }
        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employee_Pv> Employee_Pv { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Student_Term> Student_Term { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Teacher_Instr> Teacher_Instr { get; set; }
        public virtual DbSet<Term> Terms { get; set; }
        public virtual DbSet<USER> USERS { get; set; }
    
        public virtual int add_base_salary(Nullable<short> percent)
        {
            var percentParameter = percent.HasValue ?
                new ObjectParameter("percent", percent) :
                new ObjectParameter("percent", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("add_base_salary", percentParameter);
        }
    
        public virtual int add_price_percentage(Nullable<int> percent)
        {
            var percentParameter = percent.HasValue ?
                new ObjectParameter("percent", percent) :
                new ObjectParameter("percent", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("add_price_percentage", percentParameter);
        }
    
        public virtual ObjectResult<GetTeacher_Result> GetTeacher(string iD)
        {
            var iDParameter = iD != null ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetTeacher_Result>("GetTeacher", iDParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int update_academy(string reg_Num, Nullable<System.DateTime> found_Date, string founder_Name, string email, string website, string tel, string address, string name)
        {
            var reg_NumParameter = reg_Num != null ?
                new ObjectParameter("Reg_Num", reg_Num) :
                new ObjectParameter("Reg_Num", typeof(string));
    
            var found_DateParameter = found_Date.HasValue ?
                new ObjectParameter("Found_Date", found_Date) :
                new ObjectParameter("Found_Date", typeof(System.DateTime));
    
            var founder_NameParameter = founder_Name != null ?
                new ObjectParameter("Founder_Name", founder_Name) :
                new ObjectParameter("Founder_Name", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var websiteParameter = website != null ?
                new ObjectParameter("website", website) :
                new ObjectParameter("website", typeof(string));
    
            var telParameter = tel != null ?
                new ObjectParameter("Tel", tel) :
                new ObjectParameter("Tel", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("update_academy", reg_NumParameter, found_DateParameter, founder_NameParameter, emailParameter, websiteParameter, telParameter, addressParameter, nameParameter);
        }
    
        public virtual int update_Attendance(string sid, Nullable<byte> termId, Nullable<System.DateTime> dateTime, Nullable<bool> attendance, Nullable<bool> allowed)
        {
            var sidParameter = sid != null ?
                new ObjectParameter("sid", sid) :
                new ObjectParameter("sid", typeof(string));
    
            var termIdParameter = termId.HasValue ?
                new ObjectParameter("TermId", termId) :
                new ObjectParameter("TermId", typeof(byte));
    
            var dateTimeParameter = dateTime.HasValue ?
                new ObjectParameter("DateTime", dateTime) :
                new ObjectParameter("DateTime", typeof(System.DateTime));
    
            var attendanceParameter = attendance.HasValue ?
                new ObjectParameter("Attendance", attendance) :
                new ObjectParameter("Attendance", typeof(bool));
    
            var allowedParameter = allowed.HasValue ?
                new ObjectParameter("Allowed", allowed) :
                new ObjectParameter("Allowed", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("update_Attendance", sidParameter, termIdParameter, dateTimeParameter, attendanceParameter, allowedParameter);
        }
    
        public virtual int update_Class(string number, string day, string hour, string eID, string instr_name, string sid)
        {
            var numberParameter = number != null ?
                new ObjectParameter("Number", number) :
                new ObjectParameter("Number", typeof(string));
    
            var dayParameter = day != null ?
                new ObjectParameter("day", day) :
                new ObjectParameter("day", typeof(string));
    
            var hourParameter = hour != null ?
                new ObjectParameter("hour", hour) :
                new ObjectParameter("hour", typeof(string));
    
            var eIDParameter = eID != null ?
                new ObjectParameter("EID", eID) :
                new ObjectParameter("EID", typeof(string));
    
            var instr_nameParameter = instr_name != null ?
                new ObjectParameter("Instr_name", instr_name) :
                new ObjectParameter("Instr_name", typeof(string));
    
            var sidParameter = sid != null ?
                new ObjectParameter("sid", sid) :
                new ObjectParameter("sid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("update_Class", numberParameter, dayParameter, hourParameter, eIDParameter, instr_nameParameter, sidParameter);
        }
    
        public virtual int update_Employee(string eID, Nullable<int> base_salary, Nullable<System.DateTime> entrance_Date, Nullable<System.DateTime> exit_date, string job, Nullable<byte> overTime, Nullable<int> insurance_Num)
        {
            var eIDParameter = eID != null ?
                new ObjectParameter("EID", eID) :
                new ObjectParameter("EID", typeof(string));
    
            var base_salaryParameter = base_salary.HasValue ?
                new ObjectParameter("Base_salary", base_salary) :
                new ObjectParameter("Base_salary", typeof(int));
    
            var entrance_DateParameter = entrance_Date.HasValue ?
                new ObjectParameter("Entrance_Date", entrance_Date) :
                new ObjectParameter("Entrance_Date", typeof(System.DateTime));
    
            var exit_dateParameter = exit_date.HasValue ?
                new ObjectParameter("Exit_date", exit_date) :
                new ObjectParameter("Exit_date", typeof(System.DateTime));
    
            var jobParameter = job != null ?
                new ObjectParameter("Job", job) :
                new ObjectParameter("Job", typeof(string));
    
            var overTimeParameter = overTime.HasValue ?
                new ObjectParameter("OverTime", overTime) :
                new ObjectParameter("OverTime", typeof(byte));
    
            var insurance_NumParameter = insurance_Num.HasValue ?
                new ObjectParameter("Insurance_Num", insurance_Num) :
                new ObjectParameter("Insurance_Num", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("update_Employee", eIDParameter, base_salaryParameter, entrance_DateParameter, exit_dateParameter, jobParameter, overTimeParameter, insurance_NumParameter);
        }
    
        public virtual int update_Employee_Pv(string eID, string firstName, string lastName, Nullable<System.DateTime> birthDate, string national_Code, string phone, string tel, string address, Nullable<bool> marital)
        {
            var eIDParameter = eID != null ?
                new ObjectParameter("EID", eID) :
                new ObjectParameter("EID", typeof(string));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var birthDateParameter = birthDate.HasValue ?
                new ObjectParameter("BirthDate", birthDate) :
                new ObjectParameter("BirthDate", typeof(System.DateTime));
    
            var national_CodeParameter = national_Code != null ?
                new ObjectParameter("National_Code", national_Code) :
                new ObjectParameter("National_Code", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            var telParameter = tel != null ?
                new ObjectParameter("Tel", tel) :
                new ObjectParameter("Tel", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            var maritalParameter = marital.HasValue ?
                new ObjectParameter("Marital", marital) :
                new ObjectParameter("Marital", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("update_Employee_Pv", eIDParameter, firstNameParameter, lastNameParameter, birthDateParameter, national_CodeParameter, phoneParameter, telParameter, addressParameter, maritalParameter);
        }
    
        public virtual int update_student(string sID, string first_Name, string last_Name, Nullable<System.DateTime> birthDate, string nationalCode, string phone, string tel, string address)
        {
            var sIDParameter = sID != null ?
                new ObjectParameter("SID", sID) :
                new ObjectParameter("SID", typeof(string));
    
            var first_NameParameter = first_Name != null ?
                new ObjectParameter("First_Name", first_Name) :
                new ObjectParameter("First_Name", typeof(string));
    
            var last_NameParameter = last_Name != null ?
                new ObjectParameter("Last_Name", last_Name) :
                new ObjectParameter("Last_Name", typeof(string));
    
            var birthDateParameter = birthDate.HasValue ?
                new ObjectParameter("BirthDate", birthDate) :
                new ObjectParameter("BirthDate", typeof(System.DateTime));
    
            var nationalCodeParameter = nationalCode != null ?
                new ObjectParameter("NationalCode", nationalCode) :
                new ObjectParameter("NationalCode", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            var telParameter = tel != null ?
                new ObjectParameter("Tel", tel) :
                new ObjectParameter("Tel", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("update_student", sIDParameter, first_NameParameter, last_NameParameter, birthDateParameter, nationalCodeParameter, phoneParameter, telParameter, addressParameter);
        }
    
        public virtual int update_Term(Nullable<byte> termID, string eID, string instr_name, Nullable<byte> session_Count, Nullable<int> session_price, Nullable<byte> session_Time)
        {
            var termIDParameter = termID.HasValue ?
                new ObjectParameter("TermID", termID) :
                new ObjectParameter("TermID", typeof(byte));
    
            var eIDParameter = eID != null ?
                new ObjectParameter("EID", eID) :
                new ObjectParameter("EID", typeof(string));
    
            var instr_nameParameter = instr_name != null ?
                new ObjectParameter("Instr_name", instr_name) :
                new ObjectParameter("Instr_name", typeof(string));
    
            var session_CountParameter = session_Count.HasValue ?
                new ObjectParameter("Session_Count", session_Count) :
                new ObjectParameter("Session_Count", typeof(byte));
    
            var session_priceParameter = session_price.HasValue ?
                new ObjectParameter("Session_price", session_price) :
                new ObjectParameter("Session_price", typeof(int));
    
            var session_TimeParameter = session_Time.HasValue ?
                new ObjectParameter("Session_Time", session_Time) :
                new ObjectParameter("Session_Time", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("update_Term", termIDParameter, eIDParameter, instr_nameParameter, session_CountParameter, session_priceParameter, session_TimeParameter);
        }
    
        public virtual int promotion(string iD, Nullable<byte> percent)
        {
            var iDParameter = iD != null ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(string));
    
            var percentParameter = percent.HasValue ?
                new ObjectParameter("percent", percent) :
                new ObjectParameter("percent", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("promotion", iDParameter, percentParameter);
        }
    
        public virtual int promotion1(string iD, Nullable<byte> percent)
        {
            var iDParameter = iD != null ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(string));
    
            var percentParameter = percent.HasValue ?
                new ObjectParameter("percent", percent) :
                new ObjectParameter("percent", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("promotion1", iDParameter, percentParameter);
        }
    
        public virtual int promotion2(string iD, Nullable<byte> percent)
        {
            var iDParameter = iD != null ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(string));
    
            var percentParameter = percent.HasValue ?
                new ObjectParameter("percent", percent) :
                new ObjectParameter("percent", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("promotion2", iDParameter, percentParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> attendance_state_ById(string student_Id, Nullable<byte> termId)
        {
            var student_IdParameter = student_Id != null ?
                new ObjectParameter("student_Id", student_Id) :
                new ObjectParameter("student_Id", typeof(string));
    
            var termIdParameter = termId.HasValue ?
                new ObjectParameter("TermId", termId) :
                new ObjectParameter("TermId", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("attendance_state_ById", student_IdParameter, termIdParameter);
        }
    
        public virtual int BackupDatabase(string directory)
        {
            var directoryParameter = directory != null ?
                new ObjectParameter("Directory", directory) :
                new ObjectParameter("Directory", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("BackupDatabase", directoryParameter);
        }
    
        public virtual int RestoreBackup(string directory)
        {
            var directoryParameter = directory != null ?
                new ObjectParameter("Directory", directory) :
                new ObjectParameter("Directory", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RestoreBackup", directoryParameter);
        }
    
        [DbFunction("Music_Academy_ManagementEntities", "class_info")]
        public virtual IQueryable<class_info_Result1> class_info(string iD, string d)
        {
            var iDParameter = iD != null ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(string));
    
            var dParameter = d != null ?
                new ObjectParameter("d", d) :
                new ObjectParameter("d", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<class_info_Result1>("[Music_Academy_ManagementEntities].[class_info](@ID, @d)", iDParameter, dParameter);
        }
    
        public virtual int update_username(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("update_username", usernameParameter, passwordParameter);
        }
    }
}

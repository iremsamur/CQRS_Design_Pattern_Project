namespace UpSchool_CQRS_DesignPatterns.CQRS.Queries.StudentQueries
{
    public class GetStudentByIDQuery
    {
        public int id { get; set; }

        public GetStudentByIDQuery(int id)
        {
            this.id = id;
        }
    }
}

using COMP1640.Data;

using COMP1640.Repository.IRepository;
using COMP1640.ViewModels.Response;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace COMP1640.Repository
{
    public class PostRepository : IPostRepository
    {
        private readonly ApplicationDbContext _context;

        public PostRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<UserReponseManager> CreatePost()
        {
            throw new System.NotImplementedException();
        }

        public byte[] GetCategoryData(string categoryId)
        {
            // this method creates a data table
            DataTable myDataTable = new DataTable();

            myDataTable.Columns.Add("POST", typeof(string));
            myDataTable.Columns.Add("CONTENT", typeof(string));
            myDataTable.Columns.Add("CATEGORY", typeof(string));
            myDataTable.Columns.Add("FinalClosureDate", typeof(string));

            var category = _context.Categories.SingleOrDefault(c => c.Id == categoryId);
            var posts = _context.Posts.Where(p => p.CategoryId == category.Id).ToList();
            foreach (var item in posts)
            {
                myDataTable.Rows.Add(item.Date, 
                    item.Content, 
                    item.CategoryName,
                    _context.Users.SingleOrDefault(u => u.Id == item.UserId).Email);

            }
            var stream = new MemoryStream();
            StreamWriter sw = new StreamWriter(stream);

            for (int i = 0; i < myDataTable.Columns.Count; i++)
            {
                sw.Write(myDataTable.Columns[i]);
                if (i < myDataTable.Columns.Count - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);
            foreach (DataRow row in myDataTable.Rows)
            {
                for (int i = 0; i < myDataTable.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(row[i]))
                    {
                        string value = row[i].ToString();
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            sw.Write(value);
                        }
                        else
                        {
                            sw.Write(row[i].ToString());
                        }
                    }
                    if (i < myDataTable.Columns.Count - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();

            return stream.ToArray();
        }
    }
}

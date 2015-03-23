using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using huinspector.Models;

namespace huinspector.Catalog
{
    public static class EvalCatalog
    {

        public static IList<Evaluation> GetEval(int? id)
        {
            using (var db = new HUInspectorEntities1())
            {
                var eval = (from s in db.Evaluation where s.ExamId == id select s).Include(i => i.Exam).Include(i => i.User).ToList();
                return eval;
            }
        }
        public static IList<Evaluation> GetAll()
        {
            using (var db = new HUInspectorEntities1())
            {
                var eval = db.Evaluation.Include(i => i.ExamId).Include(i => i.User).ToList();

                return eval;
            }
        }
    }
}
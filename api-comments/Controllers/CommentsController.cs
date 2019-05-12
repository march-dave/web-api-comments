using api_comments.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace api_comments.Controllers
{
    /// <summary>
    /// Comments Controller
    /// </summary>
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    #region Global Comments
    public class CommentsController : ApiController
    {
        /// <summary>
        /// Get All Comments List Written by Dave Lee
        /// </summary>
        /// <remarks>
        /// Get List of all Comments Written by Dave Lee
        /// </remarks>
        /// <response code="200"></response>
        public IEnumerable<comment> Get()
        {
            var db = new Entities();
            return db.comments.ToList();
        }

        /// <summary>
        /// Post Comments List Written by Dave Lee
        /// </summary>
        public void Post(comment obj)
        {
            var db = new Entities();
            db.comments.Add(obj);
            db.SaveChanges();
        }

        /// <summary>
        /// Delete Comments Written by Dave Lee
        /// </summary>
        public void Delete(int id)
        {
            var db = new Entities();
            var data = from item in db.comments
                       where item.id == id
                       select item;
            comment obj = data.SingleOrDefault();
            db.comments.Remove(obj);
            db.SaveChanges();
        }
    } 
    #endregion
}

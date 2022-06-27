using System;
using System.Collections.Generic;

namespace CourseStringBuilder.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public  Comment Comment { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comment.Remove(comment);
        }

    }
}

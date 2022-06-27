

using System;

namespace CourseStringBuilder.Entities
{
    class Comment
    {
        public string Text { get; set; }

        public Comment()
        {

        }
        public Comment(string text)
        {
            Text = text;
        }

        internal void Remove(Comment comment)
        {
            throw new NotImplementedException();
        }
    }

  
}

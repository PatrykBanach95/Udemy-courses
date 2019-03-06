using System;

namespace postdesign
{
    class Post
    {
        string _title;
        string _description;
        private readonly DateTime _dateTime;
        int _number = 0;

        public Post(string title, string description, DateTime dateTime)
        {
            _title = title;
            _description = description;
            _dateTime = dateTime;            
        }
               
        public void upVote() => _number++;
        public void downVote() => _number--;
        public int VoteNumber()
        {
            return _number;
        }

    }
}

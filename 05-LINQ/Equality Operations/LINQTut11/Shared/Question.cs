using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public class Question
    {


        public string Title { get; set; }
        public List<Choice> Choices { get; set; } = new();

        public int CorrectAnswer { get; set; }


       


        public override string ToString()
        {
            var choices = "";

            foreach (var item in Choices)
            {
                choices += $"\n\t{item.Order}) {item.Description}";
            }

            return $"{Title}" +
                   $"{choices}";
        }
        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if(this.GetType() != obj.GetType()) return false;
            var other = (Question)obj;
            return this.Title == other.Title
                && this.CorrectAnswer == other.CorrectAnswer
                && this.Choices.SequenceEqual(other.Choices);
        }
    }
}

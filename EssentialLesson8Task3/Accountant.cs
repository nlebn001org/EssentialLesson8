namespace EssentialLesson8Task3
{
    class Accountant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            if (hours > (int)worker)
                return true;
            else
                return false;
        }


    }
}

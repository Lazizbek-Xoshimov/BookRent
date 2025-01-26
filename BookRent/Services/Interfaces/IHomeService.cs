namespace BookRent.Services.Interfaces
{
    public interface IHomeService
    {
        public void LoadExistingMenus();
        void LoadBookMenu();
        void LoadLibraryMenu();
    }
}

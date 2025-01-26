using BookRent.Services;
using BookRent.Services.Interfaces;

IHomeService homeService = new HomeService();
homeService.LoadExistingMenus();  
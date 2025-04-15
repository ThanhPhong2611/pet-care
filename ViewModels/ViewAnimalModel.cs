namespace PetShopProj.ViewModels
{
    public class ViewAnimalModel : AddAnimalViewModel
    {
        public int Id { get; set; }
        public string? ExistingPhotoPath { get; set; }
    }
}
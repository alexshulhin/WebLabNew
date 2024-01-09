namespace WebLabNew.Entities
{
    public class DishGroup
    {
        public int DishGroupId { get; set; }
        public string GroupName { get; set; }
        /// <summary> 
        /// Навигационное свойство 1-ко-многим 
        /// </summary> 
        public List<Dish> Dishes { get; set; }
    }

}





/// <summary>
/// Базовый класс для слоя абстракции.
/// Именно через этот класс будет будет происходить взаимодействие 
///     с платформами в клиентском коде
/// </summary>
class BaseUser{
    /// <summary>
    /// Ссылка на объект реализации 
    /// (вместо класса BaseUser работать будет он)
    /// </summary>
    protected IPlatform platform; 
    
    /// <summary>Конструктор для класса интерфейса</summary>
    /// <param name="platform">Объект реализации</param>
    public BaseUser(IPlatform platform){
        // Устанавливаем объект реализации 
        this.platform = platform; 
    }

    /// <summary>Скачиваем видео</summary>
    public string video(string linck){
        /* Метод смысл которого только в том, 
            чтобы передать работу объекту реализации
        Данный метод может в своем составе содержать какой-либо код, 
            но в основном этот код необходим только для того 
            чтобы взаимодействовать с объектом реализации*/
        return platform.download_video(linck); 
    }

    /// <summary>Скачиваем описание к видео</summary>
    public string description(string linck){
        /*Работа данного метода аналогична методу video*/
        return platform.get_description(linck); 
    }
}
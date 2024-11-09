



/// <summary>
/// Реализация какой-то платформы.
/// Класс обязательно должен реализовывать общий интерфейс слоя реализации
/// </summary>
class YouTube: IPlatform{
    public string download_video(string linck){
        // Реализация метода. 
        // Именно здесь будет логика, работа с API и прочее...
        // В последующих методах все аналогично
        return YouTubeAPI.download(linck);
    }

    public string get_description(string linck){
        return YouTubeAPI.descript(linck);
    }

    public string get_author(string linck){
        return YouTubeAPI.author(linck);
    }

    public int get_showers(string linck){
        return YouTubeAPI.showers(linck); 
    }

    public int get_likes(string linck){
        return YouTubeAPI.likes(linck); 
    }

    public int get_dislikes(string linck){
        return YouTubeAPI.dislikes(linck); 
    }
}
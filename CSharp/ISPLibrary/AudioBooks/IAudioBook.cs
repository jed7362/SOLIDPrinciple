﻿namespace ISPLibrary;

public interface IAudioBook : ILibraryItem
{
    int RuntimeInMinutes { get; set; }
}
﻿using System;
namespace MusicPlayer_ConsoleApp
{
    public class SongControls
    {
        private static int _count;
        public SongControls()
        {
            _count = 0;
        }

        public static void NextSong()
        {
            _count++;
        }
        public static void PreviousSong()
        {
            _count--;

        }
        public static void Shuffle()
        {

        }
    }
}


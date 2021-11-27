using System;

namespace DiscordGiftGenerator {
    internal class Utils {
        private readonly Random rdn = new Random();
        private string gift_chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        public string gen_gift() {
            return $"https://discord.gift/{new string(Enumerable.Range(1, 16).Select(str => gift_chars[rdn.Next(gift_chars.Length)]).ToArray())}";
        }
    }
}

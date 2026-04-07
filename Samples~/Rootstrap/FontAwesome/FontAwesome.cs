using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Roots.Rootstrap
{
    public static class FontAwesome
    {
        [Flags]
        public enum Styles { Brands = 1, Regular = 2, Solid = 4, }

        public class IconData
        {
            public string Label { get; }
            public string Unicode { get; }
            public Styles Styles { get; }
            public ReadOnlyCollection<string> SearchTerms { get; }

            public IconData(string label, string unicode, Styles styles, string[] searchTerms)
            {
                Label = label;
                Unicode = unicode;
                Styles = styles;
                SearchTerms = new ReadOnlyCollection<string>(searchTerms);
            }

            public static implicit operator string(IconData data) => data.Unicode;
            public static implicit operator RishUI.RishString(IconData data) => data.Unicode;
        }

        private static IconData _0;
        public static IconData FA_0 => _0 ??= new IconData("0", "\U00000030", Styles.Solid, new string[] { "0", "digit zero", "nada", "nil", "none", "nothing", "nought", "null", "number zero", "zero", "zilch" });
        private static IconData _1;
        public static IconData FA_1 => _1 ??= new IconData("1", "\U00000031", Styles.Solid, new string[] { "1", "digit one", "first", "number one", "numeral one", "one", "primary", "single", "unit" });
        private static IconData _2;
        public static IconData FA_2 => _2 ??= new IconData("2", "\U00000032", Styles.Solid, new string[] { "2", "digit two", "number two", "numeral 2", "numeric two", "second", "two" });
        private static IconData _3;
        public static IconData FA_3 => _3 ??= new IconData("3", "\U00000033", Styles.Solid, new string[] { "3", "digit three", "number three", "numeral three", "third", "three", "triad", "trio" });
        private static IconData _4;
        public static IconData FA_4 => _4 ??= new IconData("4", "\U00000034", Styles.Solid, new string[] { "4", "digit four", "four", "number 4", "number four", "numeral four", "numeric 4" });
        private static IconData _5;
        public static IconData FA_5 => _5 ??= new IconData("5", "\U00000035", Styles.Solid, new string[] { "digit five", "digit symbol", "figure 5", "five", "number five", "number symbol", "numeral 5", "numeric 5" });
        private static IconData _6;
        public static IconData FA_6 => _6 ??= new IconData("6", "\U00000036", Styles.Solid, new string[] { "6", "digit six", "number 6", "number six", "numeral six", "numeric 6", "six" });
        private static IconData _7;
        public static IconData FA_7 => _7 ??= new IconData("7", "\U00000037", Styles.Solid, new string[] { "7", "digit seven", "number digit seven", "number seven", "numeral seven", "numeric 7", "seven" });
        private static IconData _8;
        public static IconData FA_8 => _8 ??= new IconData("8", "\U00000038", Styles.Solid, new string[] { "digit eight", "eight", "figure eight", "number eight", "numeral 8", "numeric 8" });
        private static IconData _9;
        public static IconData FA_9 => _9 ??= new IconData("9", "\U00000039", Styles.Solid, new string[] { "digit nine", "nine", "number 9", "number nine", "numeral 9", "numeric 9", "symbol 9" });
        private static IconData _42Group;
        public static IconData FA_42Group => _42Group ??= new IconData("42 Group", "\U0000E080", Styles.Brands, new string[] { "42", "42 group", "coding bootcamp", "coding school", "programming academy", "programming school", "school 42", "software development", "software engineering school", "tech education" });
        private static IconData _500px;
        public static IconData FA_500px => _500px ??= new IconData("500px", "\U0000F26E", Styles.Brands, new string[] { "500 px", "500px", "image sharing", "photo community", "photo network", "photo sharing", "photographers", "photography", "photos", "portfolio" });
        private static IconData _A;
        public static IconData FA_A => _A ??= new IconData("A", "\U00000041", Styles.Solid, new string[] { "alphabet", "alphabet letter", "character", "latin letter", "letter", "letter a", "lowercase a", "text character", "uppercase a" });
        private static IconData _AccessibleIcon;
        public static IconData FA_AccessibleIcon => _AccessibleIcon ??= new IconData("Accessible Icon", "\U0000F368", Styles.Brands, new string[] { "access", "accessibility", "accessibility symbol", "accessible icon project", "disability", "disabled", "handicap", "inclusive", "mobility", "person", "user", "wheelchair", "wheelchair user" });
        private static IconData _Accusoft;
        public static IconData FA_Accusoft => _Accusoft ??= new IconData("Accusoft", "\U0000F369", Styles.Brands, new string[] { "Accusoft", "Accusoft software", "SDK", "developer tools", "document imaging", "document processing", "imaging software", "software development kit" });
        private static IconData _AddressBook;
        public static IconData FA_AddressBook => _AddressBook ??= new IconData("Address Book", "\U0000F2B9", Styles.Regular | Styles.Solid, new string[] { "address", "address book", "contact", "contact list", "contacts", "directory", "employee", "little black book", "people", "personal organizer", "phone book", "profile", "rolodex", "user", "username" });
        private static IconData _AddressCard;
        public static IconData FA_AddressCard => _AddressCard ??= new IconData("Address Card", "\U0000F2BB", Styles.Regular | Styles.Solid, new string[] { "address", "badge", "business card", "card", "contact", "contact card", "credentials", "employee", "id", "id card", "identification", "name card", "personal info", "profile", "profile card", "registration", "user" });
        private static IconData _Adn;
        public static IconData FA_Adn => _Adn ??= new IconData("Adn", "\U0000F170", Styles.Brands, new string[] { "ADN", "app dot net", "app.net", "microblogging", "networking", "online community", "social media", "social network" });
        private static IconData _Adversal;
        public static IconData FA_Adversal => _Adversal ??= new IconData("Adversal", "\U0000F36A", Styles.Brands, new string[] { "Adversal", "ad network", "ad platform", "ad service", "advertising", "digital ads", "marketing network", "online advertising" });
        private static IconData _Affiliatetheme;
        public static IconData FA_Affiliatetheme => _Affiliatetheme ??= new IconData("Affiliatetheme", "\U0000F36B", Styles.Brands, new string[] { "Affiliatetheme", "affiliate", "affiliate marketing", "affiliate network", "affiliate program", "marketing", "theme", "wordpress", "wordpress theme" });
        private static IconData _Airbnb;
        public static IconData FA_Airbnb => _Airbnb ??= new IconData("Airbnb", "\U0000F834", Styles.Brands, new string[] { "Airbnb", "accommodation", "air bnb", "holiday rental", "homestay", "hospitality", "lodging", "rental", "short term rental", "travel", "vacation", "vacation home", "vacation rental" });
        private static IconData _AlarmClock;
        public static IconData FA_AlarmClock => _AlarmClock ??= new IconData("Alarm Clock", "\U0000F34E", Styles.Regular | Styles.Solid, new string[] { "alarm", "alarm clock", "alert", "bedtime", "clock", "deadline", "morning", "reminder", "ringing", "schedule", "snooze", "stopwatch", "time", "timer", "wake up", "watch" });
        private static IconData _Algolia;
        public static IconData FA_Algolia => _Algolia ??= new IconData("Algolia", "\U0000F36C", Styles.Brands, new string[] { "Algolia", "hosted search", "instant search", "search", "search API", "search engine", "search platform", "search provider", "search service", "search tool", "search-as-a-service", "site search" });
        private static IconData _AlignCenter;
        public static IconData FA_AlignCenter => _AlignCenter ??= new IconData("Align Center", "\U0000F037", Styles.Solid, new string[] { "align", "center", "formatting", "justify-center", "layout", "middle", "paragraph", "text", "text-align" });
        private static IconData _AlignJustify;
        public static IconData FA_AlignJustify => _AlignJustify ??= new IconData("Align Justify", "\U0000F039", Styles.Solid, new string[] { "align", "alignment", "formatting", "justified text", "justify", "layout", "paragraph", "text", "text alignment" });
        private static IconData _AlignLeft;
        public static IconData FA_AlignLeft => _AlignLeft ??= new IconData("Align Left", "\U0000F036", Styles.Solid, new string[] { "align", "alignment", "format", "justify-left", "left", "left-align", "paragraph", "text", "text-align-left" });
        private static IconData _AlignRight;
        public static IconData FA_AlignRight => _AlignRight ??= new IconData("Align Right", "\U0000F038", Styles.Solid, new string[] { "align", "document", "editor", "formatting", "justify-right", "layout", "paragraph", "right", "right-align", "text" });
        private static IconData _Alipay;
        public static IconData FA_Alipay => _Alipay ??= new IconData("Alipay", "\U0000F642", Styles.Brands, new string[] { "Alipay", "QR code", "ali pay", "cashless", "china", "digital wallet", "e-wallet", "fintech", "mobile pay", "mobile wallet", "online payment", "payments" });
        private static IconData _Amazon;
        public static IconData FA_Amazon => _Amazon ??= new IconData("Amazon", "\U0000F270", Styles.Brands, new string[] { "Amazon", "amazon.com", "delivery", "ecommerce", "marketplace", "online shopping", "online store", "prime", "retail", "shipping", "shopping", "webstore" });
        private static IconData _AmazonPay;
        public static IconData FA_AmazonPay => _AmazonPay ??= new IconData("Amazon Pay", "\U0000F42C", Styles.Brands, new string[] { "Amazon", "Amazon Pay", "buy", "checkout", "digital wallet", "e-commerce", "online payment", "pay", "payment", "wallet" });
        private static IconData _Amilia;
        public static IconData FA_Amilia => _Amilia ??= new IconData("Amilia", "\U0000F36D", Styles.Brands, new string[] { "Amilia", "amilia", "ecommerce", "event registration", "membership management", "memberships", "online registration", "payment processing", "registration", "registration software" });
        private static IconData _Anchor;
        public static IconData FA_Anchor => _Anchor ??= new IconData("Anchor", "\U0000F13D", Styles.Solid, new string[] { "anchor", "berth", "boat", "dock", "embed", "harbor", "link", "maritime", "moor", "nautical", "navigation", "port", "sea", "secure", "ship", "stable" });
        private static IconData _AnchorCircleCheck;
        public static IconData FA_AnchorCircleCheck => _AnchorCircleCheck ??= new IconData("Anchor Circle Check", "\U0000E4AA", Styles.Solid, new string[] { "anchor", "approved", "check", "confirmed", "enabled", "marina", "ok", "okay", "port", "safe", "secure", "stable", "valid", "verified" });
        private static IconData _AnchorCircleExclamation;
        public static IconData FA_AnchorCircleExclamation => _AnchorCircleExclamation ??= new IconData("Anchor Circle Exclamation", "\U0000E4AB", Styles.Solid, new string[] { "alert", "anchor", "attention", "caution", "error", "exclamation", "issue", "marina", "notification", "port", "problem", "unstable", "warning" });
        private static IconData _AnchorCircleXmark;
        public static IconData FA_AnchorCircleXmark => _AnchorCircleXmark ??= new IconData("Anchor Circle Xmark", "\U0000E4AC", Styles.Solid, new string[] { "anchor", "cancel", "close", "delete", "disable", "error", "marina", "nautical", "not secure", "port", "reject", "remove", "uncheck", "xmark" });
        private static IconData _AnchorLock;
        public static IconData FA_AnchorLock => _AnchorLock ??= new IconData("Anchor Lock", "\U0000E4AD", Styles.Solid, new string[] { "anchor", "lock", "locked", "marina", "padlock", "port", "privacy", "protection", "safe", "secure", "secure anchor", "security" });
        private static IconData _Android;
        public static IconData FA_Android => _Android ??= new IconData("Android", "\U0000F17B", Styles.Brands, new string[] { "android", "android logo", "google", "google android", "green robot", "mobile", "operating system", "os", "phone", "robot", "smartphone" });
        private static IconData _Angellist;
        public static IconData FA_Angellist => _Angellist ??= new IconData("Angellist", "\U0000F209", Styles.Brands, new string[] { "AngelList", "angel investing", "funding", "investing", "investors", "job board", "startup funding", "startup jobs", "startups", "venture capital" });
        private static IconData _AngleDown;
        public static IconData FA_AngleDown => _AngleDown ??= new IconData("Angle Down", "\U0000F107", Styles.Solid, new string[] { "arrowhead", "caret", "chevron down", "collapse", "down arrow", "download", "dropdown", "expand", "more", "open", "scroll down", "show more", "toggle" });
        private static IconData _AngleLeft;
        public static IconData FA_AngleLeft => _AngleLeft ??= new IconData("Angle Left", "\U0000F104", Styles.Solid, new string[] { "angle bracket", "arrow", "arrow left", "back", "back button", "caret", "chevron left", "direction", "left", "less than", "navigation", "previous", "scroll left" });
        private static IconData _AngleRight;
        public static IconData FA_AngleRight => _AngleRight ??= new IconData("Angle Right", "\U0000F105", Styles.Solid, new string[] { "arrow", "arrow right", "caret", "chevron right", "forward", "move right", "navigation", "next", "next page", "pointer right", "right arrow", "scroll right", "slide right", "triangle right" });
        private static IconData _AngleUp;
        public static IconData FA_AngleUp => _AngleUp ??= new IconData("Angle Up", "\U0000F106", Styles.Solid, new string[] { "arrow", "arrowhead up", "caret", "chevron up", "close", "collapse", "expand less", "increase", "move up", "scroll up", "up arrow", "up triangle", "upload" });
        private static IconData _AnglesDown;
        public static IconData FA_AnglesDown => _AnglesDown ??= new IconData("Angles Down", "\U0000F103", Styles.Solid, new string[] { "arrow down", "arrows", "caret", "chevrons down", "collapse", "double down", "download", "dropdown", "expand", "more", "navigation", "pointer down", "scroll down" });
        private static IconData _AnglesLeft;
        public static IconData FA_AnglesLeft => _AnglesLeft ??= new IconData("Angles Left", "\U0000F100", Styles.Solid, new string[] { "arrows", "back", "caret", "chevrons", "double angle", "fast backward", "laquo", "left", "navigation", "previous", "quotation mark", "rewind", "skip back" });
        private static IconData _AnglesRight;
        public static IconData FA_AnglesRight => _AnglesRight ??= new IconData("Angles Right", "\U0000F101", Styles.Solid, new string[] { "arrows", "caret", "chevrons right", "double angle", "fast forward", "forward", "more", "next", "next page", "quotation mark", "quote", "raquo", "right angle" });
        private static IconData _AnglesUp;
        public static IconData FA_AnglesUp => _AnglesUp ??= new IconData("Angles Up", "\U0000F102", Styles.Solid, new string[] { "arrows", "caret", "chevrons", "chevrons up", "collapse", "double up", "expand", "increase", "move up", "navigation up", "scroll up", "up arrows", "upload" });
        private static IconData _Angrycreative;
        public static IconData FA_Angrycreative => _Angrycreative ??= new IconData("Angrycreative", "\U0000F36E", Styles.Brands, new string[] { "Angry Creative", "WordPress", "agency", "branding", "creative agency", "design studio", "digital agency", "marketing", "web design" });
        private static IconData _Angular;
        public static IconData FA_Angular => _Angular ??= new IconData("Angular", "\U0000F420", Styles.Brands, new string[] { "Angular", "AngularJS", "Google", "JavaScript", "SPA", "TypeScript", "framework", "frontend", "single-page application", "web app" });
        private static IconData _Ankh;
        public static IconData FA_Ankh => _Ankh ??= new IconData("Ankh", "\U0000F644", Styles.Solid, new string[] { "amulet", "ancient egypt", "ankh", "coptic christianity", "copts", "cross", "crux ansata", "egypt", "egyptian cross", "eternal life", "key of life", "life", "religion", "spiritual", "symbol" });
        private static IconData _AppStore;
        public static IconData FA_AppStore => _AppStore ??= new IconData("App Store", "\U0000F36F", Styles.Brands, new string[] { "App Store", "Apple App Store", "Mac apps", "app marketplace", "app store icon", "download", "iOS apps", "iPad apps", "iPhone apps", "mobile apps" });
        private static IconData _AppStoreIos;
        public static IconData FA_AppStoreIos => _AppStoreIos ??= new IconData("App Store Ios", "\U0000F370", Styles.Brands, new string[] { "App Store", "Apple", "iOS App Store", "iOS apps", "iOS download", "iOS marketplace", "iPad apps", "iPhone apps", "mobile apps" });
        private static IconData _Apper;
        public static IconData FA_Apper => _Apper ??= new IconData("Apper", "\U0000F371", Styles.Brands, new string[] { "Apper", "app", "app development", "application", "enterprise apps", "mobile app", "software" });
        private static IconData _Apple;
        public static IconData FA_Apple => _Apple ??= new IconData("Apple", "\U0000F179", Styles.Brands, new string[] { "apple", "apple computer", "apple logo", "electronics", "fruit", "ios", "ipad", "iphone", "mac", "macos", "operating system", "os", "osx", "technology" });
        private static IconData _ApplePay;
        public static IconData FA_ApplePay => _ApplePay ??= new IconData("Apple Pay", "\U0000F415", Styles.Brands, new string[] { "Apple Pay", "Apple Wallet", "NFC payment", "checkout", "contactless payment", "digital wallet", "mobile payment", "pay with phone", "tap to pay" });
        private static IconData _AppleWhole;
        public static IconData FA_AppleWhole => _AppleWhole ??= new IconData("Apple Whole", "\U0000F5D1", Styles.Solid, new string[] { "apple", "fall", "fresh", "fruit", "green apple", "healthy", "juicy", "natural", "orchard", "produce", "red apple", "seasonal", "snack", "vegan", "vegetarian" });
        private static IconData _Aquarius;
        public static IconData FA_Aquarius => _Aquarius ??= new IconData("Aquarius", "\U0000E845", Styles.Solid, new string[] { "air sign", "aquarius", "astrology", "constellation", "february", "horoscope", "january", "sign", "stars", "water bearer", "zodiac" });
        private static IconData _ArchLinux;
        public static IconData FA_ArchLinux => _ArchLinux ??= new IconData("Arch Linux", "\U0000E867", Styles.Brands, new string[] { });
        private static IconData _Archway;
        public static IconData FA_Archway => _Archway ??= new IconData("Archway", "\U0000F557", Styles.Solid, new string[] { "arch", "architecture", "archway", "doorway", "entrance", "gate", "historic", "landmark", "monument", "old city", "passage", "portal", "stone arch" });
        private static IconData _Aries;
        public static IconData FA_Aries => _Aries ??= new IconData("Aries", "\U0000E846", Styles.Solid, new string[] { "april", "aries", "astrology", "constellation", "fire sign", "horoscope", "march", "ram", "sign", "stars", "zodiac" });
        private static IconData _ArrowDown;
        public static IconData FA_ArrowDown => _ArrowDown ??= new IconData("Arrow Down", "\U0000F063", Styles.Solid, new string[] { "arrow down", "arrow pointing down", "chevron down", "descend", "direction", "down arrow", "download", "downward", "downwards arrow", "drop", "move down", "navigation down", "scroll down" });
        private static IconData _ArrowDown19;
        public static IconData FA_ArrowDown19 => _ArrowDown19 ??= new IconData("Arrow Down 1 9", "\U0000F162", Styles.Solid, new string[] { "1-9", "arrange", "ascending", "filter", "number order", "numbers", "numeric", "order", "sort", "sort by number", "sort-ascending", "sort-numeric-asc" });
        private static IconData _ArrowDown91;
        public static IconData FA_ArrowDown91 => _ArrowDown91 ??= new IconData("Arrow Down 9 1", "\U0000F886", Styles.Solid, new string[] { "9-1", "arrange", "arrow-down", "descending", "down", "filter", "numbers", "numeric", "order", "sort", "sort-numeric-desc" });
        private static IconData _ArrowDownAZ;
        public static IconData FA_ArrowDownAZ => _ArrowDownAZ ??= new IconData("Arrow Down A Z", "\U0000F15D", Styles.Solid, new string[] { "a-z", "alphabet", "alphabetical", "arrange", "ascending", "filter", "letters", "order", "sort", "sort-alpha-asc", "sort-asc", "sort-letters" });
        private static IconData _ArrowDownLong;
        public static IconData FA_ArrowDownLong => _ArrowDownLong ??= new IconData("Arrow Down Long", "\U0000F175", Styles.Solid, new string[] { "arrow", "arrow-down", "arrow-symbol", "direction", "down", "download", "download-arrow", "downward", "long-arrow-down", "move-down" });
        private static IconData _ArrowDownShortWide;
        public static IconData FA_ArrowDownShortWide => _ArrowDownShortWide ??= new IconData("Arrow Down Short Wide", "\U0000F884", Styles.Solid, new string[] { "arrange", "arrow", "descending", "down", "filter", "order", "short", "sort", "sort-amount-asc", "wide" });
        private static IconData _ArrowDownUpAcrossLine;
        public static IconData FA_ArrowDownUpAcrossLine => _ArrowDownUpAcrossLine ??= new IconData("Arrow Down Up Across Line", "\U0000E4AF", Styles.Solid, new string[] { "arrows", "directional", "exchange", "move", "navigation", "reorder", "swap", "switch", "transfer", "up and down" });
        private static IconData _ArrowDownUpLock;
        public static IconData FA_ArrowDownUpLock => _ArrowDownUpLock ??= new IconData("Arrow Down Up Lock", "\U0000E4B0", Styles.Solid, new string[] { "arrows", "data transfer", "exchange", "lock", "locked", "padlock", "privacy", "protected", "secure", "security", "transfer", "up and down" });
        private static IconData _ArrowDownWideShort;
        public static IconData FA_ArrowDownWideShort => _ArrowDownWideShort ??= new IconData("Arrow Down Wide Short", "\U0000F160", Styles.Solid, new string[] { "arrange", "descending", "down", "filter", "number", "order", "short arrow", "sort", "sort amount asc", "sort descending", "wide arrow" });
        private static IconData _ArrowDownZA;
        public static IconData FA_ArrowDownZA => _ArrowDownZA ??= new IconData("Arrow Down Z A", "\U0000F881", Styles.Solid, new string[] { "alphabetical", "alphabetically descending", "arrange", "descending", "filter", "order", "reverse alphabetical", "sort", "sort descending", "sort reverse", "sort z-a", "z to a" });
        private static IconData _ArrowLeft;
        public static IconData FA_ArrowLeft => _ArrowLeft ??= new IconData("Arrow Left", "\U0000F060", Styles.Solid, new string[] { "arrow", "arrow left", "back", "backward", "direction", "go back", "left", "navigation", "previous", "return", "rewind", "undo" });
        private static IconData _ArrowLeftLong;
        public static IconData FA_ArrowLeftLong => _ArrowLeftLong ??= new IconData("Arrow Left Long", "\U0000F177", Styles.Solid, new string[] { "arrow", "back", "direction", "go back", "left", "long arrow", "navigation", "previous", "return", "undo" });
        private static IconData _ArrowPointer;
        public static IconData FA_ArrowPointer => _ArrowPointer ??= new IconData("Arrow Pointer", "\U0000F245", Styles.Solid, new string[] { "UI pointer", "arrow", "arrow cursor", "click", "cursor", "input device", "mouse", "mouse arrow", "mouse pointer", "navigation", "pointer", "pointer arrow", "pointer icon", "select" });
        private static IconData _ArrowRight;
        public static IconData FA_ArrowRight => _ArrowRight ??= new IconData("Arrow Right", "\U0000F061", Styles.Solid, new string[] { "arrow", "arrow right", "arrowhead", "continue", "direction", "forward", "move right", "navigation", "next", "next page", "proceed", "right", "rightwards arrow" });
        private static IconData _ArrowRightArrowLeft;
        public static IconData FA_ArrowRightArrowLeft => _ArrowRightArrowLeft ??= new IconData("Arrow Right Arrow Left", "\U0000F0EC", Styles.Solid, new string[] { "arrow", "arrows", "back-and-forth", "bidirectional", "exchange", "flip", "reciprocal", "reverse", "swap", "switch", "toggle", "transfer" });
        private static IconData _ArrowRightFromBracket;
        public static IconData FA_ArrowRightFromBracket => _ArrowRightFromBracket ??= new IconData("Arrow Right From Bracket", "\U0000F08B", Styles.Solid, new string[] { "arrow", "arrow-right", "exit", "exit door", "forward", "leave", "log off", "log out", "logoff", "logout", "next", "outbox", "send", "sign out" });
        private static IconData _ArrowRightLong;
        public static IconData FA_ArrowRightLong => _ArrowRightLong ??= new IconData("Arrow Right Long", "\U0000F178", Styles.Solid, new string[] { "arrow", "continue", "direction", "forward", "long arrow", "move", "navigation", "next", "proceed", "right" });
        private static IconData _ArrowRightToBracket;
        public static IconData FA_ArrowRightToBracket => _ArrowRightToBracket ??= new IconData("Arrow Right To Bracket", "\U0000F090", Styles.Solid, new string[] { "access", "arrow", "enter", "forward", "insert", "join", "log in", "login", "next", "proceed", "sign in", "sign up", "sign-in", "sign-on", "signin", "signup", "submit" });
        private static IconData _ArrowRightToCity;
        public static IconData FA_ArrowRightToCity => _ArrowRightToCity ??= new IconData("Arrow Right To City", "\U0000E4B3", Styles.Solid, new string[] { "arrival", "arrow", "building", "city", "direction", "enter", "move", "navigation", "right", "urban" });
        private static IconData _ArrowRotateLeft;
        public static IconData FA_ArrowRotateLeft => _ArrowRotateLeft ??= new IconData("Arrow Rotate Left", "\U0000F0E2", Styles.Solid, new string[] { "anticlockwise", "back", "cancel", "control z", "history", "previous", "reset", "return", "reverse", "rewind", "rotate", "swap", "undo" });
        private static IconData _ArrowRotateRight;
        public static IconData FA_ArrowRotateRight => _ArrowRotateRight ??= new IconData("Arrow Rotate Right", "\U0000F01E", Styles.Solid, new string[] { "clockwise", "cycle", "forward", "redo", "refresh", "reload", "reload page", "renew", "repeat", "retry", "rotate", "sync", "update" });
        private static IconData _ArrowTrendDown;
        public static IconData FA_ArrowTrendDown => _ArrowTrendDown ??= new IconData("Arrow Trend Down", "\U0000E097", Styles.Solid, new string[] { "arrow", "chart", "decline", "decrease", "down", "drop", "falling", "graph", "line", "loss", "negative", "stock", "trend" });
        private static IconData _ArrowTrendUp;
        public static IconData FA_ArrowTrendUp => _ArrowTrendUp ??= new IconData("Arrow Trend Up", "\U0000E098", Styles.Solid, new string[] { "arrow", "chart", "graph", "growth", "increase", "performance", "positive", "progress", "rising", "stocks", "trend", "upward" });
        private static IconData _ArrowTurnDown;
        public static IconData FA_ArrowTurnDown => _ArrowTurnDown ??= new IconData("Arrow Turn Down", "\U0000F149", Styles.Solid, new string[] { "arrow", "arrow curve", "arrow down", "arrow turn", "curve", "direction", "down", "navigation", "rotate", "turn" });
        private static IconData _ArrowTurnUp;
        public static IconData FA_ArrowTurnUp => _ArrowTurnUp ??= new IconData("Arrow Turn Up", "\U0000F148", Styles.Solid, new string[] { "arrow", "arrow curve", "arrow rotate", "arrow turn", "arrow up", "curve", "direction", "rotate", "turn", "up" });
        private static IconData _ArrowUp;
        public static IconData FA_ArrowUp => _ArrowUp ??= new IconData("Arrow Up", "\U0000F062", Styles.Solid, new string[] { "arrow", "ascension", "forward", "higher", "increase", "rise", "top", "up", "upgrade", "upload", "upwards" });
        private static IconData _ArrowUp19;
        public static IconData FA_ArrowUp19 => _ArrowUp19 ??= new IconData("Arrow Up 1 9", "\U0000F163", Styles.Solid, new string[] { "arrange", "ascending", "filter", "increase", "numbers", "numeric", "order", "ranking", "sequence", "sort", "sort-numeric-asc", "up" });
        private static IconData _ArrowUp91;
        public static IconData FA_ArrowUp91 => _ArrowUp91 ??= new IconData("Arrow Up 9 1", "\U0000F887", Styles.Solid, new string[] { "arrange", "ascending", "filter", "increase", "numbers", "numeric", "order", "sort", "sort-numeric-asc", "up" });
        private static IconData _ArrowUpAZ;
        public static IconData FA_ArrowUpAZ => _ArrowUpAZ ??= new IconData("Arrow Up A Z", "\U0000F15E", Styles.Solid, new string[] { "a to z", "alphabet", "alphabetical", "arrange", "ascending", "filter", "letters", "order", "sort", "sort-alpha-asc" });
        private static IconData _ArrowUpFromBracket;
        public static IconData FA_ArrowUpFromBracket => _ArrowUpFromBracket ??= new IconData("Arrow Up From Bracket", "\U0000E09A", Styles.Solid, new string[] { "arrow", "export", "move up", "outbox", "send", "send out", "share", "submit", "transfer", "upload" });
        private static IconData _ArrowUpFromGroundWater;
        public static IconData FA_ArrowUpFromGroundWater => _ArrowUpFromGroundWater ??= new IconData("Arrow Up From Ground Water", "\U0000E4B5", Styles.Solid, new string[] { "aquifer", "groundwater", "irrigation", "spring", "upward arrow", "water flow", "water rising", "water source", "water supply", "water table", "well" });
        private static IconData _ArrowUpFromWaterPump;
        public static IconData FA_ArrowUpFromWaterPump => _ArrowUpFromWaterPump ??= new IconData("Arrow Up From Water Pump", "\U0000E4B6", Styles.Solid, new string[] { "drainage", "flood", "groundwater", "irrigation", "plumbing", "pump", "submersible", "sump pump", "upgrade", "upward arrow", "water flow", "water pump" });
        private static IconData _ArrowUpLong;
        public static IconData FA_ArrowUpLong => _ArrowUpLong ??= new IconData("Arrow Up Long", "\U0000F176", Styles.Solid, new string[] { "arrow", "arrow-up", "ascension", "increase", "long-arrow-up", "move up", "rise", "up", "upload", "upward" });
        private static IconData _ArrowUpRightDots;
        public static IconData FA_ArrowUpRightDots => _ArrowUpRightDots ??= new IconData("Arrow Up Right Dots", "\U0000E4B7", Styles.Solid, new string[] { "arrow", "chart", "direction", "growth", "improvement", "increase", "northeast", "positive", "progress", "rising", "statistics", "trend", "upgrade" });
        private static IconData _ArrowUpRightFromSquare;
        public static IconData FA_ArrowUpRightFromSquare => _ArrowUpRightFromSquare ??= new IconData("Arrow Up Right From Square", "\U0000F08E", Styles.Solid, new string[] { "arrow", "export", "external", "launch", "link", "navigate", "new", "open", "redirect", "send", "share", "up-right" });
        private static IconData _ArrowUpShortWide;
        public static IconData FA_ArrowUpShortWide => _ArrowUpShortWide ??= new IconData("Arrow Up Short Wide", "\U0000F885", Styles.Solid, new string[] { "arrange", "arrow", "ascending", "expand", "filter", "increase", "order", "short", "sort", "sort-amount-desc", "up", "wide", "widen" });
        private static IconData _ArrowUpWideShort;
        public static IconData FA_ArrowUpWideShort => _ArrowUpWideShort ??= new IconData("Arrow Up Wide Short", "\U0000F161", Styles.Solid, new string[] { "arrange", "arrow", "expand", "filter", "increase", "order", "short", "sort", "sort-amount-desc", "up", "upgrade", "wide", "widen" });
        private static IconData _ArrowUpZA;
        public static IconData FA_ArrowUpZA => _ArrowUpZA ??= new IconData("Arrow Up Z A", "\U0000F882", Styles.Solid, new string[] { "alphabetical", "arrange", "descending", "filter", "order", "reverse alphabetical", "sort", "sort-alpha-desc", "z to a" });
        private static IconData _ArrowsDownToLine;
        public static IconData FA_ArrowsDownToLine => _ArrowsDownToLine ??= new IconData("Arrows Down To Line", "\U0000E4B8", Styles.Solid, new string[] { "arrow down", "arrow pointing down", "arrow to line", "download", "download arrow", "downward", "insert", "move down", "sink" });
        private static IconData _ArrowsDownToPeople;
        public static IconData FA_ArrowsDownToPeople => _ArrowsDownToPeople ??= new IconData("Arrows Down To People", "\U0000E4B9", Styles.Solid, new string[] { "audience", "collaboration", "community", "focus", "group", "interaction", "people", "targeted", "team", "users" });
        private static IconData _ArrowsLeftRight;
        public static IconData FA_ArrowsLeftRight => _ArrowsLeftRight ??= new IconData("Arrows Left Right", "\U0000F07E", Styles.Solid, new string[] { "arrows", "direction", "drag", "exchange", "expand", "horizontal", "left", "move", "resize", "right", "shift", "swap", "wide" });
        private static IconData _ArrowsLeftRightToLine;
        public static IconData FA_ArrowsLeftRightToLine => _ArrowsLeftRightToLine ??= new IconData("Arrows Left Right To Line", "\U0000E4BA", Styles.Solid, new string[] { "adjust", "arrows", "direction", "expand", "gap", "horizontal", "interface", "left", "move", "navigation", "resize", "right", "swap", "transfer" });
        private static IconData _ArrowsRotate;
        public static IconData FA_ArrowsRotate => _ArrowsRotate ??= new IconData("Arrows Rotate", "\U0000F021", Styles.Solid, new string[] { "clockwise", "cycle", "exchange", "refresh", "reload", "renew", "repeat", "reset", "retry", "rotate", "rotation", "swap", "sync", "turn", "update" });
        private static IconData _ArrowsSpin;
        public static IconData FA_ArrowsSpin => _ArrowsSpin ??= new IconData("Arrows Spin", "\U0000E4BB", Styles.Solid, new string[] { "circular", "cycle", "loop", "refresh", "reload", "repeat", "rotate", "spin", "sync", "turning", "whirl" });
        private static IconData _ArrowsSplitUpAndLeft;
        public static IconData FA_ArrowsSplitUpAndLeft => _ArrowsSplitUpAndLeft ??= new IconData("Arrows Split Up And Left", "\U0000E4BC", Styles.Solid, new string[] { "arrows", "branching", "direction", "diverge", "divide", "flow", "left", "move", "navigation", "separate", "split", "up" });
        private static IconData _ArrowsToCircle;
        public static IconData FA_ArrowsToCircle => _ArrowsToCircle ??= new IconData("Arrows To Circle", "\U0000E4BD", Styles.Solid, new string[] { "aim", "center", "centralize", "concentrate", "converge", "convergence", "coordinate", "coordination", "direction", "focal point", "focus", "hub", "insert", "pinpoint", "target" });
        private static IconData _ArrowsToDot;
        public static IconData FA_ArrowsToDot => _ArrowsToDot ??= new IconData("Arrows To Dot", "\U0000E4BE", Styles.Solid, new string[] { "assembly point", "center", "centralize", "collect", "converge", "focus", "gather", "hub", "point", "target" });
        private static IconData _ArrowsToEye;
        public static IconData FA_ArrowsToEye => _ArrowsToEye ??= new IconData("Arrows To Eye", "\U0000E4BF", Styles.Solid, new string[] { "attention", "center", "focus", "look", "monitor", "observation", "target", "view", "vision", "watch" });
        private static IconData _ArrowsTurnRight;
        public static IconData FA_ArrowsTurnRight => _ArrowsTurnRight ??= new IconData("Arrows Turn Right", "\U0000E4C0", Styles.Solid, new string[] { "arrows" });
        private static IconData _ArrowsTurnToDots;
        public static IconData FA_ArrowsTurnToDots => _ArrowsTurnToDots ??= new IconData("Arrows Turn To Dots", "\U0000E4C1", Styles.Solid, new string[] { "arrows", "change", "cycle", "destination", "direction", "dots", "insert", "loop", "movement", "navigation", "nexus", "point", "rotate", "turn" });
        private static IconData _ArrowsUpDown;
        public static IconData FA_ArrowsUpDown => _ArrowsUpDown ??= new IconData("Arrows Up Down", "\U0000F07D", Styles.Solid, new string[] { "adjust", "arrows", "direction", "down", "drag", "expand", "move", "reorder", "resize", "scroll", "swap", "up", "vertical" });
        private static IconData _ArrowsUpDownLeftRight;
        public static IconData FA_ArrowsUpDownLeftRight => _ArrowsUpDownLeftRight ??= new IconData("Arrows Up Down Left Right", "\U0000F047", Styles.Solid, new string[] { "adjust", "arrow", "arrows", "directions", "down", "drag", "enlarge", "expand", "left", "move", "navigation", "reorder", "reposition", "resize", "right", "up" });
        private static IconData _ArrowsUpToLine;
        public static IconData FA_ArrowsUpToLine => _ArrowsUpToLine ??= new IconData("Arrows Up To Line", "\U0000E4C2", Styles.Solid, new string[] { "arrow up", "elevate", "growth", "improvement", "increase", "progress", "rise", "scale up", "upgrade", "upward" });
        private static IconData _Artstation;
        public static IconData FA_Artstation => _Artstation ??= new IconData("Artstation", "\U0000F77A", Styles.Brands, new string[] { "art", "artist", "artstation", "artwork", "community", "creative", "design", "digital art", "gallery", "portfolio" });
        private static IconData _Asterisk;
        public static IconData FA_Asterisk => _Asterisk ??= new IconData("Asterisk", "\U0000002A", Styles.Solid, new string[] { "annotation", "asterisk", "emphasis", "footnote", "highlight", "note", "reference", "required", "star", "symbol", "wildcard" });
        private static IconData _Asymmetrik;
        public static IconData FA_Asymmetrik => _Asymmetrik ??= new IconData("Asymmetrik", "\U0000F372", Styles.Brands, new string[] { "asymmetrik", "asymmetrik brand", "asymmetrik company", "asymmetrik logo", "asymmetrik software", "asymmetrik technology" });
        private static IconData _At;
        public static IconData FA_At => _At ??= new IconData("At", "\U00000040", Styles.Solid, new string[] { "address", "at", "commercial at", "contact", "e-mail", "email", "handle", "inbox", "mail", "symbol", "username" });
        private static IconData _Atlassian;
        public static IconData FA_Atlassian => _Atlassian ??= new IconData("Atlassian", "\U0000F77B", Styles.Brands, new string[] { "Atlassian", "Bitbucket", "Confluence", "DevOps", "Jira", "Trello", "agile", "collaboration", "project management", "software" });
        private static IconData _Atom;
        public static IconData FA_Atom => _Atom ??= new IconData("Atom", "\U0000F5D2", Styles.Solid, new string[] { "atom", "atom symbol", "atomic", "chemistry", "electron", "energy", "experiment", "isotope", "molecule", "neutron", "nuclear", "particle", "physics", "proton", "quantum", "research", "science" });
        private static IconData _Audible;
        public static IconData FA_Audible => _Audible ??= new IconData("Audible", "\U0000F373", Styles.Brands, new string[] { "amazon audible", "audible", "audio platform", "audiobook", "audiobook app", "audiobook service", "audiobooks", "listening", "spoken word" });
        private static IconData _AudioDescription;
        public static IconData FA_AudioDescription => _AudioDescription ??= new IconData("Audio Description", "\U0000F29E", Styles.Solid, new string[] { "accessibility", "audio description", "blind", "descriptive audio", "narration", "video", "visual aid", "visually impaired" });
        private static IconData _AustralSign;
        public static IconData FA_AustralSign => _AustralSign ??= new IconData("Austral Sign", "\U0000E0A9", Styles.Solid, new string[] { "Argentine currency", "Austral Sign", "cash", "currency", "finance", "monetary", "money", "payment", "peso", "symbol" });
        private static IconData _Autoprefixer;
        public static IconData FA_Autoprefixer => _Autoprefixer ??= new IconData("Autoprefixer", "\U0000F41C", Styles.Brands, new string[] { "automation", "autoprefixer", "build tool", "css", "frontend", "prefix", "stylesheet", "web development" });
        private static IconData _Avianex;
        public static IconData FA_Avianex => _Avianex ??= new IconData("Avianex", "\U0000F374", Styles.Brands, new string[] { "aircraft", "airline", "avian ex", "avianex", "aviation", "flight", "travel" });
        private static IconData _Aviato;
        public static IconData FA_Aviato => _Aviato ??= new IconData("Aviato", "\U0000F421", Styles.Brands, new string[] { "aviato", "brand", "software", "startup", "tech company", "technology" });
        private static IconData _Award;
        public static IconData FA_Award => _Award ??= new IconData("Award", "\U0000F559", Styles.Solid, new string[] { "accolade", "achievement", "award", "badge", "certificate", "commendation", "honor", "medal", "praise", "prize", "recognition", "reward", "ribbon", "trophy" });
        private static IconData _Aws;
        public static IconData FA_Aws => _Aws ??= new IconData("Aws", "\U0000F375", Styles.Brands, new string[] { "amazon", "amazon web services", "aws cloud", "aws logo", "aws platform", "cloud", "cloud computing", "web services" });
        private static IconData _B;
        public static IconData FA_B => _B ??= new IconData("B", "\U00000042", Styles.Solid, new string[] { "alphabet", "capital b", "character", "font", "letter b", "letterform", "lowercase b", "symbol", "text", "typography" });
        private static IconData _Baby;
        public static IconData FA_Baby => _Baby ??= new IconData("Baby", "\U0000F77C", Styles.Solid, new string[] { "baby", "baby face", "baby icon", "child", "child icon", "infant", "infant icon", "kid", "little one", "newborn", "newborn baby", "toddler" });
        private static IconData _BabyCarriage;
        public static IconData FA_BabyCarriage => _BabyCarriage ??= new IconData("Baby Carriage", "\U0000F77D", Styles.Solid, new string[] { "baby", "buggy", "carriage", "infant", "newborn", "pram", "push", "pushchair", "stroller", "transport", "walk", "wheels" });
        private static IconData _Backward;
        public static IconData FA_Backward => _Backward ??= new IconData("Backward", "\U0000F04A", Styles.Solid, new string[] { "arrow", "back", "back button", "double", "go back", "previous", "previous track", "reverse", "rewind", "skip back" });
        private static IconData _BackwardFast;
        public static IconData FA_BackwardFast => _BackwardFast ??= new IconData("Backward Fast", "\U0000F049", Styles.Solid, new string[] { "arrow", "back", "beginning", "double arrow", "fast backward", "first", "media control", "music", "previous", "previous track", "rewind", "skip back", "start", "track", "video" });
        private static IconData _BackwardStep;
        public static IconData FA_BackwardStep => _BackwardStep ??= new IconData("Backward Step", "\U0000F048", Styles.Solid, new string[] { "back", "backward", "beginning", "first", "go back", "previous", "reverse", "rewind", "start", "step back", "undo" });
        private static IconData _Bacon;
        public static IconData FA_Bacon => _Bacon ??= new IconData("Bacon", "\U0000F7E5", Styles.Solid, new string[] { "bacon", "breakfast", "brunch", "crispy", "cured", "deli", "food", "fried", "grease", "meat", "pork", "rasher", "savory", "snack", "strip" });
        private static IconData _Bacteria;
        public static IconData FA_Bacteria => _Bacteria ??= new IconData("Bacteria", "\U0000E059", Styles.Solid, new string[] { "antibiotic", "antibody", "bacteria", "disease", "germ", "health", "infection", "microbe", "microorganism", "pathogen", "sick", "virus" });
        private static IconData _Bacterium;
        public static IconData FA_Bacterium => _Bacterium ??= new IconData("Bacterium", "\U0000E05A", Styles.Solid, new string[] { "antibiotic", "bacteria", "bacterium", "disease", "germ", "health", "infection", "microbe", "microorganism", "pathogen", "sick" });
        private static IconData _BagShopping;
        public static IconData FA_BagShopping => _BagShopping ??= new IconData("Bag Shopping", "\U0000F290", Styles.Solid, new string[] { "bag", "basket", "buy", "cart", "checkout", "grocery", "purchase", "retail", "sale", "shopping", "shopping bag", "shopping cart", "shopping spree", "shopping tote", "store" });
        private static IconData _Bahai;
        public static IconData FA_Bahai => _Bahai ??= new IconData("Bahai", "\U0000F666", Styles.Solid, new string[] { "baha'i faith", "bahai", "bahai symbol", "bahá'í", "faith", "nine-pointed star", "religion", "spiritual", "star", "symbol" });
        private static IconData _BahtSign;
        public static IconData FA_BahtSign => _BahtSign ??= new IconData("Baht Sign", "\U0000E0AC", Styles.Solid, new string[] { "baht", "cash", "currency", "finance", "money", "payment", "thai baht", "thai currency", "thailand", "฿" });
        private static IconData _Ban;
        public static IconData FA_Ban => _Ban ??= new IconData("Ban", "\U0000F05E", Styles.Solid, new string[] { "abort", "ban", "block", "cancel", "deny", "disabled", "entry", "forbidden", "hide", "no", "prohibit", "prohibited", "remove", "slash", "stop" });
        private static IconData _BanSmoking;
        public static IconData FA_BanSmoking => _BanSmoking ??= new IconData("Ban Smoking", "\U0000F54D", Styles.Solid, new string[] { "ban", "banned", "cancel", "circle", "deny", "disallowed", "forbidden", "no", "no smoking", "non-smoking", "prohibited", "restricted", "slash", "smoke-free", "smoking", "stop" });
        private static IconData _Bandage;
        public static IconData FA_Bandage => _Bandage ??= new IconData("Bandage", "\U0000F462", Styles.Solid, new string[] { "adhesive bandage", "bandage", "boo boo", "first aid", "healing", "healthcare", "injury", "medical", "ouch", "patch", "plaster", "wound" });
        private static IconData _Bandcamp;
        public static IconData FA_Bandcamp => _Bandcamp ??= new IconData("Bandcamp", "\U0000F2D5", Styles.Brands, new string[] { "album", "artist", "audio", "bandcamp", "indie", "marketplace", "music", "platform", "songs", "streaming" });
        private static IconData _BangladeshiTakaSign;
        public static IconData FA_BangladeshiTakaSign => _BangladeshiTakaSign ??= new IconData("Bangladeshi Taka Sign", "\U0000E2E6", Styles.Solid, new string[] { "bangladesh", "bdt", "cash", "currency", "financial", "money", "payment", "price", "taka", "tk" });
        private static IconData _Barcode;
        public static IconData FA_Barcode => _Barcode ??= new IconData("Barcode", "\U0000F02A", Styles.Solid, new string[] { "barcode", "barcode-scanner", "code", "inventory", "label", "laser", "price", "product", "retail", "scan", "scanner", "tracking", "upc" });
        private static IconData _Bars;
        public static IconData FA_Bars => _Bars ??= new IconData("Bars", "\U0000F0C9", Styles.Solid, new string[] { "bars", "burger", "burger menu", "drag", "hamburger", "interface", "list", "menu", "menu button", "mobile menu", "nav", "navigation", "options", "panel", "reorder", "sidebar", "toggle" });
        private static IconData _BarsProgress;
        public static IconData FA_BarsProgress => _BarsProgress ??= new IconData("Bars Progress", "\U0000F828", Styles.Solid, new string[] { "bar chart", "checklist", "download", "downloading", "loading", "loading indicator", "poll", "progress", "progress bar", "progress indicator", "project management", "status", "task", "to do" });
        private static IconData _BarsStaggered;
        public static IconData FA_BarsStaggered => _BarsStaggered ??= new IconData("Bars Staggered", "\U0000F550", Styles.Solid, new string[] { "bars", "controls", "flow", "layout", "list", "menu", "options", "settings", "staggered", "timeline" });
        private static IconData _Baseball;
        public static IconData FA_Baseball => _Baseball ??= new IconData("Baseball", "\U0000F433", Styles.Solid, new string[] { "ball", "baseball", "bat", "catcher", "diamond", "foul", "glove", "hardball", "home run", "league", "mlb", "pitcher", "softball", "sport", "strike" });
        private static IconData _BaseballBatBall;
        public static IconData FA_BaseballBatBall => _BaseballBatBall ??= new IconData("Baseball Bat Ball", "\U0000F432", Styles.Solid, new string[] { "ball", "baseball", "baseball equipment", "baseball game", "baseball player", "bat", "hitter", "league", "mlb", "slugger", "softball", "sport" });
        private static IconData _BasketShopping;
        public static IconData FA_BasketShopping => _BasketShopping ??= new IconData("Basket Shopping", "\U0000F291", Styles.Solid, new string[] { "basket", "buy", "cart", "checkout", "goods", "grocery", "market", "purchase", "retail", "shopping", "shopping basket", "shopping cart", "store" });
        private static IconData _Basketball;
        public static IconData FA_Basketball => _Basketball ??= new IconData("Basketball", "\U0000F434", Styles.Solid, new string[] { "ball", "basket", "basketball", "court", "dribble", "dunk", "foul", "hoop", "jump shot", "nba", "player", "rebound", "slam dunk", "sport", "team" });
        private static IconData _Bath;
        public static IconData FA_Bath => _Bath ??= new IconData("Bath", "\U0000F2CD", Styles.Solid, new string[] { "bath", "bathroom", "bathtub", "clean", "cleansing", "hygiene", "relaxation", "shower", "soak", "spa", "tub", "wash", "water" });
        private static IconData _BatteryEmpty;
        public static IconData FA_BatteryEmpty => _BatteryEmpty ??= new IconData("Battery Empty", "\U0000F244", Styles.Solid, new string[] { "battery", "charge", "dead", "drain", "empty", "energy", "flat", "low", "power", "status", "zero" });
        private static IconData _BatteryFull;
        public static IconData FA_BatteryFull => _BatteryFull ??= new IconData("Battery Full", "\U0000F240", Styles.Solid, new string[] { "battery", "battery charge", "battery icon", "battery level", "battery status", "charge", "energy", "full", "power", "status" });
        private static IconData _BatteryHalf;
        public static IconData FA_BatteryHalf => _BatteryHalf ??= new IconData("Battery Half", "\U0000F242", Styles.Solid, new string[] { "battery", "battery-status", "charge", "energy", "half", "half-full", "level", "medium", "power", "status" });
        private static IconData _BatteryQuarter;
        public static IconData FA_BatteryQuarter => _BatteryQuarter ??= new IconData("Battery Quarter", "\U0000F243", Styles.Solid, new string[] { "almost empty", "battery", "charge", "energy", "half-full", "level", "low", "power", "quarter", "status", "weak" });
        private static IconData _BatteryThreeQuarters;
        public static IconData FA_BatteryThreeQuarters => _BatteryThreeQuarters ??= new IconData("Battery Three Quarters", "\U0000F241", Styles.Solid, new string[] { "75%", "battery", "battery level", "battery status", "charge", "energy", "level", "medium charge", "partially charged", "power", "status", "three quarters" });
        private static IconData _BattleNet;
        public static IconData FA_BattleNet => _BattleNet ??= new IconData("Battle Net", "\U0000F835", Styles.Brands, new string[] { "battle net", "battle.net", "blizzard", "blizzard entertainment", "esports", "game launcher", "gaming", "multiplayer", "online games", "pc games" });
        private static IconData _Bed;
        public static IconData FA_Bed => _Bed ??= new IconData("Bed", "\U0000F236", Styles.Solid, new string[] { "bed frame", "bedroom", "furniture", "hospital", "hotel", "lodging", "mattress", "nap", "patient", "relaxation", "rest", "sleep", "sleeping", "tired", "travel" });
        private static IconData _BedPulse;
        public static IconData FA_BedPulse => _BedPulse ??= new IconData("Bed Pulse", "\U0000F487", Styles.Solid, new string[] { "ECG", "EKG", "bed", "care", "electrocardiogram", "emergency", "health", "heartbeat", "hospital", "life-support", "medical", "monitoring", "patient", "pulse", "vital" });
        private static IconData _BeerMugEmpty;
        public static IconData FA_BeerMugEmpty => _BeerMugEmpty ??= new IconData("Beer Mug Empty", "\U0000F0FC", Styles.Solid, new string[] { "alcohol", "ale", "bar", "beer", "beverage", "brew", "brewery", "drink", "empty", "foam", "lager", "mug", "pint", "stein" });
        private static IconData _Behance;
        public static IconData FA_Behance => _Behance ??= new IconData("Behance", "\U0000F1B4", Styles.Brands, new string[] { "adobe behance", "art", "behance", "creative", "creative community", "design", "portfolio", "projects", "showcase" });
        private static IconData _Bell;
        public static IconData FA_Bell => _Bell ??= new IconData("Bell", "\U0000F0F3", Styles.Regular | Styles.Solid, new string[] { "alarm", "alert", "bell", "buzzer", "call", "chime", "ding", "notification", "prompt", "reminder", "request", "ring", "signal", "tone" });
        private static IconData _BellConcierge;
        public static IconData FA_BellConcierge => _BellConcierge ??= new IconData("Bell Concierge", "\U0000F562", Styles.Solid, new string[] { "alert", "assistance", "attention", "bell", "bellhop", "call", "concierge", "front desk", "help", "hotel", "notification", "receptionist", "request", "service", "support" });
        private static IconData _BellSlash;
        public static IconData FA_BellSlash => _BellSlash ??= new IconData("Bell Slash", "\U0000F1F6", Styles.Regular | Styles.Solid, new string[] { "alert", "bell", "block", "cancel", "disable notifications", "disabled", "do not disturb", "mute", "no sound", "notification", "off", "quiet", "reminder", "silent", "sound off" });
        private static IconData _BezierCurve;
        public static IconData FA_BezierCurve => _BezierCurve ??= new IconData("Bezier Curve", "\U0000F55B", Styles.Solid, new string[] { "anchor points", "bezier", "control points", "curve", "drawing", "graphic design", "illustration", "line", "path", "pen tool", "shape", "smooth curve", "vector" });
        private static IconData _Bicycle;
        public static IconData FA_Bicycle => _Bicycle ??= new IconData("Bicycle", "\U0000F206", Styles.Solid, new string[] { "bicycle", "bike", "cycle", "cycling", "eco-friendly", "exercise", "pedal", "ride", "sport", "transportation", "two-wheeler", "vehicle" });
        private static IconData _Bilibili;
        public static IconData FA_Bilibili => _Bilibili ??= new IconData("Bilibili", "\U0000E3D9", Styles.Brands, new string[] { "Bilibili", "B站", "Chinese video platform", "anime", "bilibili", "comics", "gaming", "live streaming", "streaming", "video" });
        private static IconData _Bimobject;
        public static IconData FA_Bimobject => _Bimobject ??= new IconData("Bimobject", "\U0000F378", Styles.Brands, new string[] { "3d models", "architecture", "bim", "bim library", "bimobject", "building information modeling", "cad", "construction", "design" });
        private static IconData _Binoculars;
        public static IconData FA_Binoculars => _Binoculars ??= new IconData("Binoculars", "\U0000F1E5", Styles.Solid, new string[] { "binoculars", "explore", "glasses", "inspection", "look", "magnifier", "magnify", "nature", "observe", "outdoor", "scout", "spyglass", "survey", "telescope", "view", "watch" });
        private static IconData _Biohazard;
        public static IconData FA_Biohazard => _Biohazard ??= new IconData("Biohazard", "\U0000F780", Styles.Solid, new string[] { "biohazard", "biohazard sign", "contamination", "danger", "epidemic", "hazard", "hazardous waste", "hazmat", "infectious", "medical", "pandemic", "quarantine", "toxic", "virus", "warning" });
        private static IconData _Bitbucket;
        public static IconData FA_Bitbucket => _Bitbucket ??= new IconData("Bitbucket", "\U0000F171", Styles.Brands, new string[] { "atlassian", "bitbucket", "code", "devops", "git", "repository", "software development", "source code", "version control" });
        private static IconData _Bitcoin;
        public static IconData FA_Bitcoin => _Bitcoin ??= new IconData("Bitcoin", "\U0000F379", Styles.Brands, new string[] { "bitcoin", "bitcoin logo", "bitcoin symbol", "blockchain", "btc", "crypto", "cryptocurrency", "decentralized currency", "digital currency", "virtual currency" });
        private static IconData _BitcoinSign;
        public static IconData FA_BitcoinSign => _BitcoinSign ??= new IconData("Bitcoin Sign", "\U0000E0B4", Styles.Solid, new string[] { "bitcoin", "bitcoin sign", "blockchain", "btc", "coin", "crypto", "cryptocurrency", "currency", "digital currency" });
        private static IconData _Bity;
        public static IconData FA_Bity => _Bity ??= new IconData("Bity", "\U0000F37A", Styles.Brands, new string[] { "bitcoin", "bity", "blockchain", "crypto exchange", "cryptocurrency", "digital currency" });
        private static IconData _BlackTie;
        public static IconData FA_BlackTie => _BlackTie ??= new IconData("Black Tie", "\U0000F27E", Styles.Brands, new string[] { "administrator", "black tie", "bow tie", "dress code", "evening wear", "event", "formal", "formalwear", "gala", "suit", "tuxedo" });
        private static IconData _Blackberry;
        public static IconData FA_Blackberry => _Blackberry ??= new IconData("Blackberry", "\U0000F37B", Styles.Brands, new string[] { "RIM", "blackberry", "blackberry brand", "blackberry device", "blackberry logo", "blackberry phone", "mobile", "smartphone" });
        private static IconData _Blender;
        public static IconData FA_Blender => _Blender ??= new IconData("Blender", "\U0000F517", Styles.Solid, new string[] { "blend", "blender", "cocktail maker", "crush", "drink maker", "food processor", "kitchen appliance", "milkshake", "mixer", "puree", "shake", "smoothie" });
        private static IconData _BlenderPhone;
        public static IconData FA_BlenderPhone => _BlenderPhone ??= new IconData("Blender Phone", "\U0000F6B6", Styles.Solid, new string[] { "appliance", "beverage", "blender", "cocktail", "drink", "funny", "kitchen", "milkshake", "mixer", "phone", "puree", "silly", "smoothie" });
        private static IconData _Blog;
        public static IconData FA_Blog => _Blog ??= new IconData("Blog", "\U0000F781", Styles.Solid, new string[] { "article", "blog", "diary", "entry", "journal", "log", "online", "personal", "post", "website", "wordpress", "writing" });
        private static IconData _Blogger;
        public static IconData FA_Blogger => _Blogger ??= new IconData("Blogger", "\U0000F37C", Styles.Brands, new string[] { "blog", "blogger", "blogging", "blogspot", "content creator", "google blog", "publishing", "writing" });
        private static IconData _BloggerB;
        public static IconData FA_BloggerB => _BloggerB ??= new IconData("Blogger B", "\U0000F37D", Styles.Brands, new string[] { "blog", "blog platform", "blogger", "blogging", "blogspot", "content creation", "google blogger", "publishing", "writing" });
        private static IconData _Bluesky;
        public static IconData FA_Bluesky => _Bluesky ??= new IconData("Bluesky", "\U0000E671", Styles.Brands, new string[] { "app", "bluesky", "decentralized", "platform", "social media", "social network" });
        private static IconData _Bluetooth;
        public static IconData FA_Bluetooth => _Bluetooth ??= new IconData("Bluetooth", "\U0000F293", Styles.Brands, new string[] { "bluetooth", "connection", "device", "pairing", "signal", "technology", "wireless" });
        private static IconData _BluetoothB;
        public static IconData FA_BluetoothB => _BluetoothB ??= new IconData("Bluetooth B", "\U0000F294", Styles.Brands, new string[] { "bluetooth", "bluetooth device", "bluetooth icon", "bluetooth logo", "bluetooth symbol", "connectivity", "wireless", "wireless technology" });
        private static IconData _BoardGameGeek;
        public static IconData FA_BoardGameGeek => _BoardGameGeek ??= new IconData("Board Game Geek", "\U0000E855", Styles.Brands, new string[] { });
        private static IconData _Bold;
        public static IconData FA_Bold => _Bold ??= new IconData("Bold", "\U0000F032", Styles.Solid, new string[] { "bold", "emphasis", "font", "format", "highlight", "strong", "style", "text", "typography", "weight" });
        private static IconData _Bolt;
        public static IconData FA_Bolt => _Bolt ??= new IconData("Bolt", "\U0000F0E7", Styles.Solid, new string[] { "bolt", "charge", "electric", "electricity", "energy", "flash", "high voltage", "lightning", "power", "strike", "thunderbolt", "weather", "zap" });
        private static IconData _BoltLightning;
        public static IconData FA_BoltLightning => _BoltLightning ??= new IconData("Bolt Lightning", "\U0000E0B7", Styles.Solid, new string[] { "bolt", "electric", "electricity", "energy", "flash", "lightning", "power", "storm", "strike", "thunderbolt", "weather", "zap" });
        private static IconData _Bomb;
        public static IconData FA_Bomb => _Bomb ??= new IconData("Bomb", "\U0000F1E2", Styles.Solid, new string[] { "blast", "bomb", "boom", "cartoon", "danger", "detonator", "explosion", "explosive", "fuse", "grenade", "kaboom", "warning" });
        private static IconData _Bone;
        public static IconData FA_Bone => _Bone ??= new IconData("Bone", "\U0000F5D7", Styles.Solid, new string[] { "anatomy", "bone", "calcium", "chew", "dog", "femur", "joint", "marrow", "pet", "skeletal", "skeleton", "tibia", "treat" });
        private static IconData _Bong;
        public static IconData FA_Bong => _Bong ??= new IconData("Bong", "\U0000F55C", Styles.Solid, new string[] { "apparatus", "cannabis", "herbal", "marijuana", "pipe", "smoke", "smoking", "smoking device", "tokes", "water pipe", "weed" });
        private static IconData _Book;
        public static IconData FA_Book => _Book ??= new IconData("Book", "\U0000F02D", Styles.Solid, new string[] { "book", "diary", "education", "journal", "knowledge", "library", "literature", "manuscript", "notebook", "publication", "reading", "research", "study", "text", "writing" });
        private static IconData _BookAtlas;
        public static IconData FA_BookAtlas => _BookAtlas ??= new IconData("Book Atlas", "\U0000F558", Styles.Solid, new string[] { "atlas", "book", "directions", "exploration", "geography", "globe", "guide", "knowledge", "library", "map", "navigation", "reference", "research", "travel", "wayfinding" });
        private static IconData _BookBible;
        public static IconData FA_BookBible => _BookBible ??= new IconData("Book Bible", "\U0000F647", Styles.Solid, new string[] { "bible", "book", "catholicism", "christianity", "faith", "god", "gospel", "holy book", "religion", "scripture", "testament" });
        private static IconData _BookBookmark;
        public static IconData FA_BookBookmark => _BookBookmark ??= new IconData("Book Bookmark", "\U0000E0BB", Styles.Solid, new string[] { "book", "bookmark", "favorite", "knowledge", "library", "reading", "reference", "research", "save", "study" });
        private static IconData _BookJournalWhills;
        public static IconData FA_BookJournalWhills => _BookJournalWhills ??= new IconData("Book Journal Whills", "\U0000F66A", Styles.Solid, new string[] { "ancient", "book", "force", "jedi", "journal", "lore", "scripture", "scroll", "sith", "star wars", "tome", "whills", "yoda" });
        private static IconData _BookMedical;
        public static IconData FA_BookMedical => _BookMedical ??= new IconData("Book Medical", "\U0000F7E6", Styles.Solid, new string[] { "appointment", "chart", "clinic", "diary", "documentation", "file", "health", "history", "hospital", "journal", "medical", "notes", "patient", "record", "research" });
        private static IconData _BookOpen;
        public static IconData FA_BookOpen => _BookOpen ??= new IconData("Book Open", "\U0000F518", Styles.Solid, new string[] { "book", "education", "guide", "knowledge", "library", "literature", "manual", "notebook", "open book", "pages", "reading", "research", "study", "text" });
        private static IconData _BookOpenReader;
        public static IconData FA_BookOpenReader => _BookOpenReader ??= new IconData("Book Open Reader", "\U0000F5DA", Styles.Solid, new string[] { "book", "education", "flyer", "library", "literature", "notebook", "open book", "pamphlet", "reader", "reading", "research", "study" });
        private static IconData _BookQuran;
        public static IconData FA_BookQuran => _BookQuran ??= new IconData("Book Quran", "\U0000F687", Styles.Solid, new string[] { "holy book", "islam", "islamic text", "koran", "muslim", "muslim faith", "quran", "religion", "sacred text", "scripture" });
        private static IconData _BookSkull;
        public static IconData FA_BookSkull => _BookSkull ??= new IconData("Book Skull", "\U0000F6B7", Styles.Solid, new string[] { "Dungeons & Dragons", "curses", "d&d", "dark arts", "death", "dnd", "evil", "fantasy", "halloween", "library", "magic", "necronomicon", "occult", "read", "research", "skull", "sorcery", "spellbook", "witchcraft" });
        private static IconData _BookTanakh;
        public static IconData FA_BookTanakh => _BookTanakh ??= new IconData("Book Tanakh", "\U0000F827", Styles.Solid, new string[] { "bible", "book", "faith", "hebrew bible", "jewish", "judaism", "old testament", "religion", "religious text", "sacred text", "scripture", "spiritual", "tanakh", "torah" });
        private static IconData _Bookmark;
        public static IconData FA_Bookmark => _Bookmark ??= new IconData("Bookmark", "\U0000F02E", Styles.Regular | Styles.Solid, new string[] { "bookmark", "clip", "favorite", "flag", "hold", "keep", "mark", "marker", "page", "read", "remember", "research", "ribbon", "save", "tag" });
        private static IconData _Bootstrap;
        public static IconData FA_Bootstrap => _Bootstrap ??= new IconData("Bootstrap", "\U0000F836", Styles.Brands, new string[] { "UI framework", "bootstrap", "components", "css framework", "front-end", "grid system", "open source", "responsive", "twbs", "web development" });
        private static IconData _BorderAll;
        public static IconData FA_BorderAll => _BorderAll ??= new IconData("Border All", "\U0000F84C", Styles.Solid, new string[] { "border", "border-style", "box", "cell", "cells", "frame", "grid", "layout", "outline", "spreadsheet", "square", "table" });
        private static IconData _BorderNone;
        public static IconData FA_BorderNone => _BorderNone ??= new IconData("Border None", "\U0000F850", Styles.Solid, new string[] { "border", "borderless", "cell", "clear border", "grid", "no border", "none", "outline", "remove border", "stroke", "table" });
        private static IconData _BorderTopLeft;
        public static IconData FA_BorderTopLeft => _BorderTopLeft ??= new IconData("Border Top Left", "\U0000F853", Styles.Solid, new string[] { "border", "box", "cell", "corner", "edge", "grid", "left", "outline", "stroke", "table", "top" });
        private static IconData _BoreHole;
        public static IconData FA_BoreHole => _BoreHole ??= new IconData("Bore Hole", "\U0000E4C3", Styles.Solid, new string[] { "bore", "borehole", "dig", "drill", "drilling", "drilling rig", "excavation", "hole", "shaft", "tunnel", "underground" });
        private static IconData _Bots;
        public static IconData FA_Bots => _Bots ??= new IconData("Bots", "\U0000E340", Styles.Brands, new string[] { "ai", "ai assistant", "artificial intelligence", "automated", "automation", "bots", "chatbot", "messaging", "robot", "virtual assistant" });
        private static IconData _BottleDroplet;
        public static IconData FA_BottleDroplet => _BottleDroplet ??= new IconData("Bottle Droplet", "\U0000E4C4", Styles.Solid, new string[] { "alcohol", "beverage", "bottle", "container", "drink", "droplet", "fluid", "liquid", "oil", "olive oil", "pour", "wine" });
        private static IconData _BottleWater;
        public static IconData FA_BottleWater => _BottleWater ??= new IconData("Bottle Water", "\U0000E4C5", Styles.Solid, new string[] { "beverage", "bottle", "container", "drink", "h2o", "hydration", "liquid", "plastic", "refreshment", "water" });
        private static IconData _BowlFood;
        public static IconData FA_BowlFood => _BowlFood ??= new IconData("Bowl Food", "\U0000E4C6", Styles.Solid, new string[] { "bowl", "cat food", "dish", "dog food", "food", "kibble", "meal", "pet bowl", "pet food", "rice", "snack" });
        private static IconData _BowlRice;
        public static IconData FA_BowlRice => _BowlRice ??= new IconData("Bowl Rice", "\U0000E2EB", Styles.Solid, new string[] { "Asian cuisine", "boiled", "bowl", "cooked rice", "food", "grain", "meal", "rice", "side dish", "steamed" });
        private static IconData _BowlingBall;
        public static IconData FA_BowlingBall => _BowlingBall ??= new IconData("Bowling Ball", "\U0000F436", Styles.Solid, new string[] { "alley", "ball", "bowling", "bowling ball", "candlepin", "game", "gutter", "lane", "pins", "roll", "sports", "strike", "tenpin" });
        private static IconData _Box;
        public static IconData FA_Box => _Box ??= new IconData("Box", "\U0000F466", Styles.Solid, new string[] { "archive", "box", "carton", "container", "crate", "delivery", "gift box", "moving", "package", "packing", "parcel", "shipping", "storage", "storage box" });
        private static IconData _BoxArchive;
        public static IconData FA_BoxArchive => _BoxArchive ??= new IconData("Box Archive", "\U0000F187", Styles.Solid, new string[] { "archive", "backup", "box", "container", "delivery", "file", "folder", "package", "parcel", "save", "shipment", "storage" });
        private static IconData _BoxOpen;
        public static IconData FA_BoxOpen => _BoxOpen ??= new IconData("Box Open", "\U0000F49E", Styles.Solid, new string[] { "box", "carton", "container", "crate", "delivery", "gift", "open box", "package", "parcel", "shipping", "storage", "unboxing", "unpack" });
        private static IconData _BoxTissue;
        public static IconData FA_BoxTissue => _BoxTissue ??= new IconData("Box Tissue", "\U0000E05B", Styles.Solid, new string[] { "allergy", "box", "cold", "cough", "covid-19", "flu", "hygiene", "kleenex", "mucus", "nose", "runny nose", "sneeze", "snot", "tissue", "tissues" });
        private static IconData _BoxesPacking;
        public static IconData FA_BoxesPacking => _BoxesPacking ??= new IconData("Boxes Packing", "\U0000E4C7", Styles.Solid, new string[] { "archive", "box", "container", "delivery", "moving", "package", "packing", "parcel", "shipping", "storage", "supplies" });
        private static IconData _BoxesStacked;
        public static IconData FA_BoxesStacked => _BoxesStacked ??= new IconData("Boxes Stacked", "\U0000F468", Styles.Solid, new string[] { "archives", "boxes", "carton", "container", "inventory", "logistics", "organizing", "packing", "shipping", "stacked", "storage", "supply chain", "warehouse" });
        private static IconData _Braille;
        public static IconData FA_Braille => _Braille ??= new IconData("Braille", "\U0000F2A1", Styles.Solid, new string[] { "accessibility", "alphabet", "blind", "braille", "dots", "raised", "reading", "tactile", "touch", "vision impaired", "visually impaired" });
        private static IconData _Brain;
        public static IconData FA_Brain => _Brain ??= new IconData("Brain", "\U0000F5DC", Styles.Solid, new string[] { "brain", "cerebellum", "cerebrum", "creativity", "genius", "gray matter", "idea", "intellect", "intelligence", "knowledge", "mind", "noodle", "scholar", "smart", "thinking", "wit" });
        private static IconData _Brave;
        public static IconData FA_Brave => _Brave ??= new IconData("Brave", "\U0000E63C", Styles.Brands, new string[] { "ad blocker", "brave", "brave browser", "chromium", "fast browser", "internet", "privacy", "secure browser", "web browser" });
        private static IconData _BraveReverse;
        public static IconData FA_BraveReverse => _BraveReverse ??= new IconData("Brave Reverse", "\U0000E63D", Styles.Brands, new string[] { "ad blocker", "blockchain", "brave", "brave browser", "cryptocurrency", "fast browser", "internet", "privacy", "security", "web browser" });
        private static IconData _BrazilianRealSign;
        public static IconData FA_BrazilianRealSign => _BrazilianRealSign ??= new IconData("Brazilian Real Sign", "\U0000E46C", Styles.Solid, new string[] { "brazil", "brazilian currency", "brazilian real", "brazilian real sign", "cash", "currency", "currency symbol", "financial", "money", "payment", "real" });
        private static IconData _BreadSlice;
        public static IconData FA_BreadSlice => _BreadSlice ??= new IconData("Bread Slice", "\U0000F7EC", Styles.Solid, new string[] { "baked", "bakery", "baking", "bread", "breakfast", "crust", "dough", "flour", "gluten", "grain", "loaf", "sandwich", "slice", "toast", "wheat", "yeast" });
        private static IconData _Bridge;
        public static IconData FA_Bridge => _Bridge ??= new IconData("Bridge", "\U0000E4C8", Styles.Solid, new string[] { "bridge", "connection", "crossing", "infrastructure", "overpass", "pathway", "river crossing", "road", "span", "viaduct" });
        private static IconData _BridgeCircleCheck;
        public static IconData FA_BridgeCircleCheck => _BridgeCircleCheck ??= new IconData("Bridge Circle Check", "\U0000E4C9", Styles.Solid, new string[] { "active", "approve", "bridge", "check", "confirm", "connection", "enabled", "ok", "okay", "pass", "road", "success", "validate", "verify", "working" });
        private static IconData _BridgeCircleExclamation;
        public static IconData FA_BridgeCircleExclamation => _BridgeCircleExclamation ??= new IconData("Bridge Circle Exclamation", "\U0000E4CA", Styles.Solid, new string[] { "affected", "alert", "bridge", "caution", "danger", "exclamation", "failure", "problem", "road", "warning" });
        private static IconData _BridgeCircleXmark;
        public static IconData FA_BridgeCircleXmark => _BridgeCircleXmark ??= new IconData("Bridge Circle Xmark", "\U0000E4CB", Styles.Solid, new string[] { "block", "bridge", "cancel", "close", "crossing", "delete", "deny", "no", "reject", "remove", "road", "stop", "xmark" });
        private static IconData _BridgeLock;
        public static IconData FA_BridgeLock => _BridgeLock ??= new IconData("Bridge Lock", "\U0000E4CC", Styles.Solid, new string[] { "access", "barrier", "bridge", "closed", "lock", "locked", "padlock", "privacy", "protection", "quarantine", "restricted", "road", "security" });
        private static IconData _BridgeWater;
        public static IconData FA_BridgeWater => _BridgeWater ??= new IconData("Bridge Water", "\U0000E4CE", Styles.Solid, new string[] { "bridge", "crossing", "highway", "overpass", "river", "road", "span", "structure", "viaduct", "water" });
        private static IconData _Briefcase;
        public static IconData FA_Briefcase => _Briefcase ??= new IconData("Briefcase", "\U0000F0B1", Styles.Solid, new string[] { "bag", "briefcase", "business", "career", "case", "contract", "document", "job", "luggage", "meeting", "office", "portfolio", "professional", "suitcase", "work" });
        private static IconData _BriefcaseMedical;
        public static IconData FA_BriefcaseMedical => _BriefcaseMedical ??= new IconData("Briefcase Medical", "\U0000F469", Styles.Solid, new string[] { "clinic", "doctor", "doctor bag", "emergency", "emt", "first aid", "health", "healthcare", "hospital", "medical", "medical kit", "medicine", "nurse", "paramedic", "treatment" });
        private static IconData _Broom;
        public static IconData FA_Broom => _Broom ??= new IconData("Broom", "\U0000F51A", Styles.Solid, new string[] { "broom", "brush", "clean", "cleaning", "dust", "flying broom", "halloween", "household", "janitor", "magic broom", "sweep", "sweeping", "tidy", "witch" });
        private static IconData _BroomBall;
        public static IconData FA_BroomBall => _BroomBall ??= new IconData("Broom Ball", "\U0000F458", Styles.Solid, new string[] { "ball", "bludger", "broom", "flying ball", "golden snitch", "harry potter", "hogwarts", "magical sport", "quaffle", "quidditch", "sport", "wizard" });
        private static IconData _Brush;
        public static IconData FA_Brush => _Brush ??= new IconData("Brush", "\U0000F55D", Styles.Solid, new string[] { "art", "artist", "bristles", "brushstroke", "color", "creative", "design", "drawing", "handle", "paint", "painting", "tool" });
        private static IconData _Btc;
        public static IconData FA_Btc => _Btc ??= new IconData("Btc", "\U0000F15A", Styles.Brands, new string[] { "bitcoin", "blockchain", "btc", "btc coin", "btc token", "coin", "crypto", "cryptocurrency", "digital currency", "token" });
        private static IconData _Bucket;
        public static IconData FA_Bucket => _Bucket ??= new IconData("Bucket", "\U0000E4CF", Styles.Solid, new string[] { "beach", "bucket", "carry", "cleaning", "container", "gardening", "pail", "sand", "sandcastle", "scoop", "water" });
        private static IconData _Buffer;
        public static IconData FA_Buffer => _Buffer ??= new IconData("Buffer", "\U0000F837", Styles.Brands, new string[] { "buffer", "content management", "marketing", "posts", "scheduling", "social media", "social media management", "social media platform", "social media tool", "social network" });
        private static IconData _Bug;
        public static IconData FA_Bug => _Bug ??= new IconData("Bug", "\U0000F188", Styles.Solid, new string[] { "beetle", "bug", "debug", "defect", "error", "fix", "glitch", "insect", "issue", "problem", "repair", "report", "troubleshooting" });
        private static IconData _BugSlash;
        public static IconData FA_BugSlash => _BugSlash ??= new IconData("Bug Slash", "\U0000E490", Styles.Solid, new string[] { "beetle", "block", "bug", "cancel", "disable", "disabled", "error", "fix", "glitch", "insect", "optimize", "repair", "report", "warning" });
        private static IconData _Bugs;
        public static IconData FA_Bugs => _Bugs ??= new IconData("Bugs", "\U0000E4D0", Styles.Solid, new string[] { "bedbug", "bug", "creepy crawly", "infestation", "insect", "lice", "parasite", "pest", "pest control", "ticks" });
        private static IconData _Building;
        public static IconData FA_Building => _Building ??= new IconData("Building", "\U0000F1AD", Styles.Regular | Styles.Solid, new string[] { "apartment", "architecture", "building", "business", "city", "company", "corporate", "headquarters", "office", "office building", "real estate", "skyscraper", "tower", "urban", "workplace" });
        private static IconData _BuildingCircleArrowRight;
        public static IconData FA_BuildingCircleArrowRight => _BuildingCircleArrowRight ??= new IconData("Building Circle Arrow Right", "\U0000E4D1", Styles.Solid, new string[] { "arrow", "building", "city", "delivery", "distribution center", "export", "logistics", "move", "office", "outbound", "send", "shipping", "transfer", "warehouse" });
        private static IconData _BuildingCircleCheck;
        public static IconData FA_BuildingCircleCheck => _BuildingCircleCheck ??= new IconData("Building Circle Check", "\U0000E4D2", Styles.Solid, new string[] { "approved", "building", "check", "city", "confirm", "enabled", "office", "ok", "okay", "success", "validate", "verified", "working" });
        private static IconData _BuildingCircleExclamation;
        public static IconData FA_BuildingCircleExclamation => _BuildingCircleExclamation ??= new IconData("Building Circle Exclamation", "\U0000E4D3", Styles.Solid, new string[] { "affected", "alert", "building", "caution", "city", "error", "exclamation", "failed", "issue", "office", "problem", "warning" });
        private static IconData _BuildingCircleXmark;
        public static IconData FA_BuildingCircleXmark => _BuildingCircleXmark ??= new IconData("Building Circle Xmark", "\U0000E4D4", Styles.Solid, new string[] { "block", "building", "cancel", "city", "close", "delete", "dismiss", "error", "no", "office", "reject", "remove", "stop", "xmark" });
        private static IconData _BuildingColumns;
        public static IconData FA_BuildingColumns => _BuildingColumns ??= new IconData("Building Columns", "\U0000F19C", Styles.Solid, new string[] { "architecture", "bank", "building", "classical", "college", "courthouse", "courthouse", "education", "finance", "government", "institution", "legal", "museum", "pillar", "students", "temple" });
        private static IconData _BuildingFlag;
        public static IconData FA_BuildingFlag => _BuildingFlag ??= new IconData("Building Flag", "\U0000E4D5", Styles.Solid, new string[] { "building", "city", "consulate", "diplomatic", "embassy", "flag", "government", "headquarters", "international", "office", "organization", "united nations" });
        private static IconData _BuildingLock;
        public static IconData FA_BuildingLock => _BuildingLock ??= new IconData("Building Lock", "\U0000E4D6", Styles.Solid, new string[] { "building", "city", "closed", "lock", "lockdown", "locked", "locked building", "padlock", "private", "protected", "quarantine", "restricted", "secure", "security" });
        private static IconData _BuildingNgo;
        public static IconData FA_BuildingNgo => _BuildingNgo ??= new IconData("Building Ngo", "\U0000E4D7", Styles.Solid, new string[] { "building", "charity", "city", "headquarters", "institution", "ngo", "non governmental organization", "nonprofit", "office", "organization" });
        private static IconData _BuildingShield;
        public static IconData FA_BuildingShield => _BuildingShield ??= new IconData("Building Shield", "\U0000E4D8", Styles.Solid, new string[] { "building", "city", "defense", "guard", "law enforcement", "police", "protection", "safety", "secure", "security", "shield" });
        private static IconData _BuildingUn;
        public static IconData FA_BuildingUn => _BuildingUn ??= new IconData("Building Un", "\U0000E4D9", Styles.Solid, new string[] { "UN", "building", "city", "diplomacy", "emblem", "global", "headquarters", "international", "office", "organization", "peacekeeping", "united nations" });
        private static IconData _BuildingUser;
        public static IconData FA_BuildingUser => _BuildingUser ??= new IconData("Building User", "\U0000E4DA", Styles.Solid, new string[] { "apartment", "building", "city", "employee", "occupant", "office", "person", "profile", "resident", "tenant", "user", "workplace" });
        private static IconData _BuildingWheat;
        public static IconData FA_BuildingWheat => _BuildingWheat ??= new IconData("Building Wheat", "\U0000E4DB", Styles.Solid, new string[] { "agriculture", "barn", "building", "crop", "farm", "farming", "grain", "harvest", "rural", "silo", "usda", "wheat" });
        private static IconData _Bullhorn;
        public static IconData FA_Bullhorn => _Bullhorn ??= new IconData("Bullhorn", "\U0000F0A1", Styles.Solid, new string[] { "alert", "amplify", "announce", "announcement", "broadcast", "bullhorn", "call out", "communication", "loudspeaker", "megaphone", "message", "promote", "public address", "share", "speaker", "volume" });
        private static IconData _Bullseye;
        public static IconData FA_Bullseye => _Bullseye ??= new IconData("Bullseye", "\U0000F140", Styles.Solid, new string[] { "aim", "archery", "bullseye", "dartboard", "focus", "goal", "objective", "precision", "strategy", "target" });
        private static IconData _Burger;
        public static IconData FA_Burger => _Burger ??= new IconData("Burger", "\U0000F805", Styles.Solid, new string[] { "beef", "bun", "burger", "cheeseburger", "dinner", "fast food", "food", "grill", "hamburger", "lunch", "meal", "patty", "sandwich", "takeaway" });
        private static IconData _Buromobelexperte;
        public static IconData FA_Buromobelexperte => _Buromobelexperte ??= new IconData("Buromobelexperte", "\U0000F37F", Styles.Brands, new string[] { "German brand", "buromobel", "buromobel experte", "experte", "furniture brand", "office furniture" });
        private static IconData _Burst;
        public static IconData FA_Burst => _Burst ??= new IconData("Burst", "\U0000E4DC", Styles.Solid, new string[] { "bang", "blast", "boom", "burst", "crash", "detonation", "explosion", "fireworks", "flare", "impact", "pop", "spark" });
        private static IconData _Bus;
        public static IconData FA_Bus => _Bus ??= new IconData("Bus", "\U0000F207", Styles.Solid, new string[] { "bus", "coach", "commuter", "oncoming bus", "passenger vehicle", "public transportation", "shuttle", "transit", "transport", "travel", "vehicle" });
        private static IconData _BusSide;
        public static IconData FA_BusSide => _BusSide ??= new IconData("Bus Side", "\U0000E81D", Styles.Solid, new string[] { "bus", "coach", "commuter", "mass transit", "passenger bus", "public transportation", "shuttle", "transit", "travel", "vehicle" });
        private static IconData _BusSimple;
        public static IconData FA_BusSimple => _BusSimple ??= new IconData("Bus Simple", "\U0000F55E", Styles.Solid, new string[] { "bus", "bus stop", "coach", "commuter", "mass transit", "mta", "public transportation", "shuttle", "transit", "transport", "travel", "vehicle" });
        private static IconData _BusinessTime;
        public static IconData FA_BusinessTime => _BusinessTime ??= new IconData("Business Time", "\U0000F64A", Styles.Solid, new string[] { "alarm", "appointment", "briefcase", "business", "clock", "deadline", "hours", "office", "reminder", "schedule", "time", "timer", "work" });
        private static IconData _BuyNLarge;
        public static IconData FA_BuyNLarge => _BuyNLarge ??= new IconData("Buy N Large", "\U0000F8A6", Styles.Brands, new string[] { "bnL", "buy n large", "buy-n-large", "corporation", "fictional brand", "large retailer", "mega company", "parody", "sci-fi" });
        private static IconData _Buysellads;
        public static IconData FA_Buysellads => _Buysellads ??= new IconData("Buysellads", "\U0000F20D", Styles.Brands, new string[] { "ad network", "ad platform", "advertising", "buy sell ads", "buysellads", "digital ads", "marketing", "media buying" });
        private static IconData _C;
        public static IconData FA_C => _C ??= new IconData("C", "\U00000043", Styles.Solid, new string[] { "alphabet c", "c alphabet character", "c glyph", "c symbol", "capital c", "character c", "latin letter c", "letter c", "lowercase c" });
        private static IconData _CableCar;
        public static IconData FA_CableCar => _CableCar ??= new IconData("Cable Car", "\U0000F7DA", Styles.Solid, new string[] { "aerial tramway", "cabin", "cable car", "cableway", "gondola", "lift", "mountain", "mountain cableway", "ropeway", "ski lift", "tram", "tramway", "transport", "trolley" });
        private static IconData _CakeCandles;
        public static IconData FA_CakeCandles => _CakeCandles ??= new IconData("Cake Candles", "\U0000F1FD", Styles.Solid, new string[] { "anniversary", "bakery", "birthday", "blow out candles", "cake", "candles", "celebration", "dessert", "festive", "frosting", "holiday", "party", "pastry", "sweet", "treat" });
        private static IconData _Calculator;
        public static IconData FA_Calculator => _Calculator ??= new IconData("Calculator", "\U0000F1EC", Styles.Solid, new string[] { "addition", "arithmetic", "calculator", "calculator app", "calculator device", "counting", "digits", "division", "finance", "math", "math tool", "multiplication", "numbers", "pocket calculator", "subtraction" });
        private static IconData _Calendar;
        public static IconData FA_Calendar => _Calendar ??= new IconData("Calendar", "\U0000F133", Styles.Regular | Styles.Solid, new string[] { "agenda", "appointment", "calendar", "date", "day", "deadline", "event", "month", "planner", "reminder", "schedule", "time", "year" });
        private static IconData _CalendarCheck;
        public static IconData FA_CalendarCheck => _CalendarCheck ??= new IconData("Calendar Check", "\U0000F274", Styles.Regular | Styles.Solid, new string[] { "accept", "agree", "appointment", "approved", "booked", "calendar", "check", "completed", "confirm", "confirmed", "date", "day", "deadline", "done", "event", "mark", "meeting", "month", "planned", "reminder", "schedule", "select", "success", "tick", "time", "todo", "validate" });
        private static IconData _CalendarDay;
        public static IconData FA_CalendarDay => _CalendarDay ??= new IconData("Calendar Day", "\U0000F783", Styles.Solid, new string[] { "appointment", "calendar", "date", "day", "event", "focus", "month", "planner", "reminder", "schedule", "single day", "time", "timeline", "today", "year" });
        private static IconData _CalendarDays;
        public static IconData FA_CalendarDays => _CalendarDays ??= new IconData("Calendar Days", "\U0000F073", Styles.Regular | Styles.Solid, new string[] { "agenda", "appointment", "calendar", "date", "day", "deadline", "event", "month", "planner", "reminder", "schedule", "time", "timeline", "year" });
        private static IconData _CalendarMinus;
        public static IconData FA_CalendarMinus => _CalendarMinus ??= new IconData("Calendar Minus", "\U0000F272", Styles.Regular | Styles.Solid, new string[] { "calendar", "cancel", "clear", "date", "day", "delete", "event", "minus", "month", "reduce", "remove", "schedule", "subtract", "time", "year" });
        private static IconData _CalendarPlus;
        public static IconData FA_CalendarPlus => _CalendarPlus ??= new IconData("Calendar Plus", "\U0000F271", Styles.Regular | Styles.Solid, new string[] { "add", "appointment", "calendar", "create", "date", "day", "event", "month", "new", "plan", "plus", "reminder", "schedule", "time", "year" });
        private static IconData _CalendarWeek;
        public static IconData FA_CalendarWeek => _CalendarWeek ??= new IconData("Calendar Week", "\U0000F784", Styles.Solid, new string[] { "agenda", "appointment", "calendar", "date", "day", "event", "month", "period", "planner", "schedule", "time", "timeframe", "today", "week" });
        private static IconData _CalendarXmark;
        public static IconData FA_CalendarXmark => _CalendarXmark ??= new IconData("Calendar Xmark", "\U0000F273", Styles.Regular | Styles.Solid, new string[] { "appointment", "calendar", "cancel", "cancelation", "close", "date", "day", "delete", "event", "month", "remove", "schedule", "time", "x", "year" });
        private static IconData _Camera;
        public static IconData FA_Camera => _Camera ??= new IconData("Camera", "\U0000F030", Styles.Regular | Styles.Solid, new string[] { "camera", "camera icon", "capture", "film", "image", "lens", "photo", "photograph", "photography", "picture", "recording", "shutter", "snapshot", "video" });
        private static IconData _CameraRetro;
        public static IconData FA_CameraRetro => _CameraRetro ??= new IconData("Camera Retro", "\U0000F083", Styles.Solid, new string[] { "analog", "camera", "classic", "film", "image", "lens", "old-fashioned", "photo", "photography", "picture", "record", "retro", "shutter", "snapshot", "vintage" });
        private static IconData _CameraRotate;
        public static IconData FA_CameraRotate => _CameraRotate ??= new IconData("Camera Rotate", "\U0000E0D8", Styles.Solid, new string[] { "camera", "flip", "flip camera", "front-facing", "image", "photo", "rotate", "rotate camera", "selfie", "switch" });
        private static IconData _Campground;
        public static IconData FA_Campground => _Campground ??= new IconData("Campground", "\U0000F6BB", Styles.Solid, new string[] { "campfire", "campground", "camping", "campsite", "forest", "hiking", "nature", "outdoors", "teepee", "tent", "tipi", "wilderness" });
        private static IconData _CanadianMapleLeaf;
        public static IconData FA_CanadianMapleLeaf => _CanadianMapleLeaf ??= new IconData("Canadian Maple Leaf", "\U0000F785", Styles.Brands, new string[] { "canada", "canadian", "emblem", "leaf", "maple", "nature", "plant", "symbol" });
        private static IconData _Cancer;
        public static IconData FA_Cancer => _Cancer ??= new IconData("Cancer", "\U0000E847", Styles.Solid, new string[] { "astrology", "cancer", "constellation", "crab", "horoscope", "july", "june", "sign", "stars", "water sign", "zodiac" });
        private static IconData _CandyCane;
        public static IconData FA_CandyCane => _CandyCane ??= new IconData("Candy Cane", "\U0000F786", Styles.Solid, new string[] { "candy", "cane", "christmas", "festive", "holiday", "mint", "peppermint", "striped", "sweet", "treat", "winter", "xmas" });
        private static IconData _Cannabis;
        public static IconData FA_Cannabis => _Cannabis ??= new IconData("Cannabis", "\U0000F55F", Styles.Solid, new string[] { "bud", "cannabis", "cbd", "chronic", "ganja", "hemp", "indica", "marijuana", "mary jane", "pot", "reefer", "sativa", "spliff", "thc", "weed" });
        private static IconData _Capricorn;
        public static IconData FA_Capricorn => _Capricorn ??= new IconData("Capricorn", "\U0000E848", Styles.Solid, new string[] { "astrology", "capricorn", "constellation", "december", "earth sign", "goat", "horoscope", "january", "sea", "sea goat", "sign", "stars", "zodiac" });
        private static IconData _Capsules;
        public static IconData FA_Capsules => _Capsules ??= new IconData("Capsules", "\U0000F46B", Styles.Solid, new string[] { "capsules", "drugs", "health", "medication", "medicine", "pharmaceuticals", "pharmacy", "pills", "prescription", "tablets", "treatment" });
        private static IconData _Car;
        public static IconData FA_Car => _Car ??= new IconData("Car", "\U0000F1B9", Styles.Solid, new string[] { "auto", "automobile", "car", "commute", "driving", "motorcar", "ride", "road trip", "sedan", "transportation", "travel", "vehicle" });
        private static IconData _CarBattery;
        public static IconData FA_CarBattery => _CarBattery ??= new IconData("Car Battery", "\U0000F5DF", Styles.Solid, new string[] { "auto", "automotive", "battery", "battery-pack", "car", "charge", "electric", "energy", "ignition", "mechanic", "power", "starter", "vehicle" });
        private static IconData _CarBurst;
        public static IconData FA_CarBurst => _CarBurst ??= new IconData("Car Burst", "\U0000F5E1", Styles.Solid, new string[] { "accident", "auto", "automobile", "car", "collision", "crash", "damage", "insurance", "transportation", "vehicle", "wreck" });
        private static IconData _CarOn;
        public static IconData FA_CarOn => _CarOn ??= new IconData("Car On", "\U0000E4DD", Styles.Solid, new string[] { "alarm", "alert", "anti-theft", "car", "carjack", "immobilizer", "security", "theft", "vehicle", "warning" });
        private static IconData _CarRear;
        public static IconData FA_CarRear => _CarRear ??= new IconData("Car Rear", "\U0000F5DE", Styles.Solid, new string[] { "auto", "automobile", "back", "car", "coupe", "driving", "hatchback", "motor vehicle", "rear view", "road", "sedan", "transportation", "travel", "vehicle" });
        private static IconData _CarSide;
        public static IconData FA_CarSide => _CarSide ??= new IconData("Car Side", "\U0000F5E4", Styles.Solid, new string[] { "auto", "automobile", "car", "coupe", "driving", "hatchback", "motorcar", "ride", "road", "sedan", "transport", "transportation", "travel", "vehicle" });
        private static IconData _CarTunnel;
        public static IconData FA_CarTunnel => _CarTunnel ??= new IconData("Car Tunnel", "\U0000E4DE", Styles.Solid, new string[] { "car", "driving", "highway", "motorway", "passage", "road", "transportation", "tunnel", "underpass", "vehicle" });
        private static IconData _Caravan;
        public static IconData FA_Caravan => _Caravan ??= new IconData("Caravan", "\U0000F8FF", Styles.Solid, new string[] { "camper", "camper trailer", "camping", "caravan trailer", "mobile home", "motorhome", "recreational vehicle", "road trip", "rv", "towable", "trailer", "travel", "vacation" });
        private static IconData _CaretDown;
        public static IconData FA_CaretDown => _CaretDown ??= new IconData("Caret Down", "\U0000F0D7", Styles.Solid, new string[] { "arrow", "chevron", "down", "dropdown", "expand", "indicator", "menu", "more", "navigation", "pointer", "toggle", "triangle" });
        private static IconData _CaretLeft;
        public static IconData FA_CaretLeft => _CaretLeft ??= new IconData("Caret Left", "\U0000F0D9", Styles.Solid, new string[] { "arrow", "back", "chevron", "direction", "left", "navigation", "pointer", "previous", "rewind", "triangle" });
        private static IconData _CaretRight;
        public static IconData FA_CaretRight => _CaretRight ??= new IconData("Caret Right", "\U0000F0DA", Styles.Solid, new string[] { "arrow", "chevron", "forward", "move", "navigation", "next", "play", "pointer", "right", "skip", "triangle" });
        private static IconData _CaretUp;
        public static IconData FA_CaretUp => _CaretUp ??= new IconData("Caret Up", "\U0000F0D8", Styles.Solid, new string[] { "arrow", "caret", "chevron", "collapse", "expand", "increase", "navigation", "pointer", "triangle", "up", "up arrow", "upgrade" });
        private static IconData _Carrot;
        public static IconData FA_Carrot => _Carrot ??= new IconData("Carrot", "\U0000F787", Styles.Solid, new string[] { "Bugs Bunny", "carrot", "food", "garden", "healthy", "orange", "produce", "root vegetable", "snack", "vegan", "vegetable" });
        private static IconData _CartArrowDown;
        public static IconData FA_CartArrowDown => _CartArrowDown ??= new IconData("Cart Arrow Down", "\U0000F218", Styles.Solid, new string[] { "add to cart", "arrow down", "basket", "buy", "cart", "checkout", "download", "insert", "order", "purchase", "save", "shopping" });
        private static IconData _CartFlatbed;
        public static IconData FA_CartFlatbed => _CartFlatbed ??= new IconData("Cart Flatbed", "\U0000F474", Styles.Solid, new string[] { "carry", "cart", "delivery", "dolly", "flatbed", "hand truck", "inventory", "logistics", "shipping", "transport", "trolley", "warehouse" });
        private static IconData _CartFlatbedSuitcase;
        public static IconData FA_CartFlatbedSuitcase => _CartFlatbedSuitcase ??= new IconData("Cart Flatbed Suitcase", "\U0000F59D", Styles.Solid, new string[] { "airport", "airport cart", "bag", "baggage", "carry-on", "flatbed", "luggage", "suitcase", "suitcase trolley", "travel", "travel bag", "trolley" });
        private static IconData _CartPlus;
        public static IconData FA_CartPlus => _CartPlus ??= new IconData("Cart Plus", "\U0000F217", Styles.Solid, new string[] { "add", "add to cart", "buy", "cart", "ecommerce", "increase", "new item", "plus", "positive", "purchase", "shopping", "shopping basket" });
        private static IconData _CartShopping;
        public static IconData FA_CartShopping => _CartShopping ??= new IconData("Cart Shopping", "\U0000F07A", Styles.Solid, new string[] { "add to cart", "basket", "buy", "cart", "cart icon", "checkout", "ecommerce", "grocery", "payment", "purchase", "retail", "shop", "shopping cart", "store", "trolley" });
        private static IconData _CashApp;
        public static IconData FA_CashApp => _CashApp ??= new IconData("Cash App", "\U0000E7D4", Styles.Brands, new string[] { "cash app", "cashapp", "digital wallet", "finance", "mobile payment", "money transfer", "payment", "peer-to-peer", "receive money", "send money", "venmo alternative" });
        private static IconData _CashRegister;
        public static IconData FA_CashRegister => _CashRegister ??= new IconData("Cash Register", "\U0000F788", Styles.Solid, new string[] { "buy", "cash", "cha-ching", "change", "checkout", "commerce", "machine", "pay", "payment", "purchase", "register", "retail", "store", "transaction" });
        private static IconData _Cat;
        public static IconData FA_Cat => _Cat ??= new IconData("Cat", "\U0000F6BE", Styles.Solid, new string[] { "animal", "cat", "claw", "cute", "domestic", "feline", "fur", "kitten", "kitty", "mammal", "meow", "pet", "pet animal", "whiskers" });
        private static IconData _CcAmazonPay;
        public static IconData FA_CcAmazonPay => _CcAmazonPay ??= new IconData("Cc Amazon Pay", "\U0000F42D", Styles.Brands, new string[] { "amazon", "amazon pay", "buy", "checkout", "digital wallet", "ecommerce", "online shopping", "pay", "payment", "purchase" });
        private static IconData _CcAmex;
        public static IconData FA_CcAmex => _CcAmex ??= new IconData("Cc Amex", "\U0000F1F3", Styles.Brands, new string[] { "american express", "amex", "banking", "card", "credit card", "finance", "payment" });
        private static IconData _CcApplePay;
        public static IconData FA_CcApplePay => _CcApplePay ??= new IconData("Cc Apple Pay", "\U0000F416", Styles.Brands, new string[] { "apple", "apple pay", "applepay", "contactless", "digital wallet", "mobile payment", "pay", "payment", "tap to pay", "wallet" });
        private static IconData _CcDinersClub;
        public static IconData FA_CcDinersClub => _CcDinersClub ??= new IconData("Cc Diners Club", "\U0000F24C", Styles.Brands, new string[] { "banking", "card", "club card", "credit card", "diners club", "dinersclub", "finance", "payment" });
        private static IconData _CcDiscover;
        public static IconData FA_CcDiscover => _CcDiscover ??= new IconData("Cc Discover", "\U0000F1F2", Styles.Brands, new string[] { "banking", "card network", "cc", "credit", "credit card", "debit", "discover", "financial", "payment" });
        private static IconData _CcJcb;
        public static IconData FA_CcJcb => _CcJcb ??= new IconData("Cc Jcb", "\U0000F24B", Styles.Brands, new string[] { "banking", "card", "credit card", "debit", "financial", "jcb", "mastercard alternative", "payment", "transaction" });
        private static IconData _CcMastercard;
        public static IconData FA_CcMastercard => _CcMastercard ??= new IconData("Cc Mastercard", "\U0000F1F1", Styles.Brands, new string[] { "card", "credit card", "mastercard", "mastercard brand", "mastercard card", "mastercard logo", "mastercard payment", "payment" });
        private static IconData _CcPaypal;
        public static IconData FA_CcPaypal => _CcPaypal ??= new IconData("Cc Paypal", "\U0000F1F4", Styles.Brands, new string[] { "cc", "credit card", "digital wallet", "ecommerce", "money transfer", "online payment", "payment", "paypal", "paypal card", "paypal credit" });
        private static IconData _CcStripe;
        public static IconData FA_CcStripe => _CcStripe ??= new IconData("Cc Stripe", "\U0000F1F5", Styles.Brands, new string[] { "billing", "card", "cc", "credit card", "ecommerce", "fintech", "online payment", "payment", "stripe", "subscription" });
        private static IconData _CcVisa;
        public static IconData FA_CcVisa => _CcVisa ??= new IconData("Cc Visa", "\U0000F1F0", Styles.Brands, new string[] { "banking", "card", "credit card", "debit", "financial", "mastercard alternative", "payment", "visa", "visa card", "visa logo" });
        private static IconData _CediSign;
        public static IconData FA_CediSign => _CediSign ??= new IconData("Cedi Sign", "\U0000E0DF", Styles.Solid, new string[] { "cash", "cedi", "currency", "currency sign", "currency symbol", "financial", "ghana", "ghanaian cedi", "money", "payment" });
        private static IconData _CentSign;
        public static IconData FA_CentSign => _CentSign ??= new IconData("Cent Sign", "\U0000E3F5", Styles.Solid, new string[] { "cash", "cent", "cent sign", "cents", "coin", "currency", "currency symbol", "finance", "money", "payment" });
        private static IconData _Centercode;
        public static IconData FA_Centercode => _Centercode ??= new IconData("Centercode", "\U0000F380", Styles.Brands, new string[] { "QA", "beta testing", "center code", "centercode", "feedback platform", "quality assurance", "software testing", "testing", "user testing" });
        private static IconData _Centos;
        public static IconData FA_Centos => _Centos ??= new IconData("Centos", "\U0000F789", Styles.Brands, new string[] { "centos", "enterprise linux", "linux", "linux distribution", "operating system", "os", "server" });
        private static IconData _Certificate;
        public static IconData FA_Certificate => _Certificate ??= new IconData("Certificate", "\U0000F0A3", Styles.Solid, new string[] { "achievement", "award", "badge", "certificate", "certification", "diploma", "document", "endorsement", "guarantee", "official", "quality", "recognition", "seal", "star", "verified" });
        private static IconData _Chair;
        public static IconData FA_Chair => _Chair ??= new IconData("Chair", "\U0000F6C0", Styles.Solid, new string[] { "armchair", "bench", "chair", "dining chair", "furniture", "office chair", "recliner", "seat", "seating", "sitting", "stool" });
        private static IconData _Chalkboard;
        public static IconData FA_Chalkboard => _Chalkboard ??= new IconData("Chalkboard", "\U0000F51B", Styles.Solid, new string[] { "blackboard", "board", "chalk", "chalkboard", "classroom", "education", "learning", "lesson", "presentation", "school", "teaching", "writing" });
        private static IconData _ChalkboardUser;
        public static IconData FA_ChalkboardUser => _ChalkboardUser ??= new IconData("Chalkboard User", "\U0000F51C", Styles.Solid, new string[] { "blackboard", "classroom", "education", "instructor", "learning", "lecture", "professor", "school", "teacher", "whiteboard", "writing" });
        private static IconData _ChampagneGlasses;
        public static IconData FA_ChampagneGlasses => _ChampagneGlasses ??= new IconData("Champagne Glasses", "\U0000F79F", Styles.Solid, new string[] { "alcohol", "anniversary", "bar", "beverage", "celebrate", "celebration", "champagne", "cheers", "clink", "clinking glasses", "drink", "festive", "glass", "holiday", "new year's eve", "party", "sparkling wine", "toast", "wedding" });
        private static IconData _ChargingStation;
        public static IconData FA_ChargingStation => _ChargingStation ??= new IconData("Charging Station", "\U0000F5E7", Styles.Solid, new string[] { "battery charging", "car charger", "charge", "charging", "charging station", "electric car", "electric vehicle", "ev", "ev charger", "plug-in", "power station", "tesla", "vehicle" });
        private static IconData _ChartArea;
        public static IconData FA_ChartArea => _ChartArea ??= new IconData("Chart Area", "\U0000F1FE", Styles.Solid, new string[] { "analytics", "area", "business", "chart", "data", "graph", "growth", "metrics", "performance", "report", "revenue", "statistics", "trend", "visualization" });
        private static IconData _ChartBar;
        public static IconData FA_ChartBar => _ChartBar ??= new IconData("Chart Bar", "\U0000F080", Styles.Regular | Styles.Solid, new string[] { "analytics", "bar", "chart", "comparison", "dashboard", "data", "graph", "metrics", "performance", "progress", "report", "statistics", "trends", "visualization" });
        private static IconData _ChartColumn;
        public static IconData FA_ChartColumn => _ChartColumn ??= new IconData("Chart Column", "\U0000E0E3", Styles.Solid, new string[] { "analytics", "bar", "bar chart", "chart", "column chart", "compare", "dashboard", "data", "graph", "measure", "performance", "report", "statistics", "trend", "visualize" });
        private static IconData _ChartDiagram;
        public static IconData FA_ChartDiagram => _ChartDiagram ??= new IconData("Chart Diagram", "\U0000E695", Styles.Solid, new string[] { "algorithm", "analytics", "chart", "connections", "data", "diagram", "flow", "graph", "network", "nodes", "process", "structure", "workflow" });
        private static IconData _ChartGantt;
        public static IconData FA_ChartGantt => _ChartGantt ??= new IconData("Chart Gantt", "\U0000E0E4", Styles.Solid, new string[] { "chart", "gantt", "graph", "management", "performance", "planning", "progress", "project", "schedule", "statistics", "tasks", "timeline", "tracking", "trend", "workflow" });
        private static IconData _ChartLine;
        public static IconData FA_ChartLine => _ChartLine ??= new IconData("Chart Line", "\U0000F201", Styles.Solid, new string[] { "activity", "analytics", "chart", "dashboard", "data", "gain", "graph", "growth", "increase", "line", "performance", "progress", "report", "revenue", "statistics", "trend" });
        private static IconData _ChartPie;
        public static IconData FA_ChartPie => _ChartPie ??= new IconData("Chart Pie", "\U0000F200", Styles.Solid, new string[] { "analytics", "chart", "circle", "data", "diagram", "distribution", "graph", "infographic", "performance", "pie", "pie chart", "report", "revenue", "segments", "statistics" });
        private static IconData _ChartSimple;
        public static IconData FA_ChartSimple => _ChartSimple ??= new IconData("Chart Simple", "\U0000E473", Styles.Solid, new string[] { "analytics", "bar", "chart", "column", "data", "graph", "infographic", "metrics", "performance", "progress", "report", "revenue", "statistics", "trend", "visualization" });
        private static IconData _Check;
        public static IconData FA_Check => _Check ??= new IconData("Check", "\U0000F00C", Styles.Solid, new string[] { "accept", "agree", "approved", "check", "check mark", "checkmark", "completed", "confirm", "correct", "done", "enable", "ok", "select", "success", "tick", "true", "validate", "verified", "yes" });
        private static IconData _CheckDouble;
        public static IconData FA_CheckDouble => _CheckDouble ??= new IconData("Check Double", "\U0000F560", Styles.Solid, new string[] { "accept", "agree", "approved", "checkmark", "completed", "confirm", "correct", "done", "done twice", "double check", "enable", "finished", "ok", "select", "select all", "success", "tick", "validate", "verified" });
        private static IconData _CheckToSlot;
        public static IconData FA_CheckToSlot => _CheckToSlot ??= new IconData("Check To Slot", "\U0000F772", Styles.Solid, new string[] { "accept", "approve", "ballot", "cast", "checkmark", "election", "enable", "mark", "positive", "select", "validate", "vote", "voting", "yes" });
        private static IconData _Cheese;
        public static IconData FA_Cheese => _Cheese ??= new IconData("Cheese", "\U0000F7EF", Styles.Solid, new string[] { "cheddar", "cheese", "curd", "dairy", "dairy product", "dairy wedge", "food", "gouda", "parmesan", "sandwich", "slice", "snack", "swiss", "wedge" });
        private static IconData _Chess;
        public static IconData FA_Chess => _Chess ??= new IconData("Chess", "\U0000F439", Styles.Solid, new string[] { "bishop", "board", "checkmate", "chess", "chess piece", "competition", "game", "king", "knight", "match", "pawn", "queen", "rook", "strategy", "tournament" });
        private static IconData _ChessBishop;
        public static IconData FA_ChessBishop => _ChessBishop ??= new IconData("Chess Bishop", "\U0000F43A", Styles.Regular | Styles.Solid, new string[] { "bishop", "black bishop", "board game", "checkmate", "chess", "chess piece", "chessboard", "game piece", "strategy" });
        private static IconData _ChessBoard;
        public static IconData FA_ChessBoard => _ChessBoard ??= new IconData("Chess Board", "\U0000F43C", Styles.Solid, new string[] { "board", "checkers", "checkmate", "chess", "chess game", "chess match", "chess piece", "chess set", "chessboard", "chessboard pattern", "game", "strategy" });
        private static IconData _ChessKing;
        public static IconData FA_ChessKing => _ChessKing ??= new IconData("Chess King", "\U0000F43F", Styles.Regular | Styles.Solid, new string[] { "board game", "checkmate", "chess", "chess king", "chess piece", "chess strategy", "chessboard", "game", "king", "king piece", "strategy" });
        private static IconData _ChessKnight;
        public static IconData FA_ChessKnight => _ChessKnight ??= new IconData("Chess Knight", "\U0000F441", Styles.Regular | Styles.Solid, new string[] { "board game", "checkmate", "chess", "chess match", "chess piece", "chessboard", "game piece", "horse", "knight", "strategy" });
        private static IconData _ChessPawn;
        public static IconData FA_ChessPawn => _ChessPawn ??= new IconData("Chess Pawn", "\U0000F443", Styles.Regular | Styles.Solid, new string[] { "board game", "checkmate", "chess", "chess pawn", "expendable", "game piece", "pawn", "piece", "sacrifice", "strategy" });
        private static IconData _ChessQueen;
        public static IconData FA_ChessQueen => _ChessQueen ??= new IconData("Chess Queen", "\U0000F445", Styles.Regular | Styles.Solid, new string[] { "board game", "checkmate", "chess", "chess piece", "chess queen", "chess set", "chessboard", "game", "queen", "queen piece", "strategy" });
        private static IconData _ChessRook;
        public static IconData FA_ChessRook => _ChessRook ??= new IconData("Chess Rook", "\U0000F447", Styles.Regular | Styles.Solid, new string[] { "board game", "castle", "checkmate", "chess piece", "chess strategy", "chessboard", "defense", "game piece", "rook", "strategy", "tower" });
        private static IconData _ChevronDown;
        public static IconData FA_ChevronDown => _ChevronDown ??= new IconData("Chevron Down", "\U0000F078", Styles.Solid, new string[] { "arrow", "chevron", "collapse", "down", "dropdown", "expand", "indicator", "more", "navigation", "toggle" });
        private static IconData _ChevronLeft;
        public static IconData FA_ChevronLeft => _ChevronLeft ??= new IconData("Chevron Left", "\U0000F053", Styles.Solid, new string[] { "angle bracket", "arrow", "back", "caret", "chevron", "go back", "left", "navigation", "previous", "slide back" });
        private static IconData _ChevronRight;
        public static IconData FA_ChevronRight => _ChevronRight ??= new IconData("Chevron Right", "\U0000F054", Styles.Solid, new string[] { "angle bracket", "arrow", "arrowhead", "caret", "chevron", "forward", "navigation", "next", "pointer", "right", "slide" });
        private static IconData _ChevronUp;
        public static IconData FA_ChevronUp => _ChevronUp ??= new IconData("Chevron Up", "\U0000F077", Styles.Solid, new string[] { "arrow", "back", "chevron", "collapse", "expand", "increase", "previous", "scroll up", "up", "upload" });
        private static IconData _Child;
        public static IconData FA_Child => _Child ??= new IconData("Child", "\U0000F1AE", Styles.Solid, new string[] { "baby", "boy", "child", "girl", "infant", "kid", "minor", "preschooler", "toddler", "young", "youngster", "youth" });
        private static IconData _ChildCombatant;
        public static IconData FA_ChildCombatant => _ChildCombatant ??= new IconData("Child Combatant", "\U0000E4E0", Styles.Solid, new string[] { "armed child", "child combatant", "child fighter", "child in conflict", "child militia", "child soldier", "child soldier icon", "child war", "child with weapon" });
        private static IconData _ChildDress;
        public static IconData FA_ChildDress => _ChildDress ??= new IconData("Child Dress", "\U0000E59C", Styles.Solid, new string[] { "child", "children", "clothing", "dress", "garment", "kid", "kidswear", "outfit", "toddler", "young", "youth" });
        private static IconData _ChildReaching;
        public static IconData FA_ChildReaching => _ChildReaching ??= new IconData("Child Reaching", "\U0000E59D", Styles.Solid, new string[] { "boy", "child", "girl", "kid", "playful", "reaching", "toddler", "young", "youth" });
        private static IconData _Children;
        public static IconData FA_Children => _Children ??= new IconData("Children", "\U0000E4E1", Styles.Solid, new string[] { "boy", "child", "children", "family", "friends", "girl", "kid", "kids", "play", "together", "young", "youth" });
        private static IconData _Chrome;
        public static IconData FA_Chrome => _Chrome ??= new IconData("Chrome", "\U0000F268", Styles.Brands, new string[] { "browser", "chrome", "google", "google chrome", "internet", "search engine", "web browser" });
        private static IconData _Chromecast;
        public static IconData FA_Chromecast => _Chromecast ??= new IconData("Chromecast", "\U0000F838", Styles.Brands, new string[] { "cast", "chromecast", "dongle", "google chromecast", "google device", "media player", "screen mirroring", "streaming", "television", "tv", "wireless display" });
        private static IconData _Church;
        public static IconData FA_Church => _Church ??= new IconData("Church", "\U0000F51D", Styles.Solid, new string[] { "Christian", "building", "cathedral", "chapel", "church", "community", "congregation", "cross", "faith", "house of worship", "religion", "spirituality", "worship" });
        private static IconData _Circle;
        public static IconData FA_Circle => _Circle ??= new IconData("Circle", "\U0000F111", Styles.Regular | Styles.Solid, new string[] { "black circle", "blue circle", "brown circle", "circle", "diameter", "dot", "ellipse", "fill", "geometric", "green circle", "indicator", "notification", "orange circle", "progress", "purple circle", "red circle", "round", "shape", "status", "white circle", "yellow circle" });
        private static IconData _CircleArrowDown;
        public static IconData FA_CircleArrowDown => _CircleArrowDown ??= new IconData("Circle Arrow Down", "\U0000F0AB", Styles.Solid, new string[] { "arrow", "arrow down", "circle arrow", "download", "download button", "download icon", "downward", "get file", "import", "save" });
        private static IconData _CircleArrowLeft;
        public static IconData FA_CircleArrowLeft => _CircleArrowLeft ??= new IconData("Circle Arrow Left", "\U0000F0A8", Styles.Solid, new string[] { "arrow", "back", "backward", "go back", "left", "navigate left", "previous", "return", "rewind", "undo" });
        private static IconData _CircleArrowRight;
        public static IconData FA_CircleArrowRight => _CircleArrowRight ??= new IconData("Circle Arrow Right", "\U0000F0A9", Styles.Solid, new string[] { "arrow", "circle", "continue", "direction", "forward", "move", "navigation", "next", "proceed", "right" });
        private static IconData _CircleArrowUp;
        public static IconData FA_CircleArrowUp => _CircleArrowUp ??= new IconData("Circle Arrow Up", "\U0000F0AA", Styles.Solid, new string[] { "arrow", "arrow up", "ascend", "direction", "increase", "move up", "up arrow", "upgrade", "upload", "upward" });
        private static IconData _CircleCheck;
        public static IconData FA_CircleCheck => _CircleCheck ??= new IconData("Circle Check", "\U0000F058", Styles.Regular | Styles.Solid, new string[] { "accept", "agree", "approve", "check", "confirm", "correct", "done", "enable", "ok", "select", "success", "tick", "validate", "yes" });
        private static IconData _CircleChevronDown;
        public static IconData FA_CircleChevronDown => _CircleChevronDown ??= new IconData("Circle Chevron Down", "\U0000F13A", Styles.Solid, new string[] { "arrow", "chevron", "collapse", "down", "dropdown", "expand", "menu", "more", "navigation", "toggle" });
        private static IconData _CircleChevronLeft;
        public static IconData FA_CircleChevronLeft => _CircleChevronLeft ??= new IconData("Circle Chevron Left", "\U0000F137", Styles.Solid, new string[] { "arrow", "back", "caret", "chevron", "direction", "left", "navigation", "pointer", "previous", "rewind", "slide" });
        private static IconData _CircleChevronRight;
        public static IconData FA_CircleChevronRight => _CircleChevronRight ??= new IconData("Circle Chevron Right", "\U0000F138", Styles.Solid, new string[] { "arrow", "chevron", "continue", "direction", "forward", "navigation", "next", "next step", "proceed", "right" });
        private static IconData _CircleChevronUp;
        public static IconData FA_CircleChevronUp => _CircleChevronUp ??= new IconData("Circle Chevron Up", "\U0000F139", Styles.Solid, new string[] { "arrow", "chevron", "collapse", "expand", "increase", "move up", "navigate up", "scroll up", "up", "upload" });
        private static IconData _CircleDollarToSlot;
        public static IconData FA_CircleDollarToSlot => _CircleDollarToSlot ??= new IconData("Circle Dollar To Slot", "\U0000F4B9", Styles.Solid, new string[] { "cash", "charity", "coin", "contribute", "donation", "funding", "generosity", "gift", "give", "insert", "money", "payment", "premium", "slot machine", "tip" });
        private static IconData _CircleDot;
        public static IconData FA_CircleDot => _CircleDot ??= new IconData("Circle Dot", "\U0000F192", Styles.Regular | Styles.Solid, new string[] { "bullseye", "button", "circle", "dot", "focus", "indicator", "marker", "notification", "point", "radio", "radio button", "target" });
        private static IconData _CircleDown;
        public static IconData FA_CircleDown => _CircleDown ??= new IconData("Circle Down", "\U0000F358", Styles.Regular | Styles.Solid, new string[] { "arrow-circle-down", "arrow-down", "circle-arrow-down", "circle-download", "download", "download-button", "download-circle", "downward-arrow", "save", "save-file" });
        private static IconData _CircleExclamation;
        public static IconData FA_CircleExclamation => _CircleExclamation ??= new IconData("Circle Exclamation", "\U0000F06A", Styles.Solid, new string[] { "alert", "attention", "caution", "danger", "error", "exclamation", "important", "issue", "notice", "notification", "notify", "problem", "required", "urgent", "warning" });
        private static IconData _CircleH;
        public static IconData FA_CircleH => _CircleH ??= new IconData("Circle H", "\U0000F47E", Styles.Solid, new string[] { "circled H", "clinic", "covid-19", "emergency", "health", "healthcare", "hospital", "letter H", "map", "medical" });
        private static IconData _CircleHalfStroke;
        public static IconData FA_CircleHalfStroke => _CircleHalfStroke ??= new IconData("Circle Half Stroke", "\U0000F042", Styles.Solid, new string[] { "adjust", "brightness", "circle", "contrast", "dark", "fill", "half", "half circle", "left half", "light", "mode", "pie", "progress", "saturation", "stroke", "theme", "toggle" });
        private static IconData _CircleInfo;
        public static IconData FA_CircleInfo => _CircleInfo ??= new IconData("Circle Info", "\U0000F05A", Styles.Solid, new string[] { "about", "data", "details", "explanation", "facts", "guidance", "help", "info", "information", "more", "support" });
        private static IconData _CircleLeft;
        public static IconData FA_CircleLeft => _CircleLeft ??= new IconData("Circle Left", "\U0000F359", Styles.Regular | Styles.Solid, new string[] { "arrow", "arrow-circle-left", "back", "circle", "go back", "left", "navigation", "previous", "return", "undo" });
        private static IconData _CircleMinus;
        public static IconData FA_CircleMinus => _CircleMinus ??= new IconData("Circle Minus", "\U0000F056", Styles.Solid, new string[] { "block", "cancel", "circle", "close", "delete", "disable", "hide", "minus", "negative", "remove", "subtract", "symbol" });
        private static IconData _CircleNodes;
        public static IconData FA_CircleNodes => _CircleNodes ??= new IconData("Circle Nodes", "\U0000E4E2", Styles.Solid, new string[] { "cluster", "connect", "connection", "diagram", "dots", "graph", "linked", "mesh", "network", "nodes", "points", "relationship", "web" });
        private static IconData _CircleNotch;
        public static IconData FA_CircleNotch => _CircleNotch ??= new IconData("Circle Notch", "\U0000F1CE", Styles.Solid, new string[] { "buffering", "circle", "circle-o-notch", "loading", "notch", "progress", "round", "spinner", "wait" });
        private static IconData _CirclePause;
        public static IconData FA_CirclePause => _CirclePause ??= new IconData("Circle Pause", "\U0000F28B", Styles.Regular | Styles.Solid, new string[] { "break", "halt", "hold", "media control", "pause", "pause button", "stop", "temporary stop", "wait", "waiting" });
        private static IconData _CirclePlay;
        public static IconData FA_CirclePlay => _CirclePlay ??= new IconData("Circle Play", "\U0000F144", Styles.Regular | Styles.Solid, new string[] { "audio", "clip", "media", "movie", "music", "play", "sound", "start", "streaming", "video", "watch" });
        private static IconData _CirclePlus;
        public static IconData FA_CirclePlus => _CirclePlus ??= new IconData("Circle Plus", "\U0000F055", Styles.Solid, new string[] { "add", "button", "circle", "create", "expand", "increase", "more", "new", "plus", "positive", "symbol" });
        private static IconData _CircleQuestion;
        public static IconData FA_CircleQuestion => _CircleQuestion ??= new IconData("Circle Question", "\U0000F059", Styles.Regular | Styles.Solid, new string[] { "ask", "assist", "confusion", "doubt", "faq", "help", "info", "information", "inquiry", "query", "question", "question-mark", "support", "unknown" });
        private static IconData _CircleRadiation;
        public static IconData FA_CircleRadiation => _CircleRadiation ??= new IconData("Circle Radiation", "\U0000F7BA", Styles.Solid, new string[] { "alert", "biohazard", "caution", "danger", "hazard", "nuclear", "radiation", "radioactive", "sign", "toxic", "warning" });
        private static IconData _CircleRight;
        public static IconData FA_CircleRight => _CircleRight ??= new IconData("Circle Right", "\U0000F35A", Styles.Regular | Styles.Solid, new string[] { "arrow", "arrow-circle-o-right", "circle", "continue", "direction", "forward", "move", "navigation", "next", "proceed", "right" });
        private static IconData _CircleStop;
        public static IconData FA_CircleStop => _CircleStop ??= new IconData("Circle Stop", "\U0000F28D", Styles.Regular | Styles.Solid, new string[] { "block", "cancel", "circle", "deny", "disallow", "forbidden", "halt", "no", "pause", "prevent", "prohibit", "stop" });
        private static IconData _CircleUp;
        public static IconData FA_CircleUp => _CircleUp ??= new IconData("Circle Up", "\U0000F35B", Styles.Regular | Styles.Solid, new string[] { "arrow", "arrow-circle-up", "circle", "direction up", "increase", "move up", "up", "upgrade", "upload", "upload arrow" });
        private static IconData _CircleUser;
        public static IconData FA_CircleUser => _CircleUser ??= new IconData("Circle User", "\U0000F2BD", Styles.Regular | Styles.Solid, new string[] { "account", "avatar", "contact", "employee", "individual", "member", "people", "person", "profile", "user", "username" });
        private static IconData _CircleXmark;
        public static IconData FA_CircleXmark => _CircleXmark ??= new IconData("Circle Xmark", "\U0000F057", Styles.Regular | Styles.Solid, new string[] { "cancel", "close", "cross", "dismiss", "error", "exit", "fail", "incorrect", "no", "reject", "remove", "stop", "wrong", "xmark" });
        private static IconData _CircleZulip;
        public static IconData FA_CircleZulip => _CircleZulip ??= new IconData("Circle Zulip", "\U0000E851", Styles.Brands, new string[] { });
        private static IconData _City;
        public static IconData FA_City => _City ??= new IconData("City", "\U0000F64F", Styles.Solid, new string[] { "architecture", "block", "buildings", "city", "cityscape", "downtown", "metropolis", "neighborhood", "skyline", "skyscrapers", "urban", "windows" });
        private static IconData _Clapperboard;
        public static IconData FA_Clapperboard => _Clapperboard ??= new IconData("Clapperboard", "\U0000E131", Styles.Solid, new string[] { "camera", "cinema", "clapper", "clapper board", "clapperboard", "director", "film", "movie", "production", "recording", "shoot", "slate", "video" });
        private static IconData _Claude;
        public static IconData FA_Claude => _Claude ??= new IconData("Claude", "\U0000E861", Styles.Brands, new string[] { });
        private static IconData _Clipboard;
        public static IconData FA_Clipboard => _Clipboard ??= new IconData("Clipboard", "\U0000F328", Styles.Regular | Styles.Solid, new string[] { "board", "checklist", "clipboard", "copy", "document", "file", "memo", "notepad", "notes", "paper", "paste", "record", "task", "writing" });
        private static IconData _ClipboardCheck;
        public static IconData FA_ClipboardCheck => _ClipboardCheck ??= new IconData("Clipboard Check", "\U0000F46C", Styles.Solid, new string[] { "approve", "check", "checkmark", "clipboard", "complete", "confirm", "done", "finish", "ok", "success", "task", "todo", "validate", "yes" });
        private static IconData _ClipboardList;
        public static IconData FA_ClipboardList => _ClipboardList ??= new IconData("Clipboard List", "\U0000F46D", Styles.Solid, new string[] { "agenda", "checklist", "clipboard", "completed", "done", "finished", "list", "notes", "plan", "schedule", "summary", "survey", "tasks", "tick", "todo", "wishlist" });
        private static IconData _ClipboardQuestion;
        public static IconData FA_ClipboardQuestion => _ClipboardQuestion ??= new IconData("Clipboard Question", "\U0000E4E3", Styles.Solid, new string[] { "assistance", "checklist", "clipboard", "doubt", "faq", "form", "help", "inquiry", "interview", "query", "question", "support", "task" });
        private static IconData _ClipboardUser;
        public static IconData FA_ClipboardUser => _ClipboardUser ??= new IconData("Clipboard User", "\U0000F7F3", Styles.Solid, new string[] { "account", "attendance", "employee", "identity", "list", "person", "personnel", "profile", "record", "roster", "staff", "user" });
        private static IconData _Clock;
        public static IconData FA_Clock => _Clock ??= new IconData("Clock", "\U0000F017", Styles.Regular | Styles.Solid, new string[] { "4", "4:00", "alarm", "clock", "four", "four o’clock", "hour", "late", "minute", "o'clock", "pending", "schedule", "ticking", "time", "timer", "timestamp", "watch" });
        private static IconData _ClockRotateLeft;
        public static IconData FA_ClockRotateLeft => _ClockRotateLeft ??= new IconData("Clock Rotate Left", "\U0000F1DA", Styles.Solid, new string[] { "back", "clock", "history", "pending", "refresh", "reset", "reverse", "rewind", "time", "undo", "waiting" });
        private static IconData _Clone;
        public static IconData FA_Clone => _Clone ??= new IconData("Clone", "\U0000F24D", Styles.Regular | Styles.Solid, new string[] { "add", "backup", "clone", "copy", "copy-paste", "duplicate", "mirror", "new", "repeat", "replicate", "replicate" });
        private static IconData _ClosedCaptioning;
        public static IconData FA_ClosedCaptioning => _ClosedCaptioning ??= new IconData("Closed Captioning", "\U0000F20A", Styles.Regular | Styles.Solid, new string[] { "accessibility", "captions", "cc", "closed caption", "closed captions", "deaf", "hearing impaired", "subtitle", "subtitles", "text", "transcript", "video" });
        private static IconData _ClosedCaptioningSlash;
        public static IconData FA_ClosedCaptioningSlash => _ClosedCaptioningSlash ??= new IconData("Closed Captioning Slash", "\U0000E135", Styles.Solid, new string[] { "captions off", "cc", "closed captioning", "deaf", "disabled", "hearing impaired", "mute captions", "no captions", "no subtitles", "subtitles off", "subtitling" });
        private static IconData _Cloud;
        public static IconData FA_Cloud => _Cloud ??= new IconData("Cloud", "\U0000F0C2", Styles.Regular | Styles.Solid, new string[] { "atmosphere", "backup", "cloud", "data", "fog", "internet", "network", "online", "overcast", "save", "sky", "storage", "upload", "weather" });
        private static IconData _CloudArrowDown;
        public static IconData FA_CloudArrowDown => _CloudArrowDown ??= new IconData("Cloud Arrow Down", "\U0000F0ED", Styles.Solid, new string[] { "arrow", "backup", "cloud", "data", "download", "file", "import", "network", "save", "storage", "sync", "transfer", "upload" });
        private static IconData _CloudArrowUp;
        public static IconData FA_CloudArrowUp => _CloudArrowUp ??= new IconData("Cloud Arrow Up", "\U0000F0EE", Styles.Solid, new string[] { "backup", "cloud", "cloud upload", "import", "save", "send", "sync", "transfer", "update", "upgrade", "upload" });
        private static IconData _CloudBolt;
        public static IconData FA_CloudBolt => _CloudBolt ??= new IconData("Cloud Bolt", "\U0000F76C", Styles.Solid, new string[] { "bolt", "cloud", "electric", "energy", "lightning", "lightning bolt", "power", "precipitation", "rain", "storm", "thunder", "thunderstorm", "weather" });
        private static IconData _CloudMeatball;
        public static IconData FA_CloudMeatball => _CloudMeatball ??= new IconData("Cloud Meatball", "\U0000F73B", Styles.Solid, new string[] { "FLDSMDFR", "cloud", "dinner", "food", "italian", "meal", "meatball", "pasta", "sauce", "spaghetti", "storm", "weather" });
        private static IconData _CloudMoon;
        public static IconData FA_CloudMoon => _CloudMoon ??= new IconData("Cloud Moon", "\U0000F6C3", Styles.Solid, new string[] { "crescent", "dusk", "evening", "lunar", "moon", "night", "nighttime", "partly cloudy", "sky", "twilight", "weather" });
        private static IconData _CloudMoonRain;
        public static IconData FA_CloudMoonRain => _CloudMoonRain ??= new IconData("Cloud Moon Rain", "\U0000F73C", Styles.Solid, new string[] { "crescent", "drizzle", "evening", "moon", "night", "partly cloudy", "precipitation", "rain", "showers", "sky", "storm", "weather" });
        private static IconData _CloudRain;
        public static IconData FA_CloudRain => _CloudRain ??= new IconData("Cloud Rain", "\U0000F73D", Styles.Solid, new string[] { "cloud", "drizzle", "precipitation", "rain", "rainy", "shower", "sky", "storm", "thunderstorm", "weather", "wet" });
        private static IconData _CloudShowersHeavy;
        public static IconData FA_CloudShowersHeavy => _CloudShowersHeavy ??= new IconData("Cloud Showers Heavy", "\U0000F740", Styles.Solid, new string[] { "cloud", "downpour", "heavy rain", "precipitation", "rain", "showers", "storm", "thunderstorm", "weather", "wet" });
        private static IconData _CloudShowersWater;
        public static IconData FA_CloudShowersWater => _CloudShowersWater ??= new IconData("Cloud Showers Water", "\U0000E4E4", Styles.Solid, new string[] { "cloud", "downpour", "drizzle", "precipitation", "rain", "rainfall", "shower", "storm", "thunderstorm", "water", "weather", "wet" });
        private static IconData _CloudSun;
        public static IconData FA_CloudSun => _CloudSun ??= new IconData("Cloud Sun", "\U0000F6C4", Styles.Solid, new string[] { "clear sky", "cloud", "daytime", "forecast", "mild weather", "outdoors", "overcast", "partly cloudy", "spring", "summer", "sun", "sun behind cloud", "weather" });
        private static IconData _CloudSunRain;
        public static IconData FA_CloudSunRain => _CloudSunRain ??= new IconData("Cloud Sun Rain", "\U0000F743", Styles.Solid, new string[] { "cloud", "day", "drizzle", "mixed weather", "overcast", "partly sunny", "precipitation", "rain", "shower", "storm", "summer", "sun", "sun behind rain cloud", "sunshower", "weather" });
        private static IconData _Cloudflare;
        public static IconData FA_Cloudflare => _Cloudflare ??= new IconData("Cloudflare", "\U0000E07D", Styles.Brands, new string[] { "cdn", "cf", "cloud services", "cloudflare", "content delivery network", "ddos protection", "dns", "firewall", "internet security", "web performance" });
        private static IconData _Cloudscale;
        public static IconData FA_Cloudscale => _Cloudscale ??= new IconData("Cloudscale", "\U0000F383", Styles.Brands, new string[] { "cloud computing", "cloud hosting", "cloud infrastructure", "cloud provider", "cloud services", "cloudscale", "cloudscale.ch", "data center", "hosting", "server" });
        private static IconData _Cloudsmith;
        public static IconData FA_Cloudsmith => _Cloudsmith ??= new IconData("Cloudsmith", "\U0000F384", Styles.Brands, new string[] { "artifact storage", "cloud packages", "cloudsmith", "cloudsmith.io", "continuous integration", "devops", "package management", "software repository" });
        private static IconData _Cloudversify;
        public static IconData FA_Cloudversify => _Cloudversify ??= new IconData("Cloudversify", "\U0000F385", Styles.Brands, new string[] { "cloud platform", "cloud services", "cloudversify", "cloudversify brand", "cloudversify company", "cloudversify logo" });
        private static IconData _Clover;
        public static IconData FA_Clover => _Clover ??= new IconData("Clover", "\U0000E139", Styles.Solid, new string[] { "charm", "clover", "fortune", "four leaf", "four-leaf", "good luck", "ireland", "irish", "leaf", "leprechaun", "luck", "lucky", "shamrock", "st patrick", "st patrick's day" });
        private static IconData _Cmplid;
        public static IconData FA_Cmplid => _Cmplid ??= new IconData("Cmplid", "\U0000E360", Styles.Brands, new string[] { "cmplid", "compliance", "compliance management", "compliance software", "governance", "regulatory", "risk management" });
        private static IconData _Code;
        public static IconData FA_Code => _Code ??= new IconData("Code", "\U0000F121", Styles.Solid, new string[] { "backend", "brackets", "code", "coding", "developer", "development", "frontend", "html", "markup", "mysql", "programming", "script", "software", "sql", "syntax" });
        private static IconData _CodeBranch;
        public static IconData FA_CodeBranch => _CodeBranch ??= new IconData("Code Branch", "\U0000F126", Styles.Solid, new string[] { "branch", "code", "commit", "development", "git", "github", "merge", "programming", "rebase", "repository", "software", "source control", "vcs", "version" });
        private static IconData _CodeCommit;
        public static IconData FA_CodeCommit => _CodeCommit ??= new IconData("Code Commit", "\U0000F386", Styles.Solid, new string[] { "branch", "changeset", "code", "commit", "git", "github", "merge", "push", "repository", "revision", "source control", "vcs", "version" });
        private static IconData _CodeCompare;
        public static IconData FA_CodeCompare => _CodeCompare ??= new IconData("Code Compare", "\U0000E13A", Styles.Solid, new string[] { "changes", "code", "compare", "diff", "git", "github", "merge", "repository", "review", "revision", "svn", "update", "version" });
        private static IconData _CodeFork;
        public static IconData FA_CodeFork => _CodeFork ??= new IconData("Code Fork", "\U0000E13B", Styles.Solid, new string[] { "branch", "clone", "code management", "fork", "git", "github", "repository", "source control", "split", "svn", "version" });
        private static IconData _CodeMerge;
        public static IconData FA_CodeMerge => _CodeMerge ??= new IconData("Code Merge", "\U0000F387", Styles.Solid, new string[] { "branch", "code integration", "collaboration", "commit", "git", "github", "merge", "pr", "pull request", "rebase", "svn", "vcs", "version control" });
        private static IconData _CodePullRequest;
        public static IconData FA_CodePullRequest => _CodePullRequest ??= new IconData("Code Pull Request", "\U0000E13C", Styles.Solid, new string[] { "branch", "code review", "git", "github", "merge", "pr", "pull request", "svn", "version control" });
        private static IconData _Codepen;
        public static IconData FA_Codepen => _Codepen ??= new IconData("Codepen", "\U0000F1CB", Styles.Brands, new string[] { "code editor", "codepen", "codepen.io", "coding", "front-end", "online editor", "playground", "programming", "sandbox", "web development" });
        private static IconData _Codiepie;
        public static IconData FA_Codiepie => _Codiepie ??= new IconData("Codiepie", "\U0000F284", Styles.Brands, new string[] { "codie pie", "codiepie", "content creator", "gaming", "influencer", "streamer", "youtube" });
        private static IconData _Coins;
        public static IconData FA_Coins => _Coins ??= new IconData("Coins", "\U0000F51E", Styles.Solid, new string[] { "cash", "change", "coins", "currency", "dime", "finance", "gold", "money", "nickel", "payment", "penny", "premium", "quarter", "savings", "silver", "wealth" });
        private static IconData _ColonSign;
        public static IconData FA_ColonSign => _ColonSign ??= new IconData("Colon Sign", "\U0000E140", Styles.Solid, new string[] { "colon", "cost", "currency", "currency symbol", "financial", "money sign", "price", "punctuation", "symbol" });
        private static IconData _Comment;
        public static IconData FA_Comment => _Comment ??= new IconData("Comment", "\U0000F075", Styles.Regular | Styles.Solid, new string[] { "chat", "comment", "conversation", "discussion", "feedback", "message", "note", "notification", "reply", "response", "sms", "speech bubble", "talk", "texting" });
        private static IconData _CommentDollar;
        public static IconData FA_CommentDollar => _CommentDollar ??= new IconData("Comment Dollar", "\U0000F651", Styles.Solid, new string[] { "billing", "bubble", "chat", "comment", "conversation", "dollar", "feedback", "finance", "invoice", "message", "money", "pay", "payment", "salary", "speech", "transfer" });
        private static IconData _CommentDots;
        public static IconData FA_CommentDots => _CommentDots ??= new IconData("Comment Dots", "\U0000F4AD", Styles.Regular | Styles.Solid, new string[] { "bubble", "chat", "comment", "conversation", "dialog", "discussion", "feedback", "input", "message", "note", "reply", "sms", "speech balloon", "texting", "typing" });
        private static IconData _CommentMedical;
        public static IconData FA_CommentMedical => _CommentMedical ??= new IconData("Comment Medical", "\U0000F7F5", Styles.Solid, new string[] { "advice", "answer", "bubble", "chat", "commenting", "conversation", "diagnose", "diagnosis", "doctor", "feedback", "medical", "message", "note", "notification", "prescription", "report", "speech", "talking", "texting" });
        private static IconData _CommentNodes;
        public static IconData FA_CommentNodes => _CommentNodes ??= new IconData("Comment Nodes", "\U0000E696", Styles.Solid, new string[] { "ai", "algorithm", "artificial intelligence", "cluster", "connection", "data", "graph", "language", "machine learning", "model", "network", "neural", "nodes", "technology" });
        private static IconData _CommentSlash;
        public static IconData FA_CommentSlash => _CommentSlash ??= new IconData("Comment Slash", "\U0000F4B3", Styles.Solid, new string[] { "block", "cancel", "chat", "comment", "conversation", "disabled", "feedback", "message", "muted", "no comment", "quiet", "silent", "slash", "speech", "texting" });
        private static IconData _CommentSms;
        public static IconData FA_CommentSms => _CommentSms ??= new IconData("Comment Sms", "\U0000F7CD", Styles.Solid, new string[] { "bubble", "chat", "comment", "conversation", "message", "mobile message", "notification", "phone", "reply", "sms", "speech bubble", "text message", "texting" });
        private static IconData _Comments;
        public static IconData FA_Comments => _Comments ??= new IconData("Comments", "\U0000F086", Styles.Regular | Styles.Solid, new string[] { "chat", "comment", "communication", "conversation", "dialogue", "discussion", "feedback", "message", "notification", "reply", "sms", "speech bubbles", "talk", "texting" });
        private static IconData _CommentsDollar;
        public static IconData FA_CommentsDollar => _CommentsDollar ??= new IconData("Comments Dollar", "\U0000F653", Styles.Solid, new string[] { "billing", "chat", "comment", "comments", "conversation", "discussion", "dollar", "feedback", "finance", "inquiry", "message", "money", "payment", "salary", "support", "transaction" });
        private static IconData _CompactDisc;
        public static IconData FA_CompactDisc => _CompactDisc ??= new IconData("Compact Disc", "\U0000F51F", Styles.Solid, new string[] { "album", "blu-ray", "bluray", "cd", "compact disc", "disc", "disk", "dvd", "media", "movie", "music", "optical disc", "record", "video", "vinyl" });
        private static IconData _Compass;
        public static IconData FA_Compass => _Compass ??= new IconData("Compass", "\U0000F14E", Styles.Regular | Styles.Solid, new string[] { "adventure", "compass", "directions", "explore", "guide", "location", "magnetic", "map", "navigation", "north", "orienteering", "path", "route", "travel", "wayfinding" });
        private static IconData _CompassDrafting;
        public static IconData FA_CompassDrafting => _CompassDrafting ??= new IconData("Compass Drafting", "\U0000F568", Styles.Solid, new string[] { "architecture", "blueprint", "compass", "design", "drafting", "drawing", "engineering", "geometry", "measurement", "plot", "plotting", "technical drawing" });
        private static IconData _Compress;
        public static IconData FA_Compress => _Compress ??= new IconData("Compress", "\U0000F066", Styles.Solid, new string[] { "collapse", "compress", "condense", "contract", "minimize", "narrow", "reduce", "shrink", "smaller", "tighten", "zoom out" });
        private static IconData _Computer;
        public static IconData FA_Computer => _Computer ??= new IconData("Computer", "\U0000E4E5", Styles.Solid, new string[] { "computer", "cpu", "desktop", "device", "hardware", "monitor", "pc", "screen", "technology", "workstation" });
        private static IconData _ComputerMouse;
        public static IconData FA_ComputerMouse => _ComputerMouse ??= new IconData("Computer Mouse", "\U0000F8CC", Styles.Solid, new string[] { "USB mouse", "click", "computer", "computer accessory", "cursor", "device", "hardware", "input", "mouse", "peripheral", "pointing device", "scroll wheel", "trackball", "wireless mouse" });
        private static IconData _Confluence;
        public static IconData FA_Confluence => _Confluence ??= new IconData("Confluence", "\U0000F78D", Styles.Brands, new string[] { "atlassian", "collaboration", "confluence", "documentation", "knowledge base", "project management", "teamwork", "wiki" });
        private static IconData _Connectdevelop;
        public static IconData FA_Connectdevelop => _Connectdevelop ??= new IconData("Connectdevelop", "\U0000F20E", Styles.Brands, new string[] { "coding", "connect develop", "connectdevelop", "connectdevelop brand", "developer community", "developer network", "programming", "software development" });
        private static IconData _Contao;
        public static IconData FA_Contao => _Contao ??= new IconData("Contao", "\U0000F26D", Styles.Brands, new string[] { "cms", "contao", "content management", "open source", "web development", "website" });
        private static IconData _Cookie;
        public static IconData FA_Cookie => _Cookie ??= new IconData("Cookie", "\U0000F563", Styles.Solid, new string[] { "baked good", "biscuit", "chocolate", "chocolate chip", "cookie", "dessert", "eat", "pastry", "snack", "sweet", "treat" });
        private static IconData _CookieBite;
        public static IconData FA_CookieBite => _CookieBite ??= new IconData("Cookie Bite", "\U0000F564", Styles.Solid, new string[] { "baked good", "bite", "bitten", "chocolate chip", "cookie", "dessert", "eating", "food", "snack", "snacktime", "sweet", "treat" });
        private static IconData _Copy;
        public static IconData FA_Copy => _Copy ??= new IconData("Copy", "\U0000F0C5", Styles.Regular | Styles.Solid, new string[] { "clipboard", "clone", "copy", "document", "duplicate", "file", "paper", "paste", "replicate", "replicate", "replicate" });
        private static IconData _Copyright;
        public static IconData FA_Copyright => _Copyright ??= new IconData("Copyright", "\U0000F1F9", Styles.Regular | Styles.Solid, new string[] { "c", "copyright", "copyright symbol", "intellectual property", "legal", "license", "mark", "protection", "registered", "rights", "trademark" });
        private static IconData _CottonBureau;
        public static IconData FA_CottonBureau => _CottonBureau ??= new IconData("Cotton Bureau", "\U0000F89E", Styles.Brands, new string[] { "apparel", "brand", "clothing", "clothing brand", "cotton bureau", "fashion", "t-shirts", "tshirts" });
        private static IconData _Couch;
        public static IconData FA_Couch => _Couch ??= new IconData("Couch", "\U0000F4B8", Styles.Solid, new string[] { "chair", "couch", "cushion", "furniture", "living room", "lounge", "loveseat", "relax", "seating", "sofa" });
        private static IconData _Cow;
        public static IconData FA_Cow => _Cow ??= new IconData("Cow", "\U0000F6C8", Styles.Solid, new string[] { "agriculture", "animal", "beef", "bovine", "cattle", "cow", "dairy", "farm", "herd", "livestock", "mammal", "milk", "moo" });
        private static IconData _Cpanel;
        public static IconData FA_Cpanel => _Cpanel ??= new IconData("Cpanel", "\U0000F388", Styles.Brands, new string[] { "control panel", "cpanel", "hosting", "hosting dashboard", "server management", "site management", "web admin", "web hosting", "website control" });
        private static IconData _CreativeCommons;
        public static IconData FA_CreativeCommons => _CreativeCommons ??= new IconData("Creative Commons", "\U0000F25E", Styles.Brands, new string[] { "attribution", "cc", "copyright", "creative commons", "free use", "license", "open content", "public domain", "share alike" });
        private static IconData _CreativeCommonsBy;
        public static IconData FA_CreativeCommonsBy => _CreativeCommonsBy ??= new IconData("Creative Commons By", "\U0000F4E7", Styles.Brands, new string[] { "attribution", "cc", "copyright", "creative commons", "license", "open content", "permission", "share" });
        private static IconData _CreativeCommonsNc;
        public static IconData FA_CreativeCommonsNc => _CreativeCommonsNc ??= new IconData("Creative Commons Nc", "\U0000F4E8", Styles.Brands, new string[] { "cc", "copyright", "creative commons", "intellectual property", "license", "nc", "no commercial use", "non commercial" });
        private static IconData _CreativeCommonsNcEu;
        public static IconData FA_CreativeCommonsNcEu => _CreativeCommonsNcEu ??= new IconData("Creative Commons Nc Eu", "\U0000F4E9", Styles.Brands, new string[] { "attribution", "cc", "copyright", "creative commons", "eu", "europe", "license", "nc", "noncommercial", "open content" });
        private static IconData _CreativeCommonsNcJp;
        public static IconData FA_CreativeCommonsNcJp => _CreativeCommonsNcJp ??= new IconData("Creative Commons Nc Jp", "\U0000F4EA", Styles.Brands, new string[] { "cc", "cc license", "copyright", "creative commons", "japan", "jp", "license", "nc", "non commercial", "open license" });
        private static IconData _CreativeCommonsNd;
        public static IconData FA_CreativeCommonsNd => _CreativeCommonsNd ??= new IconData("Creative Commons Nd", "\U0000F4EB", Styles.Brands, new string[] { "cc", "content sharing", "copyright", "copyright license", "creative commons", "license", "nd", "no derivatives", "reuse restriction" });
        private static IconData _CreativeCommonsPd;
        public static IconData FA_CreativeCommonsPd => _CreativeCommonsPd ??= new IconData("Creative Commons Pd", "\U0000F4EC", Styles.Brands, new string[] { "cc", "copyright free", "creative commons", "free use", "no copyright", "open license", "pd", "public domain" });
        private static IconData _CreativeCommonsPdAlt;
        public static IconData FA_CreativeCommonsPdAlt => _CreativeCommonsPdAlt ??= new IconData("Creative Commons Pd Alt", "\U0000F4ED", Styles.Brands, new string[] { "cc", "copyright free", "creative commons", "free use", "no copyright", "open license", "pd", "public domain" });
        private static IconData _CreativeCommonsRemix;
        public static IconData FA_CreativeCommonsRemix => _CreativeCommonsRemix ??= new IconData("Creative Commons Remix", "\U0000F4EE", Styles.Brands, new string[] { "attribution", "cc", "collaboration", "creative commons", "free use", "license", "open content", "remix", "sharing" });
        private static IconData _CreativeCommonsSa;
        public static IconData FA_CreativeCommonsSa => _CreativeCommonsSa ??= new IconData("Creative Commons Sa", "\U0000F4EF", Styles.Brands, new string[] { "attribution", "cc", "cc-sa", "commons license", "copyright", "creative commons", "license", "open license", "share alike" });
        private static IconData _CreativeCommonsSampling;
        public static IconData FA_CreativeCommonsSampling => _CreativeCommonsSampling ??= new IconData("Creative Commons Sampling", "\U0000F4F0", Styles.Brands, new string[] { "audio", "cc", "copyright", "creative commons", "license", "music", "remix", "reuse", "sampling" });
        private static IconData _CreativeCommonsSamplingPlus;
        public static IconData FA_CreativeCommonsSamplingPlus => _CreativeCommonsSamplingPlus ??= new IconData("Creative Commons Sampling Plus", "\U0000F4F1", Styles.Brands, new string[] { "attribution", "cc", "copyright", "creative commons", "free use", "license", "open content", "sampling plus" });
        private static IconData _CreativeCommonsShare;
        public static IconData FA_CreativeCommonsShare => _CreativeCommonsShare ??= new IconData("Creative Commons Share", "\U0000F4F2", Styles.Brands, new string[] { "attribution", "cc", "copyright", "creative commons", "creative commons license", "free use", "license", "open content", "public domain", "share" });
        private static IconData _CreativeCommonsZero;
        public static IconData FA_CreativeCommonsZero => _CreativeCommonsZero ??= new IconData("Creative Commons Zero", "\U0000F4F3", Styles.Brands, new string[] { "cc0", "copyright free", "creative commons zero", "free use", "no rights reserved", "open license", "public domain", "zero copyright" });
        private static IconData _CreditCard;
        public static IconData FA_CreditCard => _CreditCard ??= new IconData("Credit Card", "\U0000F09D", Styles.Regular | Styles.Solid, new string[] { "billing", "buy", "card", "charge", "checkout", "credit card", "debit card", "finance", "money", "pay", "payment", "plastic card", "purchase", "transaction", "wallet" });
        private static IconData _CriticalRole;
        public static IconData FA_CriticalRole => _CriticalRole ??= new IconData("Critical Role", "\U0000F6C9", Styles.Brands, new string[] { "Critical Role", "Dungeons & Dragons", "RPG", "campaign", "d&d", "dnd", "fantasy", "role-playing", "streaming", "tabletop", "voice actors", "web series" });
        private static IconData _Crop;
        public static IconData FA_Crop => _Crop ??= new IconData("Crop", "\U0000F125", Styles.Solid, new string[] { "adjust", "crop", "cut", "edit", "frame", "image", "modify", "photo", "picture", "resize", "shrink", "trim" });
        private static IconData _CropSimple;
        public static IconData FA_CropSimple => _CropSimple ??= new IconData("Crop Simple", "\U0000F565", Styles.Solid, new string[] { "adjust", "crop", "cut", "edit", "frame", "image", "modify", "photo", "resize", "shape", "trim" });
        private static IconData _Cross;
        public static IconData FA_Cross => _Cross ??= new IconData("Cross", "\U0000F654", Styles.Solid, new string[] { "catholicism", "christian", "christianity", "church", "cross", "crucifix", "cruciform", "faith", "holy", "jesus", "religion", "salvation", "spirituality", "symbol", "worship" });
        private static IconData _Crosshairs;
        public static IconData FA_Crosshairs => _Crosshairs ??= new IconData("Crosshairs", "\U0000F05B", Styles.Solid, new string[] { "GPS", "aim", "bullseye", "center", "crosshair", "focus", "location", "marker", "pinpoint", "position", "precision", "reticle", "scope", "sight", "target" });
        private static IconData _Crow;
        public static IconData FA_Crow => _Crow ??= new IconData("Crow", "\U0000F520", Styles.Solid, new string[] { "animal", "bird", "blackbird", "crow", "halloween", "nature", "raven", "spooky", "wildlife", "winged creature" });
        private static IconData _Crown;
        public static IconData FA_Crown => _Crown ??= new IconData("Crown", "\U0000F521", Styles.Solid, new string[] { "VIP", "award", "champion", "crown", "honor", "king", "luxury", "monarchy", "prize", "queen", "regal", "royal", "ruler", "tiara", "winner" });
        private static IconData _Crutch;
        public static IconData FA_Crutch => _Crutch ??= new IconData("Crutch", "\U0000F7F7", Styles.Solid, new string[] { "assistive device", "cane", "disability", "injury", "medical", "mobility", "rehabilitation", "support", "walking aid" });
        private static IconData _CruzeiroSign;
        public static IconData FA_CruzeiroSign => _CruzeiroSign ??= new IconData("Cruzeiro Sign", "\U0000E152", Styles.Solid, new string[] { "BRL", "Brazilian currency", "Brazilian real", "Cruzeiro", "cash", "currency", "currency sign", "currency symbol", "finance", "money" });
        private static IconData _Css;
        public static IconData FA_Css => _Css ??= new IconData("Css", "\U0000E6A2", Styles.Brands, new string[] { "cascading style sheets", "css", "rebecca purple", "stylesheet", "web design", "web development" });
        private static IconData _Css3;
        public static IconData FA_Css3 => _Css3 ??= new IconData("Css3", "\U0000F13C", Styles.Brands, new string[] { "code", "css", "css3", "frontend", "programming", "stylesheet", "web", "web development" });
        private static IconData _Css3Alt;
        public static IconData FA_Css3Alt => _Css3Alt ??= new IconData("Css3 Alt", "\U0000F38B", Styles.Brands, new string[] { "cascade", "css", "css3", "frontend", "frontend development", "style", "stylesheet", "web", "web design", "web development" });
        private static IconData _Cube;
        public static IconData FA_Cube => _Cube ??= new IconData("Cube", "\U0000F1B2", Styles.Solid, new string[] { "3d", "block", "box", "container", "cube", "dice", "figure", "geometric", "object", "package", "shape", "solid", "square", "tesseract" });
        private static IconData _Cubes;
        public static IconData FA_Cubes => _Cubes ??= new IconData("Cubes", "\U0000F1B3", Styles.Solid, new string[] { "3d", "block", "box", "cube", "dice", "geometric", "grid", "package", "shape", "square", "stack" });
        private static IconData _CubesStacked;
        public static IconData FA_CubesStacked => _CubesStacked ??= new IconData("Cubes Stacked", "\U0000E4E6", Styles.Solid, new string[] { "3d", "blocks", "building", "construction", "cubes", "geometric", "modular", "stack", "sugar cubes", "toy" });
        private static IconData _Cuttlefish;
        public static IconData FA_Cuttlefish => _Cuttlefish ??= new IconData("Cuttlefish", "\U0000F38C", Styles.Brands, new string[] { "animal", "cephalopod", "cuttlefish", "marine", "mollusk", "ocean", "sea creature", "seafood" });
        private static IconData _D;
        public static IconData FA_D => _D ??= new IconData("D", "\U00000044", Styles.Solid, new string[] { "alphabet", "capital d", "character", "letter d", "lowercase d", "symbol", "text" });
        private static IconData _DAndD;
        public static IconData FA_DAndD => _DAndD ??= new IconData("D And D", "\U0000F38D", Styles.Brands, new string[] { "dnd", "dragons", "dungeons", "dungeons & dragons", "dungeons and dragons", "game", "gaming", "role-playing", "roleplay", "rpg", "tabletop" });
        private static IconData _DAndDBeyond;
        public static IconData FA_DAndDBeyond => _DAndDBeyond ??= new IconData("D And D Beyond", "\U0000F6CA", Styles.Brands, new string[] { "Dungeons & Dragons", "campaign", "d&d", "dice", "dnd", "dungeons and dragons", "fantasy", "gaming", "role-playing", "rpg", "tabletop" });
        private static IconData _Dailymotion;
        public static IconData FA_Dailymotion => _Dailymotion ??= new IconData("Dailymotion", "\U0000E052", Styles.Brands, new string[] { "dailymotion", "media", "online video", "platform", "streaming", "video", "video sharing", "videos" });
        private static IconData _DartLang;
        public static IconData FA_DartLang => _DartLang ??= new IconData("Dart Lang", "\U0000E693", Styles.Brands, new string[] { "dart", "dartlang", "development", "flutter", "google", "language", "programming", "sdk" });
        private static IconData _Dashcube;
        public static IconData FA_Dashcube => _Dashcube ??= new IconData("Dashcube", "\U0000F210", Styles.Brands, new string[] { "analytics", "dash cube", "dashboard", "dashcube", "data", "metrics", "reporting" });
        private static IconData _Database;
        public static IconData FA_Database => _Database ??= new IconData("Database", "\U0000F1C0", Styles.Solid, new string[] { "backend", "cloud", "data", "database", "directory", "information", "memory", "mysql", "records", "server", "sql", "storage", "table" });
        private static IconData _Debian;
        public static IconData FA_Debian => _Debian ??= new IconData("Debian", "\U0000E60B", Styles.Brands, new string[] { "debian", "debian linux", "distribution", "distro", "linux", "open source", "operating system", "os", "penguin", "software" });
        private static IconData _Deezer;
        public static IconData FA_Deezer => _Deezer ??= new IconData("Deezer", "\U0000E077", Styles.Brands, new string[] { "audio", "deezer", "music", "playlist", "podcast", "radio", "songs", "streaming" });
        private static IconData _DeleteLeft;
        public static IconData FA_DeleteLeft => _DeleteLeft ??= new IconData("Delete Left", "\U0000F55A", Styles.Solid, new string[] { "backspace", "backspace key", "backspace symbol", "delete", "delete left", "erase", "erase to the left", "keyboard", "remove", "undo" });
        private static IconData _Delicious;
        public static IconData FA_Delicious => _Delicious ??= new IconData("Delicious", "\U0000F1A5", Styles.Brands, new string[] { "bookmarks", "del.icio.us", "delicious", "favorites", "link sharing", "save", "share", "social bookmarking" });
        private static IconData _Democrat;
        public static IconData FA_Democrat => _Democrat ??= new IconData("Democrat", "\U0000F747", Styles.Solid, new string[] { "blue party", "democrat", "democratic party", "donkey", "election", "government", "left", "left-wing", "liberal", "political party", "politics", "progressives", "united states", "usa" });
        private static IconData _Deploydog;
        public static IconData FA_Deploydog => _Deploydog ??= new IconData("Deploydog", "\U0000F38E", Styles.Brands, new string[] { "CI", "DevOps", "automation", "cloud deployment", "continuous integration", "deploy dog", "deploydog", "deployment", "software deployment" });
        private static IconData _Deskpro;
        public static IconData FA_Deskpro => _Deskpro ??= new IconData("Deskpro", "\U0000F38F", Styles.Brands, new string[] { "Deskpro", "IT support", "customer service", "customer support", "help desk", "helpdesk", "service desk", "software", "support", "ticketing" });
        private static IconData _Desktop;
        public static IconData FA_Desktop => _Desktop ??= new IconData("Desktop", "\U0000F390", Styles.Solid, new string[] { "all-in-one", "computer", "desktop", "desktop computer", "device", "display", "hardware", "imac", "monitor", "pc", "screen", "workstation" });
        private static IconData _Dev;
        public static IconData FA_Dev => _Dev ??= new IconData("Dev", "\U0000F6CC", Styles.Brands, new string[] { "code", "coding", "dev", "developer", "development", "engineer", "programming", "software", "tech", "technology" });
        private static IconData _Deviantart;
        public static IconData FA_Deviantart => _Deviantart ??= new IconData("Deviantart", "\U0000F1BD", Styles.Brands, new string[] { "art community", "artist", "artwork", "creative", "da", "design", "deviantart", "digital art", "illustration", "portfolio" });
        private static IconData _Dharmachakra;
        public static IconData FA_Dharmachakra => _Dharmachakra ??= new IconData("Dharmachakra", "\U0000F655", Styles.Solid, new string[] { "Buddhist", "Indian religion", "buddhism", "buddhist", "dharma wheel", "dharmachakra", "enlightenment", "karma", "meditation", "religion", "sacred symbol", "spirituality", "teachings", "wheel of dharma" });
        private static IconData _Dhl;
        public static IconData FA_Dhl => _Dhl ??= new IconData("Dhl", "\U0000F790", Styles.Brands, new string[] { "DHL", "Dalsey", "Hillblom", "Lynn", "courier", "delivery", "express", "freight", "german", "logistics", "package", "shipping" });
        private static IconData _DiagramNext;
        public static IconData FA_DiagramNext => _DiagramNext ??= new IconData("Diagram Next", "\U0000E476", Styles.Solid, new string[] { "cells", "chart", "diagram", "flowchart", "gantt", "next", "process", "row", "sequence", "subtask", "successor", "table", "task" });
        private static IconData _DiagramPredecessor;
        public static IconData FA_DiagramPredecessor => _DiagramPredecessor ??= new IconData("Diagram Predecessor", "\U0000E477", Styles.Solid, new string[] { "cells", "chart", "dependency", "gantt", "predecessor", "previous", "project", "row", "schedule", "subtask", "table", "task", "timeline" });
        private static IconData _DiagramProject;
        public static IconData FA_DiagramProject => _DiagramProject ??= new IconData("Diagram Project", "\U0000F542", Styles.Solid, new string[] { "chart", "connections", "diagram", "flowchart", "graph", "network", "nodes", "pert", "planning", "process", "project", "statistics", "workflow" });
        private static IconData _DiagramSuccessor;
        public static IconData FA_DiagramSuccessor => _DiagramSuccessor ??= new IconData("Diagram Successor", "\U0000E47A", Styles.Solid, new string[] { "cells", "chart", "dependency", "diagram", "gantt", "next", "row", "subtask", "successor", "table", "task" });
        private static IconData _Diamond;
        public static IconData FA_Diamond => _Diamond ??= new IconData("Diamond", "\U0000F219", Styles.Solid, new string[] { "ace", "card", "cards", "diamond", "diamond suit", "game", "gem", "gemstone", "jewel", "luxury", "playing card", "poker", "precious", "sparkle", "suit" });
        private static IconData _DiamondTurnRight;
        public static IconData FA_DiamondTurnRight => _DiamondTurnRight ??= new IconData("Diamond Turn Right", "\U0000F5EB", Styles.Solid, new string[] { "arrow", "direction", "map", "navigation", "right turn", "road", "route", "sign", "traffic", "turn" });
        private static IconData _Diaspora;
        public static IconData FA_Diaspora => _Diaspora ??= new IconData("Diaspora", "\U0000F791", Styles.Brands, new string[] { "community", "decentralized", "diaspora", "open source", "platform", "social media", "social network" });
        private static IconData _Dice;
        public static IconData FA_Dice => _Dice ??= new IconData("Dice", "\U0000F522", Styles.Solid, new string[] { "board game", "chance", "cube", "dice", "dice game", "die", "gambling", "game", "gaming", "luck", "random", "roll", "tabletop", "throw" });
        private static IconData _DiceD20;
        public static IconData FA_DiceD20 => _DiceD20 ??= new IconData("Dice D20", "\U0000F6CF", Styles.Solid, new string[] { "Dungeons & Dragons", "chance", "d&d", "d20", "dice", "dnd", "fantasy", "game", "role-playing", "roll", "rpg", "tabletop", "twenty-sided" });
        private static IconData _DiceD6;
        public static IconData FA_DiceD6 => _DiceD6 ??= new IconData("Dice D6", "\U0000F6D1", Styles.Solid, new string[] { "Dungeons & Dragons", "RPG", "chance", "d&d", "dice", "die", "dnd", "fantasy", "gambling", "game", "gaming", "role-playing", "roll", "six-sided", "tabletop" });
        private static IconData _DiceFive;
        public static IconData FA_DiceFive => _DiceFive ??= new IconData("Dice Five", "\U0000F523", Styles.Solid, new string[] { "board game", "chance", "dice", "dice game", "die", "die face 5", "five", "gambling", "game", "luck", "random", "roll", "tabletop", "throw" });
        private static IconData _DiceFour;
        public static IconData FA_DiceFour => _DiceFour ??= new IconData("Dice Four", "\U0000F524", Styles.Solid, new string[] { "4", "board game", "chance", "dice", "dice face", "die", "four", "gambling", "game", "luck", "roll", "tabletop" });
        private static IconData _DiceOne;
        public static IconData FA_DiceOne => _DiceOne ??= new IconData("Dice One", "\U0000F525", Styles.Solid, new string[] { "chance", "dice", "dice roll", "die", "dot", "face one", "gambling", "game", "luck", "number one", "one", "pip", "random", "roll", "single dot" });
        private static IconData _DiceSix;
        public static IconData FA_DiceSix => _DiceSix ??= new IconData("Dice Six", "\U0000F526", Styles.Solid, new string[] { "board game", "chance", "dice", "dice game", "die", "die face 6", "gambling", "game", "probability", "random", "roll", "six", "six-sided", "tabletop" });
        private static IconData _DiceThree;
        public static IconData FA_DiceThree => _DiceThree ??= new IconData("Dice Three", "\U0000F527", Styles.Solid, new string[] { "board game", "chance", "dice", "dice game", "die", "gambling", "game", "luck", "number three", "random", "roll", "tabletop", "three" });
        private static IconData _DiceTwo;
        public static IconData FA_DiceTwo => _DiceTwo ??= new IconData("Dice Two", "\U0000F528", Styles.Solid, new string[] { "board game", "chance", "dice", "dice game", "die face 2", "gambling", "game", "luck", "play", "random", "roll", "tabletop", "throw", "two" });
        private static IconData _Digg;
        public static IconData FA_Digg => _Digg ??= new IconData("Digg", "\U0000F1A6", Styles.Brands, new string[] { "bookmarking", "content sharing", "digg", "news aggregator", "social media", "social news" });
        private static IconData _DigitalOcean;
        public static IconData FA_DigitalOcean => _DigitalOcean ??= new IconData("Digital Ocean", "\U0000F391", Styles.Brands, new string[] { "cloud", "cloud computing", "devops", "digital ocean", "do", "droplets", "hosting", "infrastructure", "platform", "server" });
        private static IconData _Discord;
        public static IconData FA_Discord => _Discord ??= new IconData("Discord", "\U0000F392", Styles.Brands, new string[] { "app", "chat", "communication", "community", "discord", "gaming", "messaging", "server", "social", "voice" });
        private static IconData _Discourse;
        public static IconData FA_Discourse => _Discourse ??= new IconData("Discourse", "\U0000F393", Styles.Brands, new string[] { "chat", "community", "conversation", "discourse", "discussion", "discussion board", "forum", "messaging", "online forum", "social platform" });
        private static IconData _Disease;
        public static IconData FA_Disease => _Disease ??= new IconData("Disease", "\U0000F7FA", Styles.Solid, new string[] { "bacteria", "cancer", "contagion", "coronavirus", "covid-19", "epidemic", "flu", "health", "illness", "infection", "medical", "pandemic", "pathogen", "sickness", "symptom", "virus" });
        private static IconData _Display;
        public static IconData FA_Display => _Display ??= new IconData("Display", "\U0000E163", Styles.Solid, new string[] { "computer", "desktop", "device", "display", "electronic", "imac", "interface", "lcd", "led", "monitor", "panel", "screen", "tech", "visual" });
        private static IconData _Disqus;
        public static IconData FA_Disqus => _Disqus ??= new IconData("Disqus", "\U0000E7D5", Styles.Brands, new string[] { "chat", "comments", "community", "discussion", "disqus", "forum", "messaging", "social" });
        private static IconData _Divide;
        public static IconData FA_Divide => _Divide ??= new IconData("Divide", "\U0000F529", Styles.Solid, new string[] { "arithmetic", "calculation", "divide", "divide symbol", "division", "division sign", "fraction", "math", "math operation", "math symbol", "operator", "quotient", "÷" });
        private static IconData _Dna;
        public static IconData FA_Dna => _Dna ??= new IconData("Dna", "\U0000F471", Styles.Solid, new string[] { "biologist", "biology", "chromosome", "dna", "double helix", "gene", "genetic", "genetics", "genome", "helix", "heredity", "life", "molecule", "protein", "science" });
        private static IconData _Dochub;
        public static IconData FA_Dochub => _Dochub ??= new IconData("Dochub", "\U0000F394", Styles.Brands, new string[] { "digital signature", "dochub", "document hub", "document management", "document signing", "e-signature", "pdf editor", "pdf signing", "pdf tools" });
        private static IconData _Docker;
        public static IconData FA_Docker => _Docker ??= new IconData("Docker", "\U0000F395", Styles.Brands, new string[] { "cloud", "container", "containers", "deployment", "devops", "docker", "image", "platform", "software", "virtualization" });
        private static IconData _Dog;
        public static IconData FA_Dog => _Dog ??= new IconData("Dog", "\U0000F6D3", Styles.Solid, new string[] { "animal", "bark", "canine", "companion", "dog", "domestic animal", "mammal", "pet", "pooch", "puppy", "woof" });
        private static IconData _DollarSign;
        public static IconData FA_DollarSign => _DollarSign ??= new IconData("Dollar Sign", "\U00000024", Styles.Solid, new string[] { "budget", "cash", "cost", "currency", "dollar", "dollar sign", "finance", "income", "investment", "money", "payment", "premium", "price", "revenue", "salary" });
        private static IconData _Dolly;
        public static IconData FA_Dolly => _Dolly ??= new IconData("Dolly", "\U0000F472", Styles.Solid, new string[] { "carry", "cart", "delivery", "dolly", "hand truck", "moving", "shipping", "transport", "trolley", "warehouse" });
        private static IconData _DongSign;
        public static IconData FA_DongSign => _DongSign ??= new IconData("Dong Sign", "\U0000E169", Styles.Solid, new string[] { "cash", "currency", "currency symbol", "dong", "finance", "money", "payment", "vietnam", "vietnamese currency" });
        private static IconData _DoorClosed;
        public static IconData FA_DoorClosed => _DoorClosed ??= new IconData("Door Closed", "\U0000F52A", Styles.Solid, new string[] { "access", "barrier", "closed", "door", "doorway", "entrance", "exit", "locked", "privacy", "secure" });
        private static IconData _DoorOpen;
        public static IconData FA_DoorOpen => _DoorOpen ??= new IconData("Door Open", "\U0000F52B", Styles.Solid, new string[] { "access", "door", "doorway", "entrance", "entry", "exit", "open", "open door", "passage", "welcome" });
        private static IconData _Dove;
        public static IconData FA_Dove => _Dove ??= new IconData("Dove", "\U0000F4BA", Styles.Solid, new string[] { "bird", "dove", "flying", "freedom", "love", "nature", "peace", "symbol", "white bird", "wildlife" });
        private static IconData _DownLeftAndUpRightToCenter;
        public static IconData FA_DownLeftAndUpRightToCenter => _DownLeftAndUpRightToCenter ??= new IconData("Down Left And Up Right To Center", "\U0000F422", Styles.Solid, new string[] { "center", "collapse", "compress", "contract", "fullscreen", "inward", "minimize", "reduce", "resize", "scale", "shrink", "size", "smaller", "zoom out" });
        private static IconData _DownLong;
        public static IconData FA_DownLong => _DownLong ??= new IconData("Down Long", "\U0000F309", Styles.Solid, new string[] { "arrow", "arrow-down", "arrow-pointing-down", "download", "download-arrow", "download-button", "downward", "long-arrow-down", "save" });
        private static IconData _Download;
        public static IconData FA_Download => _Download ??= new IconData("Download", "\U0000F019", Styles.Solid, new string[] { "arrow down", "download", "export", "get file", "hard drive", "import", "retrieve", "save", "transfer" });
        private static IconData _Draft2digital;
        public static IconData FA_Draft2digital => _Draft2digital ??= new IconData("Draft2digital", "\U0000F396", Styles.Brands, new string[] { "author platform", "book distribution", "d2d", "digital publishing", "draft2digital", "ebook", "publishing", "self-publishing" });
        private static IconData _Dragon;
        public static IconData FA_Dragon => _Dragon ??= new IconData("Dragon", "\U0000F6D5", Styles.Solid, new string[] { "Dungeons & Dragons", "creature", "d&d", "dnd", "dragon", "fairy tale", "fantasy", "fire", "legend", "lizard", "medieval", "monster", "mythical", "serpent" });
        private static IconData _DrawPolygon;
        public static IconData FA_DrawPolygon => _DrawPolygon ??= new IconData("Draw Polygon", "\U0000F5EE", Styles.Solid, new string[] { "anchors", "drawing", "geometry", "graphic", "lines", "object", "path", "polygon", "shape", "vector" });
        private static IconData _Dribbble;
        public static IconData FA_Dribbble => _Dribbble ??= new IconData("Dribbble", "\U0000F17D", Styles.Brands, new string[] { "art", "community", "creative", "design", "designer", "dribbble", "dribble", "inspiration", "portfolio", "showcase", "social" });
        private static IconData _Dropbox;
        public static IconData FA_Dropbox => _Dropbox ??= new IconData("Dropbox", "\U0000F16B", Styles.Brands, new string[] { "backup", "cloud drive", "cloud storage", "collaboration", "dropbox", "file hosting", "file sharing", "file sync", "online storage" });
        private static IconData _Droplet;
        public static IconData FA_Droplet => _Droplet ??= new IconData("Droplet", "\U0000F043", Styles.Solid, new string[] { "blood", "drip", "drop", "droplet", "fluid", "liquid", "moisture", "oil", "raindrop", "sweat", "tear", "water", "waterdrop" });
        private static IconData _DropletSlash;
        public static IconData FA_DropletSlash => _DropletSlash ??= new IconData("Droplet Slash", "\U0000F5C7", Styles.Solid, new string[] { "blocked", "cancel", "disabled", "drop", "droplet", "muted", "no drop", "no water", "off", "raindrop", "remove", "slash", "stop", "waterdrop" });
        private static IconData _Drum;
        public static IconData FA_Drum => _Drum ??= new IconData("Drum", "\U0000F569", Styles.Solid, new string[] { "band", "beat", "drum", "drummer", "drums", "drumsticks", "instrument", "kit", "music", "musical instrument", "percussion", "rhythm", "snare", "sound" });
        private static IconData _DrumSteelpan;
        public static IconData FA_DrumSteelpan => _DrumSteelpan ??= new IconData("Drum Steelpan", "\U0000F56A", Styles.Solid, new string[] { "Caribbean", "band", "calypso", "festival", "instrument", "music", "pan drum", "percussion", "sound", "steel drum", "steelpan", "tropical" });
        private static IconData _DrumstickBite;
        public static IconData FA_DrumstickBite => _DrumstickBite ??= new IconData("Drumstick Bite", "\U0000F6D7", Styles.Solid, new string[] { "barbecue", "bite", "bone", "chicken", "dinner", "drumstick", "food", "grilled", "leg", "meat", "poultry", "snack", "turkey" });
        private static IconData _Drupal;
        public static IconData FA_Drupal => _Drupal ??= new IconData("Drupal", "\U0000F1A9", Styles.Brands, new string[] { "cms", "content management system", "drupal", "drupal cms", "open source", "php", "web development", "website" });
        private static IconData _Dumbbell;
        public static IconData FA_Dumbbell => _Dumbbell ??= new IconData("Dumbbell", "\U0000F44B", Styles.Solid, new string[] { "dumbbell", "exercise", "fitness", "gym", "lifting", "muscle", "sports", "strength", "training", "weight", "weightlifting", "workout" });
        private static IconData _Dumpster;
        public static IconData FA_Dumpster => _Dumpster ??= new IconData("Dumpster", "\U0000F793", Styles.Solid, new string[] { "bin", "commercial waste", "container", "dumpster", "dumpster bin", "garbage", "junk", "refuse", "rubbish", "trash", "trash container", "waste" });
        private static IconData _DumpsterFire;
        public static IconData FA_DumpsterFire => _DumpsterFire ??= new IconData("Dumpster Fire", "\U0000F794", Styles.Solid, new string[] { "blaze", "burning", "chaotic", "crisis", "danger", "disaster", "dumpster", "emergency", "euphemism", "fire", "flames", "hot", "meltdown", "trash", "waste" });
        private static IconData _Dungeon;
        public static IconData FA_Dungeon => _Dungeon ??= new IconData("Dungeon", "\U0000F6D9", Styles.Solid, new string[] { "Dungeons & Dragons", "RPG", "castle", "d&d", "dnd", "door", "dungeon", "dungeon door", "entrance", "fantasy", "fortress", "gate", "medieval", "role-playing" });
        private static IconData _Duolingo;
        public static IconData FA_Duolingo => _Duolingo ??= new IconData("Duolingo", "\U0000E812", Styles.Brands, new string[] { "app", "courses", "duolingo", "education", "foreign language", "language", "language learning", "learning", "owl", "study" });
        private static IconData _Dyalog;
        public static IconData FA_Dyalog => _Dyalog ??= new IconData("Dyalog", "\U0000F399", Styles.Brands, new string[] { "apl language", "dyalog", "dyalog brand", "dyalog logo", "dyalog software", "programming language", "software company" });
        private static IconData _E;
        public static IconData FA_E => _E ??= new IconData("E", "\U00000045", Styles.Solid, new string[] { "alphabet e", "capital e", "character e", "e symbol", "latin letter e", "letter e", "lowercase e" });
        private static IconData _EarDeaf;
        public static IconData FA_EarDeaf => _EarDeaf ??= new IconData("Ear Deaf", "\U0000F2A4", Styles.Solid, new string[] { "accessibility", "deaf", "disability", "ear", "hearing impaired", "hearing loss", "mute", "no sound", "sign language" });
        private static IconData _EarListen;
        public static IconData FA_EarListen => _EarListen ??= new IconData("Ear Listen", "\U0000F2A2", Styles.Solid, new string[] { "amplify", "audio", "deaf", "ear", "earphone", "headphone", "headset", "hearing", "hearing aid", "listen", "listen closely", "sound", "volume" });
        private static IconData _Earlybirds;
        public static IconData FA_Earlybirds => _Earlybirds ??= new IconData("Earlybirds", "\U0000F39A", Styles.Brands, new string[] { "Early Birds", "calendar", "earlybirds", "earlybirds app", "productivity", "scheduling", "task planning", "team collaboration", "time management" });
        private static IconData _EarthAfrica;
        public static IconData FA_EarthAfrica => _EarthAfrica ??= new IconData("Earth Africa", "\U0000F57C", Styles.Solid, new string[] { "africa", "continent", "earth", "geography", "global", "globe", "gps", "international", "localize", "location", "map", "place", "planet", "travel", "world" });
        private static IconData _EarthAmericas;
        public static IconData FA_EarthAmericas => _EarthAmericas ??= new IconData("Earth Americas", "\U0000F57D", Styles.Solid, new string[] { "america", "americas", "earth", "global", "globe", "gps", "language", "localize", "location", "map", "place", "planet", "translate", "travel", "world" });
        private static IconData _EarthAsia;
        public static IconData FA_EarthAsia => _EarthAsia ??= new IconData("Earth Asia", "\U0000F57E", Styles.Solid, new string[] { "asia", "australia", "earth", "global", "globe", "gps", "language", "localize", "location", "map", "place", "planet", "translate", "travel", "world" });
        private static IconData _EarthEurope;
        public static IconData FA_EarthEurope => _EarthEurope ??= new IconData("Earth Europe", "\U0000F7A2", Styles.Solid, new string[] { "country", "earth", "europe", "global", "globe", "gps", "language", "localize", "location", "map", "place", "planet", "translate", "travel", "world" });
        private static IconData _EarthOceania;
        public static IconData FA_EarthOceania => _EarthOceania ??= new IconData("Earth Oceania", "\U0000E47B", Styles.Solid, new string[] { "australia", "continent", "country", "earth", "geography", "global", "globe", "island", "location", "map", "melanesia", "micronesia", "new zealand", "oceania", "pacific", "polynesia", "region", "travel", "world" });
        private static IconData _Ebay;
        public static IconData FA_Ebay => _Ebay ??= new IconData("Ebay", "\U0000F4F4", Styles.Brands, new string[] { "auction", "buy", "classifieds", "ebay", "ecommerce", "marketplace", "online store", "retail", "sell", "shopping" });
        private static IconData _Edge;
        public static IconData FA_Edge => _Edge ??= new IconData("Edge", "\U0000F282", Styles.Brands, new string[] { "browser", "edge", "ie", "internet", "microsoft", "microsoft edge", "web" });
        private static IconData _EdgeLegacy;
        public static IconData FA_EdgeLegacy => _EdgeLegacy ??= new IconData("Edge Legacy", "\U0000E078", Styles.Brands, new string[] { "browser", "edge", "internet", "legacy", "microsoft", "microsoft edge", "old edge", "web browser" });
        private static IconData _Egg;
        public static IconData FA_Egg => _Egg ??= new IconData("Egg", "\U0000F7FB", Styles.Solid, new string[] { "baking", "breakfast", "chicken", "egg", "farm", "food", "fresh", "natural", "omelette", "oval", "poultry", "protein", "shell", "yolk" });
        private static IconData _Eject;
        public static IconData FA_Eject => _Eject ??= new IconData("Eject", "\U0000F052", Styles.Solid, new string[] { "abort", "cancel", "cd", "disc", "discard", "eject", "eject button", "exit", "media", "remove", "stop", "unload" });
        private static IconData _Elementor;
        public static IconData FA_Elementor => _Elementor ??= new IconData("Elementor", "\U0000F430", Styles.Brands, new string[] { "cms", "drag and drop", "elementor", "frontend editor", "page builder", "plugin", "theme builder", "web design", "website builder", "wordpress" });
        private static IconData _Elevator;
        public static IconData FA_Elevator => _Elevator ??= new IconData("Elevator", "\U0000E16D", Styles.Solid, new string[] { "accessibility", "building transport", "elevator", "elevator button", "elevator car", "elevator shaft", "hoist", "lift", "passenger lift", "people mover", "vertical transport", "wheelchair accessible" });
        private static IconData _Eleventy;
        public static IconData FA_Eleventy => _Eleventy ??= new IconData("Eleventy", "\U0000E7D6", Styles.Brands, new string[] { "11ty", "SSG", "eleventy", "static site generator", "web development" });
        private static IconData _Ellipsis;
        public static IconData FA_Ellipsis => _Ellipsis ??= new IconData("Ellipsis", "\U0000F141", Styles.Solid, new string[] { "actions", "dots", "dots menu", "ellipsis", "horizontal dots", "kebab", "menu", "more", "navigation", "options", "overflow", "settings", "three dots", "vertical dots" });
        private static IconData _EllipsisVertical;
        public static IconData FA_EllipsisVertical => _EllipsisVertical ??= new IconData("Ellipsis Vertical", "\U0000F142", Styles.Solid, new string[] { "dots", "kebab", "list", "menu", "more", "nav", "navigation", "options", "overflow", "reorder", "settings", "vertical dots" });
        private static IconData _Ello;
        public static IconData FA_Ello => _Ello ??= new IconData("Ello", "\U0000F5F1", Styles.Brands, new string[] { "art", "community", "creative", "ello", "network", "platform", "social", "social media" });
        private static IconData _Ember;
        public static IconData FA_Ember => _Ember ??= new IconData("Ember", "\U0000F423", Styles.Brands, new string[] { "ember", "emberjs", "framework", "frontend", "javascript", "js", "ui", "web" });
        private static IconData _Empire;
        public static IconData FA_Empire => _Empire ??= new IconData("Empire", "\U0000F1D1", Styles.Brands, new string[] { "empire", "film", "franchise", "galactic empire", "lucasfilm", "movie", "sci-fi", "star wars", "starwars" });
        private static IconData _Envelope;
        public static IconData FA_Envelope => _Envelope ??= new IconData("Envelope", "\U0000F0E0", Styles.Regular | Styles.Solid, new string[] { "contact", "correspondence", "e-mail", "email", "envelope", "inbox", "letter", "mail", "message", "newsletter", "notification", "postal", "receive", "send", "support" });
        private static IconData _EnvelopeCircleCheck;
        public static IconData FA_EnvelopeCircleCheck => _EnvelopeCircleCheck ??= new IconData("Envelope Circle Check", "\U0000E4E8", Styles.Solid, new string[] { "approved", "check", "confirmed", "delivered", "email", "envelope", "mail", "ok", "okay", "read", "sent", "success", "validated", "verified" });
        private static IconData _EnvelopeOpen;
        public static IconData FA_EnvelopeOpen => _EnvelopeOpen ??= new IconData("Envelope Open", "\U0000F2B6", Styles.Regular | Styles.Solid, new string[] { "communication", "correspondence", "e-mail", "email", "inbox", "letter", "mail", "message", "newsletter", "notification", "offer", "open mail", "support" });
        private static IconData _EnvelopeOpenText;
        public static IconData FA_EnvelopeOpenText => _EnvelopeOpenText ??= new IconData("Envelope Open Text", "\U0000F658", Styles.Solid, new string[] { "communication", "correspondence", "document", "e-mail", "email", "inbox", "letter", "mail", "message", "newsletter", "notification", "open mail", "reading mail", "support", "update" });
        private static IconData _EnvelopesBulk;
        public static IconData FA_EnvelopesBulk => _EnvelopesBulk ??= new IconData("Envelopes Bulk", "\U0000F674", Styles.Solid, new string[] { "bulk mail", "correspondence", "envelopes", "letters", "mail", "mailing", "newsletter", "package", "post office", "postal", "send", "shipment", "usps" });
        private static IconData _Envira;
        public static IconData FA_Envira => _Envira ??= new IconData("Envira", "\U0000F299", Styles.Brands, new string[] { "envira", "envira gallery", "gallery", "image", "leaf", "photo", "wordpress" });
        private static IconData _Equals;
        public static IconData FA_Equals => _Equals ??= new IconData("Equals", "\U0000003D", Styles.Solid, new string[] { "arithmetic", "balance", "comparison", "equal sign", "equal to", "equals", "equals sign", "equation", "equivalence", "match", "math" });
        private static IconData _Eraser;
        public static IconData FA_Eraser => _Eraser ??= new IconData("Eraser", "\U0000F12D", Styles.Solid, new string[] { "art", "clean", "correction", "delete", "drawing", "erase", "pencil", "remove", "rubber", "wipe" });
        private static IconData _Erlang;
        public static IconData FA_Erlang => _Erlang ??= new IconData("Erlang", "\U0000F39D", Styles.Brands, new string[] { "concurrency", "development", "erlang", "functional", "language", "programming", "software", "telecom" });
        private static IconData _Ethereum;
        public static IconData FA_Ethereum => _Ethereum ??= new IconData("Ethereum", "\U0000F42E", Styles.Brands, new string[] { "blockchain", "crypto", "cryptocurrency", "defi", "digital currency", "eth", "ether", "ethereum", "smart contract", "token" });
        private static IconData _Ethernet;
        public static IconData FA_Ethernet => _Ethernet ??= new IconData("Ethernet", "\U0000F796", Styles.Solid, new string[] { "cable", "cat5", "cat6", "connection", "ethernet", "ethernet cable", "ethernet port", "hardware", "internet", "lan", "network", "network cable", "rj45", "wired", "wired connection" });
        private static IconData _Etsy;
        public static IconData FA_Etsy => _Etsy ??= new IconData("Etsy", "\U0000F2D7", Styles.Brands, new string[] { "artisan", "crafts", "creative goods", "ecommerce", "etsy", "etsy shop", "handmade", "marketplace", "online store", "vintage" });
        private static IconData _EuroSign;
        public static IconData FA_EuroSign => _EuroSign ??= new IconData("Euro Sign", "\U0000F153", Styles.Solid, new string[] { "cash", "currency", "euro", "euro currency", "euro sign", "european currency", "financial", "money", "payment", "symbol" });
        private static IconData _Evernote;
        public static IconData FA_Evernote => _Evernote ??= new IconData("Evernote", "\U0000F839", Styles.Brands, new string[] { "cloud notes", "digital notebook", "evernote", "memo", "note", "notebook", "notes", "organization", "productivity", "reminder" });
        private static IconData _Exclamation;
        public static IconData FA_Exclamation => _Exclamation ??= new IconData("Exclamation", "\U00000021", Styles.Solid, new string[] { "alert", "attention", "caution", "danger", "emphasis", "error", "exclamation", "exclamation mark", "important", "notice", "notification", "notify", "problem", "punctuation", "required", "symbol", "urgent", "warning" });
        private static IconData _Expand;
        public static IconData FA_Expand => _Expand ??= new IconData("Expand", "\U0000F065", Styles.Solid, new string[] { "arrows", "bigger", "enlarge", "expand", "fullscreen", "fullscreen mode", "increase", "maximize", "open", "resize", "scale", "stretch", "viewfinder", "zoom" });
        private static IconData _Expeditedssl;
        public static IconData FA_Expeditedssl => _Expeditedssl ??= new IconData("Expeditedssl", "\U0000F23E", Styles.Brands, new string[] { "certificate authority", "encryption", "expeditedssl", "https", "security", "ssl", "ssl certificate", "ssl provider", "web security" });
        private static IconData _Explosion;
        public static IconData FA_Explosion => _Explosion ??= new IconData("Explosion", "\U0000E4E9", Styles.Solid, new string[] { "bang", "blast", "blast-off", "boom", "burst", "crash", "detonation", "eruption", "explosion", "impact", "shockwave" });
        private static IconData _Eye;
        public static IconData FA_Eye => _Eye ??= new IconData("Eye", "\U0000F06E", Styles.Regular | Styles.Solid, new string[] { "eye", "focus", "glimpse", "look", "observe", "peek", "see", "sight", "stare", "view", "visible", "vision", "watch" });
        private static IconData _EyeDropper;
        public static IconData FA_EyeDropper => _EyeDropper ??= new IconData("Eye Dropper", "\U0000F1FB", Styles.Solid, new string[] { "color", "dropper", "eyedropper", "eyedropper-tool", "paint", "pick", "pipette", "sample", "select", "tool" });
        private static IconData _EyeLowVision;
        public static IconData FA_EyeLowVision => _EyeLowVision ??= new IconData("Eye Low Vision", "\U0000F2A8", Styles.Solid, new string[] { "accessibility", "blind", "disability", "eye", "eye disability", "impaired vision", "low vision", "sight", "vision loss", "visual impairment" });
        private static IconData _EyeSlash;
        public static IconData FA_EyeSlash => _EyeSlash ??= new IconData("Eye Slash", "\U0000F070", Styles.Regular | Styles.Solid, new string[] { "blocked", "conceal", "disable", "eye", "hidden", "hide", "invisible", "no-view", "obscured", "privacy", "privacy-mode", "security", "toggle", "unseen" });
        private static IconData _F;
        public static IconData FA_F => _F ??= new IconData("F", "\U00000046", Styles.Solid, new string[] { "alphabet f", "character f", "f glyph", "f symbol", "latin letter f", "letter", "letter f" });
        private static IconData _FaceAngry;
        public static IconData FA_FaceAngry => _FaceAngry ??= new IconData("Face Angry", "\U0000F556", Styles.Regular | Styles.Solid, new string[] { "angry", "annoyed", "disapprove", "displeased", "emoticon", "emotion", "face", "frowning", "frustrated", "glare", "mad", "rage", "upset" });
        private static IconData _FaceDizzy;
        public static IconData FA_FaceDizzy => _FaceDizzy ??= new IconData("Face Dizzy", "\U0000F567", Styles.Regular | Styles.Solid, new string[] { "confused", "dazed", "dizzy", "dizzy face", "emoticon", "face", "faint", "sick", "unwell", "woozy", "woozy face" });
        private static IconData _FaceFlushed;
        public static IconData FA_FaceFlushed => _FaceFlushed ??= new IconData("Face Flushed", "\U0000F579", Styles.Regular | Styles.Solid, new string[] { "bashful", "blushing", "embarrassed", "emoticon", "face", "flushed", "overwhelmed", "red-faced", "shy", "surprised" });
        private static IconData _FaceFrown;
        public static IconData FA_FaceFrown => _FaceFrown ??= new IconData("Face Frown", "\U0000F119", Styles.Regular | Styles.Solid, new string[] { "disappointed", "disapprove", "displeased", "emoticon", "face", "frown", "frowning face", "negative", "sad", "unhappy", "unhappy emoji", "unhappy face" });
        private static IconData _FaceFrownOpen;
        public static IconData FA_FaceFrownOpen => _FaceFrownOpen ??= new IconData("Face Frown Open", "\U0000F57A", Styles.Regular | Styles.Solid, new string[] { "disappointed", "disapprove", "displeased", "emoticon", "expression", "face", "frown", "negative", "open mouth", "sad", "unhappy", "upset" });
        private static IconData _FaceGrimace;
        public static IconData FA_FaceGrimace => _FaceGrimace ??= new IconData("Face Grimace", "\U0000F57F", Styles.Regular | Styles.Solid, new string[] { "anxious", "awkward", "cringe", "emoticon", "expression", "face", "grimace", "grimacing face", "nervous", "teeth", "uncomfortable", "uneasy", "worried" });
        private static IconData _FaceGrin;
        public static IconData FA_FaceGrin => _FaceGrin ??= new IconData("Face Grin", "\U0000F580", Styles.Regular | Styles.Solid, new string[] { "amusement", "cheerful", "emoji", "expression", "face", "grin", "grinning", "happy", "joy", "laugh", "pleased", "smile" });
        private static IconData _FaceGrinBeam;
        public static IconData FA_FaceGrinBeam => _FaceGrinBeam ??= new IconData("Face Grin Beam", "\U0000F582", Styles.Regular | Styles.Solid, new string[] { "beam", "cheerful", "delighted", "emoticon", "eyes closed", "face", "grin", "happy", "joy", "laugh", "open mouth", "smile", "smiling face" });
        private static IconData _FaceGrinBeamSweat;
        public static IconData FA_FaceGrinBeamSweat => _FaceGrinBeamSweat ??= new IconData("Face Grin Beam Sweat", "\U0000F583", Styles.Regular | Styles.Solid, new string[] { "anxious", "awkward", "beam", "embarrassed", "emoticon", "face", "grin", "nervous", "relief", "smile", "sweat", "uncomfortable" });
        private static IconData _FaceGrinHearts;
        public static IconData FA_FaceGrinHearts => _FaceGrinHearts ??= new IconData("Face Grin Hearts", "\U0000F584", Styles.Regular | Styles.Solid, new string[] { "admiration", "adoration", "affection", "crush", "emoji", "emoticon", "face", "heart-eyes", "infatuation", "love", "smile", "smiling" });
        private static IconData _FaceGrinSquint;
        public static IconData FA_FaceGrinSquint => _FaceGrinSquint ??= new IconData("Face Grin Squint", "\U0000F585", Styles.Regular | Styles.Solid, new string[] { "amusement", "emoticon", "face", "grin", "happy", "joy", "laugh", "laughing", "playful", "satisfied", "smile", "squint" });
        private static IconData _FaceGrinSquintTears;
        public static IconData FA_FaceGrinSquintTears => _FaceGrinSquintTears ??= new IconData("Face Grin Squint Tears", "\U0000F586", Styles.Regular | Styles.Solid, new string[] { "emoji", "face", "funny", "grin", "happy", "humor", "joy", "laugh", "laughing", "rofl", "rolling on the floor laughing", "smile", "squint", "tears" });
        private static IconData _FaceGrinStars;
        public static IconData FA_FaceGrinStars => _FaceGrinStars ??= new IconData("Face Grin Stars", "\U0000F587", Styles.Regular | Styles.Solid, new string[] { "amazed", "celebrity", "emoticon", "excited", "face", "grin", "happy", "impressed", "joyful", "smiling", "star", "star-struck", "starry-eyed", "vip" });
        private static IconData _FaceGrinTears;
        public static IconData FA_FaceGrinTears => _FaceGrinTears ??= new IconData("Face Grin Tears", "\U0000F588", Styles.Regular | Styles.Solid, new string[] { "LOL", "crying with laughter", "emoji", "face", "funny", "grin", "happy", "joy", "laugh", "laughing", "smile", "tear", "tears of joy" });
        private static IconData _FaceGrinTongue;
        public static IconData FA_FaceGrinTongue => _FaceGrinTongue ??= new IconData("Face Grin Tongue", "\U0000F589", Styles.Regular | Styles.Solid, new string[] { "cheeky", "emoji", "face", "funny", "goofy", "grin", "joking", "laugh", "lighthearted", "playful", "silly", "teasing", "tongue" });
        private static IconData _FaceGrinTongueSquint;
        public static IconData FA_FaceGrinTongueSquint => _FaceGrinTongueSquint ??= new IconData("Face Grin Tongue Squint", "\U0000F58A", Styles.Regular | Styles.Solid, new string[] { "emoji", "face", "funny", "goofy", "grin", "joking", "laugh", "playful", "silly", "silly face", "squint", "teasing", "tongue" });
        private static IconData _FaceGrinTongueWink;
        public static IconData FA_FaceGrinTongueWink => _FaceGrinTongueWink ??= new IconData("Face Grin Tongue Wink", "\U0000F58B", Styles.Regular | Styles.Solid, new string[] { "LOL", "cheeky", "emoji", "emoticon", "face", "funny", "grin", "joke", "laugh", "playful", "silly", "teasing", "tongue", "wink", "winking face" });
        private static IconData _FaceGrinWide;
        public static IconData FA_FaceGrinWide => _FaceGrinWide ??= new IconData("Face Grin Wide", "\U0000F581", Styles.Regular | Styles.Solid, new string[] { "big eyes", "cheerful", "emoticon", "excited", "face", "grin", "happy", "joyful", "laugh", "open mouth", "smile", "wide grin" });
        private static IconData _FaceGrinWink;
        public static IconData FA_FaceGrinWink => _FaceGrinWink ??= new IconData("Face Grin Wink", "\U0000F58C", Styles.Regular | Styles.Solid, new string[] { "cheeky", "emoticon", "face", "flirt", "grin", "happy", "mischievous", "playful", "smile", "wink" });
        private static IconData _FaceKiss;
        public static IconData FA_FaceKiss => _FaceKiss ??= new IconData("Face Kiss", "\U0000F596", Styles.Regular | Styles.Solid, new string[] { "affection", "beso", "blowing a kiss", "emoji", "face", "flirt", "hug and kiss", "kiss", "kissing face", "love", "romantic", "smooch" });
        private static IconData _FaceKissBeam;
        public static IconData FA_FaceKissBeam => _FaceKissBeam ??= new IconData("Face Kiss Beam", "\U0000F597", Styles.Regular | Styles.Solid, new string[] { "affection", "blowing kiss", "emoji", "emoticon", "eyes closed", "face", "happy", "kiss", "kissing face", "love", "smile", "smooch" });
        private static IconData _FaceKissWinkHeart;
        public static IconData FA_FaceKissWinkHeart => _FaceKissWinkHeart ??= new IconData("Face Kiss Wink Heart", "\U0000F598", Styles.Regular | Styles.Solid, new string[] { "affection", "blowing a kiss", "emoji", "emoticon", "face", "flirt", "heart", "kiss", "love", "smooch", "wink" });
        private static IconData _FaceLaugh;
        public static IconData FA_FaceLaugh => _FaceLaugh ??= new IconData("Face Laugh", "\U0000F599", Styles.Regular | Styles.Solid, new string[] { "amusement", "chuckle", "emoji", "face", "funny", "grin", "happy", "humor", "joy", "laugh", "laughter", "smile" });
        private static IconData _FaceLaughBeam;
        public static IconData FA_FaceLaughBeam => _FaceLaughBeam ??= new IconData("Face Laugh Beam", "\U0000F59A", Styles.Regular | Styles.Solid, new string[] { "amusement", "beaming face", "cheerful", "emoji", "fun", "grin", "happy", "humor", "joy", "laugh", "laughing face", "laughter", "smile", "smiling eyes" });
        private static IconData _FaceLaughSquint;
        public static IconData FA_FaceLaughSquint => _FaceLaughSquint ??= new IconData("Face Laugh Squint", "\U0000F59B", Styles.Regular | Styles.Solid, new string[] { "LOL", "amused", "emoticon", "face", "funny", "grin", "happy", "joy", "laugh", "laughing", "smile", "squint" });
        private static IconData _FaceLaughWink;
        public static IconData FA_FaceLaughWink => _FaceLaughWink ??= new IconData("Face Laugh Wink", "\U0000F59C", Styles.Regular | Styles.Solid, new string[] { "LOL", "emoticon", "face", "funny", "happy", "humor", "joking", "laugh", "playful", "smile", "wink" });
        private static IconData _FaceMeh;
        public static IconData FA_FaceMeh => _FaceMeh ??= new IconData("Face Meh", "\U0000F11A", Styles.Regular | Styles.Solid, new string[] { "apathetic", "bland", "deadpan", "default", "emoticon", "emotion", "expression", "face", "indifferent", "meh", "neutral", "neutral face", "rating", "unamused", "unimpressed" });
        private static IconData _FaceMehBlank;
        public static IconData FA_FaceMehBlank => _FaceMehBlank ??= new IconData("Face Meh Blank", "\U0000F5A4", Styles.Regular | Styles.Solid, new string[] { "blank", "deadpan", "emotionless", "expressionless", "face", "indifferent", "meh", "neutral", "no mouth", "quiet", "silent", "stoic", "unimpressed" });
        private static IconData _FaceRollingEyes;
        public static IconData FA_FaceRollingEyes => _FaceRollingEyes ??= new IconData("Face Rolling Eyes", "\U0000F5A5", Styles.Regular | Styles.Solid, new string[] { "annoyed", "dismissive", "emoji", "exasperated", "expression", "eye roll", "eyeroll", "face", "reaction", "rolling eyes", "sarcastic", "unimpressed" });
        private static IconData _FaceSadCry;
        public static IconData FA_FaceSadCry => _FaceSadCry ??= new IconData("Face Sad Cry", "\U0000F5B3", Styles.Regular | Styles.Solid, new string[] { "crying", "emoticon", "emotional", "face", "sad face", "sobbing", "tearful", "tears", "unhappy", "upset" });
        private static IconData _FaceSadTear;
        public static IconData FA_FaceSadTear => _FaceSadTear ??= new IconData("Face Sad Tear", "\U0000F5B4", Styles.Regular | Styles.Solid, new string[] { "crying", "distress", "emoticon", "emotional", "face", "grief", "sad", "sorrow", "tear", "tears", "unhappy", "upset" });
        private static IconData _FaceSmile;
        public static IconData FA_FaceSmile => _FaceSmile ??= new IconData("Face Smile", "\U0000F118", Styles.Regular | Styles.Solid, new string[] { "approve", "cheerful", "content", "emoticon", "face", "friendly", "happy", "joy", "pleased", "positive", "satisfied", "slightly smiling face", "smile" });
        private static IconData _FaceSmileBeam;
        public static IconData FA_FaceSmileBeam => _FaceSmileBeam ??= new IconData("Face Smile Beam", "\U0000F5B8", Styles.Regular | Styles.Solid, new string[] { "beaming", "blush", "cheerful", "delighted", "emoticon", "face", "grin", "happiness", "happy", "joyful", "pleased", "positive", "smile", "smiling" });
        private static IconData _FaceSmileWink;
        public static IconData FA_FaceSmileWink => _FaceSmileWink ??= new IconData("Face Smile Wink", "\U0000F4DA", Styles.Regular | Styles.Solid, new string[] { "cheeky", "emoticon", "face", "flirt", "fun", "happy", "mischievous", "playful", "smile", "teasing", "wink", "winking face" });
        private static IconData _FaceSurprise;
        public static IconData FA_FaceSurprise => _FaceSurprise ??= new IconData("Face Surprise", "\U0000F5C2", Styles.Regular | Styles.Solid, new string[] { "astonished", "emoji", "expression", "face", "open mouth", "reaction", "shocked", "startled", "surprised", "wow" });
        private static IconData _FaceTired;
        public static IconData FA_FaceTired => _FaceTired ??= new IconData("Face Tired", "\U0000F5C8", Styles.Regular | Styles.Solid, new string[] { "drained", "emoticon", "exhausted", "face", "fatigued", "frustrated", "grumpy", "sleepy", "tired", "upset", "weary", "worn out" });
        private static IconData _Facebook;
        public static IconData FA_Facebook => _Facebook ??= new IconData("Facebook", "\U0000F09A", Styles.Brands, new string[] { "facebook", "facebook-official", "fb", "meta", "social media", "social network", "social platform" });
        private static IconData _FacebookF;
        public static IconData FA_FacebookF => _FacebookF ??= new IconData("Facebook F", "\U0000F39E", Styles.Brands, new string[] { "facebook", "facebook logo", "fb", "meta", "social", "social media", "social network" });
        private static IconData _FacebookMessenger;
        public static IconData FA_FacebookMessenger => _FacebookMessenger ??= new IconData("Facebook Messenger", "\U0000F39F", Styles.Brands, new string[] { "chat", "facebook", "fb", "instant messaging", "message", "messenger", "messenger app", "social" });
        private static IconData _Fan;
        public static IconData FA_Fan => _Fan ??= new IconData("Fan", "\U0000F863", Styles.Solid, new string[] { "air", "airflow", "blade", "blower", "breeze", "ceiling fan", "cool air", "cooling", "electric fan", "fan", "hot air", "ventilation" });
        private static IconData _FantasyFlightGames;
        public static IconData FA_FantasyFlightGames => _FantasyFlightGames ??= new IconData("Fantasy Flight Games", "\U0000F6DC", Styles.Brands, new string[] { "Dungeons & Dragons", "FFG", "Fantasy Flight Games", "RPG", "board games", "card games", "d&d", "dnd", "fantasy", "role-playing games", "strategy games", "tabletop games" });
        private static IconData _Faucet;
        public static IconData FA_Faucet => _Faucet ??= new IconData("Faucet", "\U0000E005", Styles.Solid, new string[] { "bathroom", "drinking", "drip", "household", "hygiene", "kitchen", "plumbing", "potable", "potable water", "sanitation", "sink", "tap", "water" });
        private static IconData _FaucetDrip;
        public static IconData FA_FaucetDrip => _FaucetDrip ??= new IconData("Faucet Drip", "\U0000E006", Styles.Solid, new string[] { "bathroom", "drinking", "drip", "faucet", "household", "hygiene", "kitchen", "leak", "plumbing", "potable", "potable water", "sanitation", "sink", "tap", "water" });
        private static IconData _Fax;
        public static IconData FA_Fax => _Fax ??= new IconData("Fax", "\U0000F1AC", Styles.Solid, new string[] { "business", "communication", "copy", "document", "facsimile", "fax", "fax machine", "message", "office", "send", "transmit" });
        private static IconData _Feather;
        public static IconData FA_Feather => _Feather ??= new IconData("Feather", "\U0000F52D", Styles.Solid, new string[] { "bird", "delicate", "feather", "flight", "light", "pen", "plumage", "plume", "plume", "plume", "plume", "quill", "writing" });
        private static IconData _FeatherPointed;
        public static IconData FA_FeatherPointed => _FeatherPointed ??= new IconData("Feather Pointed", "\U0000F56B", Styles.Solid, new string[] { "bird", "calligraphy", "feather", "ink", "light", "pen", "plume", "plume feather", "plume pen", "quill", "writing" });
        private static IconData _Fedex;
        public static IconData FA_Fedex => _Fedex ??= new IconData("Fedex", "\U0000F797", Styles.Brands, new string[] { "FedEx", "Federal Express", "courier", "delivery", "express", "freight", "logistics", "package", "shipping" });
        private static IconData _Fediverse;
        public static IconData FA_Fediverse => _Fediverse ??= new IconData("Fediverse", "\U0000E865", Styles.Brands, new string[] { });
        private static IconData _Fedora;
        public static IconData FA_Fedora => _Fedora ??= new IconData("Fedora", "\U0000F798", Styles.Brands, new string[] { "distribution", "distro", "fedora", "linux", "open source", "operating system", "os", "red hat", "rpm" });
        private static IconData _Ferry;
        public static IconData FA_Ferry => _Ferry ??= new IconData("Ferry", "\U0000E4EA", Styles.Solid, new string[] { "barge", "boat", "commute", "crossing", "ferry", "ferryboat", "passenger", "ship", "transport", "travel", "vehicle", "watercraft" });
        private static IconData _Figma;
        public static IconData FA_Figma => _Figma ??= new IconData("Figma", "\U0000F799", Styles.Brands, new string[] { "app", "collaboration", "design", "figma", "interface", "prototyping", "ui", "ux", "vector", "webdesign" });
        private static IconData _File;
        public static IconData FA_File => _File ??= new IconData("File", "\U0000F15B", Styles.Regular | Styles.Solid, new string[] { "blank", "cv", "document", "file", "form", "new", "page", "page facing up", "paper", "pdf", "report", "resume", "sheet", "text" });
        private static IconData _FileArrowDown;
        public static IconData FA_FileArrowDown => _FileArrowDown ??= new IconData("File Arrow Down", "\U0000F56D", Styles.Solid, new string[] { "archive", "arrow-down", "document", "download", "export", "file", "import", "insert", "save", "upload" });
        private static IconData _FileArrowUp;
        public static IconData FA_FileArrowUp => _FileArrowUp ??= new IconData("File Arrow Up", "\U0000F574", Styles.Solid, new string[] { "arrow-up", "document", "export", "file", "import", "page", "save", "send", "update", "upgrade", "upload" });
        private static IconData _FileAudio;
        public static IconData FA_FileAudio => _FileAudio ??= new IconData("File Audio", "\U0000F1C7", Styles.Regular | Styles.Solid, new string[] { "audio", "document", "file", "mp3", "music", "play", "recording", "sound", "track", "waveform" });
        private static IconData _FileCircleCheck;
        public static IconData FA_FileCircleCheck => _FileCircleCheck ??= new IconData("File Circle Check", "\U0000E5A0", Styles.Solid, new string[] { "approved", "check", "checkmark", "complete", "confirm", "document", "done", "file", "ok", "okay", "paper", "success", "validated", "verified" });
        private static IconData _FileCircleExclamation;
        public static IconData FA_FileCircleExclamation => _FileCircleExclamation ??= new IconData("File Circle Exclamation", "\U0000E4EB", Styles.Solid, new string[] { "alert", "document", "error", "exclamation", "failed", "file", "issue", "paper", "problem", "warning" });
        private static IconData _FileCircleMinus;
        public static IconData FA_FileCircleMinus => _FileCircleMinus ??= new IconData("File Circle Minus", "\U0000E4ED", Styles.Solid, new string[] { "cancel", "circle", "delete", "discard", "document", "erase", "file", "file-remove", "minus", "paper", "remove", "subtract" });
        private static IconData _FileCirclePlus;
        public static IconData FA_FileCirclePlus => _FileCirclePlus ??= new IconData("File Circle Plus", "\U0000E494", Styles.Solid, new string[] { "add", "blank", "circle", "create", "document", "file", "insert", "new", "page", "paper", "pdf", "plus", "sheet", "upload" });
        private static IconData _FileCircleQuestion;
        public static IconData FA_FileCircleQuestion => _FileCircleQuestion ??= new IconData("File Circle Question", "\U0000E4EF", Styles.Solid, new string[] { "document", "file", "file-help", "file-question", "help", "info", "inquiry", "paper", "question", "support", "unknown" });
        private static IconData _FileCircleXmark;
        public static IconData FA_FileCircleXmark => _FileCircleXmark ??= new IconData("File Circle Xmark", "\U0000E5A1", Styles.Solid, new string[] { "cancel", "close", "cross", "delete", "document", "error", "file", "invalid", "no", "paper", "reject", "remove", "xmark" });
        private static IconData _FileCode;
        public static IconData FA_FileCode => _FileCode ??= new IconData("File Code", "\U0000F1C9", Styles.Regular | Styles.Solid, new string[] { "code", "css", "development", "document", "file", "html", "markup", "mysql", "programming", "script", "sql" });
        private static IconData _FileContract;
        public static IconData FA_FileContract => _FileContract ??= new IconData("File Contract", "\U0000F56C", Styles.Solid, new string[] { "agreement", "binding", "contract", "deal", "document", "file", "form", "legal", "paperwork", "signature", "terms" });
        private static IconData _FileCsv;
        public static IconData FA_FileCsv => _FileCsv ??= new IconData("File Csv", "\U0000F6DD", Styles.Solid, new string[] { "comma-separated", "csv", "data", "document", "export", "file", "import", "spreadsheet", "table", "values" });
        private static IconData _FileExcel;
        public static IconData FA_FileExcel => _FileExcel ??= new IconData("File Excel", "\U0000F1C3", Styles.Regular | Styles.Solid, new string[] { "csv", "data", "document", "excel", "microsoft excel", "numbers", "sheet", "spreadsheet", "table", "workbook", "xls", "xlsx" });
        private static IconData _FileExport;
        public static IconData FA_FileExport => _FileExport ??= new IconData("File Export", "\U0000F56E", Styles.Solid, new string[] { "document", "download", "export", "file", "output", "save", "send", "share", "transfer", "upload" });
        private static IconData _FileFragment;
        public static IconData FA_FileFragment => _FileFragment ??= new IconData("File Fragment", "\U0000E697", Styles.Solid, new string[] { "block", "chunk", "data", "document", "file", "fragment", "incomplete", "partial", "piece", "segment" });
        private static IconData _FileHalfDashed;
        public static IconData FA_FileHalfDashed => _FileHalfDashed ??= new IconData("File Half Dashed", "\U0000E698", Styles.Solid, new string[] { "dashed", "data", "document", "file", "form", "fragment", "incomplete", "outline", "partial", "piece", "sheet" });
        private static IconData _FileImage;
        public static IconData FA_FileImage => _FileImage ??= new IconData("File Image", "\U0000F1C5", Styles.Regular | Styles.Solid, new string[] { "document", "document with image", "file", "graphic", "image", "image file", "img", "jpg", "photo", "photo file", "picture", "picture file", "png" });
        private static IconData _FileImport;
        public static IconData FA_FileImport => _FileImport ??= new IconData("File Import", "\U0000F56F", Styles.Solid, new string[] { "add", "bring in", "document", "file", "import", "input", "insert", "load", "transfer", "upload" });
        private static IconData _FileInvoice;
        public static IconData FA_FileInvoice => _FileInvoice ??= new IconData("File Invoice", "\U0000F570", Styles.Solid, new string[] { "account", "bill", "billing", "charge", "document", "expense", "financial", "invoice", "payment", "receipt", "statement", "transaction" });
        private static IconData _FileInvoiceDollar;
        public static IconData FA_FileInvoiceDollar => _FileInvoiceDollar ??= new IconData("File Invoice Dollar", "\U0000F571", Styles.Solid, new string[] { "$", "accounting", "bill", "charge", "cost", "document", "dollar", "earnings", "finance", "invoice", "money", "payment", "receipt", "revenue", "salary", "usd" });
        private static IconData _FileLines;
        public static IconData FA_FileLines => _FileLines ??= new IconData("File Lines", "\U0000F15C", Styles.Regular | Styles.Solid, new string[] { "document", "file", "file-text", "form", "invoice", "new document", "page", "paper", "pdf", "report", "sheet", "text" });
        private static IconData _FileMedical;
        public static IconData FA_FileMedical => _FileMedical ??= new IconData("File Medical", "\U0000F477", Styles.Solid, new string[] { "chart", "clinic", "document", "file", "health", "healthcare", "history", "hospital", "medical", "patient", "prescription", "record", "report" });
        private static IconData _FilePdf;
        public static IconData FA_FilePdf => _FilePdf ??= new IconData("File Pdf", "\U0000F1C1", Styles.Regular | Styles.Solid, new string[] { "acrobat", "attachment", "document", "ebook", "file", "pdf", "portable document format", "preview", "report", "save" });
        private static IconData _FilePen;
        public static IconData FA_FilePen => _FilePen ??= new IconData("File Pen", "\U0000F31C", Styles.Solid, new string[] { "compose", "document", "draft", "edit", "file", "memo", "modify", "note", "pen", "pencil", "text", "update", "write" });
        private static IconData _FilePowerpoint;
        public static IconData FA_FilePowerpoint => _FilePowerpoint ??= new IconData("File Powerpoint", "\U0000F1C4", Styles.Regular | Styles.Solid, new string[] { "deck", "document", "file", "keynote", "microsoft", "office", "powerpoint", "ppt", "presentation", "slide", "slideshow" });
        private static IconData _FilePrescription;
        public static IconData FA_FilePrescription => _FilePrescription ??= new IconData("File Prescription", "\U0000F572", Styles.Solid, new string[] { "document", "drugs", "healthcare", "medical", "medication", "medicine", "pharmacy", "prescription", "rx", "script", "treatment" });
        private static IconData _FileShield;
        public static IconData FA_FileShield => _FileShield ??= new IconData("File Shield", "\U0000E4F0", Styles.Solid, new string[] { "antivirus", "data", "defense", "document", "file", "locked", "privacy", "protect", "protection", "safe", "safeguard", "safety", "secure", "security", "shield" });
        private static IconData _FileSignature;
        public static IconData FA_FileSignature => _FileSignature ??= new IconData("File Signature", "\U0000F573", Styles.Solid, new string[] { "John Hancock", "approval", "autograph", "contract", "document", "endorsement", "handwriting", "name", "sign", "signature" });
        private static IconData _FileVideo;
        public static IconData FA_FileVideo => _FileVideo ??= new IconData("File Video", "\U0000F1C8", Styles.Regular | Styles.Solid, new string[] { "clip", "file", "film", "footage", "m4v", "media", "movie", "mp4", "play", "playback", "recording", "video" });
        private static IconData _FileWaveform;
        public static IconData FA_FileWaveform => _FileWaveform ??= new IconData("File Waveform", "\U0000F478", Styles.Solid, new string[] { "audio", "data", "document", "file", "music", "recording", "signal", "sound", "track", "wave", "waveform" });
        private static IconData _FileWord;
        public static IconData FA_FileWord => _FileWord ??= new IconData("File Word", "\U0000F1C2", Styles.Regular | Styles.Solid, new string[] { "doc", "document", "editable", "file", "letter", "office", "page", "paper", "report", "text", "word", "word processing", "writing" });
        private static IconData _FileZipper;
        public static IconData FA_FileZipper => _FileZipper ??= new IconData("File Zipper", "\U0000F1C6", Styles.Regular | Styles.Solid, new string[] { ".zip", "archive", "archive file", "bundle", "compress", "compressed", "compression", "download", "extractor", "file", "folder", "packed", "packing", "zip", "zipped file" });
        private static IconData _FilesPinwheel;
        public static IconData FA_FilesPinwheel => _FilesPinwheel ??= new IconData("Files Pinwheel", "\U0000E69F", Styles.Brands, new string[] { "archive", "data", "document", "file manager", "file organization", "files", "folder", "pinwheel", "rotate", "storage", "sync" });
        private static IconData _Fill;
        public static IconData FA_Fill => _Fill ??= new IconData("Fill", "\U0000F575", Styles.Solid, new string[] { "bucket", "bucket fill", "color fill", "coloring", "fill", "paint", "paint bucket", "paint can", "paint tool" });
        private static IconData _FillDrip;
        public static IconData FA_FillDrip => _FillDrip ??= new IconData("Fill Drip", "\U0000F576", Styles.Solid, new string[] { "bucket", "color", "drip", "drop", "liquid", "paint", "paint bucket", "paint drip", "paint spill", "pouring", "spill" });
        private static IconData _Film;
        public static IconData FA_Film => _Film ??= new IconData("Film", "\U0000F008", Styles.Solid, new string[] { "cinema", "clip", "film", "film strip", "footage", "frames", "media", "movie", "movie reel", "projector", "recording", "video" });
        private static IconData _Filter;
        public static IconData FA_Filter => _Filter ??= new IconData("Filter", "\U0000F0B0", Styles.Solid, new string[] { "adjust", "criteria", "filter", "funnel", "narrow", "options", "refine", "selection", "settings", "sort" });
        private static IconData _FilterCircleDollar;
        public static IconData FA_FilterCircleDollar => _FilterCircleDollar ??= new IconData("Filter Circle Dollar", "\U0000F662", Styles.Solid, new string[] { "cost", "dollar", "filter", "finance", "money", "options", "payment", "premium", "price", "sort" });
        private static IconData _FilterCircleXmark;
        public static IconData FA_FilterCircleXmark => _FilterCircleXmark ??= new IconData("Filter Circle Xmark", "\U0000E17B", Styles.Solid, new string[] { "block", "cancel", "clear", "close", "delete", "erase", "filter", "funnel", "options", "remove", "reset", "stop", "xmark" });
        private static IconData _Fingerprint;
        public static IconData FA_Fingerprint => _Fingerprint ??= new IconData("Fingerprint", "\U0000F577", Styles.Solid, new string[] { "authentication", "biometric", "fingerprint", "id", "identification", "lock", "privacy", "security", "touch", "unique", "unlock" });
        private static IconData _Fire;
        public static IconData FA_Fire => _Fire ??= new IconData("Fire", "\U0000F06D", Styles.Solid, new string[] { "blaze", "burn", "burning", "campfire", "fire", "flame", "flame icon", "flame symbol", "heat", "hot", "ignition", "popular", "spark", "tool", "wildfire" });
        private static IconData _FireBurner;
        public static IconData FA_FireBurner => _FireBurner ??= new IconData("Fire Burner", "\U0000E4F1", Styles.Solid, new string[] { "burner", "burner flame", "cook", "cooking", "cooktop", "fire", "flame", "gas", "heat", "hob", "kitchen", "range", "stove" });
        private static IconData _FireExtinguisher;
        public static IconData FA_FireExtinguisher => _FireExtinguisher ??= new IconData("Fire Extinguisher", "\U0000F134", Styles.Solid, new string[] { "blaze", "burn", "emergency", "extinguisher", "fire", "fire extinguisher", "firefighting", "flame", "heat", "hot", "put out", "quench", "rescue", "safety", "smoke" });
        private static IconData _FireFlameCurved;
        public static IconData FA_FireFlameCurved => _FireFlameCurved ??= new IconData("Fire Flame Curved", "\U0000F7E4", Styles.Solid, new string[] { "blaze", "burn", "burning", "fire", "fire hazard", "flame", "flame icon", "flame symbol", "heat", "hot", "ignition", "popular", "wildfire" });
        private static IconData _FireFlameSimple;
        public static IconData FA_FireFlameSimple => _FireFlameSimple ??= new IconData("Fire Flame Simple", "\U0000F46A", Styles.Solid, new string[] { "blaze", "burn", "caliente", "energy", "fire", "flame", "gas", "heat", "hot", "ignition", "warm" });
        private static IconData _Firefox;
        public static IconData FA_Firefox => _Firefox ??= new IconData("Firefox", "\U0000F269", Styles.Brands, new string[] { "browser", "browser icon", "firefox", "firefox browser", "internet", "mozilla", "web" });
        private static IconData _FirefoxBrowser;
        public static IconData FA_FirefoxBrowser => _FirefoxBrowser ??= new IconData("Firefox Browser", "\U0000E007", Styles.Brands, new string[] { "browser", "browser icon", "firefox", "internet", "mozilla", "web", "web browser" });
        private static IconData _FirstOrder;
        public static IconData FA_FirstOrder => _FirstOrder ??= new IconData("First Order", "\U0000F2B0", Styles.Brands, new string[] { "1st order", "first order", "hierarchy", "primary", "priority", "ranking", "top level" });
        private static IconData _FirstOrderAlt;
        public static IconData FA_FirstOrderAlt => _FirstOrderAlt ??= new IconData("First Order Alt", "\U0000F50A", Styles.Brands, new string[] { "alt", "alternative", "brand", "first order", "first-order", "logo" });
        private static IconData _Firstdraft;
        public static IconData FA_Firstdraft => _Firstdraft ??= new IconData("Firstdraft", "\U0000F3A1", Styles.Brands, new string[] { "content creation", "document", "draft", "first draft", "firstdraft", "publishing", "writing" });
        private static IconData _Fish;
        public static IconData FA_Fish => _Fish ??= new IconData("Fish", "\U0000F578", Styles.Solid, new string[] { "Pisces", "animal", "aquarium", "aquatic", "fish", "fishing", "goldfish", "marine", "ocean", "pet", "seafood", "swimming", "zodiac" });
        private static IconData _FishFins;
        public static IconData FA_FishFins => _FishFins ??= new IconData("Fish Fins", "\U0000E4F2", Styles.Solid, new string[] { "Pisces", "aquatic", "fins", "fish", "fishing", "marine", "ocean", "seafood", "swim", "water" });
        private static IconData _Flag;
        public static IconData FA_Flag => _Flag ??= new IconData("Flag", "\U0000F024", Styles.Regular | Styles.Solid, new string[] { "alert", "banner", "country", "flag", "marker", "nation", "notification", "notify", "pennant", "pole", "report", "signal", "symbol", "waving" });
        private static IconData _FlagCheckered;
        public static IconData FA_FlagCheckered => _FlagCheckered ??= new IconData("Flag Checkered", "\U0000F11E", Styles.Solid, new string[] { "checkered", "chequered", "competition", "end", "finish", "flag", "flag icon", "flagpole", "motorsport", "race", "race flag", "racing", "signal", "victory", "winner" });
        private static IconData _FlagUsa;
        public static IconData FA_FlagUsa => _FlagUsa ??= new IconData("Flag Usa", "\U0000F74D", Styles.Solid, new string[] { "american flag", "betsy ross", "country", "flag", "national emblem", "old glory", "patriotism", "stars", "stars and stripes", "stripes", "united states", "usa" });
        private static IconData _Flask;
        public static IconData FA_Flask => _Flask ??= new IconData("Flask", "\U0000F0C3", Styles.Solid, new string[] { "beaker", "chemistry", "experiment", "flask", "lab", "laboratory", "liquid", "potion", "research", "science", "test tube", "vial" });
        private static IconData _FlaskVial;
        public static IconData FA_FlaskVial => _FlaskVial ??= new IconData("Flask Vial", "\U0000E4F3", Styles.Solid, new string[] { "ampule", "beaker", "chemical", "chemistry", "experiment", "experimental", "flask", "lab", "laboratory", "liquid", "potion", "science", "test", "test tube", "vial" });
        private static IconData _Flickr;
        public static IconData FA_Flickr => _Flickr ??= new IconData("Flickr", "\U0000F16E", Styles.Brands, new string[] { "flickr", "images", "photo community", "photo hosting", "photo sharing", "photography", "photos", "social media" });
        private static IconData _Flipboard;
        public static IconData FA_Flipboard => _Flipboard ??= new IconData("Flipboard", "\U0000F44D", Styles.Brands, new string[] { "Flipboard", "articles", "content", "magazine", "news", "news aggregator", "news app", "reading", "social media" });
        private static IconData _FloppyDisk;
        public static IconData FA_FloppyDisk => _FloppyDisk ??= new IconData("Floppy Disk", "\U0000F0C7", Styles.Regular | Styles.Solid, new string[] { "archive", "backup", "computer", "data", "disk", "floppy", "floppy disk", "legacy", "memory", "old school", "retro", "save", "save icon", "storage" });
        private static IconData _FlorinSign;
        public static IconData FA_FlorinSign => _FlorinSign ??= new IconData("Florin Sign", "\U0000E184", Styles.Solid, new string[] { "cash", "currency", "euro alternative", "finance", "financial symbol", "florin", "money", "payment", "symbol", "trade" });
        private static IconData _Flutter;
        public static IconData FA_Flutter => _Flutter ??= new IconData("Flutter", "\U0000E694", Styles.Brands, new string[] { "flutter", "flutter SDK", "flutter UI", "flutter app", "flutter brand", "flutter development", "flutter framework", "flutter logo", "flutter mobile", "flutter web" });
        private static IconData _Fly;
        public static IconData FA_Fly => _Fly ??= new IconData("Fly", "\U0000F417", Styles.Brands, new string[] { "cloud computing", "cloud platform", "deployment", "devops", "fly", "fly.io", "hosting", "serverless" });
        private static IconData _Folder;
        public static IconData FA_Folder => _Folder ??= new IconData("Folder", "\U0000F07B", Styles.Regular | Styles.Solid, new string[] { "archive", "directory", "document", "documents", "file", "file folder", "file organizer", "files", "filing", "folder", "folder icon", "folder symbol", "storage" });
        private static IconData _FolderClosed;
        public static IconData FA_FolderClosed => _FolderClosed ??= new IconData("Folder Closed", "\U0000E185", Styles.Regular | Styles.Solid, new string[] { "archive", "closed folder", "directory", "documents", "file cabinet", "file folder", "filing", "folder", "organize", "storage" });
        private static IconData _FolderMinus;
        public static IconData FA_FolderMinus => _FolderMinus ??= new IconData("Folder Minus", "\U0000F65D", Styles.Solid, new string[] { "archive", "delete", "directory", "document", "file", "folder", "folder-remove", "minus", "negative", "reduce", "remove", "remove-file", "subtract" });
        private static IconData _FolderOpen;
        public static IconData FA_FolderOpen => _FolderOpen ??= new IconData("Folder Open", "\U0000F07C", Styles.Regular | Styles.Solid, new string[] { "archive", "directory", "document", "file", "file folder", "folder", "folder icon", "folder open", "folder view", "open", "open file folder", "open folder" });
        private static IconData _FolderPlus;
        public static IconData FA_FolderPlus => _FolderPlus ??= new IconData("Folder Plus", "\U0000F65E", Styles.Solid, new string[] { "add", "archive", "create", "directory", "document", "expand", "file", "folder", "insert", "new", "open", "plus", "positive", "save", "upload" });
        private static IconData _FolderTree;
        public static IconData FA_FolderTree => _FolderTree ??= new IconData("Folder Tree", "\U0000F802", Styles.Solid, new string[] { "archive", "directory", "documents", "file", "files", "folder", "folders", "hierarchy", "organization", "structure", "tree" });
        private static IconData _Font;
        public static IconData FA_Font => _Font ??= new IconData("Font", "\U0000F031", Styles.Solid, new string[] { "alphabet", "character", "font style", "glyph", "letter", "print", "script", "text", "type", "typeface", "typography", "writing" });
        private static IconData _FontAwesome;
        public static IconData FA_FontAwesome => _FontAwesome ??= new IconData("Font Awesome", "\U0000F2B4", Styles.Brands | Styles.Regular | Styles.Solid, new string[] { "branding", "fa", "font-awesome", "icon set", "logo", "typeface" });
        private static IconData _Fonticons;
        public static IconData FA_Fonticons => _Fonticons ??= new IconData("Fonticons", "\U0000F280", Styles.Brands, new string[] { "font icons", "fonticons", "glyphs", "icon font", "icon set", "symbols", "typography", "vector icons" });
        private static IconData _FonticonsFi;
        public static IconData FA_FonticonsFi => _FonticonsFi ??= new IconData("Fonticons Fi", "\U0000F3A2", Styles.Brands, new string[] { "branding", "fi", "font icon", "fonticons", "icon", "logo" });
        private static IconData _Football;
        public static IconData FA_Football => _Football ??= new IconData("Football", "\U0000F44E", Styles.Solid, new string[] { "american football", "ball", "field", "football", "game", "gridiron", "helmet", "nfl", "pigskin", "quarterback", "sport", "sports", "tackle", "team", "touchdown" });
        private static IconData _Forgejo;
        public static IconData FA_Forgejo => _Forgejo ??= new IconData("Forgejo", "\U0000E860", Styles.Brands, new string[] { });
        private static IconData _FortAwesome;
        public static IconData FA_FortAwesome => _FortAwesome ??= new IconData("Fort Awesome", "\U0000F286", Styles.Brands, new string[] { "castle", "defense", "fort", "fortress", "fortress icon", "medieval", "stronghold" });
        private static IconData _FortAwesomeAlt;
        public static IconData FA_FortAwesomeAlt => _FortAwesomeAlt ??= new IconData("Fort Awesome Alt", "\U0000F3A3", Styles.Brands, new string[] { "castle", "defense", "fort", "fortress", "fortress wall", "medieval", "military", "stronghold" });
        private static IconData _Forumbee;
        public static IconData FA_Forumbee => _Forumbee ??= new IconData("Forumbee", "\U0000F211", Styles.Brands, new string[] { "collaboration tool", "discussion platform", "forum bee", "forumbee", "online community", "social network" });
        private static IconData _Forward;
        public static IconData FA_Forward => _Forward ??= new IconData("Forward", "\U0000F04E", Styles.Solid, new string[] { "advance", "ahead", "arrow", "continue", "double", "fast", "fast-forward", "forward", "move", "next", "play", "right", "skip" });
        private static IconData _ForwardFast;
        public static IconData FA_ForwardFast => _ForwardFast ??= new IconData("Forward Fast", "\U0000F050", Styles.Solid, new string[] { "arrow", "fast-forward", "forward", "media", "next", "next scene", "next track", "playback", "quick", "skip", "speed", "triangle" });
        private static IconData _ForwardStep;
        public static IconData FA_ForwardStep => _ForwardStep ??= new IconData("Forward Step", "\U0000F051", Styles.Solid, new string[] { "advance", "end", "fast-forward", "forward", "last", "move ahead", "next", "skip", "step" });
        private static IconData _Foursquare;
        public static IconData FA_Foursquare => _Foursquare ??= new IconData("Foursquare", "\U0000F180", Styles.Brands, new string[] { "check-in", "checkin", "foursquare", "fsq", "local", "location", "maps", "places", "social", "venue" });
        private static IconData _FrancSign;
        public static IconData FA_FrancSign => _FrancSign ??= new IconData("Franc Sign", "\U0000E18F", Styles.Solid, new string[] { "Swiss franc", "currency", "currency symbol", "franc", "franc currency", "franc icon", "franc money", "franc sign", "franc symbol", "money" });
        private static IconData _FreeCodeCamp;
        public static IconData FA_FreeCodeCamp => _FreeCodeCamp ??= new IconData("Free Code Camp", "\U0000F2C5", Styles.Brands, new string[] { "bootcamp", "code", "coding", "developer", "education", "fcc", "freecodecamp", "learning", "online course", "programming" });
        private static IconData _Freebsd;
        public static IconData FA_Freebsd => _Freebsd ??= new IconData("Freebsd", "\U0000F3A4", Styles.Brands, new string[] { "bsd", "free bsd", "freebsd", "network", "open source", "operating system", "os", "server", "unix" });
        private static IconData _Frog;
        public static IconData FA_Frog => _Frog ??= new IconData("Frog", "\U0000F52E", Styles.Solid, new string[] { "amphibian", "bullfrog", "croak", "frog", "green", "hop", "kermit", "kiss", "leap", "pond", "prince", "ribbit", "tadpole", "toad", "wart" });
        private static IconData _Fulcrum;
        public static IconData FA_Fulcrum => _Fulcrum ??= new IconData("Fulcrum", "\U0000F50B", Styles.Brands, new string[] { "analytics tool", "business intelligence", "data platform", "data visualization", "fulcrum", "fulcrum analytics" });
        private static IconData _Futbol;
        public static IconData FA_Futbol => _Futbol ??= new IconData("Futbol", "\U0000F1E3", Styles.Regular | Styles.Solid, new string[] { "ball", "football", "football game", "football sport", "soccer", "soccer ball", "soccer ball graphic", "soccer ball icon", "soccer ball symbol", "soccer game", "soccer sport", "sports" });
        private static IconData _G;
        public static IconData FA_G => _G ??= new IconData("G", "\U00000047", Styles.Solid, new string[] { "alphabet", "capital g", "character", "glyph", "letter g", "lowercase g", "text symbol", "typography" });
        private static IconData _GalacticRepublic;
        public static IconData FA_GalacticRepublic => _GalacticRepublic ??= new IconData("Galactic Republic", "\U0000F50C", Styles.Brands, new string[] { "clone wars", "galactic republic", "galaxy", "jedi", "republic", "sci-fi", "science fiction", "space", "star wars", "starwars" });
        private static IconData _GalacticSenate;
        public static IconData FA_GalacticSenate => _GalacticSenate ??= new IconData("Galactic Senate", "\U0000F50D", Styles.Brands, new string[] { "galactic senate", "star wars", "star wars emblem", "star wars franchise", "star wars galaxy", "star wars icon", "star wars logo", "star wars symbol", "starwars" });
        private static IconData _Gamepad;
        public static IconData FA_Gamepad => _Gamepad ??= new IconData("Gamepad", "\U0000F11B", Styles.Solid, new string[] { "arcade", "console", "controller", "d-pad", "game controller", "gamepad", "gaming", "joystick", "play", "video game", "video games" });
        private static IconData _GasPump;
        public static IconData FA_GasPump => _GasPump ??= new IconData("Gas Pump", "\U0000F52F", Styles.Solid, new string[] { "car", "diesel", "filling station", "fuel", "fuel pump", "gas", "gas dispenser", "gas nozzle", "gas pump handle", "gas station", "gasoline", "petrol", "petrol station", "pump", "refuel" });
        private static IconData _Gauge;
        public static IconData FA_Gauge => _Gauge ??= new IconData("Gauge", "\U0000F624", Styles.Solid, new string[] { "dashboard", "dial", "gauge", "gauge cluster", "indicator", "measurement", "meter", "odometer", "performance", "speed", "speedometer", "tachometer" });
        private static IconData _GaugeHigh;
        public static IconData FA_GaugeHigh => _GaugeHigh ??= new IconData("Gauge High", "\U0000F625", Styles.Solid, new string[] { "dashboard", "dial", "fast", "gauge", "indicator", "measurement", "meter", "performance", "rpm", "speed", "speedometer", "tachometer" });
        private static IconData _GaugeSimple;
        public static IconData FA_GaugeSimple => _GaugeSimple ??= new IconData("Gauge Simple", "\U0000F629", Styles.Solid, new string[] { "dashboard", "dial", "fast", "gauge", "indicator", "instrument", "measurement", "meter", "odometer", "performance", "speed", "speedometer" });
        private static IconData _GaugeSimpleHigh;
        public static IconData FA_GaugeSimpleHigh => _GaugeSimpleHigh ??= new IconData("Gauge Simple High", "\U0000F62A", Styles.Solid, new string[] { "dashboard", "dial", "fast", "gauge", "high", "indicator", "measurement", "meter", "performance", "quick", "speed", "speedometer" });
        private static IconData _Gavel;
        public static IconData FA_Gavel => _Gavel ??= new IconData("Gavel", "\U0000F0E3", Styles.Solid, new string[] { "auction", "court", "decision", "gavel", "hammer", "judge", "judge's hammer", "justice", "law", "lawyer", "legal", "ruling", "verdict" });
        private static IconData _Gear;
        public static IconData FA_Gear => _Gear ??= new IconData("Gear", "\U0000F013", Styles.Solid, new string[] { "adjust", "cog", "cogwheel", "configuration", "control", "gear", "mechanical", "modify", "options", "preferences", "settings", "setup", "sprocket", "tool", "wheel" });
        private static IconData _Gears;
        public static IconData FA_Gears => _Gears ??= new IconData("Gears", "\U0000F085", Styles.Solid, new string[] { "adjust", "cog", "cogwheel", "configuration", "gears", "machinery", "mechanical", "options", "process", "settings", "sprocket", "system", "tools", "wheel" });
        private static IconData _Gem;
        public static IconData FA_Gem => _Gem ??= new IconData("Gem", "\U0000F3A5", Styles.Regular | Styles.Solid, new string[] { "crystal", "diamond", "emerald", "gem", "gem stone", "gemstone", "jewel", "jewelry", "luxury", "precious", "ruby", "sapphire", "treasure", "valuable" });
        private static IconData _Gemini;
        public static IconData FA_Gemini => _Gemini ??= new IconData("Gemini", "\U0000E849", Styles.Solid, new string[] { "air sign", "astrology", "constellation", "gemini", "horoscope", "june", "may", "sign", "stars", "twin", "twins", "zodiac" });
        private static IconData _Genderless;
        public static IconData FA_Genderless => _Genderless ??= new IconData("Genderless", "\U0000F22D", Styles.Solid, new string[] { "androgynous", "asexual", "gender", "gender neutral", "genderless", "identity", "neutral", "nonbinary", "sexless", "unisex" });
        private static IconData _GetPocket;
        public static IconData FA_GetPocket => _GetPocket ??= new IconData("Get Pocket", "\U0000F265", Styles.Brands, new string[] { "article", "bookmarking", "getpocket", "pocket", "pocket app", "read later", "reading list", "save", "save article", "save for later" });
        private static IconData _Gg;
        public static IconData FA_Gg => _Gg ??= new IconData("Gg", "\U0000F260", Styles.Brands, new string[] { "esports", "game over", "gamer", "gaming", "gg", "good game", "victory", "win" });
        private static IconData _GgCircle;
        public static IconData FA_GgCircle => _GgCircle ??= new IconData("Gg Circle", "\U0000F261", Styles.Brands, new string[] { "gg", "gg brand", "gg circle", "gg icon", "gg logo", "gg symbol" });
        private static IconData _Ghost;
        public static IconData FA_Ghost => _Ghost ??= new IconData("Ghost", "\U0000F6E2", Styles.Solid, new string[] { "apparition", "blinky", "clyde", "creature", "face", "fantasy", "floating", "ghost", "halloween", "inky", "monster", "pacman", "phantom", "pinky", "specter", "spirit", "spooky", "supernatural", "wraith" });
        private static IconData _Gift;
        public static IconData FA_Gift => _Gift ??= new IconData("Gift", "\U0000F06B", Styles.Solid, new string[] { "birthday", "box", "celebration", "christmas", "festive", "generosity", "gift", "giving", "holiday", "party", "present", "surprise", "wrapped", "xmas" });
        private static IconData _Gifts;
        public static IconData FA_Gifts => _Gifts ??= new IconData("Gifts", "\U0000F79C", Styles.Solid, new string[] { "box", "celebration", "christmas", "generosity", "gift", "giving", "holiday", "party", "present", "surprise", "wrapped", "xmas" });
        private static IconData _Git;
        public static IconData FA_Git => _Git ??= new IconData("Git", "\U0000F1D3", Styles.Brands, new string[] { "branch", "code", "commit", "developer", "git", "merge", "open source", "programming", "repository", "software", "source control", "version control" });
        private static IconData _GitAlt;
        public static IconData FA_GitAlt => _GitAlt ??= new IconData("Git Alt", "\U0000F841", Styles.Brands, new string[] { "branch", "code", "commit", "dev", "developer", "git", "repository", "software", "source control", "version control" });
        private static IconData _Gitee;
        public static IconData FA_Gitee => _Gitee ??= new IconData("Gitee", "\U0000E863", Styles.Brands, new string[] { });
        private static IconData _Github;
        public static IconData FA_Github => _Github ??= new IconData("Github", "\U0000F09B", Styles.Brands, new string[] { "code", "collaboration", "development", "git", "github", "octocat", "programming", "repository", "software", "version control" });
        private static IconData _GithubAlt;
        public static IconData FA_GithubAlt => _GithubAlt ??= new IconData("Github Alt", "\U0000F113", Styles.Brands, new string[] { "code", "developer", "git", "github", "octocat", "programming", "repository", "software", "version control" });
        private static IconData _Gitkraken;
        public static IconData FA_Gitkraken => _Gitkraken ??= new IconData("Gitkraken", "\U0000F3A6", Styles.Brands, new string[] { "code management", "developer tool", "git", "git client", "gitkraken", "repository", "software development", "source control", "version control" });
        private static IconData _Gitlab;
        public static IconData FA_Gitlab => _Gitlab ??= new IconData("Gitlab", "\U0000F296", Styles.Brands, new string[] { "CI/CD", "DevOps", "GitLab", "code hosting", "continuous deployment", "continuous integration", "gitlab", "repository", "software development", "version control" });
        private static IconData _Gitter;
        public static IconData FA_Gitter => _Gitter ??= new IconData("Gitter", "\U0000F426", Styles.Brands, new string[] { "chat", "chat platform", "collaboration", "communication", "community", "developer chat", "gitter", "messaging", "team chat" });
        private static IconData _GlassWater;
        public static IconData FA_GlassWater => _GlassWater ??= new IconData("Glass Water", "\U0000E4F4", Styles.Solid, new string[] { "beverage", "cold drink", "cup", "drink", "glass", "hydration", "liquid", "potable", "refreshment", "water" });
        private static IconData _GlassWaterDroplet;
        public static IconData FA_GlassWaterDroplet => _GlassWaterDroplet ??= new IconData("Glass Water Droplet", "\U0000E4F5", Styles.Solid, new string[] { "beverage", "clean", "drink", "droplet", "glass", "hydration", "liquid", "potable", "pure", "refreshment", "water" });
        private static IconData _Glasses;
        public static IconData FA_Glasses => _Glasses ??= new IconData("Glasses", "\U0000F530", Styles.Solid, new string[] { "eyeglasses", "eyewear", "frames", "glasses", "hipster", "nerd", "reading", "sight", "spectacles", "vision" });
        private static IconData _Glide;
        public static IconData FA_Glide => _Glide ??= new IconData("Glide", "\U0000F2A5", Styles.Brands, new string[] { "app builder", "app development", "glide", "glideapps", "mobile app", "no code", "no-code", "platform", "software" });
        private static IconData _GlideG;
        public static IconData FA_GlideG => _GlideG ??= new IconData("Glide G", "\U0000F2A6", Styles.Brands, new string[] { "app builder", "app maker", "glide", "glideapps", "mobile app", "no-code", "platform", "software", "web app" });
        private static IconData _Globaleaks;
        public static IconData FA_Globaleaks => _Globaleaks ??= new IconData("Globaleaks", "\U0000E85D", Styles.Brands, new string[] { });
        private static IconData _Globe;
        public static IconData FA_Globe => _Globe ??= new IconData("Globe", "\U0000F0AC", Styles.Solid, new string[] { "coordinates", "country", "earth", "global", "globe", "gps", "internet", "language", "localize", "location", "map", "meridians", "network", "online", "place", "planet", "translate", "travel", "world", "www" });
        private static IconData _Gofore;
        public static IconData FA_Gofore => _Gofore ??= new IconData("Gofore", "\U0000F3A7", Styles.Brands, new string[] { "consulting", "digital services", "finnish company", "gofore", "gofore oy", "software development" });
        private static IconData _Golang;
        public static IconData FA_Golang => _Golang ??= new IconData("Golang", "\U0000E40F", Styles.Brands, new string[] { "backend", "code", "developer", "go", "golang", "gopher", "language", "programming", "software" });
        private static IconData _GolfBallTee;
        public static IconData FA_GolfBallTee => _GolfBallTee ??= new IconData("Golf Ball Tee", "\U0000F450", Styles.Solid, new string[] { "ball", "golf", "golf ball", "golf club", "golf course", "golf game", "golf shot", "golf swing", "golf tee", "golfing", "sport", "sports equipment", "tee" });
        private static IconData _Goodreads;
        public static IconData FA_Goodreads => _Goodreads ??= new IconData("Goodreads", "\U0000F3A8", Styles.Brands, new string[] { "book community", "book recommendations", "book reviews", "books", "goodreads", "literature", "reading", "reading tracker", "social reading" });
        private static IconData _GoodreadsG;
        public static IconData FA_GoodreadsG => _GoodreadsG ??= new IconData("Goodreads G", "\U0000F3A9", Styles.Brands, new string[] { "book community", "book reviews", "books", "g", "goodreads", "literature", "reading", "social reading" });
        private static IconData _Google;
        public static IconData FA_Google => _Google ??= new IconData("Google", "\U0000F1A0", Styles.Brands, new string[] { "google", "google brand", "google company", "google icon", "google logo", "google products", "google services", "search engine" });
        private static IconData _GoogleDrive;
        public static IconData FA_GoogleDrive => _GoogleDrive ??= new IconData("Google Drive", "\U0000F3AA", Styles.Brands, new string[] { "cloud", "documents", "drive", "files", "gdrive", "google", "google drive", "storage" });
        private static IconData _GooglePay;
        public static IconData FA_GooglePay => _GooglePay ??= new IconData("Google Pay", "\U0000E079", Styles.Brands, new string[] { "contactless pay", "digital wallet", "google pay", "google wallet", "gpay", "mobile payment", "nfc payment", "online payment", "payment", "tap to pay" });
        private static IconData _GooglePlay;
        public static IconData FA_GooglePlay => _GooglePlay ??= new IconData("Google Play", "\U0000F3AB", Styles.Brands, new string[] { "android store", "app store", "google apps", "google play", "google play store", "playstore" });
        private static IconData _GooglePlus;
        public static IconData FA_GooglePlus => _GooglePlus ??= new IconData("Google Plus", "\U0000F2B3", Styles.Brands, new string[] { "google plus", "google+", "google-plus", "google-plus-circle", "google-plus-official", "gplus" });
        private static IconData _GooglePlusG;
        public static IconData FA_GooglePlusG => _GooglePlusG ??= new IconData("Google Plus G", "\U0000F0D5", Styles.Brands, new string[] { "google", "google social", "google-plus", "gplus", "social media", "social network" });
        private static IconData _GoogleScholar;
        public static IconData FA_GoogleScholar => _GoogleScholar ??= new IconData("Google Scholar", "\U0000E63B", Styles.Brands, new string[] { "academic", "citations", "google", "google scholar", "papers", "research", "scholar" });
        private static IconData _GoogleWallet;
        public static IconData FA_GoogleWallet => _GoogleWallet ??= new IconData("Google Wallet", "\U0000F1EE", Styles.Brands, new string[] { "card", "contactless", "digital wallet", "ecommerce", "finance", "google pay", "google wallet", "mobile payment", "money", "online payment", "payment", "payments", "tap to pay", "transaction", "wallet" });
        private static IconData _Gopuram;
        public static IconData FA_Gopuram => _Gopuram ??= new IconData("Gopuram", "\U0000F664", Styles.Solid, new string[] { "architecture", "entrance", "gateway", "hinduism", "landmark", "monument", "ornate", "religious", "sacred", "south india", "temple", "tower" });
        private static IconData _GraduationCap;
        public static IconData FA_GraduationCap => _GraduationCap ??= new IconData("Graduation Cap", "\U0000F19D", Styles.Solid, new string[] { "academic", "cap", "celebration", "ceremony", "college", "commencement", "diploma", "education", "graduate", "graduation", "hat", "learning", "mortarboard", "school", "student" });
        private static IconData _Gratipay;
        public static IconData FA_Gratipay => _Gratipay ??= new IconData("Gratipay", "\U0000F184", Styles.Brands, new string[] { "charity", "contribution", "crowdfunding", "donation", "funding", "gratipay", "support", "tip" });
        private static IconData _Grav;
        public static IconData FA_Grav => _Grav ??= new IconData("Grav", "\U0000F2D6", Styles.Brands, new string[] { "account", "avatar", "grav", "gravatar", "identity", "picture", "profile", "user" });
        private static IconData _GreaterThan;
        public static IconData FA_GreaterThan => _GreaterThan ??= new IconData("Greater Than", "\U0000003E", Styles.Solid, new string[] { "arithmetic", "comparison", "comparison operator", "greater than", "greater-than sign", "inequality", "math", "more than", "operator", "symbol" });
        private static IconData _GreaterThanEqual;
        public static IconData FA_GreaterThanEqual => _GreaterThanEqual ??= new IconData("Greater Than Equal", "\U0000F532", Styles.Solid, new string[] { "arithmetic", "compare", "comparison", "greater than or equal to", "inequality", "logic", "math", "math symbol", "operator", "symbol" });
        private static IconData _Grip;
        public static IconData FA_Grip => _Grip ??= new IconData("Grip", "\U0000F58D", Styles.Solid, new string[] { "UI", "control", "dots", "drag", "drop", "grab", "grip", "handle", "interface", "menu", "move", "reorder", "resize", "toolbar", "widget" });
        private static IconData _GripLines;
        public static IconData FA_GripLines => _GripLines ??= new IconData("Grip Lines", "\U0000F7A4", Styles.Solid, new string[] { "UI control", "drag", "drag handle", "draggable", "drop", "grab", "grabber", "grip", "handle", "interface element", "move", "reorder", "resize" });
        private static IconData _GripLinesVertical;
        public static IconData FA_GripLinesVertical => _GripLinesVertical ??= new IconData("Grip Lines Vertical", "\U0000F7A5", Styles.Solid, new string[] { "UI element", "affordance", "control", "drag", "drop", "grab", "grip", "handle", "interface", "move", "reorder", "resize", "slider", "vertical lines" });
        private static IconData _GripVertical;
        public static IconData FA_GripVertical => _GripVertical ??= new IconData("Grip Vertical", "\U0000F58E", Styles.Solid, new string[] { "drag", "drag handle", "drop", "grab", "grabber", "grip", "handle", "interface element", "move", "reorder", "resize", "vertical bars" });
        private static IconData _Gripfire;
        public static IconData FA_Gripfire => _Gripfire ??= new IconData("Gripfire", "\U0000F3AC", Styles.Brands, new string[] { "brand", "esports", "gaming", "grip fire", "gripfire", "logo", "streaming", "video games" });
        private static IconData _GroupArrowsRotate;
        public static IconData FA_GroupArrowsRotate => _GroupArrowsRotate ??= new IconData("Group Arrows Rotate", "\U0000E4F6", Styles.Solid, new string[] { "community", "cycle", "engagement", "loop", "refresh", "reload", "repeat", "rotate", "spin", "sync", "update" });
        private static IconData _Grunt;
        public static IconData FA_Grunt => _Grunt ??= new IconData("Grunt", "\U0000F3AD", Styles.Brands, new string[] { "automation", "build tool", "grunt", "gruntjs", "javascript", "nodejs", "task runner" });
        private static IconData _GuaraniSign;
        public static IconData FA_GuaraniSign => _GuaraniSign ??= new IconData("Guarani Sign", "\U0000E19A", Styles.Solid, new string[] { "Paraguay", "cash", "currency", "currency sign", "financial", "guarani", "money", "payment", "sign", "symbol" });
        private static IconData _Guilded;
        public static IconData FA_Guilded => _Guilded ??= new IconData("Guilded", "\U0000E07E", Styles.Brands, new string[] { "chat", "communication", "community", "esports", "gaming", "guilded", "platform", "social", "teams", "voice" });
        private static IconData _Guitar;
        public static IconData FA_Guitar => _Guitar ??= new IconData("Guitar", "\U0000F7A6", Styles.Solid, new string[] { "acoustic", "band", "chord", "electric", "guitar", "instrument", "melody", "music", "musician", "rock", "rock and roll", "song", "stringed", "strings" });
        private static IconData _Gulp;
        public static IconData FA_Gulp => _Gulp ??= new IconData("Gulp", "\U0000F3AE", Styles.Brands, new string[] { "automation", "build", "gulp", "gulpjs", "javascript", "nodejs", "streaming", "task runner" });
        private static IconData _Gun;
        public static IconData FA_Gun => _Gun ??= new IconData("Gun", "\U0000E19B", Styles.Solid, new string[] { "defense", "firearm", "firearm weapon", "gunfire", "handgun", "pistol", "revolver", "security", "shooter", "shooting", "trigger", "weapon" });
        private static IconData _H;
        public static IconData FA_H => _H ??= new IconData("H", "\U00000048", Styles.Solid, new string[] { "alphabet", "capital h", "character", "letter h", "lowercase h", "symbol", "typography" });
        private static IconData _HackerNews;
        public static IconData FA_HackerNews => _HackerNews ??= new IconData("Hacker News", "\U0000F1D4", Styles.Brands, new string[] { "developer news", "hacker news", "hn", "news aggregator", "programming", "social news", "startup news", "tech news", "technology" });
        private static IconData _Hackerrank;
        public static IconData FA_Hackerrank => _Hackerrank ??= new IconData("Hackerrank", "\U0000F5F7", Styles.Brands, new string[] { "challenges", "code practice", "coding", "competitive programming", "developer", "hacker rank", "hackerrank", "interview", "programming", "tech" });
        private static IconData _Hammer;
        public static IconData FA_Hammer => _Hammer ??= new IconData("Hammer", "\U0000F6E3", Styles.Solid, new string[] { "DIY", "building", "carpentry", "construction", "equipment", "fix", "hammer", "hardware", "maintenance", "manual tool", "repair", "tool", "toolset", "workshop" });
        private static IconData _Hamsa;
        public static IconData FA_Hamsa => _Hamsa ??= new IconData("Hamsa", "\U0000F665", Styles.Solid, new string[] { "amulet", "blessing", "evil eye", "good luck", "hand", "islam", "jewish", "judaism", "middle east", "muslim", "north africa", "protection", "spirituality", "talisman" });
        private static IconData _Hand;
        public static IconData FA_Hand => _Hand ??= new IconData("Hand", "\U0000F256", Styles.Regular | Styles.Solid, new string[] { "backhand", "gesture", "halt", "hand", "high five", "palm", "raised hand", "request", "roshambo", "signal", "stop", "wave" });
        private static IconData _HandBackFist;
        public static IconData FA_HandBackFist => _HandBackFist ??= new IconData("Hand Back Fist", "\U0000F255", Styles.Regular | Styles.Solid, new string[] { "closed hand", "fist", "game", "gesture", "hand", "punch", "rock", "roshambo", "strike" });
        private static IconData _HandDots;
        public static IconData FA_HandDots => _HandDots ??= new IconData("Hand Dots", "\U0000F461", Styles.Solid, new string[] { "allergy", "dermatology", "dots", "eczema", "freckles", "hand", "hives", "irritation", "palm", "pox", "rash", "skin", "spots" });
        private static IconData _HandFist;
        public static IconData FA_HandFist => _HandFist ??= new IconData("Hand Fist", "\U0000F6DE", Styles.Solid, new string[] { "Dungeons & Dragons", "boxing", "clenched", "combat", "d&d", "dnd", "fantasy", "fight", "fist", "hand", "ki", "martial arts", "monk", "power", "punch", "raised fist", "resistance", "strength", "unarmed combat" });
        private static IconData _HandHolding;
        public static IconData FA_HandHolding => _HandHolding ??= new IconData("Hand Holding", "\U0000F4BD", Styles.Solid, new string[] { "assistance", "carrying", "grasp", "hand", "help", "hold", "lift", "offering", "palm", "protection", "support" });
        private static IconData _HandHoldingDollar;
        public static IconData FA_HandHoldingDollar => _HandHoldingDollar ??= new IconData("Hand Holding Dollar", "\U0000F4C0", Styles.Solid, new string[] { "cash", "cost", "dollar", "donate", "donation", "earnings", "finance", "giving", "investment", "money", "payment", "premium", "price", "revenue", "salary", "wage" });
        private static IconData _HandHoldingDroplet;
        public static IconData FA_HandHoldingDroplet => _HandHoldingDroplet ??= new IconData("Hand Holding Droplet", "\U0000F4C1", Styles.Solid, new string[] { "blood", "care", "carry", "covid-19", "drop", "drought", "grow", "hand", "health", "lift", "protection", "sanitation", "support", "water" });
        private static IconData _HandHoldingHand;
        public static IconData FA_HandHoldingHand => _HandHoldingHand ??= new IconData("Hand Holding Hand", "\U0000E4F7", Styles.Solid, new string[] { "care", "compassion", "friendship", "give", "help", "hold", "partnership", "protect", "solidarity", "support", "teamwork", "together", "unity" });
        private static IconData _HandHoldingHeart;
        public static IconData FA_HandHoldingHeart => _HandHoldingHeart ??= new IconData("Hand Holding Heart", "\U0000F4BE", Styles.Solid, new string[] { "care", "charity", "compassion", "donate", "gift", "giving", "hand", "heart", "help", "holding", "kindness", "love", "support", "volunteer" });
        private static IconData _HandHoldingMedical;
        public static IconData FA_HandHoldingMedical => _HandHoldingMedical ??= new IconData("Hand Holding Medical", "\U0000E05C", Styles.Solid, new string[] { "aid", "assistance", "care", "charity", "covid-19", "donate", "healing", "health", "help", "medical", "protection", "support" });
        private static IconData _HandLizard;
        public static IconData FA_HandLizard => _HandLizard ??= new IconData("Hand Lizard", "\U0000F258", Styles.Regular | Styles.Solid, new string[] { "claw", "game", "hand gesture", "lizard", "reptile", "rock paper scissors", "roshambo", "sign" });
        private static IconData _HandMiddleFinger;
        public static IconData FA_HandMiddleFinger => _HandMiddleFinger ??= new IconData("Hand Middle Finger", "\U0000F806", Styles.Solid, new string[] { "disrespect", "finger", "flip the bird", "gesture", "hand", "hate", "insult", "middle finger", "obscene", "offensive", "rude", "swear", "vulgar" });
        private static IconData _HandPeace;
        public static IconData FA_HandPeace => _HandPeace ??= new IconData("Hand Peace", "\U0000F25B", Styles.Regular | Styles.Solid, new string[] { "gesture", "hand", "peace", "peace sign", "sign", "symbol", "truce", "two fingers", "v", "victory", "victory hand" });
        private static IconData _HandPointDown;
        public static IconData FA_HandPointDown => _HandPointDown ??= new IconData("Hand Point Down", "\U0000F0A7", Styles.Regular | Styles.Solid, new string[] { "arrow", "click", "cursor", "direction", "down", "finger", "gesture", "hand", "indicator", "point", "pointing", "select", "tap" });
        private static IconData _HandPointLeft;
        public static IconData FA_HandPointLeft => _HandPointLeft ??= new IconData("Hand Point Left", "\U0000F0A5", Styles.Regular | Styles.Solid, new string[] { "arrow", "back", "direction", "finger", "gesture", "hand", "indicate", "left", "point", "pointer", "previous", "select" });
        private static IconData _HandPointRight;
        public static IconData FA_HandPointRight => _HandPointRight ??= new IconData("Hand Point Right", "\U0000F0A4", Styles.Regular | Styles.Solid, new string[] { "arrow", "direction", "finger", "forward", "gesture", "hand", "next", "point", "pointer", "right" });
        private static IconData _HandPointUp;
        public static IconData FA_HandPointUp => _HandPointUp ??= new IconData("Hand Point Up", "\U0000F0A6", Styles.Regular | Styles.Solid, new string[] { "click", "direction", "finger", "gesture", "hand", "index", "indicate", "point up", "pointing up", "request", "select", "up", "upgrade" });
        private static IconData _HandPointer;
        public static IconData FA_HandPointer => _HandPointer ??= new IconData("Hand Pointer", "\U0000F25A", Styles.Regular | Styles.Solid, new string[] { "click", "cursor", "gesture", "hand", "hand-cursor", "interact", "pointer", "select", "tap", "touch" });
        private static IconData _HandScissors;
        public static IconData FA_HandScissors => _HandScissors ??= new IconData("Hand Scissors", "\U0000F257", Styles.Regular | Styles.Solid, new string[] { "cut", "fingers", "game", "hand gesture", "peace sign", "rock paper scissors", "roshambo", "scissors", "victory" });
        private static IconData _HandSparkles;
        public static IconData FA_HandSparkles => _HandSparkles ??= new IconData("Hand Sparkles", "\U0000E05D", Styles.Solid, new string[] { "clean", "disinfect", "fresh", "glow", "handwashing", "hygiene", "magic", "palm", "sanitizer", "shiny", "sparkle", "wash" });
        private static IconData _HandSpock;
        public static IconData FA_HandSpock => _HandSpock ??= new IconData("Hand Spock", "\U0000F259", Styles.Regular | Styles.Solid, new string[] { "finger", "gesture", "greeting", "hand", "hello", "live long", "peace", "prosper", "salute", "sci-fi", "sign", "spock", "star trek", "vulcan", "vulcan salute" });
        private static IconData _Handcuffs;
        public static IconData FA_Handcuffs => _Handcuffs ??= new IconData("Handcuffs", "\U0000E4F8", Styles.Solid, new string[] { "arrest", "criminal", "cuffs", "detention", "handcuffs", "jail", "law enforcement", "police", "prisoner", "restraint", "security", "shackles", "wrist" });
        private static IconData _Hands;
        public static IconData FA_Hands => _Hands ??= new IconData("Hands", "\U0000F2A7", Styles.Solid, new string[] { "asl", "communication", "deaf", "fingers", "gesture", "hand signal", "hands", "manual", "palm", "sign language", "translate" });
        private static IconData _HandsAslInterpreting;
        public static IconData FA_HandsAslInterpreting => _HandsAslInterpreting ??= new IconData("Hands Asl Interpreting", "\U0000F2A3", Styles.Solid, new string[] { "asl", "communication", "deaf", "fingerspelling", "gesture", "hand", "interpreting", "language", "sign language", "translate" });
        private static IconData _HandsBound;
        public static IconData FA_HandsBound => _HandsBound ??= new IconData("Hands Bound", "\U0000E4F9", Styles.Solid, new string[] { "abduction", "bound", "captivity", "handcuffs", "hands tied", "kidnapping", "prisoner", "restrained", "tied", "wrists" });
        private static IconData _HandsBubbles;
        public static IconData FA_HandsBubbles => _HandsBubbles ??= new IconData("Hands Bubbles", "\U0000E05E", Styles.Solid, new string[] { "bubbles", "clean", "germ", "handwashing", "health", "hygiene", "protection", "sanitizer", "soap", "wash" });
        private static IconData _HandsClapping;
        public static IconData FA_HandsClapping => _HandsClapping ??= new IconData("Hands Clapping", "\U0000E1A8", Styles.Solid, new string[] { "applause", "approval", "celebrate", "cheer", "clap", "clapping", "congratulations", "hands", "ovation", "praise" });
        private static IconData _HandsHolding;
        public static IconData FA_HandsHolding => _HandsHolding ??= new IconData("Hands Holding", "\U0000F4C2", Styles.Solid, new string[] { "assistance", "care", "carry", "giving", "hands", "help", "hold", "lift", "offering", "protection", "support" });
        private static IconData _HandsHoldingChild;
        public static IconData FA_HandsHoldingChild => _HandsHoldingChild ??= new IconData("Hands Holding Child", "\U0000E4FA", Styles.Solid, new string[] { "care", "child", "family", "give", "guardian", "help", "hold", "love", "nurture", "parent", "protect", "safety", "shelter", "support" });
        private static IconData _HandsHoldingCircle;
        public static IconData FA_HandsHoldingCircle => _HandsHoldingCircle ??= new IconData("Hands Holding Circle", "\U0000E4FB", Styles.Solid, new string[] { "care", "charity", "circle", "community", "giving", "hands", "help", "holding", "protection", "safety", "support" });
        private static IconData _HandsPraying;
        public static IconData FA_HandsPraying => _HandsPraying ??= new IconData("Hands Praying", "\U0000F684", Styles.Solid, new string[] { "blessing", "devotion", "faith", "gesture", "hands", "hope", "kneel", "meditate", "pray", "prayer", "praying", "religion", "spirituality", "worship" });
        private static IconData _Handshake;
        public static IconData FA_Handshake => _Handshake ??= new IconData("Handshake", "\U0000F2B5", Styles.Regular | Styles.Solid, new string[] { "agreement", "alliance", "collaboration", "contract", "cooperation", "deal", "greeting", "handshake", "meeting", "negotiation", "partnership", "trust", "welcome" });
        private static IconData _HandshakeAngle;
        public static IconData FA_HandshakeAngle => _HandshakeAngle ??= new IconData("Handshake Angle", "\U0000F4C4", Styles.Solid, new string[] { "agreement", "aid", "assistance", "collaboration", "cooperation", "deal", "greeting", "handshake", "partnership", "support", "teamwork", "volunteering" });
        private static IconData _HandshakeSlash;
        public static IconData FA_HandshakeSlash => _HandshakeSlash ??= new IconData("Handshake Slash", "\U0000E060", Styles.Solid, new string[] { "avoid", "broken", "cancel", "covid-19", "disabled", "handshake", "no handshake", "prevent", "prohibition", "social distance", "stop" });
        private static IconData _Hanukiah;
        public static IconData FA_Hanukiah => _Hanukiah ??= new IconData("Hanukiah", "\U0000F6E6", Styles.Solid, new string[] { "candelabrum", "candle", "candlestick", "celebration", "dreidel", "eight-branch menorah", "festival", "hanukiah", "hanukkah", "holiday", "jewish", "judaism", "light", "menorah", "religious symbol", "ritual", "tradition" });
        private static IconData _HardDrive;
        public static IconData FA_HardDrive => _HardDrive ??= new IconData("Hard Drive", "\U0000F0A0", Styles.Regular | Styles.Solid, new string[] { "backup", "computer", "data", "device", "disk", "drive", "hard disk", "hard drive", "hardware", "hdd", "save", "storage", "storage device" });
        private static IconData _Hashnode;
        public static IconData FA_Hashnode => _Hashnode ??= new IconData("Hashnode", "\U0000E499", Styles.Brands, new string[] { "articles", "blogging", "content platform", "developer blog", "developer community", "developer platform", "hashnode", "programming", "tech blog", "writing" });
        private static IconData _Hashtag;
        public static IconData FA_Hashtag => _Hashtag ??= new IconData("Hashtag", "\U00000023", Styles.Solid, new string[] { "grid", "hashtag", "instagram", "label", "metadata", "number sign", "pound sign", "sharp", "social media", "tag", "topic", "trending", "twitter" });
        private static IconData _HatCowboy;
        public static IconData FA_HatCowboy => _HatCowboy ??= new IconData("Hat Cowboy", "\U0000F8C0", Styles.Solid, new string[] { "buckaroo", "cattle", "cowboy", "frontier", "hat", "horseman", "jackeroo", "old west", "pardner", "ranch", "rancher", "rodeo", "western", "wrangler" });
        private static IconData _HatCowboySide;
        public static IconData FA_HatCowboySide => _HatCowboySide ??= new IconData("Hat Cowboy Side", "\U0000F8C1", Styles.Solid, new string[] { "buckaroo", "cowboy", "frontier", "hat", "horseman", "old west", "pardner", "ranch", "rancher", "rodeo", "side profile", "western", "wild west", "wrangler" });
        private static IconData _HatWizard;
        public static IconData FA_HatWizard => _HatWizard ??= new IconData("Hat Wizard", "\U0000F6E8", Styles.Solid, new string[] { "accessory", "costume", "d&d", "dnd", "dungeons & dragons", "fantasy", "halloween", "hat", "headwear", "mage", "magic", "pointy hat", "witch", "wizard" });
        private static IconData _HeadSideCough;
        public static IconData FA_HeadSideCough => _HeadSideCough ??= new IconData("Head Side Cough", "\U0000E061", Styles.Solid, new string[] { "cold", "cough", "covid-19", "flu", "germs", "health", "illness", "infection", "lungs", "medical", "respiratory", "sick", "symptom", "virus" });
        private static IconData _HeadSideCoughSlash;
        public static IconData FA_HeadSideCoughSlash => _HeadSideCoughSlash ??= new IconData("Head Side Cough Slash", "\U0000E062", Styles.Solid, new string[] { "cough", "covid-19", "germs", "health", "illness", "infection", "lungs", "respiratory", "sick", "symptom", "virus" });
        private static IconData _HeadSideMask;
        public static IconData FA_HeadSideMask => _HeadSideMask ??= new IconData("Head Side Mask", "\U0000E063", Styles.Solid, new string[] { "airborne", "breath", "coronavirus", "covid-19", "face mask", "filter", "flu", "health", "hygiene", "infection", "mask", "medical mask", "pandemic", "pollution", "protection", "respirator", "safety", "sneeze", "virus" });
        private static IconData _HeadSideVirus;
        public static IconData FA_HeadSideVirus => _HeadSideVirus ??= new IconData("Head Side Virus", "\U0000E064", Styles.Solid, new string[] { "cold", "contagious", "coronavirus", "covid-19", "disease", "fever", "flu", "headache", "illness", "infection", "pandemic", "sick", "symptom", "virus" });
        private static IconData _Heading;
        public static IconData FA_Heading => _Heading ??= new IconData("Heading", "\U0000F1DC", Styles.Solid, new string[] { "caption", "format", "header", "heading", "headline", "label", "section", "text", "title" });
        private static IconData _Headphones;
        public static IconData FA_Headphones => _Headphones ??= new IconData("Headphones", "\U0000F025", Styles.Regular | Styles.Solid, new string[] { "audio", "audio device", "earbuds", "earphones", "headphones", "headset", "listen", "music", "music player", "sound", "stereo" });
        private static IconData _Headset;
        public static IconData FA_Headset => _Headset ??= new IconData("Headset", "\U0000F590", Styles.Solid, new string[] { "audio", "call center", "communication", "customer service", "gamer", "gaming", "headphones", "headset mic", "listen", "live chat", "microphone", "sound", "support", "telemarketer" });
        private static IconData _Heart;
        public static IconData FA_Heart => _Heart ??= new IconData("Heart", "\U0000F004", Styles.Regular | Styles.Solid, new string[] { "affection", "card", "emotion", "favorite", "heart", "heart suit", "like", "love", "passion", "playing card", "relationship", "romance", "symbol", "valentine", "wishlist" });
        private static IconData _HeartCircleBolt;
        public static IconData FA_HeartCircleBolt => _HeartCircleBolt ??= new IconData("Heart Circle Bolt", "\U0000E4FC", Styles.Solid, new string[] { "bolt", "cardiogram", "cardiology", "ekg", "electric", "energy", "health", "heart", "heartbeat", "love", "medical", "pacemaker", "pulse" });
        private static IconData _HeartCircleCheck;
        public static IconData FA_HeartCircleCheck => _HeartCircleCheck ??= new IconData("Heart Circle Check", "\U0000E4FD", Styles.Solid, new string[] { "approve", "check", "confirm", "enabled", "favorite", "heart", "love", "ok", "okay", "positive", "success", "validate", "verified" });
        private static IconData _HeartCircleExclamation;
        public static IconData FA_HeartCircleExclamation => _HeartCircleExclamation ??= new IconData("Heart Circle Exclamation", "\U0000E4FE", Styles.Solid, new string[] { "alert", "attention", "caution", "error", "exclamation", "favorite", "heart", "important", "love", "warning" });
        private static IconData _HeartCircleMinus;
        public static IconData FA_HeartCircleMinus => _HeartCircleMinus ??= new IconData("Heart Circle Minus", "\U0000E4FF", Styles.Solid, new string[] { "circle", "delete", "dislike", "favorite", "heart", "love", "minus", "remove", "subtract", "unfavorite", "unlike" });
        private static IconData _HeartCirclePlus;
        public static IconData FA_HeartCirclePlus => _HeartCirclePlus ??= new IconData("Heart Circle Plus", "\U0000E500", Styles.Solid, new string[] { "add", "care", "favorite", "follow", "health", "heart", "like", "love", "new", "plus", "save", "support" });
        private static IconData _HeartCircleXmark;
        public static IconData FA_HeartCircleXmark => _HeartCircleXmark ??= new IconData("Heart Circle Xmark", "\U0000E501", Styles.Solid, new string[] { "cancel", "close", "delete", "dislike", "favorite", "heart", "love", "negative", "no", "reject", "remove", "uncheck", "xmark" });
        private static IconData _HeartCrack;
        public static IconData FA_HeartCrack => _HeartCrack ??= new IconData("Heart Crack", "\U0000F7A9", Styles.Solid, new string[] { "break", "breakup", "broken heart", "crushed", "dislike", "dumped", "emotional pain", "grief", "heartbreak", "hurt", "love lost", "lovesick", "relationship", "sadness", "sorrow" });
        private static IconData _HeartPulse;
        public static IconData FA_HeartPulse => _HeartPulse ??= new IconData("Heart Pulse", "\U0000F21E", Styles.Solid, new string[] { "cardiology", "ekg", "electrocardiogram", "health", "heart rate", "heartbeat", "lifeline", "medical", "monitor", "pulse", "rhythm", "vital signs" });
        private static IconData _Helicopter;
        public static IconData FA_Helicopter => _Helicopter ??= new IconData("Helicopter", "\U0000F533", Styles.Solid, new string[] { "aircraft", "airwolf", "apache", "aviation", "chopper", "flight", "fly", "helicopter", "military", "rescue", "rotorcraft", "transport", "travel", "vehicle" });
        private static IconData _HelicopterSymbol;
        public static IconData FA_HelicopterSymbol => _HelicopterSymbol ??= new IconData("Helicopter Symbol", "\U0000E502", Styles.Solid, new string[] { "air ambulance", "aircraft", "chopper", "helicopter", "heliport", "landing pad", "medevac", "rescue", "rotorcraft", "whirlybird" });
        private static IconData _HelmetSafety;
        public static IconData FA_HelmetSafety => _HelmetSafety ??= new IconData("Helmet Safety", "\U0000F807", Styles.Solid, new string[] { "caution", "construction", "hardhat", "headgear", "helmet", "industrial", "protection", "safety", "safety-gear", "worker" });
        private static IconData _HelmetUn;
        public static IconData FA_HelmetUn => _HelmetUn ??= new IconData("Helmet Un", "\U0000E503", Styles.Solid, new string[] { "UN", "UN peacekeeper", "blue helmet", "helmet", "international organization", "military", "peace mission", "peacekeeper", "peacekeeping", "protective gear", "soldier", "united nations" });
        private static IconData _Hexagon;
        public static IconData FA_Hexagon => _Hexagon ??= new IconData("Hexagon", "\U0000F312", Styles.Solid, new string[] { "badge", "cell", "emblem", "geometry", "hexagon", "hexagonal", "honeycomb", "polygon", "shape", "six-sided", "tile" });
        private static IconData _HexagonNodes;
        public static IconData FA_HexagonNodes => _HexagonNodes ??= new IconData("Hexagon Nodes", "\U0000E699", Styles.Solid, new string[] { "ai", "artificial intelligence", "cluster", "connection", "data", "graph", "hexagon", "language", "llm", "machine learning", "model", "network", "neural", "neural network", "nodes" });
        private static IconData _HexagonNodesBolt;
        public static IconData FA_HexagonNodesBolt => _HexagonNodesBolt ??= new IconData("Hexagon Nodes Bolt", "\U0000E69A", Styles.Solid, new string[] { "AI", "LLM", "artificial intelligence", "bolt", "cluster", "connection", "data", "electric", "graph", "language", "lightning", "model", "network", "neural", "nodes" });
        private static IconData _Highlighter;
        public static IconData FA_Highlighter => _Highlighter ??= new IconData("Highlighter", "\U0000F591", Styles.Solid, new string[] { "annotate", "color", "draw", "edit", "emphasize", "highlight", "marker", "note", "pen", "underline", "write" });
        private static IconData _HillAvalanche;
        public static IconData FA_HillAvalanche => _HillAvalanche ??= new IconData("Hill Avalanche", "\U0000E507", Styles.Solid, new string[] { "avalanche", "hazard", "landslide", "mountain", "mudslide", "natural disaster", "slope", "snow", "snowslide", "winter" });
        private static IconData _HillRockslide;
        public static IconData FA_HillRockslide => _HillRockslide ??= new IconData("Hill Rockslide", "\U0000E508", Styles.Solid, new string[] { "avalanche", "debris flow", "earth movement", "erosion", "hill collapse", "landslide", "mudslide", "natural disaster", "rockslide", "slope failure" });
        private static IconData _Hippo;
        public static IconData FA_Hippo => _Hippo ??= new IconData("Hippo", "\U0000F6ED", Styles.Solid, new string[] { "African animal", "animal", "fauna", "hippo", "hippopotamus", "large animal", "mammal", "river horse", "safari", "wildlife" });
        private static IconData _Hips;
        public static IconData FA_Hips => _Hips ??= new IconData("Hips", "\U0000F452", Styles.Brands, new string[] { "anatomy", "body", "fitness", "health", "hips", "wellness" });
        private static IconData _HireAHelper;
        public static IconData FA_HireAHelper => _HireAHelper ??= new IconData("Hire A Helper", "\U0000F3B0", Styles.Brands, new string[] { "cleaning company", "cleaning service", "domestic help", "hire a helper", "home cleaning", "home help", "housekeeper", "maid service", "professional cleaner" });
        private static IconData _Hive;
        public static IconData FA_Hive => _Hive ??= new IconData("Hive", "\U0000E07F", Styles.Brands, new string[] { "blockchain", "crypto", "cryptocurrency", "decentralized", "hive", "hive blockchain", "hive social", "social media", "web3" });
        private static IconData _HockeyPuck;
        public static IconData FA_HockeyPuck => _HockeyPuck ??= new IconData("Hockey Puck", "\U0000F453", Styles.Solid, new string[] { "hockey", "ice", "ice hockey", "nhl", "puck", "puck shot", "rink", "sport", "stick and puck", "winter sport" });
        private static IconData _HollyBerry;
        public static IconData FA_HollyBerry => _HollyBerry ??= new IconData("Holly Berry", "\U0000F7AA", Styles.Solid, new string[] { "berry", "christmas", "decoration", "festive", "flora", "greenery", "holiday", "holly", "plant", "seasonal", "winter", "xmas" });
        private static IconData _Hooli;
        public static IconData FA_Hooli => _Hooli ??= new IconData("Hooli", "\U0000F427", Styles.Brands, new string[] { "Hooli", "Silicon Valley", "brand", "software", "tech company", "technology" });
        private static IconData _Hornbill;
        public static IconData FA_Hornbill => _Hornbill ??= new IconData("Hornbill", "\U0000F592", Styles.Brands, new string[] { "animal", "beak", "bird", "exotic bird", "hornbill", "nature", "tropical bird", "wildlife" });
        private static IconData _Horse;
        public static IconData FA_Horse => _Horse ??= new IconData("Horse", "\U0000F6F0", Styles.Solid, new string[] { "animal", "equestrian", "equine", "foal", "horse", "livestock", "mammal", "mare", "neigh", "pony", "racehorse", "racing", "stallion" });
        private static IconData _HorseHead;
        public static IconData FA_HorseHead => _HorseHead ??= new IconData("Horse Head", "\U0000F7AB", Styles.Solid, new string[] { "animal", "equestrian", "equus", "foal", "horse", "livestock", "mammal", "mare", "neigh", "pony", "stallion" });
        private static IconData _Hospital;
        public static IconData FA_Hospital => _Hospital ??= new IconData("Hospital", "\U0000F0F8", Styles.Regular | Styles.Solid, new string[] { "ER", "ambulance", "building", "clinic", "covid-19", "doctor", "emergency", "health", "healthcare", "hospital", "medical center", "medicine", "nurse", "treatment" });
        private static IconData _HospitalUser;
        public static IconData FA_HospitalUser => _HospitalUser ??= new IconData("Hospital User", "\U0000F80D", Styles.Solid, new string[] { "covid-19", "doctor", "health professional", "healthcare", "hospital", "medical", "nurse", "patient", "primary care", "staff", "user" });
        private static IconData _HotTubPerson;
        public static IconData FA_HotTubPerson => _HotTubPerson ??= new IconData("Hot Tub Person", "\U0000F593", Styles.Solid, new string[] { "bath", "bathing", "hot tub", "jacuzzi", "leisure", "person", "relaxation", "soak", "spa", "wellness" });
        private static IconData _Hotdog;
        public static IconData FA_Hotdog => _Hotdog ??= new IconData("Hotdog", "\U0000F80F", Styles.Solid, new string[] { "bun", "chili", "fast food", "frankfurt", "frankfurter", "hot dog", "hotdog", "kosher", "polish", "sandwich", "sausage", "snack", "street food", "vienna", "weiner" });
        private static IconData _Hotel;
        public static IconData FA_Hotel => _Hotel ??= new IconData("Hotel", "\U0000F594", Styles.Solid, new string[] { "accommodation", "building", "check-in", "hospitality", "hotel", "inn", "lodging", "motel", "overnight", "resort", "room", "stay", "travel", "vacation" });
        private static IconData _Hotjar;
        public static IconData FA_Hotjar => _Hotjar ??= new IconData("Hotjar", "\U0000F3B1", Styles.Brands, new string[] { "UX", "analytics", "conversion rate", "feedback", "heatmap", "hotjar", "session recording", "user behavior", "user experience", "website tracking" });
        private static IconData _Hourglass;
        public static IconData FA_Hourglass => _Hourglass ??= new IconData("Hourglass", "\U0000F254", Styles.Regular | Styles.Solid, new string[] { "countdown", "hourglass", "hourglass not done", "loading", "minute", "sand", "stopwatch", "time", "timer", "waiting" });
        private static IconData _HourglassEnd;
        public static IconData FA_HourglassEnd => _HourglassEnd ??= new IconData("Hourglass End", "\U0000F253", Styles.Solid, new string[] { "complete", "countdown", "elapsed", "end", "finished", "hourglass", "hourglass done", "sand", "time", "timer", "waiting" });
        private static IconData _HourglassHalf;
        public static IconData FA_HourglassHalf => _HourglassHalf ??= new IconData("Hourglass Half", "\U0000F252", Styles.Regular | Styles.Solid, new string[] { "clock", "countdown", "delay", "hourglass", "hourglass-half", "pending", "sand", "stopwatch", "time", "timer", "waiting" });
        private static IconData _HourglassStart;
        public static IconData FA_HourglassStart => _HourglassStart ??= new IconData("Hourglass Start", "\U0000F251", Styles.Solid, new string[] { "clock", "countdown", "duration", "elapsed", "hourglass", "sand", "stopwatch", "time", "timer", "waiting" });
        private static IconData _House;
        public static IconData FA_House => _House ??= new IconData("House", "\U0000F015", Styles.Regular | Styles.Solid, new string[] { "abode", "building", "domicile", "dwelling", "home", "house", "living place", "main", "property", "real estate", "residence", "shelter" });
        private static IconData _HouseChimney;
        public static IconData FA_HouseChimney => _HouseChimney ??= new IconData("House Chimney", "\U0000E3AF", Styles.Solid, new string[] { "abode", "building", "chimney", "dwelling", "hearth", "home", "house", "main house", "residence", "rooftop", "smoke" });
        private static IconData _HouseChimneyCrack;
        public static IconData FA_HouseChimneyCrack => _HouseChimneyCrack ??= new IconData("House Chimney Crack", "\U0000F6F1", Styles.Solid, new string[] { "broken", "building", "chimney", "crack", "damage", "disaster", "earthquake", "hazard", "home", "house", "insurance", "repair", "structural" });
        private static IconData _HouseChimneyMedical;
        public static IconData FA_HouseChimneyMedical => _HouseChimneyMedical ??= new IconData("House Chimney Medical", "\U0000F7F2", Styles.Solid, new string[] { "clinic", "covid-19", "doctor", "general practitioner", "health center", "health office", "healthcare", "hospital", "house call", "infirmary", "medical", "medical office", "outpatient", "telemedicine" });
        private static IconData _HouseChimneyUser;
        public static IconData FA_HouseChimneyUser => _HouseChimneyUser ??= new IconData("House Chimney User", "\U0000E065", Styles.Solid, new string[] { "family", "home", "house", "isolation", "occupant", "person", "quarantine", "resident", "shelter", "stay-at-home", "user" });
        private static IconData _HouseChimneyWindow;
        public static IconData FA_HouseChimneyWindow => _HouseChimneyWindow ??= new IconData("House Chimney Window", "\U0000E00D", Styles.Solid, new string[] { "abode", "building", "chimney", "domestic", "dwelling", "family", "home", "house", "property", "real estate", "residence", "shelter", "window" });
        private static IconData _HouseCircleCheck;
        public static IconData FA_HouseCircleCheck => _HouseCircleCheck ??= new IconData("House Circle Check", "\U0000E509", Styles.Solid, new string[] { "approved", "check", "confirmed", "enabled", "home", "house", "ok", "okay", "residence", "safe", "secure", "validate", "verified" });
        private static IconData _HouseCircleExclamation;
        public static IconData FA_HouseCircleExclamation => _HouseCircleExclamation ??= new IconData("House Circle Exclamation", "\U0000E50A", Styles.Solid, new string[] { "abode", "alert", "caution", "error", "exclamation", "home", "house", "issue", "notification", "problem", "residence", "warning" });
        private static IconData _HouseCircleXmark;
        public static IconData FA_HouseCircleXmark => _HouseCircleXmark ??= new IconData("House Circle Xmark", "\U0000E50B", Styles.Solid, new string[] { "abandon", "cancel", "cancelation", "circle-x", "clear", "close", "delete", "deny", "home", "house", "no", "reject", "remove", "uncheck", "xmark" });
        private static IconData _HouseCrack;
        public static IconData FA_HouseCrack => _HouseCrack ??= new IconData("House Crack", "\U0000E3B1", Styles.Solid, new string[] { "broken", "building", "collapse", "crack", "damage", "disaster", "earthquake", "home", "house", "insurance", "repair", "structural" });
        private static IconData _HouseFire;
        public static IconData FA_HouseFire => _HouseFire ??= new IconData("House Fire", "\U0000E50C", Styles.Solid, new string[] { "alarm", "blaze", "burning", "disaster", "emergency", "fire", "hazard", "home", "house", "rescue", "smoke" });
        private static IconData _HouseFlag;
        public static IconData FA_HouseFlag => _HouseFlag ??= new IconData("House Flag", "\U0000E50D", Styles.Solid, new string[] { "accommodation", "cabin", "camp", "campsite", "flag", "home", "house", "lodging", "residence", "shelter", "travel", "vacation" });
        private static IconData _HouseFloodWater;
        public static IconData FA_HouseFloodWater => _HouseFloodWater ??= new IconData("House Flood Water", "\U0000E50E", Styles.Solid, new string[] { "damage", "disaster", "emergency", "flood", "home", "house", "leak", "overflow", "property loss", "storm", "water", "wet" });
        private static IconData _HouseFloodWaterCircleArrowRight;
        public static IconData FA_HouseFloodWaterCircleArrowRight => _HouseFloodWaterCircleArrowRight ??= new IconData("House Flood Water Circle Arrow Right", "\U0000E50F", Styles.Solid, new string[] { "arrow", "damage", "disaster", "emergency", "evacuation", "flood", "home", "house", "insurance", "moving out", "natural disaster", "right", "water" });
        private static IconData _HouseLaptop;
        public static IconData FA_HouseLaptop => _HouseLaptop ??= new IconData("House Laptop", "\U0000E066", Styles.Solid, new string[] { "computer", "device", "home computer", "home office", "laptop", "online work", "remote work", "telecommute", "telework", "virtual office", "work from home" });
        private static IconData _HouseLock;
        public static IconData FA_HouseLock => _HouseLock ??= new IconData("House Lock", "\U0000E510", Styles.Solid, new string[] { "home", "house", "lock", "lockdown", "locked", "padlock", "privacy", "protected", "quarantine", "secure", "security" });
        private static IconData _HouseMedical;
        public static IconData FA_HouseMedical => _HouseMedical ??= new IconData("House Medical", "\U0000E3B2", Styles.Solid, new string[] { "clinic", "covid-19", "doctor", "emergency", "facility", "general practitioner", "health", "healthcare", "hospital", "infirmary", "medical", "medicine", "office", "outpatient", "treatment" });
        private static IconData _HouseMedicalCircleCheck;
        public static IconData FA_HouseMedicalCircleCheck => _HouseMedicalCircleCheck ??= new IconData("House Medical Circle Check", "\U0000E511", Styles.Solid, new string[] { "approved", "check", "clinic", "confirmed", "enable", "health", "hospital", "medical", "ok", "okay", "safe", "valid", "verified", "working" });
        private static IconData _HouseMedicalCircleExclamation;
        public static IconData FA_HouseMedicalCircleExclamation => _HouseMedicalCircleExclamation ??= new IconData("House Medical Circle Exclamation", "\U0000E512", Styles.Solid, new string[] { "alert", "care", "clinic", "emergency", "exclamation", "health", "hospital", "medical", "urgent", "warning" });
        private static IconData _HouseMedicalCircleXmark;
        public static IconData FA_HouseMedicalCircleXmark => _HouseMedicalCircleXmark ??= new IconData("House Medical Circle Xmark", "\U0000E513", Styles.Solid, new string[] { "cancel", "clinic", "close", "cross", "delete", "health", "hospital", "medical", "no", "remove", "stop", "xmark" });
        private static IconData _HouseMedicalFlag;
        public static IconData FA_HouseMedicalFlag => _HouseMedicalFlag ??= new IconData("House Medical Flag", "\U0000E514", Styles.Solid, new string[] { "aid", "clinic", "emergency", "field hospital", "first aid", "health", "healthcare", "hospital", "infirmary", "medical", "medical flag", "medical tent" });
        private static IconData _HouseSignal;
        public static IconData FA_HouseSignal => _HouseSignal ??= new IconData("House Signal", "\U0000E012", Styles.Solid, new string[] { "building", "connect", "connection", "family", "home", "house", "internet", "network", "residence", "signal", "smart home", "wifi", "wireless" });
        private static IconData _HouseTsunami;
        public static IconData FA_HouseTsunami => _HouseTsunami ??= new IconData("House Tsunami", "\U0000E515", Styles.Solid, new string[] { "disaster", "emergency", "flood", "house", "natural disaster", "storm surge", "tidal wave", "tsunami", "water damage", "wave" });
        private static IconData _HouseUser;
        public static IconData FA_HouseUser => _HouseUser ??= new IconData("House User", "\U0000E1B0", Styles.Solid, new string[] { "account", "family", "home", "house", "household", "occupant", "person", "profile", "resident", "user" });
        private static IconData _Houzz;
        public static IconData FA_Houzz => _Houzz ??= new IconData("Houzz", "\U0000F27C", Styles.Brands, new string[] { "architecture", "decor", "home design", "home improvement", "housing", "houzz", "interior design", "real estate", "remodeling", "renovation" });
        private static IconData _HryvniaSign;
        public static IconData FA_HryvniaSign => _HryvniaSign ??= new IconData("Hryvnia Sign", "\U0000F6F2", Styles.Solid, new string[] { "UAH", "Ukrainian currency", "cash", "currency", "currency symbol", "finance", "hryvnia", "hryvnia sign", "money" });
        private static IconData _Html5;
        public static IconData FA_Html5 => _Html5 ??= new IconData("Html5", "\U0000F13B", Styles.Brands, new string[] { "coding", "frontend", "html", "html5", "internet", "markup", "programming", "web", "web design", "web development" });
        private static IconData _Hubspot;
        public static IconData FA_Hubspot => _Hubspot ??= new IconData("Hubspot", "\U0000F3B2", Styles.Brands, new string[] { "business growth", "crm", "customer relationship management", "email marketing", "hubspot", "inbound marketing", "lead generation", "marketing automation", "marketing platform", "sales software" });
        private static IconData _HuggingFace;
        public static IconData FA_HuggingFace => _HuggingFace ??= new IconData("Hugging Face", "\U0000E869", Styles.Brands, new string[] { });
        private static IconData _Hurricane;
        public static IconData FA_Hurricane => _Hurricane ??= new IconData("Hurricane", "\U0000F751", Styles.Solid, new string[] { "coriolis effect", "cyclone", "eye", "hurricane", "natural disaster", "severe weather", "storm", "tropical cyclone", "typhoon", "weather", "wind" });
        private static IconData _I;
        public static IconData FA_I => _I ??= new IconData("I", "\U00000049", Styles.Solid, new string[] { "alphabet", "capital i", "character", "letter i", "lowercase i", "symbol", "text", "typography" });
        private static IconData _ICursor;
        public static IconData FA_ICursor => _ICursor ??= new IconData("I Cursor", "\U0000F246", Styles.Solid, new string[] { "cursor", "editing", "i-beam", "insertion", "text", "text-caret", "text-editing", "typing", "write", "writing" });
        private static IconData _IceCream;
        public static IconData FA_IceCream => _IceCream ??= new IconData("Ice Cream", "\U0000F810", Styles.Solid, new string[] { "chocolate", "cold", "cone", "dessert", "frozen", "frozen yogurt", "gelato", "ice cream", "scoop", "snack", "sorbet", "summer", "sweet", "treat", "vanilla" });
        private static IconData _Icicles;
        public static IconData FA_Icicles => _Icicles ??= new IconData("Icicles", "\U0000F7AD", Styles.Solid, new string[] { "chilly", "cold", "drip", "freeze", "frost", "frozen", "hanging", "ice", "icicle", "sharp", "winter" });
        private static IconData _Icons;
        public static IconData FA_Icons => _Icons ??= new IconData("Icons", "\U0000F86D", Styles.Solid, new string[] { "bolt", "electricity", "emoji", "energy", "flash", "icon", "lightning", "power", "sign", "symbol" });
        private static IconData _IdBadge;
        public static IconData FA_IdBadge => _IdBadge ??= new IconData("Id Badge", "\U0000F2C1", Styles.Regular | Styles.Solid, new string[] { "badge", "card", "contact", "credential", "id", "identification", "identity", "license", "name tag", "profile", "user", "username" });
        private static IconData _IdCard;
        public static IconData FA_IdCard => _IdCard ??= new IconData("Id Card", "\U0000F2C2", Styles.Regular | Styles.Solid, new string[] { "badge", "card", "contact", "credentials", "demographics", "document", "id", "identification", "identity", "license", "personal", "profile", "registration", "user", "username" });
        private static IconData _IdCardClip;
        public static IconData FA_IdCardClip => _IdCardClip ??= new IconData("Id Card Clip", "\U0000F47F", Styles.Solid, new string[] { "badge", "card", "contact", "credentials", "demographics", "document", "id", "identification", "identity", "license", "pass", "profile", "user", "username" });
        private static IconData _Ideal;
        public static IconData FA_Ideal => _Ideal ??= new IconData("Ideal", "\U0000E013", Styles.Brands, new string[] { "banking", "digital wallet", "ecommerce", "finance", "ideal", "ideal logo", "money transfer", "online payment", "payment" });
        private static IconData _Igloo;
        public static IconData FA_Igloo => _Igloo ??= new IconData("Igloo", "\U0000F7AE", Styles.Solid, new string[] { "arctic", "cold", "dome", "home", "house", "ice", "igloo", "inuit", "shelter", "snow", "snow house", "winter" });
        private static IconData _Image;
        public static IconData FA_Image => _Image ??= new IconData("Image", "\U0000F03E", Styles.Regular | Styles.Solid, new string[] { "gallery", "image", "image file", "landscape", "photo", "photo album", "photograph", "picture", "picture frame", "snapshot" });
        private static IconData _ImagePortrait;
        public static IconData FA_ImagePortrait => _ImagePortrait ??= new IconData("Image Portrait", "\U0000F3E0", Styles.Solid, new string[] { "avatar", "id", "image", "img", "photo", "picture", "portrait", "profile", "selfie", "user", "username" });
        private static IconData _Images;
        public static IconData FA_Images => _Images ??= new IconData("Images", "\U0000F302", Styles.Regular | Styles.Solid, new string[] { "album", "gallery", "image", "landscape", "media", "photo", "photo album", "photo gallery", "photograph", "picture", "picture frame", "snapshot" });
        private static IconData _Imdb;
        public static IconData FA_Imdb => _Imdb ??= new IconData("Imdb", "\U0000F2D8", Styles.Brands, new string[] { "entertainment", "films", "imdb", "internet movie database", "movies", "ratings", "reviews", "tv" });
        private static IconData _Inbox;
        public static IconData FA_Inbox => _Inbox ??= new IconData("Inbox", "\U0000F01C", Styles.Solid, new string[] { "archive", "box", "delivery", "email", "folder", "inbox", "incoming", "letters", "mail", "message", "post", "tray" });
        private static IconData _Indent;
        public static IconData FA_Indent => _Indent ??= new IconData("Indent", "\U0000F03C", Styles.Solid, new string[] { "align", "format", "indent", "justify", "layout", "margin", "paragraph", "spacing", "tab", "text-indent" });
        private static IconData _IndianRupeeSign;
        public static IconData FA_IndianRupeeSign => _IndianRupeeSign ??= new IconData("Indian Rupee Sign", "\U0000E1BC", Styles.Solid, new string[] { "INR", "Indian Rupee", "Indian currency", "currency", "financial", "money", "payment", "price", "rupee", "rupee symbol" });
        private static IconData _Industry;
        public static IconData FA_Industry => _Industry ??= new IconData("Industry", "\U0000F275", Styles.Solid, new string[] { "assembly", "building", "facility", "factory", "industrial", "industry", "manufacturing", "mill", "plant", "production", "warehouse", "workshop" });
        private static IconData _Infinity;
        public static IconData FA_Infinity => _Infinity ??= new IconData("Infinity", "\U0000F534", Styles.Solid, new string[] { "continuous", "endless", "eternity", "forever", "infinite", "infinity", "loop", "math", "symbol", "timeless", "unbounded", "universal" });
        private static IconData _Info;
        public static IconData FA_Info => _Info ??= new IconData("Info", "\U0000F129", Styles.Solid, new string[] { "about", "data", "details", "explanation", "facts", "guidance", "help", "info", "information", "more", "support" });
        private static IconData _Instagram;
        public static IconData FA_Instagram => _Instagram ??= new IconData("Instagram", "\U0000F16D", Styles.Brands, new string[] { "IG", "Instagram", "app", "feed", "filter", "influencer", "photo sharing", "reels", "social media", "social network", "stories" });
        private static IconData _Instalod;
        public static IconData FA_Instalod => _Instalod ??= new IconData("Instalod", "\U0000E081", Styles.Brands, new string[] { "app", "download", "file transfer", "installation", "instaload", "instalod", "software" });
        private static IconData _Intercom;
        public static IconData FA_Intercom => _Intercom ??= new IconData("Intercom", "\U0000F7AF", Styles.Brands, new string[] { "chat", "communication", "customer service", "customer support", "helpdesk", "intercom", "live chat", "messaging" });
        private static IconData _InternetExplorer;
        public static IconData FA_InternetExplorer => _InternetExplorer ??= new IconData("Internet Explorer", "\U0000F26B", Styles.Brands, new string[] { "browser", "explorer", "ie", "internet explorer", "legacy browser", "microsoft", "web" });
        private static IconData _Invision;
        public static IconData FA_Invision => _Invision ??= new IconData("Invision", "\U0000F7B0", Styles.Brands, new string[] { "app", "collaboration", "design", "interface", "invision", "prototyping", "ui", "ux" });
        private static IconData _Ioxhost;
        public static IconData FA_Ioxhost => _Ioxhost ??= new IconData("Ioxhost", "\U0000F208", Styles.Brands, new string[] { "cloud hosting", "hosting", "internet service", "ioxhost", "server", "web hosting", "web services" });
        private static IconData _Italic;
        public static IconData FA_Italic => _Italic ??= new IconData("Italic", "\U0000F033", Styles.Solid, new string[] { "emphasis", "emphasis-style", "font", "format", "formatting", "italic", "slant", "style", "text", "type", "typography" });
        private static IconData _ItchIo;
        public static IconData FA_ItchIo => _ItchIo ??= new IconData("Itch Io", "\U0000F83A", Styles.Brands, new string[] { "digital games", "game marketplace", "game store", "gaming platform", "indie developer", "indie games", "itch.io" });
        private static IconData _Itunes;
        public static IconData FA_Itunes => _Itunes ??= new IconData("Itunes", "\U0000F3B4", Styles.Brands, new string[] { "apple", "apple music", "audio player", "digital music", "itunes", "media player", "music app", "music download", "music library", "music store" });
        private static IconData _ItunesNote;
        public static IconData FA_ItunesNote => _ItunesNote ??= new IconData("Itunes Note", "\U0000F3B5", Styles.Brands, new string[] { "apple music", "audio", "itunes", "melody", "music", "note", "song", "sound" });
        private static IconData _J;
        public static IconData FA_J => _J ??= new IconData("J", "\U0000004A", Styles.Solid, new string[] { "Latin letter", "alphabet", "capital j", "character", "letter j", "lowercase j", "symbol", "text", "typography" });
        private static IconData _Jar;
        public static IconData FA_Jar => _Jar ??= new IconData("Jar", "\U0000E516", Styles.Solid, new string[] { "bottle", "canning", "container", "food", "glass", "jam", "jar", "jelly", "preserve", "storage" });
        private static IconData _JarWheat;
        public static IconData FA_JarWheat => _JarWheat ??= new IconData("Jar Wheat", "\U0000E517", Styles.Solid, new string[] { "baking", "cereal", "flour", "food container", "grain", "harvest", "ingredient", "jar", "pantry", "storage", "wheat" });
        private static IconData _Java;
        public static IconData FA_Java => _Java ??= new IconData("Java", "\U0000F4E4", Styles.Brands, new string[] { "coding", "coffee", "java", "java language", "java platform", "java programming", "jvm", "programming", "software development" });
        private static IconData _Jedi;
        public static IconData FA_Jedi => _Jedi ??= new IconData("Jedi", "\U0000F669", Styles.Solid, new string[] { "fantasy", "force", "galactic republic", "jedi", "jedi council", "jedi knight", "jedi master", "jedi order", "lightsaber", "padawan", "sci-fi", "skywalker", "space opera", "star wars", "yoda" });
        private static IconData _JediOrder;
        public static IconData FA_JediOrder => _JediOrder ??= new IconData("Jedi Order", "\U0000F50E", Styles.Brands, new string[] { "jedi", "jedi emblem", "jedi order", "jedi symbol", "star wars", "star wars emblem", "star wars logo", "star wars symbol", "starwars" });
        private static IconData _Jenkins;
        public static IconData FA_Jenkins => _Jenkins ??= new IconData("Jenkins", "\U0000F3B6", Styles.Brands, new string[] { "automation", "automation server", "build server", "ci", "continuous integration", "devops", "jenkins", "open source", "pipeline", "software development" });
        private static IconData _JetFighter;
        public static IconData FA_JetFighter => _JetFighter ??= new IconData("Jet Fighter", "\U0000F0FB", Styles.Solid, new string[] { "aircraft", "airforce", "airplane", "aviation", "combat", "fast", "fighter", "fly", "jet", "maverick", "military", "pilot", "plane", "top gun", "warplane" });
        private static IconData _JetFighterUp;
        public static IconData FA_JetFighterUp => _JetFighterUp ??= new IconData("Jet Fighter Up", "\U0000E518", Styles.Solid, new string[] { "aircraft", "airforce", "airplane", "aviation", "combat", "fast", "fighter", "fly", "jet", "military", "pilot", "plane", "top gun", "travel", "warplane" });
        private static IconData _Jira;
        public static IconData FA_Jira => _Jira ??= new IconData("Jira", "\U0000F7B1", Styles.Brands, new string[] { "agile", "atlassian", "bug tracking", "issue tracker", "jira", "kanban", "project management", "scrum", "software development", "task management" });
        private static IconData _Joget;
        public static IconData FA_Joget => _Joget ??= new IconData("Joget", "\U0000F3B7", Styles.Brands, new string[] { "app builder", "business process management", "joget", "joget workflow", "low code", "no code", "workflow automation" });
        private static IconData _Joint;
        public static IconData FA_Joint => _Joint ??= new IconData("Joint", "\U0000F595", Styles.Solid, new string[] { "blunt", "cannabis", "doobie", "ganja", "herb", "joint cigarette", "marijuana", "pot", "reefer", "roach", "rolled cigarette", "smoke", "smoking", "spliff", "weed" });
        private static IconData _Joomla;
        public static IconData FA_Joomla => _Joomla ??= new IconData("Joomla", "\U0000F1AA", Styles.Brands, new string[] { "cms", "content management system", "joomla", "joomla cms", "joomla logo", "open source", "php", "web platform", "website" });
        private static IconData _Js;
        public static IconData FA_Js => _Js ??= new IconData("Js", "\U0000F3B8", Styles.Brands, new string[] { "coding", "developer", "javascript", "js", "language", "programming", "script", "web", "web development" });
        private static IconData _Jsfiddle;
        public static IconData FA_Jsfiddle => _Jsfiddle ??= new IconData("Jsfiddle", "\U0000F1CC", Styles.Brands, new string[] { "code editor", "code snippet", "coding sandbox", "frontend playground", "javascript playground", "js", "js fiddle", "jsfiddle", "online editor", "programming tool", "web development" });
        private static IconData _JugDetergent;
        public static IconData FA_JugDetergent => _JugDetergent ??= new IconData("Jug Detergent", "\U0000E519", Styles.Solid, new string[] { "bottle", "cleaning", "detergent", "fabric softener", "jug", "laundry", "liquid detergent", "soap", "stain remover", "wash" });
        private static IconData _Julia;
        public static IconData FA_Julia => _Julia ??= new IconData("Julia", "\U0000E852", Styles.Brands, new string[] { });
        private static IconData _Jxl;
        public static IconData FA_Jxl => _Jxl ??= new IconData("Jxl", "\U0000E67B", Styles.Brands, new string[] { "codec", "graphics", "image format", "jpeg xl", "jxl", "photo", "picture" });
        private static IconData _K;
        public static IconData FA_K => _K ??= new IconData("K", "\U0000004B", Styles.Solid, new string[] { "alphabet", "capital k", "character", "letter k", "lowercase k", "symbol", "typography" });
        private static IconData _Kaaba;
        public static IconData FA_Kaaba => _Kaaba ??= new IconData("Kaaba", "\U0000F66B", Styles.Solid, new string[] { "cube", "hajj", "holy site", "islam", "kaaba", "mecca", "mosque", "muslim", "pilgrimage", "religion", "sacred", "worship" });
        private static IconData _Kaggle;
        public static IconData FA_Kaggle => _Kaggle ??= new IconData("Kaggle", "\U0000F5FA", Styles.Brands, new string[] { "AI", "analytics", "competitions", "data analysis", "data platform", "data science", "datasets", "kaggle", "machine learning" });
        private static IconData _KakaoTalk;
        public static IconData FA_KakaoTalk => _KakaoTalk ??= new IconData("Kakao Talk", "\U0000E7D7", Styles.Brands, new string[] { "chat", "instant messaging", "kakao", "kakao talk", "kakaotalk", "korean messenger", "messaging", "messenger", "mobile chat", "social app" });
        private static IconData _Key;
        public static IconData FA_Key => _Key ??= new IconData("Key", "\U0000F084", Styles.Solid, new string[] { "access", "authentication", "credential", "key", "keyhole", "lock", "passcode", "password", "private", "secret", "secure", "security", "unlock" });
        private static IconData _Keybase;
        public static IconData FA_Keybase => _Keybase ??= new IconData("Keybase", "\U0000F4F5", Styles.Brands, new string[] { "chat", "cryptography", "encryption", "identity", "keybase", "messaging", "security", "verification" });
        private static IconData _Keyboard;
        public static IconData FA_Keyboard => _Keyboard ??= new IconData("Keyboard", "\U0000F11C", Styles.Regular | Styles.Solid, new string[] { "accessory", "computer", "data entry", "device", "hardware", "input", "keyboard", "keypad", "keys", "text", "type", "typing", "write" });
        private static IconData _Keycdn;
        public static IconData FA_Keycdn => _Keycdn ??= new IconData("Keycdn", "\U0000F3BA", Styles.Brands, new string[] { "caching", "cdn", "cloud", "content delivery network", "hosting", "internet", "keycdn", "web performance" });
        private static IconData _Khanda;
        public static IconData FA_Khanda => _Khanda ??= new IconData("Khanda", "\U0000F66D", Styles.Solid, new string[] { "Adi Shakti", "Sikh emblem", "Sikh symbol", "chakkar", "double-edged sword", "emblem", "faith", "khanda", "religion", "sikh", "sikhism", "spiritual", "sword", "symbol", "warrior emblem" });
        private static IconData _Kickstarter;
        public static IconData FA_Kickstarter => _Kickstarter ??= new IconData("Kickstarter", "\U0000F3BB", Styles.Brands, new string[] { "backer", "campaign", "creative", "crowdfunding", "fundraising", "kickstarter", "pledge", "projects", "startup", "support" });
        private static IconData _KickstarterK;
        public static IconData FA_KickstarterK => _KickstarterK ??= new IconData("Kickstarter K", "\U0000F3BC", Styles.Brands, new string[] { "creative", "crowdfunding", "fundraising", "kickstarter", "ks", "projects", "startup" });
        private static IconData _KipSign;
        public static IconData FA_KipSign => _KipSign ??= new IconData("Kip Sign", "\U0000E1C4", Styles.Solid, new string[] { "cash", "currency", "currency symbol", "kip", "kip sign", "laos", "laos kip", "laotian currency", "laotian kip", "money" });
        private static IconData _KitMedical;
        public static IconData FA_KitMedical => _KitMedical ??= new IconData("Kit Medical", "\U0000F479", Styles.Solid, new string[] { "aid", "doctor", "emergency", "emt", "first aid", "health", "healthcare", "hospital", "kit", "medical", "medicine", "nurse", "rescue", "treatment" });
        private static IconData _KitchenSet;
        public static IconData FA_KitchenSet => _KitchenSet ??= new IconData("Kitchen Set", "\U0000E51A", Styles.Solid, new string[] { "bake", "chef", "cook", "cooking utensils", "cookware", "frying pan", "kitchen", "kitchenware", "meal prep", "pan", "pot", "skillet", "stove" });
        private static IconData _KiwiBird;
        public static IconData FA_KiwiBird => _KiwiBird ??= new IconData("Kiwi Bird", "\U0000F535", Styles.Solid, new string[] { "animal", "bird", "birdwatching", "endangered", "fauna", "flightless", "kiwi", "native", "new zealand", "wildlife" });
        private static IconData _KoFi;
        public static IconData FA_KoFi => _KoFi ??= new IconData("Ko Fi", "\U0000E856", Styles.Brands, new string[] { });
        private static IconData _Korvue;
        public static IconData FA_Korvue => _Korvue ??= new IconData("Korvue", "\U0000F42F", Styles.Brands, new string[] { "korvue", "korvue app", "korvue brand", "korvue logo", "korvue software" });
        private static IconData _Kubernetes;
        public static IconData FA_Kubernetes => _Kubernetes ??= new IconData("Kubernetes", "\U0000E857", Styles.Brands, new string[] { });
        private static IconData _L;
        public static IconData FA_L => _L ??= new IconData("L", "\U0000004C", Styles.Solid, new string[] { "Latin letter", "alphabet", "capital L", "character", "letter L", "lowercase L", "symbol" });
        private static IconData _LandMineOn;
        public static IconData FA_LandMineOn => _LandMineOn ??= new IconData("Land Mine On", "\U0000E51B", Styles.Solid, new string[] { "battlefield", "bomb", "danger", "explosion", "explosive", "hazard", "landmine", "military", "mine", "threat", "war", "weapon" });
        private static IconData _Landmark;
        public static IconData FA_Landmark => _Landmark ??= new IconData("Landmark", "\U0000F66F", Styles.Solid, new string[] { "architecture", "attraction", "building", "culture", "famous", "heritage", "historic", "memorial", "monument", "notable", "politics", "site", "society", "tourist" });
        private static IconData _LandmarkDome;
        public static IconData FA_LandmarkDome => _LandmarkDome ??= new IconData("Landmark Dome", "\U0000F752", Styles.Solid, new string[] { "architecture", "building", "capitol", "dome", "government", "heritage", "historic", "landmark", "monument", "parliament", "political", "structure" });
        private static IconData _LandmarkFlag;
        public static IconData FA_LandmarkFlag => _LandmarkFlag ??= new IconData("Landmark Flag", "\U0000E51C", Styles.Solid, new string[] { "building", "capitol", "flag", "government", "historic", "landmark", "memorial", "monument", "national", "patriotic", "symbol" });
        private static IconData _Language;
        public static IconData FA_Language => _Language ??= new IconData("Language", "\U0000F1AB", Styles.Solid, new string[] { "alphabet", "communication", "dialect", "idiom", "language", "linguistics", "localization", "localize", "speech", "text", "translate", "translation", "vernacular", "words" });
        private static IconData _Laptop;
        public static IconData FA_Laptop => _Laptop ??= new IconData("Laptop", "\U0000F109", Styles.Solid, new string[] { "computer", "dell", "device", "electronics", "laptop", "mac", "macbook", "notebook", "pc", "personal computer", "portable", "technology" });
        private static IconData _LaptopCode;
        public static IconData FA_LaptopCode => _LaptopCode ??= new IconData("Laptop Code", "\U0000F5FC", Styles.Solid, new string[] { "code", "coding", "computer", "developer", "development", "device", "laptop", "mac", "macbook", "machine", "pc", "programming", "programming language", "software", "tech" });
        private static IconData _LaptopFile;
        public static IconData FA_LaptopFile => _LaptopFile ??= new IconData("Laptop File", "\U0000E51D", Styles.Solid, new string[] { "computer", "digital file", "document", "education", "file", "laptop", "learning", "online learning", "remote work", "report", "screen", "technology", "work from home" });
        private static IconData _LaptopMedical;
        public static IconData FA_LaptopMedical => _LaptopMedical ??= new IconData("Laptop Medical", "\U0000F812", Styles.Solid, new string[] { "computer", "device", "digital health", "ehr", "electronic health records", "health", "healthcare", "history", "laptop", "medical", "medical records", "patient", "telemedicine" });
        private static IconData _Laravel;
        public static IconData FA_Laravel => _Laravel ??= new IconData("Laravel", "\U0000F3BD", Styles.Brands, new string[] { "artisan", "backend", "developer", "eloquent", "laravel", "mvc", "open source", "php", "php framework", "web framework" });
        private static IconData _LariSign;
        public static IconData FA_LariSign => _LariSign ??= new IconData("Lari Sign", "\U0000E1C8", Styles.Solid, new string[] { "Georgian currency", "cash", "currency", "currency sign", "financial", "lari", "money", "payment", "price", "symbol" });
        private static IconData _Lastfm;
        public static IconData FA_Lastfm => _Lastfm ??= new IconData("Lastfm", "\U0000F202", Styles.Brands, new string[] { "artist", "audio", "band", "last.fm", "lastfm", "music", "playlist", "radio", "scrobble", "social music", "streaming" });
        private static IconData _LayerGroup;
        public static IconData FA_LayerGroup => _LayerGroup ??= new IconData("Layer Group", "\U0000F5FD", Styles.Solid, new string[] { "arrangement", "category", "cluster", "collection", "group", "layers", "map", "organize", "overlay", "panel", "set", "stack" });
        private static IconData _Leaf;
        public static IconData FA_Leaf => _Leaf ??= new IconData("Leaf", "\U0000F06C", Styles.Solid, new string[] { "botany", "eco", "environment", "flora", "foliage", "garden", "green", "herb", "leaf", "natural", "nature", "organic", "plant", "sustainable", "vegan" });
        private static IconData _Leanpub;
        public static IconData FA_Leanpub => _Leanpub ??= new IconData("Leanpub", "\U0000F212", Styles.Brands, new string[] { "author platform", "book platform", "digital publishing", "ebooks", "leanpub", "online books", "publishing", "self-publishing" });
        private static IconData _Leetcode;
        public static IconData FA_Leetcode => _Leetcode ??= new IconData("Leetcode", "\U0000E86A", Styles.Brands, new string[] { });
        private static IconData _LeftLong;
        public static IconData FA_LeftLong => _LeftLong ??= new IconData("Left Long", "\U0000F30A", Styles.Solid, new string[] { "arrow-left", "back", "go back", "left", "long arrow", "previous", "return", "rewind", "undo" });
        private static IconData _LeftRight;
        public static IconData FA_LeftRight => _LeftRight ??= new IconData("Left Right", "\U0000F337", Styles.Solid, new string[] { "adjust", "arrow", "arrows-h", "direction", "drag", "expand", "horizontal", "left arrow", "left-right", "move", "resize", "right arrow", "slider", "wide" });
        private static IconData _Lemon;
        public static IconData FA_Lemon => _Lemon ??= new IconData("Lemon", "\U0000F094", Styles.Regular | Styles.Solid, new string[] { "citrus", "citrus fruit", "fruit", "lemon", "lemonade", "refreshing", "sour", "summer", "tart", "vitamin C", "yellow" });
        private static IconData _Leo;
        public static IconData FA_Leo => _Leo ??= new IconData("Leo", "\U0000E84A", Styles.Solid, new string[] { "astrology", "august", "constellation", "fire sign", "horoscope", "july", "leo", "lion", "sign", "stars", "zodiac" });
        private static IconData _Less;
        public static IconData FA_Less => _Less ??= new IconData("Less", "\U0000F41D", Styles.Brands, new string[] { "coding", "css", "design", "frontend", "less", "lesscss", "preprocessor", "style", "stylesheet", "web development" });
        private static IconData _LessThan;
        public static IconData FA_LessThan => _LessThan ??= new IconData("Less Than", "\U0000003C", Styles.Solid, new string[] { "arithmetic", "comparison", "comparison operator", "inequality", "less than", "less-than sign", "math", "math symbol", "operator", "symbol" });
        private static IconData _LessThanEqual;
        public static IconData FA_LessThanEqual => _LessThanEqual ??= new IconData("Less Than Equal", "\U0000F537", Styles.Solid, new string[] { "arithmetic", "compare", "comparison", "inequality", "less than or equal", "math", "math operator", "relational operator", "symbol" });
        private static IconData _Letterboxd;
        public static IconData FA_Letterboxd => _Letterboxd ??= new IconData("Letterboxd", "\U0000E62D", Styles.Brands, new string[] { "cinema", "film community", "films", "letterboxd", "movie", "movies app", "ratings", "reviews", "social network", "watchlist" });
        private static IconData _Libra;
        public static IconData FA_Libra => _Libra ??= new IconData("Libra", "\U0000E84B", Styles.Solid, new string[] { "air sign", "astrology", "constellation", "horoscope", "libra", "october", "scales", "september", "sign", "stars", "zodiac" });
        private static IconData _LifeRing;
        public static IconData FA_LifeRing => _LifeRing ??= new IconData("Life Ring", "\U0000F1CD", Styles.Regular | Styles.Solid, new string[] { "coast guard", "emergency", "flotation", "help", "life preserver", "lifebuoy", "lifesaver", "overboard", "rescue", "safety", "save", "support" });
        private static IconData _Lightbulb;
        public static IconData FA_Lightbulb => _Lightbulb ??= new IconData("Lightbulb", "\U0000F0EB", Styles.Regular | Styles.Solid, new string[] { "bright", "bulb", "concept", "creativity", "electric", "electricity", "energy", "idea", "innovation", "inspiration", "invention", "lamp", "light", "light bulb", "thinking" });
        private static IconData _Line;
        public static IconData FA_Line => _Line ??= new IconData("Line", "\U0000F3C0", Styles.Brands, new string[] { "border", "divider", "line", "lines", "path", "rule", "separator", "stroke" });
        private static IconData _LinesLeaning;
        public static IconData FA_LinesLeaning => _LinesLeaning ??= new IconData("Lines Leaning", "\U0000E51E", Styles.Solid, new string[] { "angled", "canted", "diagonal", "domino", "falling", "imbalance", "leaning", "leaning tower", "slanted", "sloping", "tilted", "tipped" });
        private static IconData _Link;
        public static IconData FA_Link => _Link ??= new IconData("Link", "\U0000F0C1", Styles.Solid, new string[] { "attach", "attachment", "bond", "chain", "connect", "connection", "fasten", "hyperlink", "join", "link", "url" });
        private static IconData _LinkSlash;
        public static IconData FA_LinkSlash => _LinkSlash ??= new IconData("Link Slash", "\U0000F127", Styles.Solid, new string[] { "attachment", "broken", "broken link", "cancel", "chain", "disable", "disabled", "disconnect", "link", "remove", "slash", "unlink" });
        private static IconData _Linkedin;
        public static IconData FA_Linkedin => _Linkedin ??= new IconData("Linkedin", "\U0000F08C", Styles.Brands, new string[] { "business", "career", "jobs", "linkedin", "linkedin-square", "professional network", "social media" });
        private static IconData _LinkedinIn;
        public static IconData FA_LinkedinIn => _LinkedinIn ??= new IconData("Linkedin In", "\U0000F0E1", Styles.Brands, new string[] { "business networking", "linkedin", "linkedin icon", "linkedin logo", "linkin", "professional network", "social media" });
        private static IconData _Linktree;
        public static IconData FA_Linktree => _Linktree ??= new IconData("Linktree", "\U0000E7D8", Styles.Brands, new string[] { "bio link", "link aggregator", "link landing page", "link tree", "links", "linktree", "profile links", "social links" });
        private static IconData _Linode;
        public static IconData FA_Linode => _Linode ??= new IconData("Linode", "\U0000F2B8", Styles.Brands, new string[] { "VPS", "cloud computing", "cloud hosting", "cloud infrastructure", "cloud server", "hosting provider", "linode", "linode cloud", "virtual server" });
        private static IconData _Linux;
        public static IconData FA_Linux => _Linux ??= new IconData("Linux", "\U0000F17C", Styles.Brands, new string[] { "distro", "kernel", "linux", "open source", "operating system", "penguin", "tux" });
        private static IconData _LiraSign;
        public static IconData FA_LiraSign => _LiraSign ??= new IconData("Lira Sign", "\U0000F195", Styles.Solid, new string[] { "cash", "currency", "finance", "lira", "money", "payment", "symbol", "turkish currency", "turkish lira", "turkish money" });
        private static IconData _List;
        public static IconData FA_List => _List ??= new IconData("List", "\U0000F03A", Styles.Solid, new string[] { "bullet", "checklist", "completed", "done", "finished", "items", "list", "ol", "ordered", "outline", "points", "summary", "tasks", "todo", "ul", "unordered" });
        private static IconData _ListCheck;
        public static IconData FA_ListCheck => _ListCheck ??= new IconData("List Check", "\U0000F0AE", Styles.Solid, new string[] { "approve", "checklist", "completed", "done", "mark", "progress", "project management", "summary", "task list", "tick", "to do", "verify" });
        private static IconData _ListOl;
        public static IconData FA_ListOl => _ListOl ??= new IconData("List Ol", "\U0000F0CB", Styles.Solid, new string[] { "checklist", "items", "list", "numbered list", "numbers", "ol", "ordered list", "outline", "sequence", "steps", "tasks", "todo" });
        private static IconData _ListUl;
        public static IconData FA_ListUl => _ListUl ??= new IconData("List Ul", "\U0000F0CA", Styles.Solid, new string[] { "bullet", "checklist", "items", "list", "points", "summary", "survey", "tasks", "todo", "ul", "unordered", "unordered list" });
        private static IconData _LitecoinSign;
        public static IconData FA_LitecoinSign => _LitecoinSign ??= new IconData("Litecoin Sign", "\U0000E1D3", Styles.Solid, new string[] { "LTC", "blockchain", "coin", "crypto", "cryptocurrency", "currency", "digital currency", "litecoin", "token" });
        private static IconData _LocationArrow;
        public static IconData FA_LocationArrow => _LocationArrow ??= new IconData("Location Arrow", "\U0000F124", Styles.Solid, new string[] { "address", "arrow", "compass", "coordinate", "direction", "gps", "location", "map", "navigation", "place", "pointer", "route", "travel", "waypoint" });
        private static IconData _LocationCrosshairs;
        public static IconData FA_LocationCrosshairs => _LocationCrosshairs ??= new IconData("Location Crosshairs", "\U0000F601", Styles.Solid, new string[] { "coordinate", "crosshairs", "find", "geolocation", "gps", "location", "map", "navigation", "pinpoint", "place", "position", "target", "tracking", "where" });
        private static IconData _LocationDot;
        public static IconData FA_LocationDot => _LocationDot ??= new IconData("Location Dot", "\U0000F3C5", Styles.Solid, new string[] { "address", "coordinates", "destination", "geotag", "gps", "location", "map", "map marker", "marker", "navigation", "pin", "place", "point of interest", "position", "route", "spot", "travel", "waypoint" });
        private static IconData _LocationPin;
        public static IconData FA_LocationPin => _LocationPin ??= new IconData("Location Pin", "\U0000F041", Styles.Solid, new string[] { "address", "coordinates", "destination", "drop", "gps", "location", "map", "map marker", "marker", "navigation", "pin", "place", "point of interest", "position", "route", "spot", "travel", "waypoint" });
        private static IconData _LocationPinLock;
        public static IconData FA_LocationPinLock => _LocationPinLock ??= new IconData("Location Pin Lock", "\U0000E51F", Styles.Solid, new string[] { "location", "lock", "lockdown", "locked", "map", "padlock", "pin", "privacy", "protected", "quarantine", "restricted", "secure" });
        private static IconData _Lock;
        public static IconData FA_Lock => _Lock ??= new IconData("Lock", "\U0000F023", Styles.Solid, new string[] { "access", "authentication", "closed", "lock", "locked", "padlock", "password", "privacy", "private", "protect", "safety", "secure", "security" });
        private static IconData _LockOpen;
        public static IconData FA_LockOpen => _LockOpen ??= new IconData("Lock Open", "\U0000F3C1", Styles.Solid, new string[] { "access", "authorized", "lock", "open", "open lock", "padlock", "permission", "privacy", "protection", "safe", "security", "unlock", "unlocked" });
        private static IconData _Locust;
        public static IconData FA_Locust => _Locust ??= new IconData("Locust", "\U0000E520", Styles.Solid, new string[] { "biblical plague", "crop damage", "grasshopper", "horde", "infestation", "insect", "locust", "outbreak", "pest", "plague", "swarm" });
        private static IconData _Lumon;
        public static IconData FA_Lumon => _Lumon ??= new IconData("Lumon", "\U0000E7E2", Styles.Brands, new string[] { "lumon", "lumon balcony", "lumon brand", "lumon company", "lumon glass", "lumon logo" });
        private static IconData _LumonDrop;
        public static IconData FA_LumonDrop => _LumonDrop ??= new IconData("Lumon Drop", "\U0000E7E3", Styles.Brands, new string[] { "brand", "company", "drop", "logo", "lumon", "lumon drop" });
        private static IconData _Lungs;
        public static IconData FA_Lungs => _Lungs ??= new IconData("Lungs", "\U0000F604", Styles.Solid, new string[] { "air", "anatomy", "breath", "breathing", "covid-19", "exhale", "health", "inhale", "lung", "lungs", "medicine", "organ", "pulmonary", "respiration", "respiratory" });
        private static IconData _LungsVirus;
        public static IconData FA_LungsVirus => _LungsVirus ??= new IconData("Lungs Virus", "\U0000E067", Styles.Solid, new string[] { "breath", "coronavirus", "covid-19", "disease", "flu", "health", "illness", "infection", "lungs", "pandemic", "respiratory", "respiratory illness", "sickness", "virus", "virus infection" });
        private static IconData _Lyft;
        public static IconData FA_Lyft => _Lyft ??= new IconData("Lyft", "\U0000F3C3", Styles.Brands, new string[] { "app", "car service", "lyft", "mobility", "ride", "rideshare", "taxi", "transportation", "travel" });
        private static IconData _M;
        public static IconData FA_M => _M ??= new IconData("M", "\U0000004D", Styles.Solid, new string[] { "alphabet", "capital M", "character", "initial", "letter M", "lowercase m", "symbol", "text", "typography" });
        private static IconData _Magento;
        public static IconData FA_Magento => _Magento ??= new IconData("Magento", "\U0000F3C4", Styles.Brands, new string[] { "adobe magento", "cms", "ecommerce", "magento", "marketplace", "online store", "platform", "shopping" });
        private static IconData _Magnet;
        public static IconData FA_Magnet => _Magnet ??= new IconData("Magnet", "\U0000F076", Styles.Solid, new string[] { "attract", "attraction", "force", "horseshoe", "iron", "lodestone", "magnet", "magnetic", "metal", "north pole", "polarity", "pull", "south pole", "tool" });
        private static IconData _MagnifyingGlass;
        public static IconData FA_MagnifyingGlass => _MagnifyingGlass ??= new IconData("Magnifying Glass", "\U0000F002", Styles.Solid, new string[] { "bigger", "enlarge", "find", "glass", "inspect", "inspection", "magnifier", "magnify", "magnifying glass", "preview", "search", "tool", "zoom" });
        private static IconData _MagnifyingGlassArrowRight;
        public static IconData FA_MagnifyingGlassArrowRight => _MagnifyingGlassArrowRight ??= new IconData("Magnifying Glass Arrow Right", "\U0000E521", Styles.Solid, new string[] { "arrow", "explore", "find", "forward", "go", "lookup", "magnifier", "next", "proceed", "search" });
        private static IconData _MagnifyingGlassChart;
        public static IconData FA_MagnifyingGlassChart => _MagnifyingGlassChart ??= new IconData("Magnifying Glass Chart", "\U0000E522", Styles.Solid, new string[] { "analysis", "analytics", "chart", "data", "graph", "inspect", "magnifier", "magnifying glass", "market", "overview", "report", "revenue", "search", "statistics", "trends" });
        private static IconData _MagnifyingGlassDollar;
        public static IconData FA_MagnifyingGlassDollar => _MagnifyingGlassDollar ??= new IconData("Magnifying Glass Dollar", "\U0000F688", Styles.Solid, new string[] { "analyze", "budget", "cost", "currency", "dollar", "finance", "find", "inspect", "magnifier", "magnify", "money", "price", "search", "zoom" });
        private static IconData _MagnifyingGlassLocation;
        public static IconData FA_MagnifyingGlassLocation => _MagnifyingGlassLocation ??= new IconData("Magnifying Glass Location", "\U0000F689", Styles.Solid, new string[] { "area", "detect", "explore", "find", "location", "magnifier", "magnify", "map", "navigation", "pinpoint", "place", "search", "spot", "zoom" });
        private static IconData _MagnifyingGlassMinus;
        public static IconData FA_MagnifyingGlassMinus => _MagnifyingGlassMinus ??= new IconData("Magnifying Glass Minus", "\U0000F010", Styles.Solid, new string[] { "decrease", "magnifier", "minimize", "minus", "reduce", "search less", "shrink", "smaller", "zoom out", "zoom-out icon" });
        private static IconData _MagnifyingGlassPlus;
        public static IconData FA_MagnifyingGlassPlus => _MagnifyingGlassPlus ??= new IconData("Magnifying Glass Plus", "\U0000F00E", Styles.Solid, new string[] { "add", "bigger", "enlarge", "find", "magnify", "magnifying glass", "plus", "positive", "search", "zoom", "zoom in" });
        private static IconData _Mailchimp;
        public static IconData FA_Mailchimp => _Mailchimp ??= new IconData("Mailchimp", "\U0000F59E", Styles.Brands, new string[] { "automation", "campaign", "chimp", "email marketing", "email service", "mail service", "mailchimp", "marketing", "marketing platform", "newsletter" });
        private static IconData _ManatSign;
        public static IconData FA_ManatSign => _ManatSign ??= new IconData("Manat Sign", "\U0000E1D5", Styles.Solid, new string[] { "Azerbaijan currency", "Turkmenistan currency", "currency", "currency symbol", "financial symbol", "manat", "manat sign", "money" });
        private static IconData _Mandalorian;
        public static IconData FA_Mandalorian => _Mandalorian ??= new IconData("Mandalorian", "\U0000F50F", Styles.Brands, new string[] { "armor", "beskar", "bounty hunter", "din djarin", "disney plus", "helmet", "mandalorian", "sci-fi", "star wars", "tv show", "warrior" });
        private static IconData _Map;
        public static IconData FA_Map => _Map ??= new IconData("Map", "\U0000F279", Styles.Regular | Styles.Solid, new string[] { "address", "atlas", "chart", "coordinates", "destination", "directions", "gps", "guide", "location", "map", "navigation", "pin", "place", "point of interest", "position", "route", "travel", "world", "world map" });
        private static IconData _MapLocation;
        public static IconData FA_MapLocation => _MapLocation ??= new IconData("Map Location", "\U0000F59F", Styles.Solid, new string[] { "address", "coordinates", "destination", "geolocation", "gps", "location", "map", "map marker", "marker", "navigation", "pin", "place", "point of interest", "position", "route", "spot", "travel", "waypoint" });
        private static IconData _MapLocationDot;
        public static IconData FA_MapLocationDot => _MapLocationDot ??= new IconData("Map Location Dot", "\U0000F5A0", Styles.Solid, new string[] { "address", "coordinates", "destination", "drop pin", "find", "geolocation", "gps", "location", "map", "map marker", "marker", "navigation", "pin", "place", "point of interest", "position", "route", "spot", "travel", "waypoint" });
        private static IconData _MapPin;
        public static IconData FA_MapPin => _MapPin ??= new IconData("Map Pin", "\U0000F276", Styles.Solid, new string[] { "address", "coordinates", "destination", "droppin", "geo", "gps", "location", "location marker", "map", "map marker", "map pin", "marker", "navigation", "pin", "place", "position", "pushpin", "spot", "travel", "waypoint" });
        private static IconData _Markdown;
        public static IconData FA_Markdown => _Markdown ??= new IconData("Markdown", "\U0000F60F", Styles.Brands, new string[] { "developer", "documentation", "formatting", "markdown", "markup", "md", "readme", "syntax", "text", "writing" });
        private static IconData _Marker;
        public static IconData FA_Marker => _Marker ??= new IconData("Marker", "\U0000F5A1", Styles.Solid, new string[] { "annotate", "coloring", "draw", "edit", "highlight", "marker", "marker pen", "marker tip", "modify", "pen", "sharpie", "sketch", "update", "write" });
        private static IconData _Mars;
        public static IconData FA_Mars => _Mars ??= new IconData("Mars", "\U0000F222", Styles.Solid, new string[] { "gender", "male", "male gender", "male gender symbol", "male icon", "male sex", "male sign", "male symbol", "man", "mars", "masculinity" });
        private static IconData _MarsAndVenus;
        public static IconData FA_MarsAndVenus => _MarsAndVenus ??= new IconData("Mars And Venus", "\U0000F224", Styles.Solid, new string[] { "Mars and Venus", "female", "gender", "gender diversity", "gender equality", "gender identity", "gender signs", "gender symbols", "intersex", "male", "male and female", "transgender" });
        private static IconData _MarsAndVenusBurst;
        public static IconData FA_MarsAndVenusBurst => _MarsAndVenusBurst ??= new IconData("Mars And Venus Burst", "\U0000E523", Styles.Solid, new string[] { "astrology", "burst", "conflict", "female", "gender", "love", "male", "mars", "relationship", "symbols", "venus" });
        private static IconData _MarsDouble;
        public static IconData FA_MarsDouble => _MarsDouble ??= new IconData("Mars Double", "\U0000F227", Styles.Solid, new string[] { "LGBTQ", "double male", "gay", "gender", "male", "male couple", "male gender", "male symbol", "masculinity", "men", "same-sex male" });
        private static IconData _MarsStroke;
        public static IconData FA_MarsStroke => _MarsStroke ??= new IconData("Mars Stroke", "\U0000F229", Styles.Solid, new string[] { "accessibility", "disability", "gender", "health", "male", "medical", "sign", "stroke", "symbol", "transgender" });
        private static IconData _MarsStrokeRight;
        public static IconData FA_MarsStrokeRight => _MarsStrokeRight ??= new IconData("Mars Stroke Right", "\U0000F22B", Styles.Solid, new string[] { "gender", "gender male", "gender symbol", "horizontal male", "male", "male sign", "male symbol", "mars", "masculinity", "right stroke" });
        private static IconData _MarsStrokeUp;
        public static IconData FA_MarsStrokeUp => _MarsStrokeUp ??= new IconData("Mars Stroke Up", "\U0000F22A", Styles.Solid, new string[] { "Mars", "arrow", "gender", "gender symbol", "male", "male gender", "masculine", "stroke", "symbol", "up" });
        private static IconData _MartiniGlass;
        public static IconData FA_MartiniGlass => _MartiniGlass ??= new IconData("Martini Glass", "\U0000F57B", Styles.Solid, new string[] { "alcohol", "bar", "beverage", "celebration", "cocktail", "cocktail glass", "drink", "drinkware", "glass", "happy hour", "liquor", "martini", "party" });
        private static IconData _MartiniGlassCitrus;
        public static IconData FA_MartiniGlassCitrus => _MartiniGlassCitrus ??= new IconData("Martini Glass Citrus", "\U0000F561", Styles.Solid, new string[] { "alcohol", "bar", "beverage", "citrus", "cocktail", "drink", "gin", "glass", "lemon", "lime", "margarita", "martini", "party", "refreshment", "vodka" });
        private static IconData _MartiniGlassEmpty;
        public static IconData FA_MartiniGlassEmpty => _MartiniGlassEmpty ??= new IconData("Martini Glass Empty", "\U0000F000", Styles.Solid, new string[] { "alcohol", "bar", "beverage", "celebration", "cocktail", "drink", "glass", "liquor", "martini", "nightlife", "party", "spirits" });
        private static IconData _Mask;
        public static IconData FA_Mask => _Mask ??= new IconData("Mask", "\U0000F6FA", Styles.Solid, new string[] { "carnival", "costume", "costume party", "disguise", "disguise accessory", "festival", "halloween", "mask", "masquerade", "party", "secret", "superhero" });
        private static IconData _MaskFace;
        public static IconData FA_MaskFace => _MaskFace ??= new IconData("Mask Face", "\U0000E1D7", Styles.Solid, new string[] { "breath", "coronavirus", "covid-19", "face mask", "filter", "flu", "health", "infection", "mask", "medical mask", "pandemic", "protection", "respirator", "safety", "surgical mask", "virus" });
        private static IconData _MaskVentilator;
        public static IconData FA_MaskVentilator => _MaskVentilator ??= new IconData("Mask Ventilator", "\U0000E524", Styles.Solid, new string[] { "airway", "breathing", "breathing apparatus", "gas mask", "life support", "medical mask", "oxygen", "respirator", "respiratory support", "ventilation", "ventilator" });
        private static IconData _MasksTheater;
        public static IconData FA_MasksTheater => _MasksTheater ??= new IconData("Masks Theater", "\U0000F630", Styles.Solid, new string[] { "acting", "arts", "comedy", "drama", "masks", "performance", "performance art", "play", "stage", "theater", "theatre", "theatrical", "tragedy" });
        private static IconData _Mastodon;
        public static IconData FA_Mastodon => _Mastodon ??= new IconData("Mastodon", "\U0000F4F6", Styles.Brands, new string[] { "decentralized", "federated", "fediverse", "mastodon", "microblogging", "network", "open source", "platform", "social", "social media" });
        private static IconData _MattressPillow;
        public static IconData FA_MattressPillow => _MattressPillow ??= new IconData("Mattress Pillow", "\U0000E525", Styles.Solid, new string[] { "bed", "bedding", "comfort", "mattress", "mattress pad", "nap", "pillow", "rest", "sleep", "sleeping pad" });
        private static IconData _Maxcdn;
        public static IconData FA_Maxcdn => _Maxcdn ??= new IconData("Maxcdn", "\U0000F136", Styles.Brands, new string[] { "caching", "cdn", "cloudflare alternative", "content delivery network", "hosting", "internet service", "maxcdn", "web performance" });
        private static IconData _Maximize;
        public static IconData FA_Maximize => _Maximize ??= new IconData("Maximize", "\U0000F31E", Styles.Solid, new string[] { "arrows", "bigger", "enlarge", "expand", "full screen", "fullscreen", "grow", "increase", "maximize", "open", "resize", "scale", "stretch", "zoom in" });
        private static IconData _Mdb;
        public static IconData FA_Mdb => _Mdb ??= new IconData("Mdb", "\U0000F8CA", Styles.Brands, new string[] { "backend", "cloud database", "data storage", "database", "database service", "document database", "mdb", "mongo", "mongodb", "nosql" });
        private static IconData _Medal;
        public static IconData FA_Medal => _Medal ??= new IconData("Medal", "\U0000F5A2", Styles.Solid, new string[] { "achievement", "award", "badge", "bronze medal", "champion", "gold medal", "honor", "medal", "prize", "quality", "ribbon", "silver medal", "sports medal", "trophy", "winner" });
        private static IconData _Medapps;
        public static IconData FA_Medapps => _Medapps ??= new IconData("Medapps", "\U0000F3C6", Styles.Brands, new string[] { "health services", "health technology", "healthcare apps", "medapps", "medical apps", "medical software" });
        private static IconData _Medium;
        public static IconData FA_Medium => _Medium ??= new IconData("Medium", "\U0000F23A", Styles.Brands, new string[] { "articles", "blog", "blogging", "content", "medium", "platform", "publishing", "social media", "stories", "writing" });
        private static IconData _Medrt;
        public static IconData FA_Medrt => _Medrt ??= new IconData("Medrt", "\U0000F3C8", Styles.Brands, new string[] { "arbitration", "conflict management", "dispute resolution", "legal", "mediation", "medrt" });
        private static IconData _Meetup;
        public static IconData FA_Meetup => _Meetup ??= new IconData("Meetup", "\U0000F2E0", Styles.Brands, new string[] { "community", "event", "gathering", "group", "meetup", "meetup.com", "network", "social" });
        private static IconData _Megaport;
        public static IconData FA_Megaport => _Megaport ??= new IconData("Megaport", "\U0000F5A3", Styles.Brands, new string[] { "cloud", "connectivity", "data center", "interconnection", "megaport", "network", "service provider", "telecommunications" });
        private static IconData _Memory;
        public static IconData FA_Memory => _Memory ??= new IconData("Memory", "\U0000F538", Styles.Solid, new string[] { "DIMM", "RAM", "chip", "computer", "hardware", "memory", "memory card", "memory module", "module", "stick", "technology", "volatile" });
        private static IconData _Mendeley;
        public static IconData FA_Mendeley => _Mendeley ??= new IconData("Mendeley", "\U0000F7B3", Styles.Brands, new string[] { "academic", "bibliography", "citation", "library", "literature", "mendeley", "papers", "reference manager", "research", "scholarly" });
        private static IconData _Menorah;
        public static IconData FA_Menorah => _Menorah ??= new IconData("Menorah", "\U0000F676", Styles.Solid, new string[] { "candle", "candles", "celebration", "festival of lights", "hanukkah", "jewish", "jewish holiday", "judaism", "light", "menorah", "menorah candleholder", "oil lamp", "religious" });
        private static IconData _Mercury;
        public static IconData FA_Mercury => _Mercury ??= new IconData("Mercury", "\U0000F223", Styles.Solid, new string[] { "alchemy", "astrology", "gender", "hybrid", "mercury", "messenger", "planet", "roman god", "symbol", "transgender" });
        private static IconData _Message;
        public static IconData FA_Message => _Message ??= new IconData("Message", "\U0000F27A", Styles.Regular | Styles.Solid, new string[] { "bubble", "chat", "comment", "conversation", "discussion", "feedback", "message", "note", "notification", "reply", "sms", "speech", "talk", "text", "texting" });
        private static IconData _Meta;
        public static IconData FA_Meta => _Meta ??= new IconData("Meta", "\U0000E49B", Styles.Brands, new string[] { "meta", "meta brand", "meta data", "meta information", "meta tag", "metadata" });
        private static IconData _Meteor;
        public static IconData FA_Meteor => _Meteor ??= new IconData("Meteor", "\U0000F753", Styles.Solid, new string[] { "asteroid", "blaze", "comet", "falling star", "fireball", "impact", "meteor", "meteor shower", "meteorite", "shooting star", "sky", "space", "streak" });
        private static IconData _Microblog;
        public static IconData FA_Microblog => _Microblog ??= new IconData("Microblog", "\U0000E01A", Styles.Brands, new string[] { "blogging platform", "content sharing", "microblog", "microblogging", "online journal", "short posts", "social media", "social network", "status update" });
        private static IconData _Microchip;
        public static IconData FA_Microchip => _Microchip ??= new IconData("Microchip", "\U0000F2DB", Styles.Solid, new string[] { "chip", "circuit", "computer", "cpu", "device", "electronic", "hardware", "microprocessor", "motherboard", "processor", "semiconductor", "silicon", "technology" });
        private static IconData _Microphone;
        public static IconData FA_Microphone => _Microphone ??= new IconData("Microphone", "\U0000F130", Styles.Solid, new string[] { "audio", "broadcast", "karaoke", "microphone", "music", "podcast", "record", "recording", "sing", "sound", "speech", "talk", "talking", "vocal", "voice" });
        private static IconData _MicrophoneLines;
        public static IconData FA_MicrophoneLines => _MicrophoneLines ??= new IconData("Microphone Lines", "\U0000F3C9", Styles.Solid, new string[] { "audio", "broadcast", "karaoke", "mic", "microphone", "music", "podcast", "recording", "sing", "sound", "speech", "studio", "talking", "vocal", "voice" });
        private static IconData _MicrophoneLinesSlash;
        public static IconData FA_MicrophoneLinesSlash => _MicrophoneLinesSlash ??= new IconData("Microphone Lines Slash", "\U0000F539", Styles.Solid, new string[] { "audio", "disabled", "microphone", "mute", "muted", "no sound", "off", "podcast", "record", "silence", "sing", "sound", "voice" });
        private static IconData _MicrophoneSlash;
        public static IconData FA_MicrophoneSlash => _MicrophoneSlash ??= new IconData("Microphone Slash", "\U0000F131", Styles.Solid, new string[] { "audio off", "disable", "disabled", "microphone", "mute", "muted", "no sound", "podcast", "record", "silence", "sing", "sound off", "voice off" });
        private static IconData _Microscope;
        public static IconData FA_Microscope => _Microscope ??= new IconData("Microscope", "\U0000F610", Styles.Solid, new string[] { "analysis", "biology", "chemistry", "experiment", "investigation", "laboratory", "lens", "magnification", "magnify", "microscope", "optics", "research", "science", "study", "tool" });
        private static IconData _Microsoft;
        public static IconData FA_Microsoft => _Microsoft ??= new IconData("Microsoft", "\U0000F3CA", Styles.Brands, new string[] { "azure", "microsoft", "ms", "msft", "office", "software", "technology", "windows", "windows logo", "xbox" });
        private static IconData _MillSign;
        public static IconData FA_MillSign => _MillSign ??= new IconData("Mill Sign", "\U0000E1ED", Styles.Solid, new string[] { "currency", "finance", "financial symbol", "measurement", "mill sign", "monetary unit", "money", "symbol", "unit" });
        private static IconData _Minimize;
        public static IconData FA_Minimize => _Minimize ??= new IconData("Minimize", "\U0000F78C", Styles.Solid, new string[] { "collapse", "contract", "downsize", "hide", "minimize", "reduce", "screen", "shrink", "smaller", "window" });
        private static IconData _Mintbit;
        public static IconData FA_Mintbit => _Mintbit ??= new IconData("Mintbit", "\U0000E62F", Styles.Brands, new string[] { "blockchain", "crypto", "cryptocurrency", "digital currency", "mint bit", "mintbit", "token" });
        private static IconData _Minus;
        public static IconData FA_Minus => _Minus ??= new IconData("Minus", "\U0000F068", Styles.Solid, new string[] { "collapse", "dash", "delete", "hide", "math", "minimize", "minus", "minus sign", "negative", "reduce", "remove", "shrink", "sign", "subtract", "−" });
        private static IconData _Mitten;
        public static IconData FA_Mitten => _Mitten ??= new IconData("Mitten", "\U0000F7B5", Styles.Solid, new string[] { "clothing", "cold", "cozy", "frost", "glove", "handwear", "knitted", "mitten", "protection", "seasonal", "snow", "warmth", "winter" });
        private static IconData _Mix;
        public static IconData FA_Mix => _Mix ??= new IconData("Mix", "\U0000F3CB", Styles.Brands, new string[] { "audio", "blend", "combine", "dj", "media", "mix", "mixer", "mixing", "music", "sound" });
        private static IconData _Mixcloud;
        public static IconData FA_Mixcloud => _Mixcloud ??= new IconData("Mixcloud", "\U0000F289", Styles.Brands, new string[] { "DJ mixes", "audio platform", "mixcloud", "music sharing", "music streaming", "online radio", "podcasts", "radio shows", "streaming service" });
        private static IconData _Mixer;
        public static IconData FA_Mixer => _Mixer ??= new IconData("Mixer", "\U0000E056", Styles.Brands, new string[] { "DJ mixer", "audio control", "audio mixer", "mixer", "mixing console", "mixing desk", "music mixer", "sound mixer", "soundboard" });
        private static IconData _Mizuni;
        public static IconData FA_Mizuni => _Mizuni ??= new IconData("Mizuni", "\U0000F3CC", Styles.Brands, new string[] { "mizuni", "mizuni brand", "mizuni company", "mizuni logo", "mizuni software", "mizuni technology" });
        private static IconData _Mobile;
        public static IconData FA_Mobile => _Mobile ??= new IconData("Mobile", "\U0000F3CE", Styles.Solid, new string[] { "android", "call", "cell", "cell phone", "cellular", "device", "handset", "mobile", "mobile phone", "number", "phone", "screen", "smartphone", "telephone", "text" });
        private static IconData _MobileButton;
        public static IconData FA_MobileButton => _MobileButton ??= new IconData("Mobile Button", "\U0000F10B", Styles.Solid, new string[] { "apple", "call", "cell phone", "contact", "device", "dial", "handset", "iphone", "mobile", "number", "phone", "screen", "smartphone", "telephone" });
        private static IconData _MobileRetro;
        public static IconData FA_MobileRetro => _MobileRetro ??= new IconData("Mobile Retro", "\U0000E527", Styles.Solid, new string[] { "call", "cellphone", "cellular", "classic phone", "communication", "handset", "mobile", "old-fashioned", "phone", "retro phone", "vintage" });
        private static IconData _MobileScreen;
        public static IconData FA_MobileScreen => _MobileScreen ??= new IconData("Mobile Screen", "\U0000F3CF", Styles.Solid, new string[] { "android", "call", "cell phone", "communication", "device", "digital device", "handset", "ios", "mobile", "mobile device", "phone", "screen", "smartphone", "text", "touchscreen" });
        private static IconData _MobileScreenButton;
        public static IconData FA_MobileScreenButton => _MobileScreenButton ??= new IconData("Mobile Screen Button", "\U0000F3CD", Styles.Solid, new string[] { "apple", "call", "cell phone", "communication", "device", "handset", "iphone", "mobile", "number", "phone", "screen", "smartphone", "telephone", "touchscreen" });
        private static IconData _MobileVibrate;
        public static IconData FA_MobileVibrate => _MobileVibrate ??= new IconData("Mobile Vibrate", "\U0000E816", Styles.Solid, new string[] { "alert", "call", "cell phone", "device", "haptic", "message", "mobile", "notification", "phone", "ring", "silent", "smartphone", "text", "vibrate", "vibration" });
        private static IconData _Modx;
        public static IconData FA_Modx => _Modx ??= new IconData("Modx", "\U0000F285", Styles.Brands, new string[] { "cms", "content management", "content management system", "modx", "modx cms", "open source", "web platform", "website" });
        private static IconData _Monero;
        public static IconData FA_Monero => _Monero ??= new IconData("Monero", "\U0000F3D0", Styles.Brands, new string[] { "altcoin", "blockchain", "crypto", "cryptocurrency", "decentralized", "digital currency", "monero", "privacy coin", "xmr" });
        private static IconData _MoneyBill;
        public static IconData FA_MoneyBill => _MoneyBill ??= new IconData("Money Bill", "\U0000F0D6", Styles.Solid, new string[] { "bill", "buy", "cash", "currency", "earnings", "finance", "funds", "income", "money", "payment", "price", "purchase", "revenue", "salary", "wallet" });
        private static IconData _MoneyBill1;
        public static IconData FA_MoneyBill1 => _MoneyBill1 ??= new IconData("Money Bill 1", "\U0000F3D1", Styles.Regular | Styles.Solid, new string[] { "bill", "buy", "cash", "checkout", "currency", "dollar", "finance", "money", "paycheck", "payment", "premium", "price", "purchase", "salary" });
        private static IconData _MoneyBill1Wave;
        public static IconData FA_MoneyBill1Wave => _MoneyBill1Wave ??= new IconData("Money Bill 1 Wave", "\U0000F53B", Styles.Solid, new string[] { "banknote", "bill", "cash", "currency", "earnings", "finance", "funds", "income", "money", "pay", "payment", "price", "purchase", "salary", "wallet" });
        private static IconData _MoneyBillTransfer;
        public static IconData FA_MoneyBillTransfer => _MoneyBillTransfer ??= new IconData("Money Bill Transfer", "\U0000E528", Styles.Solid, new string[] { "bank", "currency", "deposit", "exchange", "funds", "money", "payment", "receive", "salary", "send", "transaction", "transfer", "wire", "withdrawal" });
        private static IconData _MoneyBillTrendUp;
        public static IconData FA_MoneyBillTrendUp => _MoneyBillTrendUp ??= new IconData("Money Bill Trend Up", "\U0000E529", Styles.Solid, new string[] { "bank", "bonds", "earnings", "finance", "growth", "income", "inflation", "investment", "market", "money", "profit", "revenue", "salary", "stocks", "trade" });
        private static IconData _MoneyBillWave;
        public static IconData FA_MoneyBillWave => _MoneyBillWave ??= new IconData("Money Bill Wave", "\U0000F53A", Styles.Solid, new string[] { "bills", "buy", "cash", "currency", "earnings", "finance", "funds", "money", "paycheck", "payment", "price", "purchase", "salary", "transaction", "wallet" });
        private static IconData _MoneyBillWheat;
        public static IconData FA_MoneyBillWheat => _MoneyBillWheat ??= new IconData("Money Bill Wheat", "\U0000E52A", Styles.Solid, new string[] { "agribusiness", "agriculture", "crops", "economy", "farming", "finance", "food", "grain", "harvest", "income", "investment", "money", "payment", "subsidy", "wheat" });
        private static IconData _MoneyBills;
        public static IconData FA_MoneyBills => _MoneyBills ??= new IconData("Money Bills", "\U0000E1F3", Styles.Solid, new string[] { "atm", "bills", "cash", "currency", "dollars", "finance", "funds", "income", "investment", "money", "payment", "revenue", "salary" });
        private static IconData _MoneyCheck;
        public static IconData FA_MoneyCheck => _MoneyCheck ??= new IconData("Money Check", "\U0000F53C", Styles.Solid, new string[] { "bank check", "billing", "buy", "check", "checkout", "cheque", "finance", "invoice", "money", "paycheck", "payment", "paystub", "purchase", "salary", "transaction" });
        private static IconData _MoneyCheckDollar;
        public static IconData FA_MoneyCheckDollar => _MoneyCheckDollar ??= new IconData("Money Check Dollar", "\U0000F53D", Styles.Solid, new string[] { "bank check", "billing", "cash", "checkbook", "cheque", "dollar", "finance", "funds", "invoice", "money", "pay", "paycheck", "payment", "salary", "transaction" });
        private static IconData _Monument;
        public static IconData FA_Monument => _Monument ??= new IconData("Monument", "\U0000F5A6", Styles.Solid, new string[] { "building", "commemorative", "famous", "heritage", "historic", "iconic", "landmark", "memorial", "monument", "monumental", "notable", "statue", "tourist attraction" });
        private static IconData _Moon;
        public static IconData FA_Moon => _Moon ??= new IconData("Moon", "\U0000F186", Styles.Regular | Styles.Solid, new string[] { "crescent", "crescent moon", "dark", "dark mode", "evening", "lunar", "moon", "moonlight", "night", "night mode", "nighttime", "nighttime symbol", "sleep" });
        private static IconData _MortarPestle;
        public static IconData FA_MortarPestle => _MortarPestle ??= new IconData("Mortar Pestle", "\U0000F5A7", Styles.Solid, new string[] { "apothecary", "cooking", "crush", "grind", "herbal", "herbs", "kitchen", "medical", "medicine", "mix", "pharmacy", "prescription", "spices" });
        private static IconData _Mosque;
        public static IconData FA_Mosque => _Mosque ??= new IconData("Mosque", "\U0000F678", Styles.Solid, new string[] { "Islam", "Islamic architecture", "Muslim", "building", "dome", "landmark", "minaret", "mosque", "prayer", "religion", "worship" });
        private static IconData _Mosquito;
        public static IconData FA_Mosquito => _Mosquito ??= new IconData("Mosquito", "\U0000E52B", Styles.Solid, new string[] { "West Nile", "Zika", "bite", "bloodsucker", "bug", "dengue", "disease", "insect", "malaria", "mosquito", "mosquito bite", "nuisance", "pest" });
        private static IconData _MosquitoNet;
        public static IconData FA_MosquitoNet => _MosquitoNet ??= new IconData("Mosquito Net", "\U0000E52C", Styles.Solid, new string[] { "bug net", "bug screen", "camping", "insect net", "insect screen", "malaria prevention", "mosquito", "mosquito bite", "mosquito net", "net", "outdoor gear", "pest control", "protection", "sleeping net" });
        private static IconData _Motorcycle;
        public static IconData FA_Motorcycle => _Motorcycle ??= new IconData("Motorcycle", "\U0000F21C", Styles.Solid, new string[] { "bike", "chopper", "cruiser", "motorbike", "motorcycle", "motorized bike", "racing", "scooter", "transportation", "two-wheeler", "vehicle" });
        private static IconData _Mound;
        public static IconData FA_Mound => _Mound ??= new IconData("Mound", "\U0000E52D", Styles.Solid, new string[] { "barrier", "dirt", "earth", "embankment", "heap", "hill", "mound", "pile", "soil", "speedbump" });
        private static IconData _Mountain;
        public static IconData FA_Mountain => _Mountain ??= new IconData("Mountain", "\U0000F6FC", Styles.Solid, new string[] { "climbing", "glacier", "hiking", "hill", "landscape", "mountain", "nature", "outdoor", "peak", "snow", "snow-capped", "summit", "travel", "view" });
        private static IconData _MountainCity;
        public static IconData FA_MountainCity => _MountainCity ??= new IconData("Mountain City", "\U0000E52E", Styles.Solid, new string[] { "adventure", "city", "landscape", "mountain", "nature", "outdoors", "rural", "skyline", "town", "travel", "urban", "village" });
        private static IconData _MountainSun;
        public static IconData FA_MountainSun => _MountainSun ??= new IconData("Mountain Sun", "\U0000E52F", Styles.Solid, new string[] { "adventure", "hiking", "landscape", "mountain", "nature", "outdoors", "scenic", "sun", "sunrise", "sunset", "travel", "view", "wilderness" });
        private static IconData _MugHot;
        public static IconData FA_MugHot => _MugHot ??= new IconData("Mug Hot", "\U0000F7B6", Styles.Solid, new string[] { "beverage", "cappuccino", "cocoa", "coffee", "cozy", "cup", "drink", "hot", "hot beverage", "hot chocolate", "latte", "morning", "mug", "steam", "steaming", "tea", "warm drink", "warmth" });
        private static IconData _MugSaucer;
        public static IconData FA_MugSaucer => _MugSaucer ??= new IconData("Mug Saucer", "\U0000F0F4", Styles.Solid, new string[] { "autumn", "beverage", "breakfast", "cafe", "coffee", "cozy", "cup", "drink", "fall", "hot drink", "morning", "mug", "saucer", "seasonal", "tea", "warm" });
        private static IconData _Music;
        public static IconData FA_Music => _Music ??= new IconData("Music", "\U0000F001", Styles.Solid, new string[] { "audio", "lyrics", "melody", "music", "musical note", "note", "sing", "song", "sound", "tune" });
        private static IconData _N;
        public static IconData FA_N => _N ??= new IconData("N", "\U0000004E", Styles.Solid, new string[] { "Latin letter", "alphabet", "character", "letter", "lowercase n", "nay", "no", "uppercase n" });
        private static IconData _NairaSign;
        public static IconData FA_NairaSign => _NairaSign ??= new IconData("Naira Sign", "\U0000E1F6", Styles.Solid, new string[] { "Nigerian currency", "cash", "currency", "currency symbol", "financial", "money", "naira", "naira sign", "payment", "₦" });
        private static IconData _Napster;
        public static IconData FA_Napster => _Napster ??= new IconData("Napster", "\U0000F3D2", Styles.Brands, new string[] { "audio", "brand", "logo", "media", "mp3", "music", "napster", "playlist", "streaming" });
        private static IconData _Neos;
        public static IconData FA_Neos => _Neos ??= new IconData("Neos", "\U0000F612", Styles.Brands, new string[] { "blockchain", "crypto", "crypto coin", "crypto token", "cryptocurrency", "digital currency", "neos", "neos wallet" });
        private static IconData _NetworkWired;
        public static IconData FA_NetworkWired => _NetworkWired ??= new IconData("Network Wired", "\U0000F6FF", Styles.Solid, new string[] { "cable", "communication", "computer", "connection", "data", "ethernet", "internet", "intranet", "lan", "network", "router", "switch", "wired" });
        private static IconData _Neuter;
        public static IconData FA_Neuter => _Neuter ??= new IconData("Neuter", "\U0000F22C", Styles.Solid, new string[] { "gender", "gender icon", "gender neutral", "gender symbol", "genderless", "neuter", "neutral gender", "no gender", "non-binary", "unisex" });
        private static IconData _Newspaper;
        public static IconData FA_Newspaper => _Newspaper ??= new IconData("Newspaper", "\U0000F1EA", Styles.Regular | Styles.Solid, new string[] { "article", "bulletin", "editorial", "gazette", "headline", "journalism", "media", "news", "newsletter", "newspaper", "paper", "periodical", "press", "publication", "report" });
        private static IconData _NfcDirectional;
        public static IconData FA_NfcDirectional => _NfcDirectional ??= new IconData("Nfc Directional", "\U0000E530", Styles.Brands, new string[] { "connect", "contactless", "data transfer", "near field communication", "nfc", "proximity", "scan", "signal", "tap", "transfer", "wireless", "wireless payment" });
        private static IconData _NfcSymbol;
        public static IconData FA_NfcSymbol => _NfcSymbol ??= new IconData("Nfc Symbol", "\U0000E531", Styles.Brands, new string[] { "connect", "contactless", "data", "near field communication", "nfc", "scan", "signal", "tap", "transfer", "wireless", "wireless payment" });
        private static IconData _Nimblr;
        public static IconData FA_Nimblr => _Nimblr ??= new IconData("Nimblr", "\U0000F5A8", Styles.Brands, new string[] { "nimblr", "nimblr app", "nimblr brand", "nimblr logo", "nimblr platform", "nimblr social" });
        private static IconData _Node;
        public static IconData FA_Node => _Node ??= new IconData("Node", "\U0000F419", Styles.Brands, new string[] { "JavaScript", "Node", "Node.js", "backend", "development", "programming", "runtime", "server" });
        private static IconData _NodeJs;
        public static IconData FA_NodeJs => _NodeJs ??= new IconData("Node Js", "\U0000F3D3", Styles.Brands, new string[] { "backend", "development", "event-driven", "javascript", "js", "node.js", "nodejs", "npm", "programming", "runtime", "server" });
        private static IconData _NonBinary;
        public static IconData FA_NonBinary => _NonBinary ??= new IconData("Non Binary", "\U0000E807", Styles.Solid, new string[] { "LGBTQ", "gender", "gender identity", "genderfluid", "genderqueer", "identity", "nb", "non-binary", "nonbinary", "queer" });
        private static IconData _NotEqual;
        public static IconData FA_NotEqual => _NotEqual ??= new IconData("Not Equal", "\U0000F53E", Styles.Solid, new string[] { "arithmetic", "compare", "comparison", "difference", "inequality", "math", "math symbol", "not equal", "symbol" });
        private static IconData _Notdef;
        public static IconData FA_Notdef => _Notdef ??= new IconData("Notdef", "\U0000E1FE", Styles.Solid, new string[] { "404", "absent", "broken", "close", "error", "fail", "invalid", "missing", "not found", "unavailable" });
        private static IconData _NoteSticky;
        public static IconData FA_NoteSticky => _NoteSticky ??= new IconData("Note Sticky", "\U0000F249", Styles.Regular | Styles.Solid, new string[] { "annotation", "label", "memo", "message", "note", "paper", "post-it", "reminder", "sticker", "sticky note" });
        private static IconData _NotesMedical;
        public static IconData FA_NotesMedical => _NotesMedical ??= new IconData("Notes Medical", "\U0000F481", Styles.Solid, new string[] { "chart", "clinic", "clipboard", "doctor", "ehr", "health", "healthcare", "history", "hospital", "medical", "notes", "patient", "prescription", "records", "treatment" });
        private static IconData _Notion;
        public static IconData FA_Notion => _Notion ??= new IconData("Notion", "\U0000E7D9", Styles.Brands, new string[] { "collaboration", "knowledge base", "note-taking", "notes", "notion", "notion.so", "organization", "productivity", "project management", "workspace" });
        private static IconData _Npm;
        public static IconData FA_Npm => _Npm ??= new IconData("Npm", "\U0000F3D4", Styles.Brands, new string[] { "JavaScript", "Node Package Manager", "Node.js", "libraries", "modules", "node modules", "npm", "package manager", "packages" });
        private static IconData _Ns8;
        public static IconData FA_Ns8 => _Ns8 ??= new IconData("Ns8", "\U0000F3D5", Styles.Brands, new string[] { "NS8", "cybersecurity", "fraud prevention", "ns8", "online protection", "risk management", "security", "website security" });
        private static IconData _Nutritionix;
        public static IconData FA_Nutritionix => _Nutritionix ??= new IconData("Nutritionix", "\U0000F3D6", Styles.Brands, new string[] { "app", "calories", "database", "diet", "fitness", "food", "health", "nutrition", "nutritionix", "tracking" });
        private static IconData _O;
        public static IconData FA_O => _O ??= new IconData("O", "\U0000004F", Styles.Solid, new string[] { "alphabet", "character", "latin letter", "letter", "letter o", "symbol", "text", "typeface", "typography", "vowel" });
        private static IconData _ObjectGroup;
        public static IconData FA_ObjectGroup => _ObjectGroup ??= new IconData("Object Group", "\U0000F247", Styles.Regular | Styles.Solid, new string[] { "cluster", "collection", "combine", "copy", "design", "group", "layers", "merge", "objects", "select" });
        private static IconData _ObjectUngroup;
        public static IconData FA_ObjectUngroup => _ObjectUngroup ??= new IconData("Object Ungroup", "\U0000F248", Styles.Regular | Styles.Solid, new string[] { "break apart", "design", "divide", "layers", "objects", "select", "separate", "split", "ungroup" });
        private static IconData _Obsidian;
        public static IconData FA_Obsidian => _Obsidian ??= new IconData("Obsidian", "\U0000E879", Styles.Brands, new string[] { });
        private static IconData _Octagon;
        public static IconData FA_Octagon => _Octagon ??= new IconData("Octagon", "\U0000F306", Styles.Solid, new string[] { "geometric", "octagon", "octagonal", "polygon", "road sign", "shape", "stop", "stop sign", "symbol", "traffic", "warning" });
        private static IconData _OctopusDeploy;
        public static IconData FA_OctopusDeploy => _OctopusDeploy ??= new IconData("Octopus Deploy", "\U0000E082", Styles.Brands, new string[] { "automation", "cd", "ci", "cloud deployment", "continuous delivery", "continuous integration", "deploy", "deployment", "devops", "octopus", "octopus deploy", "release management", "software release" });
        private static IconData _Odnoklassniki;
        public static IconData FA_Odnoklassniki => _Odnoklassniki ??= new IconData("Odnoklassniki", "\U0000F263", Styles.Brands, new string[] { "odnoklassniki", "odnoklassniki.ru", "ok", "ok.ru", "russian social network", "social media", "social network" });
        private static IconData _Odysee;
        public static IconData FA_Odysee => _Odysee ??= new IconData("Odysee", "\U0000E5C6", Styles.Brands, new string[] { "blockchain video", "content sharing", "decentralized video", "odysee", "video hosting", "video platform" });
        private static IconData _OilCan;
        public static IconData FA_OilCan => _OilCan ??= new IconData("Oil Can", "\U0000F613", Styles.Solid, new string[] { "automotive", "engine oil", "grease", "lubricant", "maintenance", "motor oil", "oil", "oil bottle", "oil can", "oil change", "oil container", "oil dispenser", "petroleum" });
        private static IconData _OilWell;
        public static IconData FA_OilWell => _OilWell ??= new IconData("Oil Well", "\U0000E532", Styles.Solid, new string[] { "drilling", "energy", "extraction", "fossil fuel", "oil", "oil drilling", "oil rig", "oil well", "petroleum", "rig" });
        private static IconData _OldRepublic;
        public static IconData FA_OldRepublic => _OldRepublic ??= new IconData("Old Republic", "\U0000F510", Styles.Brands, new string[] { "galactic republic", "jedi", "old republic", "republic", "sith", "star wars", "star wars the old republic", "swtor" });
        private static IconData _Om;
        public static IconData FA_Om => _Om ??= new IconData("Om", "\U0000F679", Styles.Solid, new string[] { "Buddhism", "Hindu", "Hinduism", "Jainism", "chant", "mantra", "meditation", "om", "religion", "sacred", "spirituality", "symbol" });
        private static IconData _Openai;
        public static IconData FA_Openai => _Openai ??= new IconData("Openai", "\U0000E7CF", Styles.Brands, new string[] { "ai", "ai research", "artificial intelligence", "chatgpt", "dall-e", "gpt", "language model", "machine learning", "open ai", "openai" });
        private static IconData _Opencart;
        public static IconData FA_Opencart => _Opencart ??= new IconData("Opencart", "\U0000F23D", Styles.Brands, new string[] { "cart", "ecommerce", "marketplace", "online store", "open source", "opencart", "retail", "shopping", "shopping cart", "web store" });
        private static IconData _Openid;
        public static IconData FA_Openid => _Openid ??= new IconData("Openid", "\U0000F19B", Styles.Brands, new string[] { "authentication", "identity", "login", "open id", "openid", "sign in", "single sign-on", "sso" });
        private static IconData _Openstreetmap;
        public static IconData FA_Openstreetmap => _Openstreetmap ??= new IconData("Openstreetmap", "\U0000E86B", Styles.Brands, new string[] { });
        private static IconData _Opensuse;
        public static IconData FA_Opensuse => _Opensuse ??= new IconData("Opensuse", "\U0000E62B", Styles.Brands, new string[] { "green chameleon", "linux", "linux distribution", "linux distro", "openSUSE", "opensource", "opensuse", "operating system", "suse" });
        private static IconData _Opera;
        public static IconData FA_Opera => _Opera ??= new IconData("Opera", "\U0000F26A", Styles.Brands, new string[] { "browser", "browsing", "fast browser", "internet", "opera", "opera browser", "secure browser", "web", "web browser" });
        private static IconData _OptinMonster;
        public static IconData FA_OptinMonster => _OptinMonster ??= new IconData("Optin Monster", "\U0000F23C", Styles.Brands, new string[] { "conversion optimization", "email marketing", "lead generation", "marketing tool", "optin monster", "optinmonster", "popup builder" });
        private static IconData _Orcid;
        public static IconData FA_Orcid => _Orcid ??= new IconData("Orcid", "\U0000F8D2", Styles.Brands, new string[] { "academic id", "orcid", "research profile", "researcher", "researcher id", "researcher identifier", "scholarly id" });
        private static IconData _Osi;
        public static IconData FA_Osi => _Osi ??= new IconData("Osi", "\U0000F41A", Styles.Brands, new string[] { "communication", "layers", "network model", "networking", "open systems interconnection", "osi", "protocol" });
        private static IconData _Otter;
        public static IconData FA_Otter => _Otter ??= new IconData("Otter", "\U0000F700", Styles.Solid, new string[] { "animal", "aquatic", "cute", "fishing", "fur", "mammal", "nature", "otter", "playful", "river", "wildlife" });
        private static IconData _Outdent;
        public static IconData FA_Outdent => _Outdent ??= new IconData("Outdent", "\U0000F03B", Styles.Solid, new string[] { "align left", "decrease indent", "formatting", "indent less", "margin", "outdent", "paragraph", "tab", "text" });
        private static IconData _P;
        public static IconData FA_P => _P ??= new IconData("P", "\U00000050", Styles.Solid, new string[] { "alphabet p", "capital p", "character p", "letter p", "lowercase p", "text p" });
        private static IconData _Padlet;
        public static IconData FA_Padlet => _Padlet ??= new IconData("Padlet", "\U0000E4A0", Styles.Brands, new string[] { "classroom tool", "digital board", "education", "note sharing", "online collaboration", "padlet", "virtual bulletin" });
        private static IconData _Page4;
        public static IconData FA_Page4 => _Page4 ??= new IconData("Page4", "\U0000F3D7", Styles.Brands, new string[] { "brand", "logo", "p4", "page 4", "page4", "pagefour" });
        private static IconData _Pagelines;
        public static IconData FA_Pagelines => _Pagelines ??= new IconData("Pagelines", "\U0000F18C", Styles.Brands, new string[] { "eco", "environment", "green", "leaf", "leaves", "nature", "organic", "pagelines", "plant", "sustainable", "tree" });
        private static IconData _Pager;
        public static IconData FA_Pager => _Pager ??= new IconData("Pager", "\U0000F815", Styles.Solid, new string[] { "alert", "beeper", "communication", "message", "notification", "old technology", "page", "pager", "pager device", "wireless device" });
        private static IconData _PaintRoller;
        public static IconData FA_PaintRoller => _PaintRoller ??= new IconData("Paint Roller", "\U0000F5AA", Styles.Solid, new string[] { "DIY", "brush", "coating", "color", "decoration", "home improvement", "paint", "paintbrush", "painting", "renovation", "roller", "tool", "wall" });
        private static IconData _Paintbrush;
        public static IconData FA_Paintbrush => _Paintbrush ??= new IconData("Paintbrush", "\U0000F1FC", Styles.Solid, new string[] { "acrylic", "art", "artist", "brush", "color", "creativity", "design", "drawing", "fill", "paint", "paintbrush", "painting", "pigment", "tool", "watercolor" });
        private static IconData _Palette;
        public static IconData FA_Palette => _Palette ??= new IconData("Palette", "\U0000F53F", Styles.Solid, new string[] { "acrylic", "art", "artist palette", "brush", "color", "colors", "creativity", "design", "drawing", "paint", "paintbrush", "painting", "palette", "pigment", "watercolor" });
        private static IconData _Palfed;
        public static IconData FA_Palfed => _Palfed ??= new IconData("Palfed", "\U0000F3D8", Styles.Brands, new string[] { "palestine", "palestine federation", "palestinian", "palestinian federation", "palfed" });
        private static IconData _Pallet;
        public static IconData FA_Pallet => _Pallet ??= new IconData("Pallet", "\U0000F482", Styles.Solid, new string[] { "boxes", "cargo", "crates", "delivery", "freight", "inventory", "loading", "logistics", "packaging", "pallet", "shipping", "storage", "supply chain", "transport", "warehouse" });
        private static IconData _Pandora;
        public static IconData FA_Pandora => _Pandora ??= new IconData("Pandora", "\U0000E7DA", Styles.Brands, new string[] { "audio", "brand", "entertainment", "internet radio", "music", "pandora", "pandora radio", "streaming" });
        private static IconData _Panorama;
        public static IconData FA_Panorama => _Panorama ??= new IconData("Panorama", "\U0000E209", Styles.Solid, new string[] { "horizon", "image", "landscape", "nature", "outdoors", "panorama", "photo", "picture", "scenic", "view", "wide", "wide-angle" });
        private static IconData _PaperPlane;
        public static IconData FA_PaperPlane => _PaperPlane ??= new IconData("Paper Plane", "\U0000F1D8", Styles.Regular | Styles.Solid, new string[] { "air", "communication", "delivery", "flight", "float", "folded paper", "mail", "message", "paper", "paper aeroplane", "paper airplane", "plane", "send", "send message" });
        private static IconData _Paperclip;
        public static IconData FA_Paperclip => _Paperclip ??= new IconData("Paperclip", "\U0000F0C6", Styles.Solid, new string[] { "attach", "attachment", "binder", "clip", "document", "fasten", "file", "hold", "office", "paperclip", "paperclip icon", "pin" });
        private static IconData _ParachuteBox;
        public static IconData FA_ParachuteBox => _ParachuteBox ??= new IconData("Parachute Box", "\U0000F4CD", Styles.Solid, new string[] { "aid", "airlift", "assistance", "delivery", "drop", "emergency", "humanitarian", "package", "parachute", "relief", "rescue", "supplies" });
        private static IconData _Paragraph;
        public static IconData FA_Paragraph => _Paragraph ??= new IconData("Paragraph", "\U0000F1DD", Styles.Solid, new string[] { "edit", "formatting", "mark", "paragraph", "paragraph break", "pilcrow", "symbol", "text", "writing" });
        private static IconData _Passport;
        public static IconData FA_Passport => _Passport ??= new IconData("Passport", "\U0000F5AB", Styles.Solid, new string[] { "border", "citizenship", "document", "id", "identification", "immigration", "international", "passport", "passport control", "travel", "travel document", "visa" });
        private static IconData _Paste;
        public static IconData FA_Paste => _Paste ??= new IconData("Paste", "\U0000F0EA", Styles.Regular | Styles.Solid, new string[] { "clipboard", "clipboard-insert", "clipboard-paste", "content", "document", "input", "insert", "paper", "paste", "text" });
        private static IconData _Patreon;
        public static IconData FA_Patreon => _Patreon ??= new IconData("Patreon", "\U0000F3D9", Styles.Brands, new string[] { "content creator", "creator", "crowdfunding", "donations", "fan funding", "membership", "patreon", "patron", "subscription", "support" });
        private static IconData _Pause;
        public static IconData FA_Pause => _Pause ??= new IconData("Pause", "\U0000F04C", Styles.Solid, new string[] { "break", "double bar", "freeze", "hold", "interrupt", "pause", "pause button", "stop", "vertical bars", "wait" });
        private static IconData _Paw;
        public static IconData FA_Paw => _Paw ??= new IconData("Paw", "\U0000F1B0", Styles.Solid, new string[] { "animal", "cat", "claw", "dog", "footprint", "mammal", "paw", "paw pad", "paw print", "pawprint", "pet", "print" });
        private static IconData _Paypal;
        public static IconData FA_Paypal => _Paypal ??= new IconData("Paypal", "\U0000F1ED", Styles.Brands, new string[] { "checkout", "digital wallet", "ecommerce", "finance", "merchant", "money transfer", "online payment", "pay", "payment", "payments", "paypal", "transaction" });
        private static IconData _Peace;
        public static IconData FA_Peace => _Peace ??= new IconData("Peace", "\U0000F67C", Styles.Solid, new string[] { "antiwar", "calm", "ceasefire", "harmony", "nonviolence", "pacifism", "peace", "peace symbol", "protest", "serenity", "tranquility" });
        private static IconData _Pen;
        public static IconData FA_Pen => _Pen ??= new IconData("Pen", "\U0000F304", Styles.Solid, new string[] { "ballpoint", "compose", "drawing", "edit", "handwriting", "modify", "note", "pen", "signature", "sketch", "update", "write" });
        private static IconData _PenClip;
        public static IconData FA_PenClip => _PenClip ??= new IconData("Pen Clip", "\U0000F305", Styles.Solid, new string[] { "annotate", "compose", "create", "draw", "edit", "modify", "note", "pen", "pencil", "update", "write" });
        private static IconData _PenFancy;
        public static IconData FA_PenFancy => _PenFancy ??= new IconData("Pen Fancy", "\U0000F5AC", Styles.Solid, new string[] { "black nib", "calligraphy", "design", "drawing", "edit", "fountain pen", "handwriting", "ink", "modify", "nib", "pen", "signature", "stylus", "update", "write" });
        private static IconData _PenNib;
        public static IconData FA_PenNib => _PenNib ??= new IconData("Pen Nib", "\U0000F5AD", Styles.Solid, new string[] { "calligraphy", "design", "drawing", "edit", "handwriting", "modify", "nib", "pen", "sketch", "update", "write" });
        private static IconData _PenRuler;
        public static IconData FA_PenRuler => _PenRuler ??= new IconData("Pen Ruler", "\U0000F5AE", Styles.Solid, new string[] { "architecture", "creativity", "design", "draft", "draw", "edit", "measurement", "modify", "pencil", "plan", "ruler", "sketch" });
        private static IconData _PenToSquare;
        public static IconData FA_PenToSquare => _PenToSquare ??= new IconData("Pen To Square", "\U0000F044", Styles.Regular | Styles.Solid, new string[] { "annotate", "change", "compose", "document", "draft", "edit", "form", "input", "modify", "note", "pen", "pencil", "signature", "update", "write" });
        private static IconData _Pencil;
        public static IconData FA_Pencil => _Pencil ??= new IconData("Pencil", "\U0000F303", Styles.Solid, new string[] { "annotate", "compose", "design", "draft", "draw", "edit", "modify", "note", "pencil", "sketch", "update", "write" });
        private static IconData _Pentagon;
        public static IconData FA_Pentagon => _Pentagon ??= new IconData("Pentagon", "\U0000E790", Styles.Solid, new string[] { "5", "figure", "five", "geometric", "pentagon", "pentagonal", "polygon", "shape", "sided shape" });
        private static IconData _PeopleArrows;
        public static IconData FA_PeopleArrows => _PeopleArrows ??= new IconData("People Arrows", "\U0000E068", Styles.Solid, new string[] { "arrows", "communication", "connection", "conversation", "discussion", "exchange", "group", "interaction", "isolation", "people", "separate", "social distancing", "users" });
        private static IconData _PeopleCarryBox;
        public static IconData FA_PeopleCarryBox => _PeopleCarryBox ??= new IconData("People Carry Box", "\U0000F4CE", Styles.Solid, new string[] { "box", "carrying", "collaboration", "group", "help", "moving", "people", "support", "teamwork", "transport" });
        private static IconData _PeopleGroup;
        public static IconData FA_PeopleGroup => _PeopleGroup ??= new IconData("People Group", "\U0000E533", Styles.Solid, new string[] { "community", "crowd", "family", "gathering", "group", "members", "people", "social", "team", "together", "users" });
        private static IconData _PeopleLine;
        public static IconData FA_PeopleLine => _PeopleLine ??= new IconData("People Line", "\U0000E534", Styles.Solid, new string[] { "community", "crowd", "group", "people", "team", "together", "users" });
        private static IconData _PeoplePulling;
        public static IconData FA_PeoplePulling => _PeoplePulling ??= new IconData("People Pulling", "\U0000E535", Styles.Solid, new string[] { "cooperation", "effort", "forced return", "group", "pulling", "struggle", "teamwork", "tugging", "yanking" });
        private static IconData _PeopleRobbery;
        public static IconData FA_PeopleRobbery => _PeopleRobbery ??= new IconData("People Robbery", "\U0000E536", Styles.Solid, new string[] { "burglary", "criminal", "hands up", "hold up", "looting", "mugging", "robbery", "robbery suspect", "steal", "theft" });
        private static IconData _PeopleRoof;
        public static IconData FA_PeopleRoof => _PeopleRoof ??= new IconData("People Roof", "\U0000E537", Styles.Solid, new string[] { "community", "crowd", "family", "group", "home", "housing", "manage", "people", "protection", "safe", "shelter", "support", "together" });
        private static IconData _PepperHot;
        public static IconData FA_PepperHot => _PepperHot ??= new IconData("Pepper Hot", "\U0000F816", Styles.Solid, new string[] { "capsicum", "cayenne", "chili", "chili pepper", "chilli", "fiery", "habanero", "heat", "hot", "hot pepper", "jalapeno", "pepper", "peppercorn", "red pepper", "spicy", "spicy food", "tabasco" });
        private static IconData _Perbyte;
        public static IconData FA_Perbyte => _Perbyte ??= new IconData("Perbyte", "\U0000E083", Styles.Brands, new string[] { "digital", "perbyte", "perbyte brand", "perbyte logo", "software", "technology" });
        private static IconData _Percent;
        public static IconData FA_Percent => _Percent ??= new IconData("Percent", "\U00000025", Styles.Solid, new string[] { "discount", "fraction", "interest rate", "percent", "percent off", "percent sign", "percent symbol", "percent value", "percentage", "proportion", "rate", "ratio", "tax rate" });
        private static IconData _Periscope;
        public static IconData FA_Periscope => _Periscope ??= new IconData("Periscope", "\U0000F3DA", Styles.Brands, new string[] { "app", "broadcast", "camera", "live streaming", "live video", "mobile app", "periscope", "social media", "streaming", "video" });
        private static IconData _Person;
        public static IconData FA_Person => _Person ??= new IconData("Person", "\U0000F183", Styles.Solid, new string[] { "avatar", "figure", "human", "individual", "man", "person", "profile", "standing", "user", "woman" });
        private static IconData _PersonArrowDownToLine;
        public static IconData FA_PersonArrowDownToLine => _PersonArrowDownToLine ??= new IconData("Person Arrow Down To Line", "\U0000E538", Styles.Solid, new string[] { "access", "arrow down", "arrow to line", "download", "enter", "insert", "login", "person", "sign in", "user" });
        private static IconData _PersonArrowUpFromLine;
        public static IconData FA_PersonArrowUpFromLine => _PersonArrowUpFromLine ??= new IconData("Person Arrow Up From Line", "\U0000E539", Styles.Solid, new string[] { "arrow", "growth", "increase", "person", "profile", "promotion", "rise", "upgrade", "upward", "user" });
        private static IconData _PersonBiking;
        public static IconData FA_PersonBiking => _PersonBiking ??= new IconData("Person Biking", "\U0000F84A", Styles.Solid, new string[] { "bicycle", "bike", "biking", "cycling", "cyclist", "exercise", "fitness", "outdoors", "pedal", "person biking", "recreation", "wheel" });
        private static IconData _PersonBooth;
        public static IconData FA_PersonBooth => _PersonBooth ??= new IconData("Person Booth", "\U0000F756", Styles.Solid, new string[] { "ballot", "changing room", "curtain", "election", "polling", "privacy", "vote", "voter", "voting", "voting booth" });
        private static IconData _PersonBreastfeeding;
        public static IconData FA_PersonBreastfeeding => _PersonBreastfeeding ??= new IconData("Person Breastfeeding", "\U0000E53A", Styles.Solid, new string[] { "baby", "breastfeeding", "child", "feeding", "infant", "lactation", "mother", "nursing", "nutrition", "parent", "sustenance" });
        private static IconData _PersonBurst;
        public static IconData FA_PersonBurst => _PersonBurst ??= new IconData("Person Burst", "\U0000E53B", Styles.Solid, new string[] { "abuse", "accident", "burst", "crash", "danger", "emergency", "explode", "harm", "impact", "injury", "shock", "trauma", "violence" });
        private static IconData _PersonCane;
        public static IconData FA_PersonCane => _PersonCane ??= new IconData("Person Cane", "\U0000E53C", Styles.Solid, new string[] { "aging", "assistance", "cane", "disabled", "elderly", "mobility", "old", "senior", "staff", "support", "walking stick" });
        private static IconData _PersonChalkboard;
        public static IconData FA_PersonChalkboard => _PersonChalkboard ??= new IconData("Person Chalkboard", "\U0000E53D", Styles.Solid, new string[] { "blackboard", "chalkboard", "classroom", "education", "instructor", "lecture", "lesson", "presentation", "seminar", "speaker", "teacher", "teaching", "training" });
        private static IconData _PersonCircleCheck;
        public static IconData FA_PersonCircleCheck => _PersonCircleCheck ??= new IconData("Person Circle Check", "\U0000E53E", Styles.Solid, new string[] { "account", "active", "approved", "check", "confirmed", "enabled", "ok", "okay", "profile", "success", "user", "validated", "verified", "verified user" });
        private static IconData _PersonCircleExclamation;
        public static IconData FA_PersonCircleExclamation => _PersonCircleExclamation ??= new IconData("Person Circle Exclamation", "\U0000E53F", Styles.Solid, new string[] { "account", "alert", "attention", "error", "exclamation", "failed", "issue", "missing", "person", "problem", "profile", "user", "warning" });
        private static IconData _PersonCircleMinus;
        public static IconData FA_PersonCircleMinus => _PersonCircleMinus ??= new IconData("Person Circle Minus", "\U0000E540", Styles.Solid, new string[] { "account removal", "delete", "delete user", "minus", "person", "profile", "remove", "remove account", "remove user", "subtract", "user", "user minus" });
        private static IconData _PersonCirclePlus;
        public static IconData FA_PersonCirclePlus => _PersonCirclePlus ??= new IconData("Person Circle Plus", "\U0000E541", Styles.Solid, new string[] { "account", "add", "contact", "create", "friend", "member", "new", "person", "plus", "profile", "register", "sign up", "user" });
        private static IconData _PersonCircleQuestion;
        public static IconData FA_PersonCircleQuestion => _PersonCircleQuestion ??= new IconData("Person Circle Question", "\U0000E542", Styles.Solid, new string[] { "account", "assistance", "faq", "help", "inquiry", "profile", "question", "support", "unknown", "user" });
        private static IconData _PersonCircleXmark;
        public static IconData FA_PersonCircleXmark => _PersonCircleXmark ??= new IconData("Person Circle Xmark", "\U0000E543", Styles.Solid, new string[] { "avatar", "ban", "block", "cancel", "circle", "close", "delete", "disable", "person", "profile", "remove", "user", "xmark" });
        private static IconData _PersonDigging;
        public static IconData FA_PersonDigging => _PersonDigging ??= new IconData("Person Digging", "\U0000F85E", Styles.Solid, new string[] { "construction", "digging", "digging site", "digging worker", "excavation", "labor", "maintenance", "manual labor", "shovel", "site work", "work", "worker" });
        private static IconData _PersonDotsFromLine;
        public static IconData FA_PersonDotsFromLine => _PersonDotsFromLine ??= new IconData("Person Dots From Line", "\U0000F470", Styles.Solid, new string[] { "allergy", "connection", "diagnosis", "dots", "linked", "network", "person", "profile", "user" });
        private static IconData _PersonDress;
        public static IconData FA_PersonDress => _PersonDress ??= new IconData("Person Dress", "\U0000F182", Styles.Solid, new string[] { "clothing", "dress", "female", "female avatar", "person", "skirt", "user", "woman" });
        private static IconData _PersonDressBurst;
        public static IconData FA_PersonDressBurst => _PersonDressBurst ??= new IconData("Person Dress Burst", "\U0000E544", Styles.Solid, new string[] { "accident", "blast", "burst", "crash", "danger", "dress", "explosion", "hazard", "injury", "person", "violence" });
        private static IconData _PersonDrowning;
        public static IconData FA_PersonDrowning => _PersonDrowning ??= new IconData("Person Drowning", "\U0000E545", Styles.Solid, new string[] { "danger", "distress", "drown", "drowning", "emergency", "hazard", "help", "lifesaver", "swim", "water rescue" });
        private static IconData _PersonFalling;
        public static IconData FA_PersonFalling => _PersonFalling ??= new IconData("Person Falling", "\U0000E546", Styles.Solid, new string[] { "accident", "danger", "fall", "falling person", "hazard", "injury", "slip", "trip", "tumble" });
        private static IconData _PersonFallingBurst;
        public static IconData FA_PersonFallingBurst => _PersonFallingBurst ??= new IconData("Person Falling Burst", "\U0000E547", Styles.Solid, new string[] { "accident", "collapse", "danger", "emergency", "fall", "hazard", "injury", "slip", "trip", "tumble" });
        private static IconData _PersonHalfDress;
        public static IconData FA_PersonHalfDress => _PersonHalfDress ??= new IconData("Person Half Dress", "\U0000E548", Styles.Solid, new string[] { "clothing", "gender", "gender fluid", "gender identity", "half dress", "man", "nonbinary", "person", "restroom", "transgender", "unisex", "woman" });
        private static IconData _PersonHarassing;
        public static IconData FA_PersonHarassing => _PersonHarassing ??= new IconData("Person Harassing", "\U0000E549", Styles.Solid, new string[] { "abuse", "attack", "bully", "harass", "harassment", "insult", "intimidation", "mistreat", "scream", "shout", "verbal abuse", "yell" });
        private static IconData _PersonHiking;
        public static IconData FA_PersonHiking => _PersonHiking ??= new IconData("Person Hiking", "\U0000F6EC", Styles.Solid, new string[] { "adventure", "autumn", "backpack", "exercise", "fall", "hike", "hiking", "mountain", "nature", "outdoors", "summer", "trail", "trekking", "walk" });
        private static IconData _PersonMilitaryPointing;
        public static IconData FA_PersonMilitaryPointing => _PersonMilitaryPointing ??= new IconData("Person Military Pointing", "\U0000E54A", Styles.Solid, new string[] { "army", "commander", "guard", "military", "officer", "pointing", "salute", "service", "soldier", "troops" });
        private static IconData _PersonMilitaryRifle;
        public static IconData FA_PersonMilitaryRifle => _PersonMilitaryRifle ??= new IconData("Person Military Rifle", "\U0000E54B", Styles.Solid, new string[] { "armed forces", "army", "combat", "gun", "infantry", "military", "rifle", "soldier", "war", "weapon" });
        private static IconData _PersonMilitaryToPerson;
        public static IconData FA_PersonMilitaryToPerson => _PersonMilitaryToPerson ??= new IconData("Person Military To Person", "\U0000E54C", Styles.Solid, new string[] { "change", "civilian", "identity", "military", "person", "role", "service member", "soldier", "transfer", "transition", "user" });
        private static IconData _PersonPraying;
        public static IconData FA_PersonPraying => _PersonPraying ??= new IconData("Person Praying", "\U0000F683", Styles.Solid, new string[] { "devotion", "faith", "gratitude", "kneel", "meditate", "place of worship", "prayer", "praying", "religion", "spiritual", "thank", "worship" });
        private static IconData _PersonPregnant;
        public static IconData FA_PersonPregnant => _PersonPregnant ??= new IconData("Person Pregnant", "\U0000E31E", Styles.Solid, new string[] { "baby", "birth", "expecting", "maternity", "parent", "pregnant", "pregnant woman", "woman" });
        private static IconData _PersonRays;
        public static IconData FA_PersonRays => _PersonRays ??= new IconData("Person Rays", "\U0000E54D", Styles.Solid, new string[] { "affected", "focus", "highlight", "person", "rays", "shine", "spotlight", "user" });
        private static IconData _PersonRifle;
        public static IconData FA_PersonRifle => _PersonRifle ??= new IconData("Person Rifle", "\U0000E54E", Styles.Solid, new string[] { "army", "combatant", "firearm", "gun", "infantry", "military", "rifle", "shooter", "soldier", "war" });
        private static IconData _PersonRunning;
        public static IconData FA_PersonRunning => _PersonRunning ??= new IconData("Person Running", "\U0000F70C", Styles.Solid, new string[] { "athletic", "escape", "exercise", "fitness", "flee", "jogging", "marathon", "person running", "race", "run", "runner", "running", "sprint", "track", "workout" });
        private static IconData _PersonShelter;
        public static IconData FA_PersonShelter => _PersonShelter ??= new IconData("Person Shelter", "\U0000E54F", Styles.Solid, new string[] { "home", "house", "indoors", "occupant", "person", "protection", "refuge", "roof", "safe", "safety", "shelter" });
        private static IconData _PersonSkating;
        public static IconData FA_PersonSkating => _PersonSkating ??= new IconData("Person Skating", "\U0000F7C5", Styles.Solid, new string[] { "figure skating", "ice skating", "olympics", "rink", "skater", "skating", "winter sports" });
        private static IconData _PersonSkiing;
        public static IconData FA_PersonSkiing => _PersonSkiing ??= new IconData("Person Skiing", "\U0000F7C9", Styles.Solid, new string[] { "alpine", "cold weather", "downhill", "mountain", "olympics", "ski", "skier", "skiing", "slope", "snow", "snow sport", "winter" });
        private static IconData _PersonSkiingNordic;
        public static IconData FA_PersonSkiingNordic => _PersonSkiingNordic ??= new IconData("Person Skiing Nordic", "\U0000F7CA", Styles.Solid, new string[] { "athlete", "cold weather", "cross country", "nordic skiing", "olympics", "outdoor", "ski", "snow", "winter sports" });
        private static IconData _PersonSnowboarding;
        public static IconData FA_PersonSnowboarding => _PersonSnowboarding ??= new IconData("Person Snowboarding", "\U0000F7CE", Styles.Solid, new string[] { "athlete", "olympics", "snow", "snow sport", "snowboard", "snowboarder", "snowboarding", "sport", "winter", "winter sports" });
        private static IconData _PersonSwimming;
        public static IconData FA_PersonSwimming => _PersonSwimming ??= new IconData("Person Swimming", "\U0000F5C4", Styles.Solid, new string[] { "aquatic", "exercise", "freestyle", "lap swimming", "ocean", "pool", "sea", "sport", "swim", "swimmer", "swimming", "water" });
        private static IconData _PersonThroughWindow;
        public static IconData FA_PersonThroughWindow => _PersonThroughWindow ??= new IconData("Person Through Window", "\U0000E5A9", Styles.Solid, new string[] { "break-in", "burglary", "door", "exit", "forced entry", "intrusion", "leave", "looking", "peeking", "person", "through", "window" });
        private static IconData _PersonWalking;
        public static IconData FA_PersonWalking => _PersonWalking ??= new IconData("Person Walking", "\U0000F554", Styles.Solid, new string[] { "crosswalk", "exercise", "hike", "move", "pedestrian", "person walking", "stroll", "walk", "walking", "walking activity", "workout" });
        private static IconData _PersonWalkingArrowLoopLeft;
        public static IconData FA_PersonWalkingArrowLoopLeft => _PersonWalkingArrowLoopLeft ??= new IconData("Person Walking Arrow Loop Left", "\U0000E551", Styles.Solid, new string[] { "arrow", "back", "follow", "go back", "loop", "person", "return", "reverse", "rewind", "undo", "walking" });
        private static IconData _PersonWalkingArrowRight;
        public static IconData FA_PersonWalkingArrowRight => _PersonWalkingArrowRight ??= new IconData("Person Walking Arrow Right", "\U0000E552", Styles.Solid, new string[] { "arrow", "continue", "direction", "exit", "forward", "leave", "move", "next", "person", "proceed", "right", "walk" });
        private static IconData _PersonWalkingDashedLineArrowRight;
        public static IconData FA_PersonWalkingDashedLineArrowRight => _PersonWalkingDashedLineArrowRight ??= new IconData("Person Walking Dashed Line Arrow Right", "\U0000E553", Styles.Solid, new string[] { "arrow", "dashed line", "direction", "exit", "follow", "forward", "move", "next", "path", "pedestrian", "proceed", "route", "walking" });
        private static IconData _PersonWalkingLuggage;
        public static IconData FA_PersonWalkingLuggage => _PersonWalkingLuggage ??= new IconData("Person Walking Luggage", "\U0000E554", Styles.Solid, new string[] { "bag", "baggage", "briefcase", "carry-on", "luggage", "rolling", "suitcase", "travel", "traveler", "walking" });
        private static IconData _PersonWalkingWithCane;
        public static IconData FA_PersonWalkingWithCane => _PersonWalkingWithCane ??= new IconData("Person Walking With Cane", "\U0000F29D", Styles.Solid, new string[] { "accessibility", "blind", "cane", "disabled", "elderly", "mobility aid", "person", "senior", "visually impaired", "walking", "walking stick" });
        private static IconData _PesetaSign;
        public static IconData FA_PesetaSign => _PesetaSign ??= new IconData("Peseta Sign", "\U0000E221", Styles.Solid, new string[] { "cash", "currency", "finance", "money", "old currency", "payment", "peseta", "peseta sign", "spanish currency", "symbol" });
        private static IconData _PesoSign;
        public static IconData FA_PesoSign => _PesoSign ??= new IconData("Peso Sign", "\U0000E222", Styles.Solid, new string[] { "currency", "currency sign", "currency symbol", "money", "peso", "peso coin", "peso currency", "peso peso currency", "peso peso moneda", "peso sign", "peso symbol" });
        private static IconData _Phabricator;
        public static IconData FA_Phabricator => _Phabricator ??= new IconData("Phabricator", "\U0000F3DB", Styles.Brands, new string[] { "code review", "collaboration", "development", "open source", "phabricator", "project management", "repository", "software", "version control" });
        private static IconData _PhoenixFramework;
        public static IconData FA_PhoenixFramework => _PhoenixFramework ??= new IconData("Phoenix Framework", "\U0000F3DC", Styles.Brands, new string[] { "backend", "development", "elixir", "open source", "phoenix", "phoenix framework", "programming", "server", "software", "web framework" });
        private static IconData _PhoenixSquadron;
        public static IconData FA_PhoenixSquadron => _PhoenixSquadron ??= new IconData("Phoenix Squadron", "\U0000F511", Styles.Brands, new string[] { "phoenix", "phoenix squadron", "pilot", "rebellion", "resistance", "sci-fi", "space battle", "squadron", "star wars", "starfighter" });
        private static IconData _Phone;
        public static IconData FA_Phone => _Phone ??= new IconData("Phone", "\U0000F095", Styles.Solid, new string[] { "call", "communication", "contact", "dial", "earphone", "handset", "landline", "mobile", "phone", "receiver", "support", "talk", "telephone", "voice" });
        private static IconData _PhoneFlip;
        public static IconData FA_PhoneFlip => _PhoneFlip ??= new IconData("Phone Flip", "\U0000F879", Styles.Solid, new string[] { "call", "communication", "flip phone", "handset", "mobile", "phone", "receiver", "support", "telephone", "voice" });
        private static IconData _PhoneSlash;
        public static IconData FA_PhoneSlash => _PhoneSlash ??= new IconData("Phone Slash", "\U0000F3DD", Styles.Solid, new string[] { "block", "call", "cancel", "disabled", "disconnect", "end-call", "handset", "mute", "no-sound", "off", "phone", "reject", "silent", "telephone", "voice" });
        private static IconData _PhoneVolume;
        public static IconData FA_PhoneVolume => _PhoneVolume ??= new IconData("Phone Volume", "\U0000F2A0", Styles.Solid, new string[] { "audio", "call", "communication", "handset", "phone", "ringing", "ringtone", "sound", "speaker", "support", "talk", "telephone", "voice", "volume" });
        private static IconData _PhotoFilm;
        public static IconData FA_PhotoFilm => _PhotoFilm ??= new IconData("Photo Film", "\U0000F87C", Styles.Solid, new string[] { "camera", "film", "gallery", "image", "media", "movie", "photo", "photograph", "picture", "reel", "snapshot", "video" });
        private static IconData _Php;
        public static IconData FA_Php => _Php ??= new IconData("Php", "\U0000F457", Styles.Brands, new string[] { "php", "php code", "php developer", "php framework", "php language", "php logo", "php programming", "php script" });
        private static IconData _PictureInPicture;
        public static IconData FA_PictureInPicture => _PictureInPicture ??= new IconData("Picture In Picture", "\U0000E80B", Styles.Solid, new string[] { "floating", "media", "minimize", "multitasking", "overlay", "picture-in-picture", "pip", "popout", "resize", "screen", "secondary window", "small screen", "video", "window" });
        private static IconData _PiedPiper;
        public static IconData FA_PiedPiper => _PiedPiper ??= new IconData("Pied Piper", "\U0000F2AE", Styles.Brands, new string[] { "brand", "fable", "flute", "legend", "music", "pied piper", "piper", "story" });
        private static IconData _PiedPiperAlt;
        public static IconData FA_PiedPiperAlt => _PiedPiperAlt ??= new IconData("Pied Piper Alt", "\U0000F1A8", Styles.Brands, new string[] { "alt", "brand", "company", "logo", "pied piper", "pied-piper", "piper", "software", "startup", "technology" });
        private static IconData _PiedPiperHat;
        public static IconData FA_PiedPiperHat => _PiedPiperHat ??= new IconData("Pied Piper Hat", "\U0000F4E5", Styles.Brands, new string[] { "clothing", "costume", "folklore", "hat", "jester", "mascot", "medieval", "pied piper" });
        private static IconData _PiedPiperPp;
        public static IconData FA_PiedPiperPp => _PiedPiperPp ??= new IconData("Pied Piper Pp", "\U0000F1A7", Styles.Brands, new string[] { "brand", "logo", "pied piper", "pied-piper", "piper", "software", "startup", "technology" });
        private static IconData _PiggyBank;
        public static IconData FA_PiggyBank => _PiggyBank ??= new IconData("Piggy Bank", "\U0000F4D3", Styles.Solid, new string[] { "budget", "cash", "coin", "deposit", "finance", "money", "piggy", "piggy bank", "save", "savings" });
        private static IconData _Pills;
        public static IconData FA_Pills => _Pills ??= new IconData("Pills", "\U0000F484", Styles.Solid, new string[] { "capsules", "drugs", "health", "medication", "medicine", "pharmaceuticals", "pharmacy", "pills", "prescription", "supplements", "tablets", "vitamins" });
        private static IconData _Pinterest;
        public static IconData FA_Pinterest => _Pinterest ??= new IconData("Pinterest", "\U0000F0D2", Styles.Brands, new string[] { "boards", "ideas", "image sharing", "inspiration", "pin", "pins", "pinterest", "social media", "social network", "visual discovery" });
        private static IconData _PinterestP;
        public static IconData FA_PinterestP => _PinterestP ??= new IconData("Pinterest P", "\U0000F231", Styles.Brands, new string[] { "boards", "ideas", "image sharing", "inspiration", "pin", "pinterest", "social media", "visual discovery" });
        private static IconData _Pisces;
        public static IconData FA_Pisces => _Pisces ??= new IconData("Pisces", "\U0000E84C", Styles.Solid, new string[] { "astrology", "constellation", "february", "fish", "horoscope", "march", "pisces", "sign", "stars", "water sign", "zodiac" });
        private static IconData _Pix;
        public static IconData FA_Pix => _Pix ??= new IconData("Pix", "\U0000E43A", Styles.Brands, new string[] { "free images", "images", "media", "photo sharing", "photography", "photos", "pictures", "pix", "pixabay", "stock photos" });
        private static IconData _Pixelfed;
        public static IconData FA_Pixelfed => _Pixelfed ??= new IconData("Pixelfed", "\U0000E7DB", Styles.Brands, new string[] { "decentralized", "fediverse", "image hosting", "open source", "photo sharing", "pixel fed", "pixelfed", "social media", "social network" });
        private static IconData _Pixiv;
        public static IconData FA_Pixiv => _Pixiv ??= new IconData("Pixiv", "\U0000E640", Styles.Brands, new string[] { "anime", "art sharing", "creative community", "digital art platform", "illustration site", "japanese art community", "manga", "pixiv", "pixiv logo" });
        private static IconData _PizzaSlice;
        public static IconData FA_PizzaSlice => _PizzaSlice ??= new IconData("Pizza Slice", "\U0000F818", Styles.Solid, new string[] { "cheese", "chicago", "dinner", "fast food", "food", "italian", "lunch", "mozzarella", "new york", "pepperoni", "pie", "pizza", "slice", "snack", "teenage mutant ninja turtles", "tomato" });
        private static IconData _PlaceOfWorship;
        public static IconData FA_PlaceOfWorship => _PlaceOfWorship ??= new IconData("Place Of Worship", "\U0000F67F", Styles.Solid, new string[] { "building", "chapel", "church", "faith", "holy place", "mosque", "religion", "sanctuary", "spiritual", "synagogue", "temple", "worship" });
        private static IconData _Plane;
        public static IconData FA_Plane => _Plane ??= new IconData("Plane", "\U0000F072", Styles.Solid, new string[] { "aircraft", "airplane", "airport", "arrival", "departure", "flight", "fly", "journey", "plane", "transportation", "travel", "trip" });
        private static IconData _PlaneArrival;
        public static IconData FA_PlaneArrival => _PlaneArrival ??= new IconData("Plane Arrival", "\U0000F5AF", Styles.Solid, new string[] { "aeroplane", "airplane", "airport", "arrival", "arrivals", "destination", "flight", "fly", "incoming", "land", "landing", "plane", "touch down", "travel", "trip" });
        private static IconData _PlaneCircleCheck;
        public static IconData FA_PlaneCircleCheck => _PlaneCircleCheck ??= new IconData("Plane Circle Check", "\U0000E555", Styles.Solid, new string[] { "active", "airplane", "airport", "approved", "available", "check", "confirmed", "enabled", "flight", "fly", "ok", "okay", "travel", "validated" });
        private static IconData _PlaneCircleExclamation;
        public static IconData FA_PlaneCircleExclamation => _PlaneCircleExclamation ??= new IconData("Plane Circle Exclamation", "\U0000E556", Styles.Solid, new string[] { "affected", "airplane", "airport", "alert", "canceled", "delay", "exclamation", "flight", "issue", "problem", "travel", "warning" });
        private static IconData _PlaneCircleXmark;
        public static IconData FA_PlaneCircleXmark => _PlaneCircleXmark ??= new IconData("Plane Circle Xmark", "\U0000E557", Styles.Solid, new string[] { "airplane", "blocked", "cancel", "delete", "flight", "no fly", "prohibited", "reject", "remove", "stop", "travel", "xmark" });
        private static IconData _PlaneDeparture;
        public static IconData FA_PlaneDeparture => _PlaneDeparture ??= new IconData("Plane Departure", "\U0000F5B0", Styles.Solid, new string[] { "aeroplane", "airplane", "airplane departure", "airport", "boarding", "departing", "departure", "flight", "fly", "leaving", "plane", "takeoff", "taking off", "terminal", "travel", "trip" });
        private static IconData _PlaneLock;
        public static IconData FA_PlaneLock => _PlaneLock ??= new IconData("Plane Lock", "\U0000E558", Styles.Solid, new string[] { "airplane", "airport", "flight", "grounded", "lockdown", "locked", "no-fly", "padlock", "privacy", "quarantine", "restricted", "security", "travel" });
        private static IconData _PlaneSlash;
        public static IconData FA_PlaneSlash => _PlaneSlash ??= new IconData("Plane Slash", "\U0000E069", Styles.Solid, new string[] { "airplane mode", "airplane off", "disabled", "flight canceled", "flight delayed", "flight off", "grounded", "no airplane", "no flights", "no plane", "no signal", "no travel", "offline", "travel off" });
        private static IconData _PlaneUp;
        public static IconData FA_PlaneUp => _PlaneUp ??= new IconData("Plane Up", "\U0000E22D", Styles.Solid, new string[] { "aircraft", "airplane", "aviation", "departure", "flight", "flying", "plane", "sky", "takeoff", "travel" });
        private static IconData _PlantWilt;
        public static IconData FA_PlantWilt => _PlantWilt ??= new IconData("Plant Wilt", "\U0000E5AA", Styles.Solid, new string[] { "agriculture", "drooping", "drought", "dry", "dying", "garden", "leaf", "plant", "shriveled", "vegetation", "wilt", "withered" });
        private static IconData _PlateWheat;
        public static IconData FA_PlateWheat => _PlateWheat ??= new IconData("Plate Wheat", "\U0000E55A", Styles.Solid, new string[] { "agriculture", "bowl", "bread", "cereal", "crop", "farming", "food", "grain", "harvest", "hunger", "meal", "nutrition", "plate", "rations", "wheat" });
        private static IconData _Play;
        public static IconData FA_Play => _Play ??= new IconData("Play", "\U0000F04B", Styles.Solid, new string[] { "arrow", "audio", "forward", "go", "media", "music", "play", "play button", "playback", "press", "right", "sound", "start", "triangle", "video" });
        private static IconData _Playstation;
        public static IconData FA_Playstation => _Playstation ??= new IconData("Playstation", "\U0000F3DF", Styles.Brands, new string[] { "console", "controller", "entertainment", "game system", "gaming", "playstation", "ps", "sony", "video game", "videogame" });
        private static IconData _Plug;
        public static IconData FA_Plug => _Plug ??= new IconData("Plug", "\U0000F1E6", Styles.Solid, new string[] { "adapter", "cable", "charge", "charging", "connect", "connector", "electric", "electricity", "energy", "outlet", "plug", "plug-in", "power", "power cord", "socket" });
        private static IconData _PlugCircleBolt;
        public static IconData FA_PlugCircleBolt => _PlugCircleBolt ??= new IconData("Plug Circle Bolt", "\U0000E55B", Styles.Solid, new string[] { "bolt", "charge", "current", "electric", "electricity", "energy", "lightning", "outlet", "plug", "power", "socket" });
        private static IconData _PlugCircleCheck;
        public static IconData FA_PlugCircleCheck => _PlugCircleCheck ??= new IconData("Plug Circle Check", "\U0000E55C", Styles.Solid, new string[] { "active", "check", "connected", "electric", "electricity", "enabled", "ok", "okay", "plug", "power", "validate", "verified", "working" });
        private static IconData _PlugCircleExclamation;
        public static IconData FA_PlugCircleExclamation => _PlugCircleExclamation ??= new IconData("Plug Circle Exclamation", "\U0000E55D", Styles.Solid, new string[] { "alert", "caution", "disconnected", "electric", "electricity", "error", "exclamation", "failure", "issue", "outage", "plug", "power", "problem", "warning" });
        private static IconData _PlugCircleMinus;
        public static IconData FA_PlugCircleMinus => _PlugCircleMinus ??= new IconData("Plug Circle Minus", "\U0000E55E", Styles.Solid, new string[] { "disable", "disconnect", "electric", "electricity", "minus", "outlet", "plug", "power", "power off", "remove", "socket", "unplug" });
        private static IconData _PlugCirclePlus;
        public static IconData FA_PlugCirclePlus => _PlugCirclePlus ??= new IconData("Plug Circle Plus", "\U0000E55F", Styles.Solid, new string[] { "add", "charging", "connect", "electric", "electricity", "energy", "insert", "plug", "plus", "power", "socket", "supply" });
        private static IconData _PlugCircleXmark;
        public static IconData FA_PlugCircleXmark => _PlugCircleXmark ??= new IconData("Plug Circle Xmark", "\U0000E560", Styles.Solid, new string[] { "cancel", "close", "disable", "disconnect", "electric", "electricity", "error", "outage", "plug", "power", "remove", "stop", "unplug", "xmark" });
        private static IconData _Plus;
        public static IconData FA_Plus => _Plus ??= new IconData("Plus", "\U0000002B", Styles.Solid, new string[] { "add", "create", "expand", "icon", "increase", "math", "more", "new", "plus", "plus sign", "positive", "sign", "symbol" });
        private static IconData _PlusMinus;
        public static IconData FA_PlusMinus => _PlusMinus ??= new IconData("Plus Minus", "\U0000E43C", Styles.Solid, new string[] { "add", "adjust", "arithmetic", "math", "plus minus", "plus-minus", "positive negative", "sign", "subtract", "symbol", "toggle" });
        private static IconData _Podcast;
        public static IconData FA_Podcast => _Podcast ??= new IconData("Podcast", "\U0000F2CE", Styles.Solid, new string[] { "audio", "broadcast", "conversation", "episode", "interview", "media", "music", "radio", "recording", "show", "sound", "streaming", "talk" });
        private static IconData _Poo;
        public static IconData FA_Poo => _Poo ??= new IconData("Poo", "\U0000F2FE", Styles.Solid, new string[] { "crap", "dung", "emoji", "excrement", "feces", "funny", "pile of poo", "poo", "poop", "poop emoji", "shit", "smelly", "stink", "turd", "waste" });
        private static IconData _PooStorm;
        public static IconData FA_PooStorm => _PooStorm ??= new IconData("Poo Storm", "\U0000F75A", Styles.Solid, new string[] { "bad smell", "chaos", "cloud", "disaster", "euphemism", "foul", "lightning", "mess", "poop", "shit", "storm", "turd" });
        private static IconData _Poop;
        public static IconData FA_Poop => _Poop ??= new IconData("Poop", "\U0000F619", Styles.Solid, new string[] { "brown", "cartoon", "crap", "dung", "excrement", "feces", "funny", "pile", "poop", "poop emoji", "shit", "stink", "turd" });
        private static IconData _Postgresql;
        public static IconData FA_Postgresql => _Postgresql ??= new IconData("Postgresql", "\U0000E858", Styles.Brands, new string[] { });
        private static IconData _PowerOff;
        public static IconData FA_PowerOff => _PowerOff ??= new IconData("Power Off", "\U0000F011", Styles.Solid, new string[] { "button", "computer", "device", "off", "power", "power symbol", "reboot", "restart", "shutdown", "toggle", "turn off" });
        private static IconData _Prescription;
        public static IconData FA_Prescription => _Prescription ??= new IconData("Prescription", "\U0000F5B1", Styles.Solid, new string[] { "doctor", "dosage", "drugs", "healthcare", "medical", "medication", "medicine", "pharmacy", "pill", "prescription", "rx", "script", "treatment" });
        private static IconData _PrescriptionBottle;
        public static IconData FA_PrescriptionBottle => _PrescriptionBottle ??= new IconData("Prescription Bottle", "\U0000F485", Styles.Solid, new string[] { "bottle", "drugs", "drugstore", "healthcare", "medical", "medication", "medicine", "pharmacy", "pill", "prescription", "rx", "treatment" });
        private static IconData _PrescriptionBottleMedical;
        public static IconData FA_PrescriptionBottleMedical => _PrescriptionBottleMedical ??= new IconData("Prescription Bottle Medical", "\U0000F486", Styles.Solid, new string[] { "bottle", "drugs", "healthcare", "medical", "medication", "medicine", "pharmacy", "pills", "prescription", "rx" });
        private static IconData _Print;
        public static IconData FA_Print => _Print ??= new IconData("Print", "\U0000F02F", Styles.Solid, new string[] { "business", "computer", "copy", "document", "hard copy", "office", "output", "paper", "print", "print icon", "print screen", "printer", "printer icon", "printing" });
        private static IconData _ProductHunt;
        public static IconData FA_ProductHunt => _ProductHunt ??= new IconData("Product Hunt", "\U0000F288", Styles.Brands, new string[] { "app discovery", "community", "innovation", "launch", "new apps", "ph", "product hunt", "products", "startup", "tech" });
        private static IconData _PumpMedical;
        public static IconData FA_PumpMedical => _PumpMedical ??= new IconData("Pump Medical", "\U0000E06A", Styles.Solid, new string[] { "anti-bacterial", "clean", "covid-19", "disinfect", "dispenser", "hand sanitizer", "hand soap", "hand wash", "hygiene", "medical", "pump bottle", "sanitizer", "soap" });
        private static IconData _PumpSoap;
        public static IconData FA_PumpSoap => _PumpSoap ??= new IconData("Pump Soap", "\U0000E06B", Styles.Solid, new string[] { "antibacterial", "clean", "covid-19", "disinfect", "germ protection", "hand sanitizer", "hand soap", "handwash", "hygiene", "pump bottle", "sanitizer", "soap" });
        private static IconData _Pushed;
        public static IconData FA_Pushed => _Pushed ??= new IconData("Pushed", "\U0000F3E1", Styles.Brands, new string[] { "action", "button", "click", "interaction", "press", "push", "pushed" });
        private static IconData _PuzzlePiece;
        public static IconData FA_PuzzlePiece => _PuzzlePiece ??= new IconData("Puzzle Piece", "\U0000F12E", Styles.Solid, new string[] { "add-on", "addon", "block", "clue", "connect", "fitting", "game", "interlocking", "jigsaw", "part", "piece", "puzzle", "puzzle piece", "section", "segment" });
        private static IconData _Python;
        public static IconData FA_Python => _Python ??= new IconData("Python", "\U0000F3E2", Styles.Brands, new string[] { "coding", "development", "programming", "python", "python brand", "python language", "python logo", "python programming", "scripting", "software" });
        private static IconData _Q;
        public static IconData FA_Q => _Q ??= new IconData("Q", "\U00000051", Styles.Solid, new string[] { "alphabet", "capital q", "character", "glyph", "letter q", "lowercase q", "symbol", "text", "typography" });
        private static IconData _Qq;
        public static IconData FA_Qq => _Qq ??= new IconData("Qq", "\U0000F1D6", Styles.Brands, new string[] { "chat", "chinese messenger", "communication", "instant messaging", "qq", "social media", "tencent" });
        private static IconData _Qrcode;
        public static IconData FA_Qrcode => _Qrcode ??= new IconData("Qrcode", "\U0000F029", Styles.Solid, new string[] { "barcode", "code", "data", "info", "information", "matrix", "qr", "qr-code", "qrcode", "quick response", "scan", "scanner", "tag" });
        private static IconData _Question;
        public static IconData FA_Question => _Question ??= new IconData("Question", "\U0000003F", Styles.Solid, new string[] { "ask", "faq", "help", "information", "inquiry", "punctuation", "query", "question", "question mark", "request", "support", "symbol", "unknown" });
        private static IconData _Quinscape;
        public static IconData FA_Quinscape => _Quinscape ??= new IconData("Quinscape", "\U0000F459", Styles.Brands, new string[] { "quinscape", "quinscape brand", "quinscape company", "quinscape icon", "quinscape logo" });
        private static IconData _Quora;
        public static IconData FA_Quora => _Quora ??= new IconData("Quora", "\U0000F2C4", Styles.Brands, new string[] { "answers", "community", "discussion", "forum", "knowledge", "q&a", "questions", "quora", "social network" });
        private static IconData _QuoteLeft;
        public static IconData FA_QuoteLeft => _QuoteLeft ??= new IconData("Quote Left", "\U0000F10D", Styles.Solid, new string[] { "citation", "dialogue", "left quote", "mention", "note", "phrase", "quotation", "quotation mark", "quote", "speech", "text" });
        private static IconData _QuoteRight;
        public static IconData FA_QuoteRight => _QuoteRight ??= new IconData("Quote Right", "\U0000F10E", Styles.Solid, new string[] { "citation", "double quote", "mention", "note", "phrase", "quotation", "quote", "right quote", "speech", "text", "type" });
        private static IconData _R;
        public static IconData FA_R => _R ??= new IconData("R", "\U00000052", Styles.Solid, new string[] { "alphabet", "capital r", "character", "latin r", "letter r", "lowercase r", "symbol", "text", "typeface", "typography" });
        private static IconData _RProject;
        public static IconData FA_RProject => _RProject ??= new IconData("R Project", "\U0000F4F7", Styles.Brands, new string[] { "R", "R language", "R programming", "R software", "R-project", "data analysis", "data science", "programming language", "statistical computing" });
        private static IconData _Radiation;
        public static IconData FA_Radiation => _Radiation ??= new IconData("Radiation", "\U0000F7B9", Styles.Solid, new string[] { "biohazard", "contamination", "danger", "deadly", "fallout", "hazard", "nuclear", "radiation", "radioactive", "toxic", "warning" });
        private static IconData _Radio;
        public static IconData FA_Radio => _Radio ??= new IconData("Radio", "\U0000F8D7", Styles.Solid, new string[] { "am", "antenna", "audio", "broadcast", "fm", "frequency", "music", "news", "radio", "receiver", "signal", "station", "transmission", "tuner", "wave" });
        private static IconData _Rainbow;
        public static IconData FA_Rainbow => _Rainbow ??= new IconData("Rainbow", "\U0000F75B", Styles.Solid, new string[] { "arc", "colors", "hope", "leprechaun", "nature", "pot of gold", "prism", "rain", "rainbow", "sky", "spectrum", "sunlight", "weather" });
        private static IconData _RankingStar;
        public static IconData FA_RankingStar => _RankingStar ??= new IconData("Ranking Star", "\U0000E561", Styles.Solid, new string[] { "achievement", "award", "best", "first place", "medal", "podium", "prize", "quality", "ranking", "rating", "star", "success", "top", "win", "winner" });
        private static IconData _RaspberryPi;
        public static IconData FA_RaspberryPi => _RaspberryPi ??= new IconData("Raspberry Pi", "\U0000F7BB", Styles.Brands, new string[] { "SBC", "diy", "electronics", "maker", "pi", "raspberry pi", "raspberry pi foundation", "raspberry-pi", "raspberrypi", "single board computer" });
        private static IconData _Ravelry;
        public static IconData FA_Ravelry => _Ravelry ??= new IconData("Ravelry", "\U0000F2D9", Styles.Brands, new string[] { "crafts", "crochet", "fiber arts", "knitting", "patterns", "ravelry", "yarn" });
        private static IconData _React;
        public static IconData FA_React => _React ??= new IconData("React", "\U0000F41B", Styles.Brands, new string[] { "component", "facebook", "framework", "frontend", "javascript", "jsx", "library", "react", "reactjs", "ui", "web app", "web development" });
        private static IconData _Reacteurope;
        public static IconData FA_Reacteurope => _Reacteurope ??= new IconData("Reacteurope", "\U0000F75D", Styles.Brands, new string[] { "developer event", "frontend", "javascript", "programming", "react conference", "react europe", "reactjs", "tech conference", "web development" });
        private static IconData _Readme;
        public static IconData FA_Readme => _Readme ??= new IconData("Readme", "\U0000F4D5", Styles.Brands, new string[] { "documentation", "guide", "help", "info", "information", "instructions", "manual", "readme", "tutorial" });
        private static IconData _Rebel;
        public static IconData FA_Rebel => _Rebel ??= new IconData("Rebel", "\U0000F1D0", Styles.Brands, new string[] { "alliance", "fighter", "freedom", "insurgent", "rebel", "rebellion", "resistance", "sci-fi", "star wars", "symbol" });
        private static IconData _Receipt;
        public static IconData FA_Receipt => _Receipt ??= new IconData("Receipt", "\U0000F543", Styles.Solid, new string[] { "accounting", "bill", "bookkeeping", "check", "coupon", "expense", "invoice", "money", "payment", "proof", "receipt", "record", "transaction" });
        private static IconData _RecordVinyl;
        public static IconData FA_RecordVinyl => _RecordVinyl ??= new IconData("Record Vinyl", "\U0000F8D9", Styles.Solid, new string[] { "LP", "album", "analog", "audio", "classic", "disc", "groove", "music", "phonograph", "record", "retro", "sound", "turntable", "vinyl" });
        private static IconData _RectangleAd;
        public static IconData FA_RectangleAd => _RectangleAd ??= new IconData("Rectangle Ad", "\U0000F641", Styles.Solid, new string[] { "ad", "advertisement", "announcement", "banner", "commercial", "flyer", "marketing", "media", "newspaper", "poster", "promotion", "publicity" });
        private static IconData _RectangleList;
        public static IconData FA_RectangleList => _RectangleList ??= new IconData("Rectangle List", "\U0000F022", Styles.Regular | Styles.Solid, new string[] { "checklist", "completed", "done", "finished", "items", "list", "notes", "outline", "summary", "tasks", "todo" });
        private static IconData _RectangleXmark;
        public static IconData FA_RectangleXmark => _RectangleXmark ??= new IconData("Rectangle Xmark", "\U0000F410", Styles.Regular | Styles.Solid, new string[] { "cancel", "clear", "close", "delete", "dismiss", "exit", "rectangle", "reject", "remove", "stop", "window", "xmark" });
        private static IconData _Recycle;
        public static IconData FA_Recycle => _Recycle ??= new IconData("Recycle", "\U0000F1B8", Styles.Solid, new string[] { "compost", "eco-friendly", "environmental", "garbage", "recycle", "recycle bin", "recycling", "recycling logo", "recycling symbol", "reuse", "sustainability", "trash", "waste" });
        private static IconData _RedRiver;
        public static IconData FA_RedRiver => _RedRiver ??= new IconData("Red River", "\U0000F3E3", Styles.Brands, new string[] { "environment", "nature", "outdoors", "red river", "redriver", "river", "water" });
        private static IconData _Reddit;
        public static IconData FA_Reddit => _Reddit ??= new IconData("Reddit", "\U0000F1A1", Styles.Brands, new string[] { "community", "discussion", "forum", "karma", "meme", "online community", "reddit", "reddit logo", "social media", "social network", "subreddit", "upvote" });
        private static IconData _RedditAlien;
        public static IconData FA_RedditAlien => _RedditAlien ??= new IconData("Reddit Alien", "\U0000F281", Styles.Brands, new string[] { "alien", "community", "forum", "mascot", "reddit", "snoo", "social media", "subreddit", "upvote" });
        private static IconData _Redhat;
        public static IconData FA_Redhat => _Redhat ??= new IconData("Redhat", "\U0000F7BC", Styles.Brands, new string[] { "enterprise linux", "linux", "open source", "operating system", "os", "red hat", "redhat", "rhel", "software" });
        private static IconData _Registered;
        public static IconData FA_Registered => _Registered ??= new IconData("Registered", "\U0000F25D", Styles.Regular | Styles.Solid, new string[] { "copyright-related", "intellectual property", "legal", "mark", "r", "registered", "symbol", "trademark" });
        private static IconData _Renren;
        public static IconData FA_Renren => _Renren ??= new IconData("Renren", "\U0000F18B", Styles.Brands, new string[] { "chinese social media", "renren", "renren brand", "renren network", "social network", "social platform" });
        private static IconData _Repeat;
        public static IconData FA_Repeat => _Repeat ??= new IconData("Repeat", "\U0000F363", Styles.Solid, new string[] { "arrow", "clockwise", "cycle", "loop", "refresh", "reload", "repeat", "replay", "retry", "switch" });
        private static IconData _Reply;
        public static IconData FA_Reply => _Reply ??= new IconData("Reply", "\U0000F3E5", Styles.Solid, new string[] { "answer", "chat", "comment", "conversation", "email", "feedback", "mail", "message", "reply", "respond", "respond to", "response" });
        private static IconData _ReplyAll;
        public static IconData FA_ReplyAll => _ReplyAll ??= new IconData("Reply All", "\U0000F122", Styles.Solid, new string[] { "answer", "conversation", "email", "inbox", "mail", "message", "reply", "reply all", "respond", "send" });
        private static IconData _Replyd;
        public static IconData FA_Replyd => _Replyd ??= new IconData("Replyd", "\U0000F3E6", Styles.Brands, new string[] { "Replyd", "brand", "communication", "messaging", "replyd", "social" });
        private static IconData _Republican;
        public static IconData FA_Republican => _Republican ??= new IconData("Republican", "\U0000F75E", Styles.Solid, new string[] { "GOP", "america", "conservative", "election", "elephant", "political party", "politics", "red party", "republican", "republican party", "right", "right side", "right-wing", "usa" });
        private static IconData _Researchgate;
        public static IconData FA_Researchgate => _Researchgate ??= new IconData("Researchgate", "\U0000F4F8", Styles.Brands, new string[] { "RG", "academic", "collaboration", "network", "publications", "research", "researchers", "researchgate", "scholarly", "scientists" });
        private static IconData _Resolving;
        public static IconData FA_Resolving => _Resolving ??= new IconData("Resolving", "\U0000F3E7", Styles.Brands, new string[] { "brand", "company", "corporate", "logo", "resolving", "resolving icon" });
        private static IconData _Restroom;
        public static IconData FA_Restroom => _Restroom ??= new IconData("Restroom", "\U0000F7BD", Styles.Solid, new string[] { "bathroom", "facilities", "john", "lavatory", "loo", "powder room", "restroom", "toilet", "washroom", "water closet", "wc" });
        private static IconData _Retweet;
        public static IconData FA_Retweet => _Retweet ??= new IconData("Retweet", "\U0000F079", Styles.Solid, new string[] { "cycle", "exchange", "forward", "refresh", "reload", "renew", "repeat", "repost", "retry", "retweet", "share", "swap", "twitter" });
        private static IconData _Rev;
        public static IconData FA_Rev => _Rev ??= new IconData("Rev", "\U0000F5B2", Styles.Brands, new string[] { "audio", "captions", "dictation", "rev", "rev.com", "speech to text", "subtitles", "transcription", "transcription service", "video" });
        private static IconData _Ribbon;
        public static IconData FA_Ribbon => _Ribbon ??= new IconData("Ribbon", "\U0000F4D6", Styles.Solid, new string[] { "achievement", "award", "awareness", "badge", "cause", "celebration", "decoration", "honor", "lapel", "medal", "pin", "prize", "reminder", "ribbon" });
        private static IconData _RightFromBracket;
        public static IconData FA_RightFromBracket => _RightFromBracket ??= new IconData("Right From Bracket", "\U0000F2F5", Styles.Solid, new string[] { "arrow", "exit", "forward", "leave", "log off", "log out", "logoff", "logout", "next", "outbox", "quit", "send", "sign out", "sign-out" });
        private static IconData _RightLeft;
        public static IconData FA_RightLeft => _RightLeft ??= new IconData("Right Left", "\U0000F362", Styles.Solid, new string[] { "arrow", "arrows", "bidirectional", "exchange", "flip", "horizontal", "left-right", "reverse", "swap", "switch", "transfer" });
        private static IconData _RightLong;
        public static IconData FA_RightLong => _RightLong ??= new IconData("Right Long", "\U0000F30B", Styles.Solid, new string[] { "arrow", "arrow-right", "continue", "direction", "forward", "move right", "navigation", "next", "next step", "proceed", "right arrow", "rightward" });
        private static IconData _RightToBracket;
        public static IconData FA_RightToBracket => _RightToBracket ??= new IconData("Right To Bracket", "\U0000F2F6", Styles.Solid, new string[] { "arrow", "arrow right", "bracket", "enter", "enter bracket", "join", "log in", "login", "login arrow", "sign in", "sign up", "sign-in", "sign-in arrow", "signin", "signup" });
        private static IconData _Ring;
        public static IconData FA_Ring => _Ring ??= new IconData("Ring", "\U0000F70B", Styles.Solid, new string[] { "Dungeons & Dragons", "Gollum", "band", "binding", "circle", "commitment", "d&d", "dnd", "engagement", "fantasy", "gold", "jewelry", "loop", "magic", "marriage", "precious", "promise", "ring", "treasure", "wedding" });
        private static IconData _Road;
        public static IconData FA_Road => _Road ??= new IconData("Road", "\U0000F018", Styles.Solid, new string[] { "avenue", "boulevard", "drive", "highway", "lane", "motorway", "path", "pavement", "road", "roadway", "route", "street", "street map", "traffic", "travel" });
        private static IconData _RoadBarrier;
        public static IconData FA_RoadBarrier => _RoadBarrier ??= new IconData("Road Barrier", "\U0000E562", Styles.Solid, new string[] { "barricade", "barrier", "block", "caution", "closed", "construction", "detour", "no entry", "obstacle", "roadblock", "traffic control" });
        private static IconData _RoadBridge;
        public static IconData FA_RoadBridge => _RoadBridge ??= new IconData("Road Bridge", "\U0000E563", Styles.Solid, new string[] { "bridge", "crossing", "highway", "infrastructure", "overpass", "road", "roadway", "transportation", "travel", "viaduct" });
        private static IconData _RoadCircleCheck;
        public static IconData FA_RoadCircleCheck => _RoadCircleCheck ??= new IconData("Road Circle Check", "\U0000E564", Styles.Solid, new string[] { "accessible", "active", "check", "clear", "confirm", "enabled", "freeway", "highway", "ok", "okay", "open", "pavement", "road", "validate", "verify", "working" });
        private static IconData _RoadCircleExclamation;
        public static IconData FA_RoadCircleExclamation => _RoadCircleExclamation ??= new IconData("Road Circle Exclamation", "\U0000E565", Styles.Solid, new string[] { "affected", "alert", "caution", "construction", "danger", "detour", "exclamation", "freeway", "highway", "incident", "pavement", "road", "sign", "traffic", "warning" });
        private static IconData _RoadCircleXmark;
        public static IconData FA_RoadCircleXmark => _RoadCircleXmark ??= new IconData("Road Circle Xmark", "\U0000E566", Styles.Solid, new string[] { "blocked", "cancel", "closed", "deny", "forbidden", "freeway", "highway", "no entry", "pavement", "remove", "restrict", "road", "route", "street", "xmark" });
        private static IconData _RoadLock;
        public static IconData FA_RoadLock => _RoadLock ??= new IconData("Road Lock", "\U0000E567", Styles.Solid, new string[] { "barrier", "blocked", "closed", "freeway", "highway", "lock", "lockdown", "padlock", "pavement", "privacy", "quarantine", "restricted", "road", "security" });
        private static IconData _RoadSpikes;
        public static IconData FA_RoadSpikes => _RoadSpikes ??= new IconData("Road Spikes", "\U0000E568", Styles.Solid, new string[] { "barrier", "law enforcement", "police", "road spikes", "roadblock", "security", "spike strip", "spike strip roadblock", "tire spikes", "traffic control", "vehicle stop" });
        private static IconData _Robot;
        public static IconData FA_Robot => _Robot ??= new IconData("Robot", "\U0000F544", Styles.Solid, new string[] { "ai", "android", "android face", "artificial intelligence", "automate", "automation", "bot", "computer", "cyborg", "futuristic", "machine", "robot", "technology" });
        private static IconData _Rocket;
        public static IconData FA_Rocket => _Rocket ??= new IconData("Rocket", "\U0000F135", Styles.Solid, new string[] { "astronaut", "booster", "exploration", "flight", "launch", "missile", "nasa", "orbit", "propulsion", "rocket", "shuttle", "space", "spacecraft" });
        private static IconData _Rocketchat;
        public static IconData FA_Rocketchat => _Rocketchat ??= new IconData("Rocketchat", "\U0000F3E8", Styles.Brands, new string[] { "chat", "chat app", "chat platform", "chat service", "collaboration", "communication", "messaging", "rocket chat", "rocketchat", "team chat" });
        private static IconData _Rockrms;
        public static IconData FA_Rockrms => _Rockrms ??= new IconData("Rockrms", "\U0000F3E9", Styles.Brands, new string[] { "church administration", "church management", "church software", "donation tracking", "event management", "membership management", "nonprofit software", "rock church", "rock rms", "rockrms" });
        private static IconData _Rotate;
        public static IconData FA_Rotate => _Rotate ??= new IconData("Rotate", "\U0000F2F1", Styles.Solid, new string[] { "arrow", "clockwise", "counterclockwise", "cycle", "exchange", "refresh", "reload", "reset", "retry", "rotate", "rotation", "spin", "swap", "turn", "update" });
        private static IconData _RotateLeft;
        public static IconData FA_RotateLeft => _RotateLeft ??= new IconData("Rotate Left", "\U0000F2EA", Styles.Solid, new string[] { "back", "cancel", "counterclockwise", "reset", "reverse", "revert", "rewind", "rotate", "turn left", "undo" });
        private static IconData _RotateRight;
        public static IconData FA_RotateRight => _RotateRight ??= new IconData("Rotate Right", "\U0000F2F9", Styles.Solid, new string[] { "clockwise", "forward", "refresh", "reload", "renew", "repeat", "retry", "right", "rotate", "rotate-clockwise", "spin", "turn" });
        private static IconData _Route;
        public static IconData FA_Route => _Route ??= new IconData("Route", "\U0000F4D7", Styles.Solid, new string[] { "course", "directions", "itinerary", "journey", "map", "navigation", "path", "route planning", "travel", "wayfinding" });
        private static IconData _Rss;
        public static IconData FA_Rss => _Rss ??= new IconData("Rss", "\U0000F09E", Styles.Solid, new string[] { "blog", "broadcast", "channel", "feed", "headlines", "journal", "news", "podcast", "rss", "subscribe", "updates" });
        private static IconData _RubleSign;
        public static IconData FA_RubleSign => _RubleSign ??= new IconData("Ruble Sign", "\U0000F158", Styles.Solid, new string[] { "currency", "currency symbol", "money", "rouble", "ruble", "ruble sign", "ruble symbol", "russian currency", "russian ruble", "₽" });
        private static IconData _Rug;
        public static IconData FA_Rug => _Rug ??= new IconData("Rug", "\U0000E569", Styles.Solid, new string[] { "area rug", "carpet", "decorative rug", "floor covering", "mat", "rug", "tapestry", "textile", "throw", "woven rug" });
        private static IconData _Ruler;
        public static IconData FA_Ruler => _Ruler ??= new IconData("Ruler", "\U0000F545", Styles.Solid, new string[] { "design", "draft", "drawing tool", "geometry", "length", "measure", "measurement", "planning", "ruler", "ruler icon", "ruler tool", "scale", "straight edge", "straight ruler" });
        private static IconData _RulerCombined;
        public static IconData FA_RulerCombined => _RulerCombined ??= new IconData("Ruler Combined", "\U0000F546", Styles.Solid, new string[] { "blueprint", "design", "dimensions", "draft", "drawing", "length", "measure", "measurement", "planning", "ruler", "scale", "size" });
        private static IconData _RulerHorizontal;
        public static IconData FA_RulerHorizontal => _RulerHorizontal ??= new IconData("Ruler Horizontal", "\U0000F547", Styles.Solid, new string[] { "design", "dimensions", "draft", "horizontal ruler", "layout", "length", "measure", "measurement", "planning", "ruler", "ruler tool", "scale" });
        private static IconData _RulerVertical;
        public static IconData FA_RulerVertical => _RulerVertical ??= new IconData("Ruler Vertical", "\U0000F548", Styles.Solid, new string[] { "design", "dimension", "draft", "length", "measure", "measurement", "planning", "ruler", "ruler tool", "scale", "size", "vertical" });
        private static IconData _RupeeSign;
        public static IconData FA_RupeeSign => _RupeeSign ??= new IconData("Rupee Sign", "\U0000F156", Styles.Solid, new string[] { "INR", "cash", "cost", "currency", "finance", "financial", "indian currency", "money", "payment", "price", "rupee", "rupee sign", "rupees" });
        private static IconData _RupiahSign;
        public static IconData FA_RupiahSign => _RupiahSign ??= new IconData("Rupiah Sign", "\U0000E23D", Styles.Solid, new string[] { "IDR", "Indonesian rupiah", "cash", "currency", "currency sign", "finance", "money", "payment", "rupiah", "symbol" });
        private static IconData _Rust;
        public static IconData FA_Rust => _Rust ??= new IconData("Rust", "\U0000E07A", Styles.Brands, new string[] { "coding", "developer", "fast", "programming language", "rust", "rust language", "rust programming", "safe", "software", "systems programming" });
        private static IconData _S;
        public static IconData FA_S => _S ??= new IconData("S", "\U00000053", Styles.Solid, new string[] { "alphabet", "character", "initial", "letter", "letter s", "lowercase s", "symbol", "text", "typography", "uppercase s" });
        private static IconData _SackDollar;
        public static IconData FA_SackDollar => _SackDollar ??= new IconData("Sack Dollar", "\U0000F81D", Styles.Solid, new string[] { "bag", "burlap", "cash", "currency", "dollar", "finance", "money", "money bag", "moneybag", "payment", "salary", "savings", "usd", "wealth" });
        private static IconData _SackXmark;
        public static IconData FA_SackXmark => _SackXmark ??= new IconData("Sack Xmark", "\U0000E56A", Styles.Solid, new string[] { "bag", "block", "cancel", "close", "delete", "deny", "money bag", "no entry", "reject", "remove", "sack", "sack with x", "xmark" });
        private static IconData _Safari;
        public static IconData FA_Safari => _Safari ??= new IconData("Safari", "\U0000F267", Styles.Brands, new string[] { "apple", "browser", "internet", "ios", "mac", "safari", "web" });
        private static IconData _Sagittarius;
        public static IconData FA_Sagittarius => _Sagittarius ??= new IconData("Sagittarius", "\U0000E84D", Styles.Solid, new string[] { "archer", "astrology", "centaur", "constellation", "december", "fire sign", "horoscope", "november", "sagittarius", "sign", "stars", "zodiac" });
        private static IconData _Sailboat;
        public static IconData FA_Sailboat => _Sailboat ??= new IconData("Sailboat", "\U0000E445", Styles.Solid, new string[] { "boat", "dinghy", "marine", "mast", "nautical", "regatta", "sail", "sailboat", "sailing", "vessel", "watercraft", "yacht" });
        private static IconData _Salesforce;
        public static IconData FA_Salesforce => _Salesforce ??= new IconData("Salesforce", "\U0000F83B", Styles.Brands, new string[] { "business", "cloud", "crm", "customer relationship management", "enterprise", "marketing", "saas", "sales", "sales force", "salesforce" });
        private static IconData _Sass;
        public static IconData FA_Sass => _Sass ??= new IconData("Sass", "\U0000F41E", Styles.Brands, new string[] { "css preprocessor", "frontend", "sass", "sass brand", "sass logo", "sass-lang", "style language", "stylesheet", "web development" });
        private static IconData _Satellite;
        public static IconData FA_Satellite => _Satellite ??= new IconData("Satellite", "\U0000F7BF", Styles.Solid, new string[] { "GPS", "broadcast", "communications", "orbit", "satellite", "satellite antenna", "satellite dish", "satellite network", "signal", "space", "telemetry", "transmission" });
        private static IconData _SatelliteDish;
        public static IconData FA_SatelliteDish => _SatelliteDish ??= new IconData("Satellite Dish", "\U0000F7C0", Styles.Solid, new string[] { "SETI", "antenna", "broadcast", "communications", "dish", "radar", "receiver", "satellite", "satellite antenna", "satellite dish", "saucer", "signal", "space", "telecom", "transmission", "wireless" });
        private static IconData _ScaleBalanced;
        public static IconData FA_ScaleBalanced => _ScaleBalanced ??= new IconData("Scale Balanced", "\U0000F24E", Styles.Solid, new string[] { "Libra", "balance", "courtroom", "equality", "equilibrium", "fairness", "judge", "justice", "law", "legal", "measurement", "scales", "weight", "zodiac" });
        private static IconData _ScaleUnbalanced;
        public static IconData FA_ScaleUnbalanced => _ScaleUnbalanced ??= new IconData("Scale Unbalanced", "\U0000F515", Styles.Solid, new string[] { "balance", "fairness", "imbalance", "inequality", "judgment", "justice", "law", "legal", "measure", "scale", "unbalanced", "uneven", "weight" });
        private static IconData _ScaleUnbalancedFlip;
        public static IconData FA_ScaleUnbalancedFlip => _ScaleUnbalancedFlip ??= new IconData("Scale Unbalanced Flip", "\U0000F516", Styles.Solid, new string[] { "balance", "court", "fairness", "inequality", "judge", "justice", "law", "legal", "measurement", "scale", "unbalanced", "uneven", "weight" });
        private static IconData _Scaleway;
        public static IconData FA_Scaleway => _Scaleway ??= new IconData("Scaleway", "\U0000E859", Styles.Brands, new string[] { });
        private static IconData _Schlix;
        public static IconData FA_Schlix => _Schlix ??= new IconData("Schlix", "\U0000F3EA", Styles.Brands, new string[] { "blogging", "cms", "content management", "schlix", "schlix cms", "website" });
        private static IconData _School;
        public static IconData FA_School => _School ??= new IconData("School", "\U0000F549", Styles.Solid, new string[] { "academic", "campus", "classroom", "college", "education", "institution", "learning", "lecture", "school", "school building", "schoolhouse", "student", "study", "teacher", "university" });
        private static IconData _SchoolCircleCheck;
        public static IconData FA_SchoolCircleCheck => _SchoolCircleCheck ??= new IconData("School Circle Check", "\U0000E56B", Styles.Solid, new string[] { "approved", "check", "checkmark", "confirm", "education", "enable", "ok", "okay", "school", "schoolhouse", "success", "validated", "verified", "working" });
        private static IconData _SchoolCircleExclamation;
        public static IconData FA_SchoolCircleExclamation => _SchoolCircleExclamation ??= new IconData("School Circle Exclamation", "\U0000E56C", Styles.Solid, new string[] { "alert", "attention", "caution", "error", "exclamation", "issue", "problem", "school", "schoolhouse", "warning" });
        private static IconData _SchoolCircleXmark;
        public static IconData FA_SchoolCircleXmark => _SchoolCircleXmark ??= new IconData("School Circle Xmark", "\U0000E56D", Styles.Solid, new string[] { "cancel", "close", "delete", "dismiss", "education", "error", "reject", "remove", "school", "schoolhouse", "xmark" });
        private static IconData _SchoolFlag;
        public static IconData FA_SchoolFlag => _SchoolFlag ??= new IconData("School Flag", "\U0000E56E", Styles.Solid, new string[] { "academic", "campus", "classroom", "education", "flag", "learning", "school", "schoolhouse", "student", "teaching" });
        private static IconData _SchoolLock;
        public static IconData FA_SchoolLock => _SchoolLock ??= new IconData("School Lock", "\U0000E56F", Styles.Solid, new string[] { "closed", "lock", "lockdown", "locked", "padlock", "privacy", "quarantine", "restricted", "safety", "school", "schoolhouse", "security" });
        private static IconData _Scissors;
        public static IconData FA_Scissors => _Scissors ??= new IconData("Scissors", "\U0000F0C4", Styles.Solid, new string[] { "clip", "craft", "cut", "cutting", "modify", "office", "safety scissors", "school", "scissors", "scissors tool", "shear", "snip", "tool", "trim" });
        private static IconData _Scorpio;
        public static IconData FA_Scorpio => _Scorpio ??= new IconData("Scorpio", "\U0000E84E", Styles.Solid, new string[] { "astrology", "constellation", "horoscope", "november", "october", "scorpio", "scorpion", "sign", "stars", "water sign", "zodiac" });
        private static IconData _Screenpal;
        public static IconData FA_Screenpal => _Screenpal ??= new IconData("Screenpal", "\U0000E570", Styles.Brands, new string[] { "Recording software", "Screen capture tool", "Screen recording", "Screen sharing", "Screen video", "ScreenPal", "Screencast", "Screencastify", "Video capture", "Video tutorial" });
        private static IconData _Screwdriver;
        public static IconData FA_Screwdriver => _Screwdriver ??= new IconData("Screwdriver", "\U0000F54A", Styles.Solid, new string[] { "DIY", "adjust", "configuration", "construction", "equipment", "fix", "hardware", "loosen", "maintenance", "mechanic", "repair", "screwdriver", "settings", "tighten", "tool", "toolset" });
        private static IconData _ScrewdriverWrench;
        public static IconData FA_ScrewdriverWrench => _ScrewdriverWrench ??= new IconData("Screwdriver Wrench", "\U0000F7D9", Styles.Solid, new string[] { "adjust", "admin", "build", "configuration", "equipment", "fix", "fix-it", "handyman", "hardware", "maintenance", "repair", "screwdriver", "service", "settings", "tools", "wrench" });
        private static IconData _Scribd;
        public static IconData FA_Scribd => _Scribd ??= new IconData("Scribd", "\U0000F28A", Styles.Brands, new string[] { "audiobooks", "digital library", "documents", "ebooks", "literature", "online books", "publishing", "reading", "scribd", "subscription" });
        private static IconData _Scroll;
        public static IconData FA_Scroll => _Scroll ??= new IconData("Scroll", "\U0000F70E", Styles.Solid, new string[] { "Dungeons & Dragons", "announcement", "d&d", "dnd", "document", "fantasy", "letter", "manuscript", "message", "paper", "parchment", "scholar", "script", "scroll" });
        private static IconData _ScrollTorah;
        public static IconData FA_ScrollTorah => _ScrollTorah ??= new IconData("Scroll Torah", "\U0000F6A0", Styles.Solid, new string[] { "hebrew", "holy book", "jewish", "judaism", "law", "old testament", "parchment", "religion", "scripture", "scroll", "synagogue", "text", "torah" });
        private static IconData _SdCard;
        public static IconData FA_SdCard => _SdCard ??= new IconData("Sd Card", "\U0000F7C2", Styles.Solid, new string[] { "backup", "data", "flash card", "image", "img", "memory card", "micro sd", "photo", "portable storage", "save", "sd card", "storage" });
        private static IconData _Searchengin;
        public static IconData FA_Searchengin => _Searchengin ??= new IconData("Searchengin", "\U0000F3EB", Styles.Brands, new string[] { "SEO", "analytics", "digital marketing", "marketing", "online marketing", "search", "search engine", "searchengin", "web search" });
        private static IconData _Section;
        public static IconData FA_Section => _Section ??= new IconData("Section", "\U0000E447", Styles.Solid, new string[] { "citation", "document", "law", "legal", "paragraph", "reference", "section sign", "silcrow", "symbol", "text", "writing" });
        private static IconData _Seedling;
        public static IconData FA_Seedling => _Seedling ??= new IconData("Seedling", "\U0000F4D8", Styles.Solid, new string[] { "agriculture", "eco", "environment", "farming", "garden", "green", "growth", "nature", "plant", "sapling", "seedling", "sprout", "vegan", "young" });
        private static IconData _Sellcast;
        public static IconData FA_Sellcast => _Sellcast ??= new IconData("Sellcast", "\U0000F2DA", Styles.Brands, new string[] { "broadcast", "media", "sell cast", "sellcast", "streaming", "video" });
        private static IconData _Sellsy;
        public static IconData FA_Sellsy => _Sellsy ??= new IconData("Sellsy", "\U0000F213", Styles.Brands, new string[] { "CRM", "SaaS", "Sellsy", "billing", "business management", "invoicing", "sales", "software" });
        private static IconData _Septagon;
        public static IconData FA_Septagon => _Septagon ??= new IconData("Septagon", "\U0000E820", Styles.Solid, new string[] { "7", "figure", "geometric", "heptagon", "polygon", "septagonal", "seven", "shape", "sided" });
        private static IconData _Server;
        public static IconData FA_Server => _Server ??= new IconData("Server", "\U0000F233", Styles.Solid, new string[] { "backend", "cloud", "computer", "cpu", "data center", "database", "hardware", "hosting", "mysql", "network", "rack", "server", "sql", "storage", "web server" });
        private static IconData _Servicestack;
        public static IconData FA_Servicestack => _Servicestack ??= new IconData("Servicestack", "\U0000F3EC", Styles.Brands, new string[] { ".net", "api framework", "backend", "cloud services", "dotnet", "microservices", "service stack", "servicestack", "software development", "web services" });
        private static IconData _Shapes;
        public static IconData FA_Shapes => _Shapes ??= new IconData("Shapes", "\U0000F61F", Styles.Solid, new string[] { "blocks", "build", "circle", "figures", "forms", "geometric", "polygons", "shapes", "square", "triangle" });
        private static IconData _Share;
        public static IconData FA_Share => _Share ??= new IconData("Share", "\U0000F064", Styles.Solid, new string[] { "broadcast", "communicate", "distribute", "export", "forward", "link", "post", "send", "share", "social", "upload" });
        private static IconData _ShareFromSquare;
        public static IconData FA_ShareFromSquare => _ShareFromSquare ??= new IconData("Share From Square", "\U0000F14D", Styles.Regular | Styles.Solid, new string[] { "arrow", "distribute", "export", "forward", "link", "send", "send-to", "share", "social", "upload" });
        private static IconData _ShareNodes;
        public static IconData FA_ShareNodes => _ShareNodes ??= new IconData("Share Nodes", "\U0000F1E0", Styles.Solid, new string[] { "broadcast", "communication", "connect", "distribute", "forward", "link", "network", "nodes", "send", "share", "social" });
        private static IconData _SheetPlastic;
        public static IconData FA_SheetPlastic => _SheetPlastic ??= new IconData("Sheet Plastic", "\U0000E571", Styles.Solid, new string[] { "barrier", "clear cover", "film", "plastic", "plastic wrap", "protective cover", "sheet", "shield", "tarp", "tarpaulin", "waterproof", "wrap" });
        private static IconData _ShekelSign;
        public static IconData FA_ShekelSign => _ShekelSign ??= new IconData("Shekel Sign", "\U0000F20B", Styles.Solid, new string[] { "currency", "finance", "ils", "israeli currency", "israeli shekel", "money", "new shekel", "nis", "shekel", "sheqel", "symbol" });
        private static IconData _Shield;
        public static IconData FA_Shield => _Shield ??= new IconData("Shield", "\U0000F132", Styles.Solid, new string[] { "achievement", "armor", "award", "block", "cleric", "defend", "defense", "holy", "paladin", "protect", "safety", "security", "shield", "weapon", "winner" });
        private static IconData _ShieldCat;
        public static IconData FA_ShieldCat => _ShieldCat ??= new IconData("Shield Cat", "\U0000E572", Styles.Solid, new string[] { "animal", "cat", "defense", "feline", "guard", "pet", "protection", "safety", "shield", "veterinary" });
        private static IconData _ShieldDog;
        public static IconData FA_ShieldDog => _ShieldDog ??= new IconData("Shield Dog", "\U0000E573", Styles.Solid, new string[] { "animal", "canine", "dog", "guard", "pet", "protection", "safety", "security", "shield", "veterinary" });
        private static IconData _ShieldHalved;
        public static IconData FA_ShieldHalved => _ShieldHalved ??= new IconData("Shield Halved", "\U0000F3ED", Styles.Solid, new string[] { "achievement", "armor", "award", "barrier", "block", "cleric", "defense", "guard", "holy", "paladin", "privacy", "protect", "security", "shield", "weapon", "winner" });
        private static IconData _ShieldHeart;
        public static IconData FA_ShieldHeart => _ShieldHeart ??= new IconData("Shield Heart", "\U0000E574", Styles.Solid, new string[] { "favorite", "heart", "love", "protect", "protection", "safe", "safety", "secure", "shield", "wishlist" });
        private static IconData _ShieldVirus;
        public static IconData FA_ShieldVirus => _ShieldVirus ??= new IconData("Shield Virus", "\U0000E06C", Styles.Solid, new string[] { "antibodies", "barrier", "coronavirus", "covid-19", "disease", "flu", "health", "infection", "pandemic", "protect", "protection", "safety", "shield", "vaccine", "virus" });
        private static IconData _Ship;
        public static IconData FA_Ship => _Ship ??= new IconData("Ship", "\U0000F21A", Styles.Solid, new string[] { "boat", "cargo", "cruise", "ferry", "maritime", "nautical", "ocean", "passenger", "sailing", "sea", "ship", "transport", "vessel", "water" });
        private static IconData _Shirt;
        public static IconData FA_Shirt => _Shirt ??= new IconData("Shirt", "\U0000F553", Styles.Solid, new string[] { "apparel", "casual wear", "clothing", "garment", "outfit", "shirt", "short sleeve", "t-shirt", "top", "tshirt" });
        private static IconData _Shirtsinbulk;
        public static IconData FA_Shirtsinbulk => _Shirtsinbulk ??= new IconData("Shirtsinbulk", "\U0000F214", Styles.Brands, new string[] { "apparel supplier", "bulk apparel", "bulk clothing", "bulk orders", "bulk t-shirts", "clothing wholesale", "shirts in bulk", "shirtsinbulk", "wholesale fashion", "wholesale shirts" });
        private static IconData _ShoePrints;
        public static IconData FA_ShoePrints => _ShoePrints ??= new IconData("Shoe Prints", "\U0000F54B", Styles.Solid, new string[] { "footpath", "footprints", "footsteps", "shoeprints", "steps", "tracks", "trail", "trail marks", "walking" });
        private static IconData _Shoelace;
        public static IconData FA_Shoelace => _Shoelace ??= new IconData("Shoelace", "\U0000E60C", Styles.Brands, new string[] { "boot", "footwear", "lace", "shoelace", "shoelaces", "shoes", "sneaker", "string", "tie" });
        private static IconData _Shop;
        public static IconData FA_Shop => _Shop ??= new IconData("Shop", "\U0000F54F", Styles.Solid, new string[] { "bodega", "boutique", "building", "buy", "commerce", "mall", "market", "outlet", "purchase", "retail", "shop", "shopping", "store" });
        private static IconData _ShopLock;
        public static IconData FA_ShopLock => _ShopLock ??= new IconData("Shop Lock", "\U0000E4A5", Styles.Solid, new string[] { "buy", "closed", "lock", "lockdown", "market", "padlock", "privacy", "purchase", "retail", "secure", "security", "shop", "shopping", "store", "storefront" });
        private static IconData _ShopSlash;
        public static IconData FA_ShopSlash => _ShopSlash ??= new IconData("Shop Slash", "\U0000E070", Styles.Solid, new string[] { "blocked", "buy", "closed", "disabled", "forbidden", "no shopping", "purchase", "retail", "shop", "shopping", "slash", "store", "storefront", "unavailable" });
        private static IconData _Shopify;
        public static IconData FA_Shopify => _Shopify ??= new IconData("Shopify", "\U0000E057", Styles.Brands, new string[] { "ecommerce", "marketplace", "online shop", "online store", "retail", "sales", "shopify", "shopping" });
        private static IconData _Shopware;
        public static IconData FA_Shopware => _Shopware ??= new IconData("Shopware", "\U0000F5B5", Styles.Brands, new string[] { "e-commerce", "ecommerce software", "online shop", "online store", "retail software", "shopping platform", "shopware", "webshop" });
        private static IconData _Shower;
        public static IconData FA_Shower => _Shower ??= new IconData("Shower", "\U0000F2CC", Styles.Solid, new string[] { "bath", "bathroom", "clean", "faucet", "hygiene", "rinse", "shower", "spray", "water", "wet" });
        private static IconData _Shrimp;
        public static IconData FA_Shrimp => _Shrimp ??= new IconData("Shrimp", "\U0000E448", Styles.Solid, new string[] { "allergy", "crustacean", "edible", "fishing", "marine", "ocean", "prawn", "seafood", "seafood allergy", "shellfish", "shellfish allergy", "shrimp", "tail" });
        private static IconData _Shuffle;
        public static IconData FA_Shuffle => _Shuffle ??= new IconData("Shuffle", "\U0000F074", Styles.Solid, new string[] { "arrows", "crossed", "mix", "music", "playlist", "random", "randomize", "reorder", "shuffle", "shuffle tracks", "swap", "switch", "tracks", "transfer" });
        private static IconData _ShuttleSpace;
        public static IconData FA_ShuttleSpace => _ShuttleSpace ??= new IconData("Shuttle Space", "\U0000F197", Styles.Solid, new string[] { "NASA", "aerospace", "astronaut", "launch", "orbit", "rocket", "shuttlecraft", "space", "space shuttle", "space travel", "spacecraft", "transportation" });
        private static IconData _SignHanging;
        public static IconData FA_SignHanging => _SignHanging ??= new IconData("Sign Hanging", "\U0000F4D9", Styles.Solid, new string[] { "announcement", "directions", "display", "hanging sign", "notice", "placard", "real estate", "shop sign", "signage", "signpost", "storefront", "wayfinding" });
        private static IconData _Signal;
        public static IconData FA_Signal => _Signal ??= new IconData("Signal", "\U0000F012", Styles.Solid, new string[] { "antenna", "cell", "cellular", "connectivity", "coverage", "mobile", "network", "online", "phone", "reception", "signal", "signal bars", "status", "strength", "wireless" });
        private static IconData _SignalMessenger;
        public static IconData FA_SignalMessenger => _SignalMessenger ??= new IconData("Signal Messenger", "\U0000E663", Styles.Brands, new string[] { "app", "calls", "chat", "communication", "encrypted", "messaging", "messenger", "private", "secure", "signal", "text" });
        private static IconData _Signature;
        public static IconData FA_Signature => _Signature ??= new IconData("Signature", "\U0000F5B7", Styles.Solid, new string[] { "John Hancock", "approval", "autograph", "cursive", "document", "endorsement", "handwriting", "name", "sign", "signature", "signature line", "signing", "written name" });
        private static IconData _SignsPost;
        public static IconData FA_SignsPost => _SignsPost ??= new IconData("Signs Post", "\U0000F277", Styles.Solid, new string[] { "directions", "directory", "guide", "map", "marker", "navigation", "pointer", "route", "sign", "signage", "signpost", "street sign", "trail", "wayfinding" });
        private static IconData _SimCard;
        public static IconData FA_SimCard => _SimCard ??= new IconData("Sim Card", "\U0000F7C4", Styles.Solid, new string[] { "card", "cellular", "chip", "data", "hardware", "mobile", "network", "phone", "portable", "sim", "sim card", "simcard", "technology", "tiny" });
        private static IconData _Simplybuilt;
        public static IconData FA_Simplybuilt => _Simplybuilt ??= new IconData("Simplybuilt", "\U0000F215", Styles.Brands, new string[] { "building company", "construction", "home builder", "housing", "real estate", "simply built", "simplybuilt" });
        private static IconData _SingleQuoteLeft;
        public static IconData FA_SingleQuoteLeft => _SingleQuoteLeft ??= new IconData("Single Quote Left", "\U0000E81B", Styles.Solid, new string[] { "apostrophe-like", "citation", "dialogue", "left single quotation mark", "opening quote", "punctuation", "quotation", "quote", "speech", "text" });
        private static IconData _SingleQuoteRight;
        public static IconData FA_SingleQuoteRight => _SingleQuoteRight ??= new IconData("Single Quote Right", "\U0000E81C", Styles.Solid, new string[] { "apostrophe", "citation", "dialogue", "note", "phrase", "punctuation", "quotation", "quote", "right single quotation mark", "single quote", "speech", "text" });
        private static IconData _Sink;
        public static IconData FA_Sink => _Sink ??= new IconData("Sink", "\U0000E06D", Styles.Solid, new string[] { "basin", "bathroom", "faucet", "handwashing", "hygiene", "kitchen", "plumbing", "tap", "wash", "water" });
        private static IconData _Sistrix;
        public static IconData FA_Sistrix => _Sistrix ??= new IconData("Sistrix", "\U0000F3EE", Styles.Brands, new string[] { "analytics", "digital marketing", "marketing", "search engine optimization", "seo", "seo software", "seo tool", "sistrix", "website analysis" });
        private static IconData _Sitemap;
        public static IconData FA_Sitemap => _Sitemap ??= new IconData("Sitemap", "\U0000F0E8", Styles.Solid, new string[] { "directory", "flowchart", "hierarchy", "information architecture", "map", "navigation", "organization", "outline", "site map", "sitemap", "structure", "web structure" });
        private static IconData _Sith;
        public static IconData FA_Sith => _Sith ??= new IconData("Sith", "\U0000F512", Styles.Brands, new string[] { "dark lord", "dark side", "darth", "force user", "sith", "star wars", "star wars villain", "starwars", "villain" });
        private static IconData _Sitrox;
        public static IconData FA_Sitrox => _Sitrox ??= new IconData("Sitrox", "\U0000E44A", Styles.Brands, new string[] { "Sitrox", "Sitrox brand", "Sitrox company", "Sitrox logo", "Sitrox technology", "sitrox" });
        private static IconData _Sketch;
        public static IconData FA_Sketch => _Sketch ??= new IconData("Sketch", "\U0000F7C6", Styles.Brands, new string[] { "app", "design", "illustration", "mac", "macos", "prototyping", "sketch", "software", "ui", "ux", "vector" });
        private static IconData _Skull;
        public static IconData FA_Skull => _Skull ??= new IconData("Skull", "\U0000F54C", Styles.Solid, new string[] { "bones", "danger", "death", "face", "halloween", "horror", "monster", "poison", "skeleton", "skull", "spooky", "x-ray", "yorick" });
        private static IconData _SkullCrossbones;
        public static IconData FA_SkullCrossbones => _SkullCrossbones ??= new IconData("Skull Crossbones", "\U0000F714", Styles.Solid, new string[] { "alert", "bones", "crossbones", "danger", "danger symbol", "deadly", "death", "halloween", "hazard", "jolly-roger", "pirate", "poison", "skull", "skull and crossbones", "skull icon", "toxic", "warning", "warning sign" });
        private static IconData _Skyatlas;
        public static IconData FA_Skyatlas => _Skyatlas ??= new IconData("Skyatlas", "\U0000F216", Styles.Brands, new string[] { "astronomy", "atlas", "celestial", "constellation", "map", "navigation", "sky atlas", "skyatlas", "space", "star chart" });
        private static IconData _Skype;
        public static IconData FA_Skype => _Skype ??= new IconData("Skype", "\U0000F17E", Styles.Brands, new string[] { "calling", "chat", "communication", "conference", "messaging", "microsoft", "online meeting", "skype", "video call", "voip" });
        private static IconData _Slack;
        public static IconData FA_Slack => _Slack ??= new IconData("Slack", "\U0000F198", Styles.Brands, new string[] { "chat", "collaboration", "communication", "hashtag", "messaging", "slack", "team", "workspace" });
        private static IconData _Slash;
        public static IconData FA_Slash => _Slash ??= new IconData("Slash", "\U0000F715", Styles.Solid, new string[] { "block", "cancel", "close", "cross", "disable", "forbidden", "mute", "negate", "no", "off", "prohibit", "remove", "stop", "x" });
        private static IconData _Sleigh;
        public static IconData FA_Sleigh => _Sleigh ??= new IconData("Sleigh", "\U0000F7CC", Styles.Solid, new string[] { "christmas", "claus", "festive", "flying sleigh", "gift", "holiday", "north pole", "present", "reindeer", "santa", "sled", "snow", "winter", "xmas", "yuletide" });
        private static IconData _Sliders;
        public static IconData FA_Sliders => _Sliders ??= new IconData("Sliders", "\U0000F1DE", Styles.Solid, new string[] { "adjust", "configuration", "controls", "customize", "dashboard", "equalizer", "filter", "interface", "mixer", "modify", "options", "panel", "preferences", "settings", "sliders", "tuning", "volume" });
        private static IconData _Slideshare;
        public static IconData FA_Slideshare => _Slideshare ??= new IconData("Slideshare", "\U0000F1E7", Styles.Brands, new string[] { "content sharing", "document sharing", "presentation", "professional presentations", "slide deck", "slide hosting", "slide share", "slideshare", "slideshow" });
        private static IconData _Smog;
        public static IconData FA_Smog => _Smog ??= new IconData("Smog", "\U0000F75F", Styles.Solid, new string[] { "air quality", "dirty air", "environmental", "exhaust", "fog", "haze", "pollution", "smog", "smoggy", "smoke", "smokescreen", "weather" });
        private static IconData _Smoking;
        public static IconData FA_Smoking => _Smoking ??= new IconData("Smoking", "\U0000F48D", Styles.Solid, new string[] { "addiction", "cigarette", "cigarette smoke", "health risk", "lung cancer", "nicotine", "no smoking", "smoke", "smoker", "smoking", "smoking area", "smoking ban", "tobacco" });
        private static IconData _Snapchat;
        public static IconData FA_Snapchat => _Snapchat ??= new IconData("Snapchat", "\U0000F2AB", Styles.Brands, new string[] { "app", "chat", "filters", "ghost", "messaging", "snap", "snapchat", "snaps", "social media", "stories" });
        private static IconData _Snowflake;
        public static IconData FA_Snowflake => _Snowflake ??= new IconData("Snowflake", "\U0000F2DC", Styles.Regular | Styles.Solid, new string[] { "blizzard", "cold", "freeze", "frost", "ice", "precipitation", "snow", "snowfall", "snowflake", "winter" });
        private static IconData _Snowman;
        public static IconData FA_Snowman => _Snowman ??= new IconData("Snowman", "\U0000F7D0", Styles.Solid, new string[] { "cold", "decoration", "frost", "frosty", "holiday", "snow", "snow figure", "snow sculpture", "snowman", "snowman face", "snowman icon", "snowman without snow", "winter", "winter fun" });
        private static IconData _Snowplow;
        public static IconData FA_Snowplow => _Snowplow ??= new IconData("Snowplow", "\U0000F7D2", Styles.Solid, new string[] { "clean up", "cold", "plow", "road clearing", "snow", "snow clearing", "snow removal", "snowplow", "storm", "vehicle", "winter" });
        private static IconData _Soap;
        public static IconData FA_Soap => _Soap ??= new IconData("Soap", "\U0000E06E", Styles.Solid, new string[] { "bar", "bathing", "bubbles", "clean", "cleaning", "disinfect", "foam", "germ", "hygiene", "hygiene product", "lather", "sanitizer", "soap", "suds", "wash" });
        private static IconData _Socks;
        public static IconData FA_Socks => _Socks ??= new IconData("Socks", "\U0000F696", Styles.Solid, new string[] { "ankle socks", "clothing", "cotton socks", "cozy", "crew socks", "feet", "flight of the conchords", "footwear", "hosiery", "socks", "socks and shoes", "stockings", "warm", "wednesday", "wool socks" });
        private static IconData _Solana;
        public static IconData FA_Solana => _Solana ??= new IconData("Solana", "\U0000E85E", Styles.Brands, new string[] { });
        private static IconData _SolarPanel;
        public static IconData FA_SolarPanel => _SolarPanel ??= new IconData("Solar Panel", "\U0000F5BA", Styles.Solid, new string[] { "clean", "eco-friendly", "electricity", "energy", "environment", "green", "panel", "photovoltaic", "power", "renewable", "solar", "sun", "sustainable" });
        private static IconData _Sort;
        public static IconData FA_Sort => _Sort ??= new IconData("Sort", "\U0000F0DC", Styles.Solid, new string[] { "arrange", "filter", "order", "organize", "prioritize", "ranking", "sequence", "sort", "sort ascending", "sort descending" });
        private static IconData _SortDown;
        public static IconData FA_SortDown => _SortDown ??= new IconData("Sort Down", "\U0000F0DD", Styles.Solid, new string[] { "arrow", "arrow down", "decrease", "descending", "down", "down arrow", "filter", "order", "sort", "sort down", "sort-desc" });
        private static IconData _SortUp;
        public static IconData FA_SortUp => _SortUp ??= new IconData("Sort Up", "\U0000F0DE", Styles.Solid, new string[] { "arrow", "arrow-up", "ascending", "filter", "growth", "increase", "order", "rise", "sort", "sort-asc", "up", "upgrade", "upward" });
        private static IconData _Soundcloud;
        public static IconData FA_Soundcloud => _Soundcloud ??= new IconData("Soundcloud", "\U0000F1BE", Styles.Brands, new string[] { "audio", "music", "online music", "platform", "podcast", "social audio", "songs", "soundcloud", "streaming", "tracks" });
        private static IconData _Sourcetree;
        public static IconData FA_Sourcetree => _Sourcetree ??= new IconData("Sourcetree", "\U0000F7D3", Styles.Brands, new string[] { "atlassian", "code management", "git", "git client", "repository", "scm", "software development", "source code", "sourcetree", "version control" });
        private static IconData _Spa;
        public static IconData FA_Spa => _Spa ??= new IconData("Spa", "\U0000F5BB", Styles.Solid, new string[] { "aromatherapy", "calm", "flora", "health", "massage", "mindfulness", "plant", "rejuvenation", "relaxation", "self-care", "spa", "therapy", "wellness" });
        private static IconData _SpaceAwesome;
        public static IconData FA_SpaceAwesome => _SpaceAwesome ??= new IconData("Space Awesome", "\U0000E5AC", Styles.Brands, new string[] { "adventure", "astronautics", "exploration", "launch", "rocket", "shuttle", "space", "spaceship" });
        private static IconData _SpaghettiMonsterFlying;
        public static IconData FA_SpaghettiMonsterFlying => _SpaghettiMonsterFlying ??= new IconData("Spaghetti Monster Flying", "\U0000F67B", Styles.Solid, new string[] { "agnosticism", "atheism", "flying spaghetti monster", "fsm", "noodly appendage", "parody religion", "pasta", "pastafarian", "satire", "skeptic" });
        private static IconData _Speakap;
        public static IconData FA_Speakap => _Speakap ??= new IconData("Speakap", "\U0000F3F3", Styles.Brands, new string[] { "corporate social network", "employee app", "internal communication", "speakap", "team collaboration", "workplace chat" });
        private static IconData _SpeakerDeck;
        public static IconData FA_SpeakerDeck => _SpeakerDeck ??= new IconData("Speaker Deck", "\U0000F83C", Styles.Brands, new string[] { "conferences", "presentations", "presentations platform", "sharing", "slide deck", "slides", "speakerdeck", "talks" });
        private static IconData _SpellCheck;
        public static IconData FA_SpellCheck => _SpellCheck ??= new IconData("Spell Check", "\U0000F891", Styles.Solid, new string[] { "check", "correction", "dictionary", "editing", "editor", "grammar", "language", "proofreading", "spell check", "spellcheck", "text", "validate", "writing" });
        private static IconData _Spider;
        public static IconData FA_Spider => _Spider ??= new IconData("Spider", "\U0000F717", Styles.Solid, new string[] { "arachnid", "bug", "charlotte", "crawl", "creepy", "eight legs", "halloween", "insect-like", "pest", "spider", "web" });
        private static IconData _Spinner;
        public static IconData FA_Spinner => _Spinner ??= new IconData("Spinner", "\U0000F110", Styles.Solid, new string[] { "buffering", "busy", "circle", "hourglass", "loading", "pending", "processing", "progress", "spinner", "wait", "working" });
        private static IconData _Spiral;
        public static IconData FA_Spiral => _Spiral ??= new IconData("Spiral", "\U0000E80A", Styles.Solid, new string[] { "circular", "coil", "curl", "dizzy", "helix", "loop", "rotate", "spin", "spiral", "spiral staircase", "swirl", "twist", "vortex" });
        private static IconData _Splotch;
        public static IconData FA_Splotch => _Splotch ??= new IconData("Splotch", "\U0000F5BC", Styles.Solid, new string[] { "blob", "blotch", "drop", "ink", "mark", "paint", "smudge", "spill", "splash", "stain" });
        private static IconData _Spoon;
        public static IconData FA_Spoon => _Spoon ??= new IconData("Spoon", "\U0000F2E5", Styles.Solid, new string[] { "cutlery", "dining", "eating", "food", "kitchen", "scoop", "silverware", "spoon", "tableware", "utensil" });
        private static IconData _Spotify;
        public static IconData FA_Spotify => _Spotify ??= new IconData("Spotify", "\U0000F1BC", Styles.Brands, new string[] { "album", "artist", "audio", "music", "playlist", "podcast", "songs", "sound", "spotify", "streaming" });
        private static IconData _SprayCan;
        public static IconData FA_SprayCan => _SprayCan ??= new IconData("Spray Can", "\U0000F5BD", Styles.Solid, new string[] { "aerosol", "art", "can", "coloring", "graffiti", "paint", "spray", "spray bottle", "spray paint", "stencil", "street art", "tag" });
        private static IconData _SprayCanSparkles;
        public static IconData FA_SprayCanSparkles => _SprayCanSparkles ??= new IconData("Spray Can Sparkles", "\U0000F5D0", Styles.Solid, new string[] { "aerosol", "air freshener", "clean", "deodorize", "fragrance", "fresh", "mist", "perfume", "pine", "scent", "shine", "sparkle", "spray", "spray can" });
        private static IconData _Square;
        public static IconData FA_Square => _Square ??= new IconData("Square", "\U0000F0C8", Styles.Regular | Styles.Solid, new string[] { "black square", "block", "box", "geometric", "quadrilateral", "rectangle", "shape", "solid square", "square", "square shape", "white square" });
        private static IconData _SquareArrowUpRight;
        public static IconData FA_SquareArrowUpRight => _SquareArrowUpRight ??= new IconData("Square Arrow Up Right", "\U0000F14C", Styles.Solid, new string[] { "arrow", "diagonal", "direction", "export", "external", "link", "navigate", "new", "open", "out", "send", "share", "up-right" });
        private static IconData _SquareBehance;
        public static IconData FA_SquareBehance => _SquareBehance ??= new IconData("Square Behance", "\U0000F1B5", Styles.Brands, new string[] { "adobe behance", "art", "behance", "creative", "design", "portfolio", "projects", "showcase" });
        private static IconData _SquareBinary;
        public static IconData FA_SquareBinary => _SquareBinary ??= new IconData("Square Binary", "\U0000E69B", Styles.Solid, new string[] { "ai", "algorithm", "binary", "code", "computing", "data", "digital", "language", "llm", "model", "programming", "token" });
        private static IconData _SquareBluesky;
        public static IconData FA_SquareBluesky => _SquareBluesky ??= new IconData("Square Bluesky", "\U0000E6A3", Styles.Brands, new string[] { "app", "bluesky", "decentralized", "platform", "social media", "social network" });
        private static IconData _SquareCaretDown;
        public static IconData FA_SquareCaretDown => _SquareCaretDown ??= new IconData("Square Caret Down", "\U0000F150", Styles.Regular | Styles.Solid, new string[] { "arrow", "caret", "down", "dropdown", "expand", "indicator", "menu", "more", "navigation", "pointer", "square", "toggle", "triangle" });
        private static IconData _SquareCaretLeft;
        public static IconData FA_SquareCaretLeft => _SquareCaretLeft ??= new IconData("Square Caret Left", "\U0000F191", Styles.Regular | Styles.Solid, new string[] { "arrow", "back", "caret", "direction", "left", "navigation", "pointer", "previous", "square", "triangle" });
        private static IconData _SquareCaretRight;
        public static IconData FA_SquareCaretRight => _SquareCaretRight ??= new IconData("Square Caret Right", "\U0000F152", Styles.Regular | Styles.Solid, new string[] { "arrow", "arrowhead", "caret", "forward", "navigation", "next", "play", "pointer", "right", "skip", "square", "triangle" });
        private static IconData _SquareCaretUp;
        public static IconData FA_SquareCaretUp => _SquareCaretUp ??= new IconData("Square Caret Up", "\U0000F151", Styles.Regular | Styles.Solid, new string[] { "arrow", "arrow-up", "arrowhead", "caret", "caret-square-o-up", "collapse", "expand", "increase", "pointer", "square", "triangle", "up", "up arrow", "up caret", "upload" });
        private static IconData _SquareCheck;
        public static IconData FA_SquareCheck => _SquareCheck ??= new IconData("Square Check", "\U0000F14A", Styles.Regular | Styles.Solid, new string[] { "accept", "agree", "box", "button", "check", "check mark", "checkbox", "checkmark", "confirm", "correct", "done", "enable", "mark", "ok", "select", "success", "tick", "validate", "yes" });
        private static IconData _SquareDeskpro;
        public static IconData FA_SquareDeskpro => _SquareDeskpro ??= new IconData("Square Deskpro", "\U0000E844", Styles.Brands, new string[] { });
        private static IconData _SquareDribbble;
        public static IconData FA_SquareDribbble => _SquareDribbble ??= new IconData("Square Dribbble", "\U0000F397", Styles.Brands, new string[] { "art", "branding", "community", "creative", "design", "designer", "dribbble", "dribble", "portfolio", "social" });
        private static IconData _SquareEnvelope;
        public static IconData FA_SquareEnvelope => _SquareEnvelope ??= new IconData("Square Envelope", "\U0000F199", Styles.Solid, new string[] { "communication", "contact", "correspondence", "e-mail", "email", "envelope", "inbox", "letter", "mail", "message", "message alert", "notification", "support" });
        private static IconData _SquareFacebook;
        public static IconData FA_SquareFacebook => _SquareFacebook ??= new IconData("Square Facebook", "\U0000F082", Styles.Brands, new string[] { "facebook", "facebook app", "facebook logo", "fb", "fb icon", "social media", "social network", "social platform" });
        private static IconData _SquareFigma;
        public static IconData FA_SquareFigma => _SquareFigma ??= new IconData("Square Figma", "\U0000E7E4", Styles.Brands, new string[] { "app", "collaboration", "design", "figma", "interface", "prototyping", "software", "ui", "ux", "vector" });
        private static IconData _SquareFontAwesome;
        public static IconData FA_SquareFontAwesome => _SquareFontAwesome ??= new IconData("Square Font Awesome", "\U0000E5AD", Styles.Brands, new string[] { "brand", "fa", "font awesome", "fontawesome", "icon set", "logo" });
        private static IconData _SquareFontAwesomeStroke;
        public static IconData FA_SquareFontAwesomeStroke => _SquareFontAwesomeStroke ??= new IconData("Square Font Awesome Stroke", "\U0000F35C", Styles.Brands, new string[] { "brand", "fa", "font-awesome", "icon", "logo", "square", "typeface" });
        private static IconData _SquareFull;
        public static IconData FA_SquareFull => _SquareFull ??= new IconData("Square Full", "\U0000F45C", Styles.Regular | Styles.Solid, new string[] { "block", "color block", "colored square", "filled square", "geometric shape", "shape", "solid square", "square" });
        private static IconData _SquareGit;
        public static IconData FA_SquareGit => _SquareGit ??= new IconData("Square Git", "\U0000F1D2", Styles.Brands, new string[] { "code", "development", "git", "git square", "repository", "software", "source control", "version control" });
        private static IconData _SquareGithub;
        public static IconData FA_SquareGithub => _SquareGithub ??= new IconData("Square Github", "\U0000F092", Styles.Brands, new string[] { "code", "development", "git", "github", "octocat", "programming", "repository", "software", "version control" });
        private static IconData _SquareGitlab;
        public static IconData FA_SquareGitlab => _SquareGitlab ??= new IconData("Square Gitlab", "\U0000E5AE", Styles.Brands, new string[] { "ci", "code", "collaboration", "continuous integration", "devops", "git", "gitlab", "repository", "software", "version control" });
        private static IconData _SquareGooglePlus;
        public static IconData FA_SquareGooglePlus => _SquareGooglePlus ??= new IconData("Square Google Plus", "\U0000F0D4", Styles.Brands, new string[] { "google plus", "google social", "google+", "gplus", "social media", "social network" });
        private static IconData _SquareH;
        public static IconData FA_SquareH => _SquareH ??= new IconData("Square H", "\U0000F0FD", Styles.Solid, new string[] { "aid", "clinic", "directions", "emergency", "health", "healthcare", "hospital", "letter h", "map", "medical", "sign", "wayfinding" });
        private static IconData _SquareHackerNews;
        public static IconData FA_SquareHackerNews => _SquareHackerNews ??= new IconData("Square Hacker News", "\U0000F3AF", Styles.Brands, new string[] { "community", "developer", "hacker news", "hn", "news", "programming", "social", "startup", "tech", "technology" });
        private static IconData _SquareInstagram;
        public static IconData FA_SquareInstagram => _SquareInstagram ??= new IconData("Square Instagram", "\U0000E055", Styles.Brands, new string[] { "app", "brand", "camera", "insta", "instagram", "photo", "social media" });
        private static IconData _SquareJs;
        public static IconData FA_SquareJs => _SquareJs ??= new IconData("Square Js", "\U0000F3B9", Styles.Brands, new string[] { "api", "developer", "ecommerce", "fintech", "javascript", "js", "payments", "programming", "sdk", "square" });
        private static IconData _SquareLastfm;
        public static IconData FA_SquareLastfm => _SquareLastfm ??= new IconData("Square Lastfm", "\U0000F203", Styles.Brands, new string[] { "audio", "brand", "last.fm", "lastfm", "media", "music", "social", "streaming" });
        private static IconData _SquareLetterboxd;
        public static IconData FA_SquareLetterboxd => _SquareLetterboxd ??= new IconData("Square Letterboxd", "\U0000E62E", Styles.Brands, new string[] { "cinema", "film", "letterboxd", "movie", "movies", "rating", "reviews", "social", "streaming", "watchlist" });
        private static IconData _SquareLinkedin;
        public static IconData FA_SquareLinkedin => _SquareLinkedin ??= new IconData("Square Linkedin", "\U0000E7D0", Styles.Brands, new string[] { "business", "linkedin", "linkedin-logo", "linkedin-square", "network", "professional network", "social", "social media" });
        private static IconData _SquareMinus;
        public static IconData FA_SquareMinus => _SquareMinus ??= new IconData("Square Minus", "\U0000F146", Styles.Regular | Styles.Solid, new string[] { "close", "collapse", "hide", "hide-content", "minimize", "minus", "negative", "reduce", "remove", "shrink", "square", "subtract" });
        private static IconData _SquareNfi;
        public static IconData FA_SquareNfi => _SquareNfi ??= new IconData("Square Nfi", "\U0000E576", Styles.Solid, new string[] { "aid", "essentials", "goods", "humanitarian", "materials", "non-food item", "provisions", "relief", "supplies", "support items" });
        private static IconData _SquareOdnoklassniki;
        public static IconData FA_SquareOdnoklassniki => _SquareOdnoklassniki ??= new IconData("Square Odnoklassniki", "\U0000F264", Styles.Brands, new string[] { "odnoklassniki", "odnoklassniki.ru", "ok", "russian internet", "russian social network", "social media", "social network" });
        private static IconData _SquareParking;
        public static IconData FA_SquareParking => _SquareParking ??= new IconData("Square Parking", "\U0000F540", Styles.Solid, new string[] { "automobile", "car", "garage", "lot", "meter", "park", "parking", "parking-lot", "parking-space", "space", "square", "vehicle" });
        private static IconData _SquarePen;
        public static IconData FA_SquarePen => _SquarePen ??= new IconData("Square Pen", "\U0000F14B", Styles.Solid, new string[] { "annotate", "compose", "document", "draft", "edit", "form", "modify", "note", "pen", "pencil", "signature", "update", "write" });
        private static IconData _SquarePersonConfined;
        public static IconData FA_SquarePersonConfined => _SquarePersonConfined ??= new IconData("Square Person Confined", "\U0000E577", Styles.Solid, new string[] { "captivity", "confined", "detained", "enclosed", "isolated", "locked-in", "prisoner", "restricted", "trapped" });
        private static IconData _SquarePhone;
        public static IconData FA_SquarePhone => _SquarePhone ??= new IconData("Square Phone", "\U0000F098", Styles.Solid, new string[] { "call", "communication", "contact", "device", "handset", "mobile", "phone", "support", "telephone", "voice" });
        private static IconData _SquarePhoneFlip;
        public static IconData FA_SquarePhoneFlip => _SquarePhoneFlip ??= new IconData("Square Phone Flip", "\U0000F87B", Styles.Solid, new string[] { "call", "cell", "communication", "device", "flip phone", "handset", "mobile", "phone", "support", "telephone", "voice" });
        private static IconData _SquarePiedPiper;
        public static IconData FA_SquarePiedPiper => _SquarePiedPiper ??= new IconData("Square Pied Piper", "\U0000E01E", Styles.Brands, new string[] { "brand", "pied piper", "piedpiper", "piper", "software", "startup", "tech" });
        private static IconData _SquarePinterest;
        public static IconData FA_SquarePinterest => _SquarePinterest ??= new IconData("Square Pinterest", "\U0000F0D3", Styles.Brands, new string[] { "board", "ideas", "image sharing", "inspiration", "pin", "pinterest", "social media" });
        private static IconData _SquarePlus;
        public static IconData FA_SquarePlus => _SquarePlus ??= new IconData("Square Plus", "\U0000F0FE", Styles.Regular | Styles.Solid, new string[] { "add", "box", "create", "expand", "increase", "more", "new", "plus", "positive", "shape", "square" });
        private static IconData _SquarePollHorizontal;
        public static IconData FA_SquarePollHorizontal => _SquarePollHorizontal ??= new IconData("Square Poll Horizontal", "\U0000F682", Styles.Solid, new string[] { "chart", "comparison", "data", "feedback", "graph", "horizontal bars", "options", "poll", "questionnaire", "rating", "results", "statistics", "survey", "vote", "voting" });
        private static IconData _SquarePollVertical;
        public static IconData FA_SquarePollVertical => _SquarePollVertical ??= new IconData("Square Poll Vertical", "\U0000F681", Styles.Solid, new string[] { "analysis", "bar chart", "chart", "comparison", "data", "feedback", "graph", "metrics", "poll", "results", "statistics", "survey", "vertical bars", "vote", "voting" });
        private static IconData _SquareReddit;
        public static IconData FA_SquareReddit => _SquareReddit ??= new IconData("Square Reddit", "\U0000F1A2", Styles.Brands, new string[] { "community", "discussion", "forum", "reddit", "reddit logo", "rslash", "social media", "subreddit", "upvote" });
        private static IconData _SquareRootVariable;
        public static IconData FA_SquareRootVariable => _SquareRootVariable ??= new IconData("Square Root Variable", "\U0000F698", Styles.Solid, new string[] { "algebra", "arithmetic", "calculation", "equation", "formula", "math", "mathematics", "radical", "root symbol", "square root", "variable" });
        private static IconData _SquareRss;
        public static IconData FA_SquareRss => _SquareRss ??= new IconData("Square Rss", "\U0000F143", Styles.Solid, new string[] { "atom", "blog", "broadcast", "channel", "feed", "journal", "news", "podcast", "rss", "subscription", "syndication", "updates", "writing", "xml" });
        private static IconData _SquareShareNodes;
        public static IconData FA_SquareShareNodes => _SquareShareNodes ??= new IconData("Square Share Nodes", "\U0000F1E1", Styles.Solid, new string[] { "connect", "distribute", "export", "forward", "link", "network", "send", "share", "social", "upload" });
        private static IconData _SquareSnapchat;
        public static IconData FA_SquareSnapchat => _SquareSnapchat ??= new IconData("Square Snapchat", "\U0000F2AD", Styles.Brands, new string[] { "app", "chat", "filter", "ghost", "messaging", "snap", "snapchat", "snapcode", "social", "stories" });
        private static IconData _SquareSteam;
        public static IconData FA_SquareSteam => _SquareSteam ??= new IconData("Square Steam", "\U0000F1B7", Styles.Brands, new string[] { "digital", "distribution", "games", "gaming", "online", "pc", "platform", "steam", "store", "valve", "video games" });
        private static IconData _SquareThreads;
        public static IconData FA_SquareThreads => _SquareThreads ??= new IconData("Square Threads", "\U0000E619", Styles.Brands, new string[] { "meta", "microblogging", "online community", "social media", "social network", "square threads", "threads" });
        private static IconData _SquareTumblr;
        public static IconData FA_SquareTumblr => _SquareTumblr ??= new IconData("Square Tumblr", "\U0000F174", Styles.Brands, new string[] { "blog", "blogging", "microblog", "platform", "post", "social", "tmb", "tumblr" });
        private static IconData _SquareTwitter;
        public static IconData FA_SquareTwitter => _SquareTwitter ??= new IconData("Square Twitter", "\U0000F081", Styles.Brands, new string[] { "bird", "message", "microblogging", "post", "social media", "social network", "tweet", "tweetbird", "twitter" });
        private static IconData _SquareUpRight;
        public static IconData FA_SquareUpRight => _SquareUpRight ??= new IconData("Square Up Right", "\U0000F360", Styles.Solid, new string[] { "arrow", "diagonal", "direction", "exit", "external-link", "external-link-square", "forward", "launch", "link", "navigate", "northeast", "open", "share", "shortcut", "up-right arrow" });
        private static IconData _SquareUpwork;
        public static IconData FA_SquareUpwork => _SquareUpwork ??= new IconData("Square Upwork", "\U0000E67C", Styles.Brands, new string[] { "contract", "freelance", "freelancer", "gig economy", "jobs", "marketplace", "online work", "remote work", "upwork", "work platform" });
        private static IconData _SquareViadeo;
        public static IconData FA_SquareViadeo => _SquareViadeo ??= new IconData("Square Viadeo", "\U0000F2AA", Styles.Brands, new string[] { "brand", "business", "networking", "professional network", "social network", "viadeo" });
        private static IconData _SquareVimeo;
        public static IconData FA_SquareVimeo => _SquareVimeo ??= new IconData("Square Vimeo", "\U0000F194", Styles.Brands, new string[] { "brand", "media", "social", "streaming", "video", "vimeo" });
        private static IconData _SquareVirus;
        public static IconData FA_SquareVirus => _SquareVirus ??= new IconData("Square Virus", "\U0000E578", Styles.Solid, new string[] { "contagion", "coronavirus", "covid-19", "disease", "germ", "illness", "infection", "outbreak", "pandemic", "pathogen", "virus" });
        private static IconData _SquareWebAwesome;
        public static IconData FA_SquareWebAwesome => _SquareWebAwesome ??= new IconData("Square Web Awesome", "\U0000E683", Styles.Brands, new string[] { "UI", "awesome", "coding", "components", "crown", "front-end", "programming", "user interface", "web", "web development" });
        private static IconData _SquareWebAwesomeStroke;
        public static IconData FA_SquareWebAwesomeStroke => _SquareWebAwesomeStroke ??= new IconData("Square Web Awesome Stroke", "\U0000E684", Styles.Brands, new string[] { "awesome", "coding", "components", "crown", "design", "developer", "programming", "software", "web" });
        private static IconData _SquareWhatsapp;
        public static IconData FA_SquareWhatsapp => _SquareWhatsapp ??= new IconData("Square Whatsapp", "\U0000F40C", Styles.Brands, new string[] { "chat", "communication", "instant messaging", "message", "messaging", "mobile app", "social", "whatsapp", "whatsapp logo" });
        private static IconData _SquareXTwitter;
        public static IconData FA_SquareXTwitter => _SquareXTwitter ??= new IconData("Square X Twitter", "\U0000E61A", Styles.Brands, new string[] { "elon musk", "microblogging", "social media", "social network", "tweet", "twitter", "x", "x app" });
        private static IconData _SquareXing;
        public static IconData FA_SquareXing => _SquareXing ??= new IconData("Square Xing", "\U0000F169", Styles.Brands, new string[] { "business networking", "careers", "jobs", "networking site", "professional network", "social network", "xing", "xing brand", "xing logo" });
        private static IconData _SquareXmark;
        public static IconData FA_SquareXmark => _SquareXmark ??= new IconData("Square Xmark", "\U0000F2D3", Styles.Solid, new string[] { "cancel", "close", "cross", "cross mark", "dismiss", "error", "exit", "incorrect", "mark", "problem", "remove", "square", "stop", "wrong", "x" });
        private static IconData _SquareYoutube;
        public static IconData FA_SquareYoutube => _SquareYoutube ??= new IconData("Square Youtube", "\U0000F431", Styles.Brands, new string[] { "brand", "media", "play", "social", "square", "streaming", "video", "youtube" });
        private static IconData _Squarespace;
        public static IconData FA_Squarespace => _Squarespace ??= new IconData("Squarespace", "\U0000F5BE", Styles.Brands, new string[] { "blogging", "cms", "content management", "ecommerce", "online store", "sqsp", "squarespace", "web design", "website builder", "website hosting", "website platform" });
        private static IconData _StackExchange;
        public static IconData FA_StackExchange => _StackExchange ??= new IconData("Stack Exchange", "\U0000F18D", Styles.Brands, new string[] { "Q&A", "answers", "community", "developer", "forum", "knowledge sharing", "programming", "questions", "stack exchange", "stackexchange" });
        private static IconData _StackOverflow;
        public static IconData FA_StackOverflow => _StackOverflow ??= new IconData("Stack Overflow", "\U0000F16C", Styles.Brands, new string[] { "Q&A", "answers", "coding", "community", "developer", "forum", "programming", "questions", "stack overflow", "stackoverflow", "tech" });
        private static IconData _Stackpath;
        public static IconData FA_Stackpath => _Stackpath ??= new IconData("Stackpath", "\U0000F842", Styles.Brands, new string[] { "cdn", "cloud security", "cloud services", "content delivery network", "cybersecurity", "edge computing", "internet security", "network services", "stackpath", "web performance" });
        private static IconData _StaffSnake;
        public static IconData FA_StaffSnake => _StaffSnake ??= new IconData("Staff Snake", "\U0000E579", Styles.Solid, new string[] { "asclepius", "asklepian", "caduceus", "healing", "health", "healthcare", "medical", "medicine", "pharmacy", "serpent", "snake", "wellness" });
        private static IconData _Stairs;
        public static IconData FA_Stairs => _Stairs ??= new IconData("Stairs", "\U0000E289", Styles.Solid, new string[] { "ascent", "climb", "exit", "staircase", "stairs", "stairway", "steps", "up" });
        private static IconData _Stamp;
        public static IconData FA_Stamp => _Stamp ??= new IconData("Stamp", "\U0000F5BF", Styles.Solid, new string[] { "approval", "certification", "endorsement", "imprint", "mark", "official", "rubber stamp", "seal", "stamp", "validation" });
        private static IconData _Stapler;
        public static IconData FA_Stapler => _Stapler ??= new IconData("Stapler", "\U0000E5AF", Styles.Solid, new string[] { "binder", "clip", "desktop", "document", "fastening", "office", "paper", "staple", "stapler", "stationery" });
        private static IconData _Star;
        public static IconData FA_Star => _Star ??= new IconData("Star", "\U0000F005", Styles.Regular | Styles.Solid, new string[] { "achievement", "award", "bookmark", "favorite", "favorite item", "highlight", "important", "night", "premium", "quality", "rating", "score", "star", "top", "vip" });
        private static IconData _StarAndCrescent;
        public static IconData FA_StarAndCrescent => _StarAndCrescent ??= new IconData("Star And Crescent", "\U0000F699", Styles.Solid, new string[] { "Islam", "Islamic symbol", "Muslim", "Muslim faith", "crescent and star", "crescent moon", "faith", "religion", "star and crescent" });
        private static IconData _StarHalf;
        public static IconData FA_StarHalf => _StarHalf ??= new IconData("Star Half", "\U0000F089", Styles.Regular | Styles.Solid, new string[] { "achievement", "award", "feedback", "half star", "half-filled star", "partial rating", "rating", "review", "score", "star half", "star outline" });
        private static IconData _StarHalfStroke;
        public static IconData FA_StarHalfStroke => _StarHalfStroke ??= new IconData("Star Half Stroke", "\U0000F5C0", Styles.Regular | Styles.Solid, new string[] { "achievement", "award", "favorite", "feedback", "half star", "partial rating", "rating", "review", "score", "star half", "star half empty", "star half full" });
        private static IconData _StarOfDavid;
        public static IconData FA_StarOfDavid => _StarOfDavid ??= new IconData("Star Of David", "\U0000F69A", Styles.Solid, new string[] { "David", "Israel", "Jewish", "Jewish star", "Judaism", "faith", "heritage", "hexagram", "religion", "star of David", "symbol" });
        private static IconData _StarOfLife;
        public static IconData FA_StarOfLife => _StarOfLife ??= new IconData("Star Of Life", "\U0000F621", Styles.Solid, new string[] { "ambulance", "emergency", "emergency medical services", "emt", "first aid", "health", "healthcare", "lifesaver", "medical", "paramedic", "rescue", "star of life" });
        private static IconData _Staylinked;
        public static IconData FA_Staylinked => _Staylinked ??= new IconData("Staylinked", "\U0000F3F5", Styles.Brands, new string[] { "barcode scanning", "enterprise mobility", "linkin", "mobile computing", "staylinked", "warehouse software" });
        private static IconData _Steam;
        public static IconData FA_Steam => _Steam ??= new IconData("Steam", "\U0000F1B6", Styles.Brands, new string[] { "digital distribution", "game launcher", "games", "gaming", "online store", "pc games", "platform", "steam", "valve", "video games" });
        private static IconData _SteamSymbol;
        public static IconData FA_SteamSymbol => _SteamSymbol ??= new IconData("Steam Symbol", "\U0000F3F6", Styles.Brands, new string[] { "PC games", "digital distribution", "game launcher", "game store", "gaming", "online gaming", "platform", "steam", "valve", "video games" });
        private static IconData _SterlingSign;
        public static IconData FA_SterlingSign => _SterlingSign ??= new IconData("Sterling Sign", "\U0000F154", Styles.Solid, new string[] { "GBP", "british pound", "currency", "currency symbol", "finance", "money", "pound", "sterling" });
        private static IconData _Stethoscope;
        public static IconData FA_Stethoscope => _Stethoscope ??= new IconData("Stethoscope", "\U0000F0F1", Styles.Solid, new string[] { "auscultation", "clinic", "diagnosis", "doctor", "examination", "health", "healthcare", "heart", "hospital", "medical", "medical equipment", "medicine", "nurse", "physician", "stethoscope" });
        private static IconData _StickerMule;
        public static IconData FA_StickerMule => _StickerMule ??= new IconData("Sticker Mule", "\U0000F3F7", Styles.Brands, new string[] { "Sticker Mule", "branded stickers", "custom labels", "custom stickers", "decal", "label printing", "printing service", "promotional stickers", "stickers" });
        private static IconData _Stop;
        public static IconData FA_Stop => _Stop ??= new IconData("Stop", "\U0000F04D", Styles.Solid, new string[] { "block", "cancel", "end", "forbidden", "halt", "no entry", "pause", "prohibition", "red square", "square", "stop", "stop button", "stop sign", "warning" });
        private static IconData _Stopwatch;
        public static IconData FA_Stopwatch => _Stopwatch ??= new IconData("Stopwatch", "\U0000F2F2", Styles.Solid, new string[] { "chronometer", "clock", "countdown", "stopwatch", "stopwatch clock", "stopwatch device", "stopwatch icon", "stopwatch measurement", "stopwatch symbol", "stopwatch timer", "stopwatch tracking", "stopwatch watch", "time", "timer", "timing" });
        private static IconData _Stopwatch20;
        public static IconData FA_Stopwatch20 => _Stopwatch20 ??= new IconData("Stopwatch 20", "\U0000E06F", Styles.Solid, new string[] { "chronometer", "clock", "countdown", "reminder", "seconds", "stopwatch", "stopwatch clock", "stopwatch countdown", "stopwatch reminder", "stopwatch timer", "time", "timer", "timing" });
        private static IconData _Store;
        public static IconData FA_Store => _Store ??= new IconData("Store", "\U0000F54E", Styles.Solid, new string[] { "bodega", "boutique", "building", "business", "buy", "commerce", "mall", "market", "outlet", "purchase", "retail", "shop", "shopping", "store", "storefront" });
        private static IconData _StoreSlash;
        public static IconData FA_StoreSlash => _StoreSlash ??= new IconData("Store Slash", "\U0000E071", Styles.Solid, new string[] { "blocked", "building", "buy", "cancel", "closed", "disabled", "forbidden", "no entry", "purchase", "shop", "shopping", "slash", "stop", "store", "unavailable" });
        private static IconData _Strava;
        public static IconData FA_Strava => _Strava ??= new IconData("Strava", "\U0000F428", Styles.Brands, new string[] { "cycling", "exercise", "fitness", "gps", "running", "sports", "strava", "tracking", "training", "workout" });
        private static IconData _StreetView;
        public static IconData FA_StreetView => _StreetView ??= new IconData("Street View", "\U0000F21D", Styles.Solid, new string[] { "directions", "explore", "gps", "location", "map", "navigation", "panorama", "route", "street", "street-level", "travel", "view" });
        private static IconData _Strikethrough;
        public static IconData FA_Strikethrough => _Strikethrough ??= new IconData("Strikethrough", "\U0000F0CC", Styles.Solid, new string[] { "cancel", "cross out", "delete", "edit", "font", "format", "line-through", "modify", "remove", "strike", "strikethrough", "text", "type" });
        private static IconData _Stripe;
        public static IconData FA_Stripe => _Stripe ??= new IconData("Stripe", "\U0000F429", Styles.Brands, new string[] { "billing", "credit card", "ecommerce", "fintech", "gateway", "merchant", "online payment", "payment", "payments", "stripe", "subscription" });
        private static IconData _StripeS;
        public static IconData FA_StripeS => _StripeS ??= new IconData("Stripe S", "\U0000F42A", Styles.Brands, new string[] { "billing", "credit card", "ecommerce", "financial", "fintech", "online payments", "payment", "payments", "stripe", "subscription" });
        private static IconData _Stroopwafel;
        public static IconData FA_Stroopwafel => _Stroopwafel ??= new IconData("Stroopwafel", "\U0000F551", Styles.Solid, new string[] { "Dutch", "biscuit", "caramel", "cookie", "dessert", "snack", "stroopwafel", "sweets", "syrup", "treat", "waffle" });
        private static IconData _Stubber;
        public static IconData FA_Stubber => _Stubber ??= new IconData("Stubber", "\U0000E5C7", Styles.Brands, new string[] { "admission", "coupon", "event ticket", "receipt", "stub", "stub ticket", "stubber", "ticket", "voucher" });
        private static IconData _Studiovinari;
        public static IconData FA_Studiovinari => _Studiovinari ??= new IconData("Studiovinari", "\U0000F3F8", Styles.Brands, new string[] { "brand", "company", "logo", "studio vinari", "studiovinari", "vinari" });
        private static IconData _Stumbleupon;
        public static IconData FA_Stumbleupon => _Stumbleupon ??= new IconData("Stumbleupon", "\U0000F1A4", Styles.Brands, new string[] { "bookmarking", "content", "discovery", "internet", "network", "sharing", "social", "stumble", "stumbleupon", "web" });
        private static IconData _StumbleuponCircle;
        public static IconData FA_StumbleuponCircle => _StumbleuponCircle ??= new IconData("Stumbleupon Circle", "\U0000F1A3", Styles.Brands, new string[] { "bookmark", "discovery", "network", "sharing", "social", "stumble", "stumbleupon", "su" });
        private static IconData _Subscript;
        public static IconData FA_Subscript => _Subscript ??= new IconData("Subscript", "\U0000F12C", Styles.Solid, new string[] { "character", "edit", "font", "formatting", "script", "style", "subscript", "text", "type", "typography" });
        private static IconData _Suitcase;
        public static IconData FA_Suitcase => _Suitcase ??= new IconData("Suitcase", "\U0000F0F2", Styles.Solid, new string[] { "bag", "baggage", "briefcase", "carry-on", "holiday", "journey", "luggage", "moving", "packing", "suitcase", "suitcase icon", "travel", "travel bag", "trip", "vacation" });
        private static IconData _SuitcaseMedical;
        public static IconData FA_SuitcaseMedical => _SuitcaseMedical ??= new IconData("Suitcase Medical", "\U0000F0FA", Styles.Solid, new string[] { "aid", "case", "emergency", "first aid", "firstaid", "health", "help", "kit", "medical", "medical bag", "medical kit", "supplies", "support" });
        private static IconData _SuitcaseRolling;
        public static IconData FA_SuitcaseRolling => _SuitcaseRolling ??= new IconData("Suitcase Rolling", "\U0000F5C1", Styles.Solid, new string[] { "baggage", "carry-on", "journey", "luggage", "packing", "rolling suitcase", "suitcase", "suitcase with wheels", "travel", "travel bag", "trip", "trolley bag", "vacation", "wheeled luggage" });
        private static IconData _Sun;
        public static IconData FA_Sun => _Sun ??= new IconData("Sun", "\U0000F185", Styles.Regular | Styles.Solid, new string[] { "bright", "daylight", "daytime", "rays", "sol", "solar", "star", "sun", "sunlight", "sunny", "sunshine", "warmth", "weather" });
        private static IconData _SunPlantWilt;
        public static IconData FA_SunPlantWilt => _SunPlantWilt ??= new IconData("Sun Plant Wilt", "\U0000E57A", Styles.Solid, new string[] { "arid", "droop", "drought", "dry", "heat damage", "plant stress", "sun damage", "thirsty", "wilt", "wither" });
        private static IconData _Superpowers;
        public static IconData FA_Superpowers => _Superpowers ??= new IconData("Superpowers", "\U0000F2DD", Styles.Brands, new string[] { "abilities", "comic", "fantasy", "hero", "powers", "special abilities", "strength", "superhero", "superhuman", "superpowers" });
        private static IconData _Superscript;
        public static IconData FA_Superscript => _Superscript ??= new IconData("Superscript", "\U0000F12B", Styles.Solid, new string[] { "edit", "exponent", "font", "format", "math", "power", "raised", "script", "superscript", "text", "typing" });
        private static IconData _Supple;
        public static IconData FA_Supple => _Supple ??= new IconData("Supple", "\U0000F3F9", Styles.Brands, new string[] { "Supple", "Supple brand", "Supple company", "Supple logo", "supple" });
        private static IconData _Supportnow;
        public static IconData FA_Supportnow => _Supportnow ??= new IconData("Supportnow", "\U0000E833", Styles.Brands, new string[] { "customer support", "helpdesk", "online support", "support brand", "support now", "support platform", "support service", "supportnow", "tech support" });
        private static IconData _Suse;
        public static IconData FA_Suse => _Suse ??= new IconData("Suse", "\U0000F7D6", Styles.Brands, new string[] { "enterprise linux", "linux", "linux distribution", "open source", "operating system", "os", "sle", "suse", "suse linux" });
        private static IconData _Svelte;
        public static IconData FA_Svelte => _Svelte ??= new IconData("Svelte", "\U0000E868", Styles.Brands, new string[] { });
        private static IconData _Swatchbook;
        public static IconData FA_Swatchbook => _Swatchbook ??= new IconData("Swatchbook", "\U0000F5C3", Styles.Solid, new string[] { "Pantone", "color", "color chart", "color picker", "colors", "design", "hue", "paint", "palette", "sample", "shades", "swatch", "tint", "tone" });
        private static IconData _Swift;
        public static IconData FA_Swift => _Swift ??= new IconData("Swift", "\U0000F8E1", Styles.Brands, new string[] { "app development", "apple swift", "code", "developer", "ios", "macos", "programming language", "software", "swift", "swift programming" });
        private static IconData _Symfony;
        public static IconData FA_Symfony => _Symfony ??= new IconData("Symfony", "\U0000F83D", Styles.Brands, new string[] { "backend", "mvc", "open source", "php", "php framework", "php library", "symfony", "symfony framework", "web development" });
        private static IconData _Symfonycasts;
        public static IconData FA_Symfonycasts => _Symfonycasts ??= new IconData("Symfonycasts", "\U0000E8AB", Styles.Brands, new string[] { });
        private static IconData _Synagogue;
        public static IconData FA_Synagogue => _Synagogue ??= new IconData("Synagogue", "\U0000F69B", Styles.Solid, new string[] { "Jewish", "Judaism", "Star of David", "community center", "faith", "house of worship", "religion", "synagogue", "synagogue building", "temple" });
        private static IconData _Syringe;
        public static IconData FA_Syringe => _Syringe ??= new IconData("Syringe", "\U0000F48E", Styles.Solid, new string[] { "covid-19", "doctor", "flu shot", "immunization", "immunizations", "injection", "inoculation", "medical", "medicine", "needle", "shot", "syringe", "vaccinate", "vaccination", "vaccine" });
        private static IconData _T;
        public static IconData FA_T => _T ??= new IconData("T", "\U00000054", Styles.Solid, new string[] { "alphabet", "capital t", "character", "letter t", "lowercase t", "symbol", "text" });
        private static IconData _Table;
        public static IconData FA_Table => _Table ??= new IconData("Table", "\U0000F0CE", Styles.Solid, new string[] { "chart", "columns", "data", "database", "excel", "grid", "report", "rows", "sheet", "spreadsheet", "table" });
        private static IconData _TableCells;
        public static IconData FA_TableCells => _TableCells ??= new IconData("Table Cells", "\U0000F00A", Styles.Solid, new string[] { "blocks", "boxes", "cells", "chart", "columns", "data", "excel", "grid", "layout", "matrix", "organize", "rows", "spreadsheet", "squares", "table" });
        private static IconData _TableCellsColumnLock;
        public static IconData FA_TableCellsColumnLock => _TableCellsColumnLock ??= new IconData("Table Cells Column Lock", "\U0000E678", Styles.Solid, new string[] { "block", "cells", "column", "data", "excel", "grid", "lock", "locked-column", "protected", "restricted", "secure", "sheet", "spreadsheet", "table" });
        private static IconData _TableCellsLarge;
        public static IconData FA_TableCellsLarge => _TableCellsLarge ??= new IconData("Table Cells Large", "\U0000F009", Styles.Solid, new string[] { "blocks", "boxes", "category", "cells", "columns", "data", "excel", "grid", "layout", "matrix", "rows", "spreadsheet", "squares", "table" });
        private static IconData _TableCellsRowLock;
        public static IconData FA_TableCellsRowLock => _TableCellsRowLock ??= new IconData("Table Cells Row Lock", "\U0000E67A", Styles.Solid, new string[] { "block", "boxes", "cells", "column", "data", "excel", "grid", "lock", "locked", "protected", "row", "secure", "spreadsheet", "table" });
        private static IconData _TableCellsRowUnlock;
        public static IconData FA_TableCellsRowUnlock => _TableCellsRowUnlock ??= new IconData("Table Cells Row Unlock", "\U0000E691", Styles.Solid, new string[] { "access", "blocks", "boxes", "cells", "column", "data", "edit", "grid", "open", "row", "spreadsheet", "table", "unlock", "unlocked" });
        private static IconData _TableColumns;
        public static IconData FA_TableColumns => _TableColumns ??= new IconData("Table Columns", "\U0000F0DB", Styles.Solid, new string[] { "browser", "columns", "dashboard", "data", "grid", "layout", "organize", "panes", "sections", "split", "spreadsheet", "table", "view" });
        private static IconData _TableList;
        public static IconData FA_TableList => _TableList ??= new IconData("Table List", "\U0000F00B", Styles.Solid, new string[] { "category", "checklist", "columns", "completed", "data", "done", "finished", "items", "list", "organized", "rows", "summary", "table", "tasks", "todo" });
        private static IconData _TableTennisPaddleBall;
        public static IconData FA_TableTennisPaddleBall => _TableTennisPaddleBall ??= new IconData("Table Tennis Paddle Ball", "\U0000F45D", Styles.Solid, new string[] { "ball", "bat", "game", "paddle", "ping pong", "ping-pong ball", "ping-pong paddle", "racket", "sport", "table tennis" });
        private static IconData _Tablet;
        public static IconData FA_Tablet => _Tablet ??= new IconData("Tablet", "\U0000F3FB", Styles.Solid, new string[] { "device", "e-reader", "gadget", "kindle", "mobile", "portable", "screen", "slate", "tablet", "touchscreen" });
        private static IconData _TabletButton;
        public static IconData FA_TabletButton => _TabletButton ??= new IconData("Tablet Button", "\U0000F10A", Styles.Solid, new string[] { "device", "digital reader", "electronic", "gadget", "ipad", "kindle", "mobile", "screen", "slate", "tablet", "touchscreen" });
        private static IconData _TabletScreenButton;
        public static IconData FA_TabletScreenButton => _TabletScreenButton ??= new IconData("Tablet Screen Button", "\U0000F3FA", Styles.Solid, new string[] { "device", "digital reader", "gadget", "ipad", "kindle", "mobile", "screen", "slate", "tablet", "touchscreen" });
        private static IconData _Tablets;
        public static IconData FA_Tablets => _Tablets ??= new IconData("Tablets", "\U0000F490", Styles.Solid, new string[] { "capsules", "drugs", "health", "medication", "medicine", "pharmaceutical", "pills", "prescription", "remedy", "tablets", "treatment" });
        private static IconData _TachographDigital;
        public static IconData FA_TachographDigital => _TachographDigital ??= new IconData("Tachograph Digital", "\U0000F566", Styles.Solid, new string[] { "dashboard", "data", "digital", "distance", "driving", "gauge", "instrument", "meter", "speed", "speedometer", "tachograph", "vehicle" });
        private static IconData _Tag;
        public static IconData FA_Tag => _Tag ??= new IconData("Tag", "\U0000F02B", Styles.Solid, new string[] { "badge", "coupon", "discount", "label", "marker", "price", "price tag", "sale", "shopping", "sticker", "tag", "tag price", "ticket" });
        private static IconData _Tags;
        public static IconData FA_Tags => _Tags ??= new IconData("Tags", "\U0000F02C", Styles.Solid, new string[] { "clearance", "coupon", "deal", "discount", "label", "markdown", "offer", "price", "price tag", "sale", "shopping", "tag", "tag price" });
        private static IconData _TailwindCss;
        public static IconData FA_TailwindCss => _TailwindCss ??= new IconData("Tailwind Css", "\U0000E866", Styles.Brands, new string[] { });
        private static IconData _Tape;
        public static IconData FA_Tape => _Tape ??= new IconData("Tape", "\U0000F4DB", Styles.Solid, new string[] { "adhesive", "duct tape", "masking tape", "packaging", "roll", "sealing", "sticky", "sticky tape", "tape", "tape dispenser", "tape measure", "tape roll" });
        private static IconData _Tarp;
        public static IconData FA_Tarp => _Tarp ??= new IconData("Tarp", "\U0000E57B", Styles.Solid, new string[] { "canopy", "cover", "groundsheet", "outdoor", "protection", "rain cover", "shelter", "tarp", "tarp tent", "waterproof" });
        private static IconData _TarpDroplet;
        public static IconData FA_TarpDroplet => _TarpDroplet ??= new IconData("Tarp Droplet", "\U0000E57C", Styles.Solid, new string[] { "cover", "droplet", "moisture", "outdoor", "protection", "rain", "shelter", "tarp", "water", "waterproof" });
        private static IconData _Taurus;
        public static IconData FA_Taurus => _Taurus ??= new IconData("Taurus", "\U0000E84F", Styles.Solid, new string[] { "april", "astrology", "bull", "constellation", "earth sign", "horoscope", "may", "sign", "stars", "taurus", "zodiac" });
        private static IconData _Taxi;
        public static IconData FA_Taxi => _Taxi ??= new IconData("Taxi", "\U0000F1BA", Styles.Solid, new string[] { "cab", "cabbie", "car", "car service", "dropoff", "fare", "pickup", "ride", "rideshare", "taxi", "taxi cab", "taxi driver", "transportation", "travel", "vehicle", "yellow cab" });
        private static IconData _Teamspeak;
        public static IconData FA_Teamspeak => _Teamspeak ??= new IconData("Teamspeak", "\U0000F4F9", Styles.Brands, new string[] { "VoIP", "chat app", "communication", "gaming voice", "online gaming", "teamspeak", "ts", "voice chat" });
        private static IconData _Teeth;
        public static IconData FA_Teeth => _Teeth ??= new IconData("Teeth", "\U0000F62E", Styles.Solid, new string[] { "bite", "braces", "chewing", "dental", "dentist", "enamel", "gums", "hygiene", "incisor", "molar", "mouth", "oral", "plaque", "smile", "tooth" });
        private static IconData _TeethOpen;
        public static IconData FA_TeethOpen => _TeethOpen ??= new IconData("Teeth Open", "\U0000F62F", Styles.Solid, new string[] { "bite", "canines", "chewing", "dental", "dentist", "gums", "jaw", "molars", "mouth", "oral", "smile", "teeth", "tooth" });
        private static IconData _Telegram;
        public static IconData FA_Telegram => _Telegram ??= new IconData("Telegram", "\U0000F2C6", Styles.Brands, new string[] { "app", "chat", "communication", "instant messaging", "messaging", "messenger app", "mobile app", "social media", "telegram", "telegram messenger" });
        private static IconData _TemperatureArrowDown;
        public static IconData FA_TemperatureArrowDown => _TemperatureArrowDown ??= new IconData("Temperature Arrow Down", "\U0000E03F", Styles.Solid, new string[] { "air conditioner", "arrow down", "chill", "cold", "cooling", "decrease", "drop", "temperature", "thermometer", "winter" });
        private static IconData _TemperatureArrowUp;
        public static IconData FA_TemperatureArrowUp => _TemperatureArrowUp ??= new IconData("Temperature Arrow Up", "\U0000E040", Styles.Solid, new string[] { "air conditioner", "climate", "heat", "heat increase", "heater", "heating", "hot", "mercury", "rising temperature", "temperature", "temperature rise", "thermometer", "warmer", "weather" });
        private static IconData _TemperatureEmpty;
        public static IconData FA_TemperatureEmpty => _TemperatureEmpty ??= new IconData("Temperature Empty", "\U0000F2CB", Styles.Solid, new string[] { "chilly", "climate", "cold", "empty", "freeze", "frost", "gauge", "indicator", "low", "temperature", "thermometer", "weather" });
        private static IconData _TemperatureFull;
        public static IconData FA_TemperatureFull => _TemperatureFull ??= new IconData("Temperature Full", "\U0000F2C7", Styles.Solid, new string[] { "climate", "fever", "heat", "hot", "mercury", "status", "temperature", "thermometer", "warmth", "weather" });
        private static IconData _TemperatureHalf;
        public static IconData FA_TemperatureHalf => _TemperatureHalf ??= new IconData("Temperature Half", "\U0000F2C9", Styles.Solid, new string[] { "climate", "cold", "degree", "gauge", "heat", "measurement", "mercury", "sensor", "status", "temperature", "thermometer", "weather" });
        private static IconData _TemperatureHigh;
        public static IconData FA_TemperatureHigh => _TemperatureHigh ??= new IconData("Temperature High", "\U0000F769", Styles.Solid, new string[] { "cook", "fever", "heat", "hot", "mercury", "summer", "temperature", "thermometer", "warm", "weather" });
        private static IconData _TemperatureLow;
        public static IconData FA_TemperatureLow => _TemperatureLow ??= new IconData("Temperature Low", "\U0000F76B", Styles.Solid, new string[] { "chilly", "cold", "cold weather", "cool", "freeze", "frost", "icy", "low temperature", "thermometer", "winter" });
        private static IconData _TemperatureQuarter;
        public static IconData FA_TemperatureQuarter => _TemperatureQuarter ??= new IconData("Temperature Quarter", "\U0000F2CA", Styles.Solid, new string[] { "climate", "cold", "gauge", "heat", "level", "mercury", "status", "temperature", "thermometer", "weather" });
        private static IconData _TemperatureThreeQuarters;
        public static IconData FA_TemperatureThreeQuarters => _TemperatureThreeQuarters ??= new IconData("Temperature Three Quarters", "\U0000F2C8", Styles.Solid, new string[] { "climate", "degree", "gauge", "heat", "mercury", "status", "temperature", "thermometer", "warm", "weather" });
        private static IconData _TencentWeibo;
        public static IconData FA_TencentWeibo => _TencentWeibo ??= new IconData("Tencent Weibo", "\U0000F1D5", Styles.Brands, new string[] { "chinese social media", "messaging", "microblog", "platform", "social", "tencent", "weibo" });
        private static IconData _TengeSign;
        public static IconData FA_TengeSign => _TengeSign ??= new IconData("Tenge Sign", "\U0000F7D7", Styles.Solid, new string[] { "KZT", "Kazakhstani currency", "Kazakhstani tenge", "Tenge", "currency", "currency symbol", "financial symbol", "money", "payment", "price" });
        private static IconData _Tent;
        public static IconData FA_Tent => _Tent ??= new IconData("Tent", "\U0000E57D", Styles.Solid, new string[] { "backpacking", "bivouac", "campground", "camping", "camping equipment", "camping gear", "camping shelter", "camping tent", "camping trip", "campsite", "hiking", "outdoor", "shelter", "temporary shelter", "tent" });
        private static IconData _TentArrowDownToLine;
        public static IconData FA_TentArrowDownToLine => _TentArrowDownToLine ??= new IconData("Tent Arrow Down To Line", "\U0000E57E", Styles.Solid, new string[] { "arrow down", "arrow down to line", "bivouac", "campground", "camping", "camping gear", "camping site", "campsite", "outdoor", "pitched tent", "shelter", "temporary shelter", "tent", "tent setup" });
        private static IconData _TentArrowLeftRight;
        public static IconData FA_TentArrowLeftRight => _TentArrowLeftRight ??= new IconData("Tent Arrow Left Right", "\U0000E57F", Styles.Solid, new string[] { "arrows", "bivouac", "campground", "camping", "campsite", "direction", "left-right", "move", "navigation", "outdoor", "shelter", "tent", "transition", "travel" });
        private static IconData _TentArrowTurnLeft;
        public static IconData FA_TentArrowTurnLeft => _TentArrowTurnLeft ??= new IconData("Tent Arrow Turn Left", "\U0000E580", Styles.Solid, new string[] { "arrow", "bivouac", "campground", "camping", "campsite", "direction", "left", "navigation", "outdoor", "shelter", "temporary", "tent", "turn" });
        private static IconData _TentArrowsDown;
        public static IconData FA_TentArrowsDown => _TentArrowsDown ??= new IconData("Tent Arrows Down", "\U0000E581", Styles.Solid, new string[] { "arrows-down", "bivouac", "campground", "camping", "campsite", "insert", "outdoor", "refugee", "shelter", "tent" });
        private static IconData _Tents;
        public static IconData FA_Tents => _Tents ??= new IconData("Tents", "\U0000E582", Styles.Solid, new string[] { "bivouac", "campground", "camping", "camping gear", "camping shelter", "camping site", "camping tent", "campsite", "outdoor", "outdoor shelter", "shelter", "temporary shelter", "tent" });
        private static IconData _Terminal;
        public static IconData FA_Terminal => _Terminal ??= new IconData("Terminal", "\U0000F120", Styles.Solid, new string[] { "cli", "code", "coding", "command", "command line", "command prompt", "console", "developer", "development", "programming", "prompt", "script", "shell", "terminal" });
        private static IconData _Tex;
        public static IconData FA_Tex => _Tex ??= new IconData("Tex", "\U0000E7FF", Styles.Brands, new string[] { "document", "formula", "latex", "markup", "math", "scientific", "tex", "typesetting" });
        private static IconData _TextHeight;
        public static IconData FA_TextHeight => _TextHeight ??= new IconData("Text Height", "\U0000F034", Styles.Solid, new string[] { "edit", "font", "format", "formatting", "height", "resize", "size", "style", "text", "type", "typography" });
        private static IconData _TextSlash;
        public static IconData FA_TextSlash => _TextSlash ??= new IconData("Text Slash", "\U0000F87D", Styles.Solid, new string[] { "block", "cancel", "disabled", "font", "forbidden", "format", "no-text", "remove", "strike", "strikethrough", "style", "text" });
        private static IconData _TextWidth;
        public static IconData FA_TextWidth => _TextWidth ??= new IconData("Text Width", "\U0000F035", Styles.Solid, new string[] { "adjust", "alignment", "edit", "format", "layout", "paragraph", "resize", "text", "type", "typography", "width" });
        private static IconData _TheRedYeti;
        public static IconData FA_TheRedYeti => _TheRedYeti ??= new IconData("The Red Yeti", "\U0000F69D", Styles.Brands, new string[] { "brand", "content creator", "esports", "gaming", "red yeti", "streamer", "the red", "the red yeti", "yeti" });
        private static IconData _Themeco;
        public static IconData FA_Themeco => _Themeco ??= new IconData("Themeco", "\U0000F5C6", Styles.Brands, new string[] { "brand", "builder", "creative", "digital products", "page builder", "templates", "theme", "themeco", "themes", "web design", "website", "wordpress" });
        private static IconData _Themeisle;
        public static IconData FA_Themeisle => _Themeisle ??= new IconData("Themeisle", "\U0000F2B2", Styles.Brands, new string[] { "theme isle", "themeisle", "website templates", "website themes", "wordpress", "wordpress plugins", "wordpress themes" });
        private static IconData _Thermometer;
        public static IconData FA_Thermometer => _Thermometer ??= new IconData("Thermometer", "\U0000F491", Styles.Solid, new string[] { "cold", "covid-19", "fever", "health", "heat", "medical", "mercury", "status", "temperature", "thermometer" });
        private static IconData _ThinkPeaks;
        public static IconData FA_ThinkPeaks => _ThinkPeaks ??= new IconData("Think Peaks", "\U0000F731", Styles.Brands, new string[] { "analytics", "business intelligence", "charts", "data", "graphs", "peaks", "think peaks", "thinkpeaks", "visualization" });
        private static IconData _Threads;
        public static IconData FA_Threads => _Threads ??= new IconData("Threads", "\U0000E618", Styles.Brands, new string[] { "chat", "communication", "conversation", "messaging", "meta", "social media", "social network", "threads" });
        private static IconData _Threema;
        public static IconData FA_Threema => _Threema ??= new IconData("Threema", "\U0000E85F", Styles.Brands, new string[] { });
        private static IconData _ThumbsDown;
        public static IconData FA_ThumbsDown => _ThumbsDown ??= new IconData("Thumbs Down", "\U0000F165", Styles.Regular | Styles.Solid, new string[] { "disagree", "disapprove", "dislike", "dislike button", "downvote", "hand gesture", "negative", "no", "thumb down", "thumbs down", "thumbs-o-down" });
        private static IconData _ThumbsUp;
        public static IconData FA_ThumbsUp => _ThumbsUp ??= new IconData("Thumbs Up", "\U0000F164", Styles.Regular | Styles.Solid, new string[] { "+1", "agree", "approve", "endorsement", "good", "hand", "like", "ok", "okay", "positive", "recommend", "social", "success", "support", "thumb", "thumbs up", "vote", "yes" });
        private static IconData _Thumbtack;
        public static IconData FA_Thumbtack => _Thumbtack ??= new IconData("Thumbtack", "\U0000F08D", Styles.Solid, new string[] { "drop", "location", "map", "map-pin", "marker", "office", "pin", "place", "pushpin", "stationery", "tack", "thumbtack" });
        private static IconData _ThumbtackSlash;
        public static IconData FA_ThumbtackSlash => _ThumbtackSlash ??= new IconData("Thumbtack Slash", "\U0000E68F", Styles.Solid, new string[] { "block pin", "cancel location", "disable location", "location", "map pin off", "marker", "no pin", "pin", "pushpin", "remove pin", "thumbtack", "unpin" });
        private static IconData _Ticket;
        public static IconData FA_Ticket => _Ticket ??= new IconData("Ticket", "\U0000F145", Styles.Solid, new string[] { "admission", "admission ticket", "boarding pass", "concert", "coupon", "entry", "event", "movie", "pass", "show", "ticket", "voucher" });
        private static IconData _TicketSimple;
        public static IconData FA_TicketSimple => _TicketSimple ??= new IconData("Ticket Simple", "\U0000F3FF", Styles.Solid, new string[] { "admission", "boarding", "concert", "coupon", "entry", "event", "movie", "pass", "stub", "support", "ticket", "voucher" });
        private static IconData _Tidal;
        public static IconData FA_Tidal => _Tidal ??= new IconData("Tidal", "\U0000E7DC", Styles.Brands, new string[] { "album", "artist", "audio", "hi-fi", "music", "playlist", "songs", "streaming", "tidal" });
        private static IconData _Tiktok;
        public static IconData FA_Tiktok => _Tiktok ??= new IconData("Tiktok", "\U0000E07B", Styles.Brands, new string[] { "app", "dance", "lip sync", "music", "short video", "social media", "tik tok", "tiktok", "trends", "video", "viral" });
        private static IconData _Timeline;
        public static IconData FA_Timeline => _Timeline ??= new IconData("Timeline", "\U0000E29C", Styles.Solid, new string[] { "agenda", "chronological", "deadline", "events", "history", "linear", "milestones", "progress", "roadmap", "schedule", "sequence", "timeline chart" });
        private static IconData _ToggleOff;
        public static IconData FA_ToggleOff => _ToggleOff ??= new IconData("Toggle Off", "\U0000F204", Styles.Solid, new string[] { "UI", "button", "control", "disable", "inactive", "off", "option", "power", "setting", "slider", "switch", "toggle" });
        private static IconData _ToggleOn;
        public static IconData FA_ToggleOn => _ToggleOn ??= new IconData("Toggle On", "\U0000F205", Styles.Solid, new string[] { "active", "button", "control", "enabled", "on", "power", "setting", "slider", "switch", "toggle" });
        private static IconData _Toilet;
        public static IconData FA_Toilet => _Toilet ??= new IconData("Toilet", "\U0000F7D8", Styles.Solid, new string[] { "bathroom", "bathroom fixture", "commode", "flush", "john", "lavatory", "loo", "pee", "plumbing", "poop", "porcelain", "potty", "restroom", "restroom fixture", "sanitary", "throne", "toilet", "washroom", "waste", "water closet", "wc" });
        private static IconData _ToiletPaper;
        public static IconData FA_ToiletPaper => _ToiletPaper ??= new IconData("Toilet Paper", "\U0000F71E", Styles.Solid, new string[] { "bathroom", "bathroom roll", "bathroom tissue", "bidet", "clean-up", "hygiene", "lavatory", "paper roll", "restroom", "restroom essentials", "roll", "sanitary", "tissue", "toilet", "toilet paper", "wipe" });
        private static IconData _ToiletPaperSlash;
        public static IconData FA_ToiletPaperSlash => _ToiletPaperSlash ??= new IconData("Toilet Paper Slash", "\U0000E072", Styles.Solid, new string[] { "bathroom", "blocked", "covid-19", "disabled", "lavatory", "no toilet paper", "no wipe", "out of toilet paper", "paperless", "prank", "restroom", "roll", "shortage", "toilet paper", "wipe" });
        private static IconData _ToiletPortable;
        public static IconData FA_ToiletPortable => _ToiletPortable ??= new IconData("Toilet Portable", "\U0000E583", Styles.Solid, new string[] { "mobile restroom", "outdoor toilet", "outhouse", "porta john", "porta potty", "porta-potty", "portable restroom", "portable toilet", "temporary toilet", "toilet" });
        private static IconData _ToiletsPortable;
        public static IconData FA_ToiletsPortable => _ToiletsPortable ??= new IconData("Toilets Portable", "\U0000E584", Styles.Solid, new string[] { "chemical toilet", "event restroom", "mobile toilet", "outdoor toilet", "outhouse", "porta-john", "porta-potty", "portable restroom", "portable toilet", "toilet" });
        private static IconData _Toolbox;
        public static IconData FA_Toolbox => _Toolbox ??= new IconData("Toolbox", "\U0000F552", Styles.Solid, new string[] { "box", "chest", "configuration", "container", "equipment", "fix", "hardware", "kit", "maintenance", "mechanic", "modify", "repair", "settings", "tool", "toolbox", "tools" });
        private static IconData _Tooth;
        public static IconData FA_Tooth => _Tooth ??= new IconData("Tooth", "\U0000F5C9", Styles.Solid, new string[] { "bicuspid", "canine", "cavity", "dental", "dentist", "enamel", "hygiene", "incisor", "molar", "mouth", "oral", "root", "smile", "teeth", "tooth" });
        private static IconData _TorBrowser;
        public static IconData FA_TorBrowser => _TorBrowser ??= new IconData("Tor Browser", "\U0000E838", Styles.Brands, new string[] { "anonymity", "anonymous browsing", "censorship circumvention", "dark web", "internet privacy", "onion", "privacy", "secure browsing", "tor", "tor browser" });
        private static IconData _ToriiGate;
        public static IconData FA_ToriiGate => _ToriiGate ??= new IconData("Torii Gate", "\U0000F6A1", Styles.Solid, new string[] { "archway", "entrance", "gate", "japan", "japanese", "religion", "shinto", "shinto shrine", "shrine", "spiritual", "temple", "torii", "traditional" });
        private static IconData _Tornado;
        public static IconData FA_Tornado => _Tornado ??= new IconData("Tornado", "\U0000F76F", Styles.Solid, new string[] { "cloud", "cyclone", "funnel", "landspout", "storm", "tornado", "twister", "vortex", "waterspout", "weather", "whirlwind" });
        private static IconData _TowerBroadcast;
        public static IconData FA_TowerBroadcast => _TowerBroadcast ??= new IconData("Tower Broadcast", "\U0000F519", Styles.Solid, new string[] { "antenna", "broadcast", "broadcast-tower", "communication", "emergency-alert", "network", "radio", "reception", "signal", "tower", "transmission", "waves", "wifi" });
        private static IconData _TowerCell;
        public static IconData FA_TowerCell => _TowerCell ??= new IconData("Tower Cell", "\U0000E585", Styles.Solid, new string[] { "antenna", "broadcast", "cell tower", "cellphone", "communication", "mobile", "network", "radio", "reception", "signal", "tower", "transmission", "waves", "wireless" });
        private static IconData _TowerObservation;
        public static IconData FA_TowerObservation => _TowerObservation ??= new IconData("Tower Observation", "\U0000E586", Styles.Solid, new string[] { "fire tower", "lookout", "lookout point", "observation deck", "observation tower", "panorama", "scenic view", "tower", "viewing platform", "watchtower" });
        private static IconData _Tractor;
        public static IconData FA_Tractor => _Tractor ??= new IconData("Tractor", "\U0000F722", Styles.Solid, new string[] { "agriculture", "cultivation", "farm", "farm machinery", "farming", "farming equipment", "rural", "tractor", "tractor vehicle", "vehicle" });
        private static IconData _TradeFederation;
        public static IconData FA_TradeFederation => _TradeFederation ??= new IconData("Trade Federation", "\U0000F513", Styles.Brands, new string[] { "clone wars", "federation", "galactic", "sci-fi", "separatists", "space", "star wars", "star wars logo", "starship", "trade federation" });
        private static IconData _Trademark;
        public static IconData FA_Trademark => _Trademark ??= new IconData("Trademark", "\U0000F25C", Styles.Solid, new string[] { "brand", "copyright", "intellectual property", "legal", "logo", "mark", "protection", "registered", "symbol", "tm", "trade mark", "trademark" });
        private static IconData _TrafficLight;
        public static IconData FA_TrafficLight => _TrafficLight ??= new IconData("Traffic Light", "\U0000F637", Styles.Solid, new string[] { "control", "go", "intersection", "light", "lights", "road", "safety", "signal", "slow", "stop", "street", "traffic", "vertical traffic light", "warning" });
        private static IconData _Trailer;
        public static IconData FA_Trailer => _Trailer ??= new IconData("Trailer", "\U0000E041", Styles.Solid, new string[] { "camper", "caravan", "cargo", "carry", "haul", "moving", "towing", "trailer", "trailer hitch", "trailer truck", "transport", "travel", "vehicle" });
        private static IconData _Train;
        public static IconData FA_Train => _Train ??= new IconData("Train", "\U0000F238", Styles.Solid, new string[] { "bullet", "commute", "locomotive", "metro", "passenger", "rail", "railway", "subway", "train", "transit", "transportation", "travel" });
        private static IconData _TrainSubway;
        public static IconData FA_TrainSubway => _TrainSubway ??= new IconData("Train Subway", "\U0000F239", Styles.Solid, new string[] { "commuter", "metro", "public transport", "railway", "subway", "train", "transit", "transportation", "underground", "vehicle" });
        private static IconData _TrainTram;
        public static IconData FA_TrainTram => _TrainTram ??= new IconData("Train Tram", "\U0000E5B4", Styles.Solid, new string[] { "commute", "light rail", "public transit", "rails", "streetcar", "train", "tram", "transportation", "trolleybus", "urban transit", "vehicle" });
        private static IconData _Transgender;
        public static IconData FA_Transgender => _Transgender ??= new IconData("Transgender", "\U0000F225", Styles.Solid, new string[] { "LGBTQ", "female", "gender", "gender identity", "gender symbol", "intersex", "male", "nonbinary", "queer", "trans", "transgender", "transgender symbol" });
        private static IconData _Trash;
        public static IconData FA_Trash => _Trash ??= new IconData("Trash", "\U0000F1F8", Styles.Solid, new string[] { "bin", "delete", "discard", "garbage", "recycle", "remove", "rubbish", "trash", "trashcan", "waste" });
        private static IconData _TrashArrowUp;
        public static IconData FA_TrashArrowUp => _TrashArrowUp ??= new IconData("Trash Arrow Up", "\U0000F829", Styles.Solid, new string[] { "back", "delete", "garbage", "oops", "recover", "recycle", "remove", "restore", "retrieve", "revert", "trash", "undo" });
        private static IconData _TrashCan;
        public static IconData FA_TrashCan => _TrashCan ??= new IconData("Trash Can", "\U0000F2ED", Styles.Regular | Styles.Solid, new string[] { "bin", "delete", "discard", "dumpster", "garbage", "recycle", "remove", "rubbish", "trash", "trashcan", "waste" });
        private static IconData _TrashCanArrowUp;
        public static IconData FA_TrashCanArrowUp => _TrashCanArrowUp ??= new IconData("Trash Can Arrow Up", "\U0000F82A", Styles.Solid, new string[] { "back", "delete", "garbage", "recover", "recycle", "restore", "retrieve", "revert", "trash", "trash can", "undelete", "undo" });
        private static IconData _Tree;
        public static IconData FA_Tree => _Tree ??= new IconData("Tree", "\U0000F1BB", Styles.Solid, new string[] { "autumn", "bark", "deciduous", "environment", "evergreen", "foliage", "forest", "growth", "leaf", "nature", "outdoors", "plant", "seasonal", "tree", "wood" });
        private static IconData _TreeCity;
        public static IconData FA_TreeCity => _TreeCity ??= new IconData("Tree City", "\U0000E587", Styles.Solid, new string[] { "architecture", "buildings", "city", "cityscape", "downtown", "environment", "green", "metropolis", "nature", "skyline", "tree", "urban" });
        private static IconData _Trello;
        public static IconData FA_Trello => _Trello ??= new IconData("Trello", "\U0000F181", Styles.Brands, new string[] { "atlassian", "boards", "collaboration", "kanban", "productivity", "project management", "task management", "trello", "workflow" });
        private static IconData _TriangleExclamation;
        public static IconData FA_TriangleExclamation => _TriangleExclamation ??= new IconData("Triangle Exclamation", "\U0000F071", Styles.Solid, new string[] { "alert", "alert-triangle", "attention", "caution", "danger", "error", "exclamation", "failed", "hazard", "important", "notice", "notification", "notify", "problem", "required", "warning", "warning-sign" });
        private static IconData _Trophy;
        public static IconData FA_Trophy => _Trophy ??= new IconData("Trophy", "\U0000F091", Styles.Solid, new string[] { "achievement", "award", "champion", "competition", "cup", "honor", "prize", "reward", "success", "trophy", "victory", "winner" });
        private static IconData _Trowel;
        public static IconData FA_Trowel => _Trowel ??= new IconData("Trowel", "\U0000E589", Styles.Solid, new string[] { "bricklaying", "building", "cement", "construction", "equipment", "gardening", "hand tool", "masonry", "plastering", "tool", "trowel" });
        private static IconData _TrowelBricks;
        public static IconData FA_TrowelBricks => _TrowelBricks ??= new IconData("Trowel Bricks", "\U0000E58A", Styles.Solid, new string[] { "bricklaying", "build", "cement", "construction", "labor", "masonry", "mortar", "renovation", "repair", "tool", "trowel" });
        private static IconData _Truck;
        public static IconData FA_Truck => _Truck ??= new IconData("Truck", "\U0000F0D1", Styles.Regular | Styles.Solid, new string[] { "cargo", "delivery", "delivery truck", "freight", "hauler", "lorry", "pickup", "shipping", "transport", "truck", "truck icon", "vehicle" });
        private static IconData _TruckArrowRight;
        public static IconData FA_TruckArrowRight => _TruckArrowRight ??= new IconData("Truck Arrow Right", "\U0000E58B", Styles.Solid, new string[] { "arrow", "cargo", "delivery", "dispatch", "fast", "forward", "freight", "logistics", "move", "send", "shipping", "transport", "truck" });
        private static IconData _TruckDroplet;
        public static IconData FA_TruckDroplet => _TruckDroplet ??= new IconData("Truck Droplet", "\U0000E58C", Styles.Solid, new string[] { "delivery", "droplet", "fluid", "hydration", "liquid", "supply", "tanker", "transport", "truck", "water" });
        private static IconData _TruckFast;
        public static IconData FA_TruckFast => _TruckFast ??= new IconData("Truck Fast", "\U0000F48B", Styles.Solid, new string[] { "courier", "delivery", "express", "fast", "fedex", "freight", "logistics", "mail", "overnight", "package", "quick", "shipping", "transport", "truck", "ups" });
        private static IconData _TruckField;
        public static IconData FA_TruckField => _TruckField ??= new IconData("Truck Field", "\U0000E58D", Styles.Solid, new string[] { "agriculture", "cargo", "delivery", "farm", "farming", "field", "pickup", "supply", "transport", "truck" });
        private static IconData _TruckFieldUn;
        public static IconData FA_TruckFieldUn => _TruckFieldUn ??= new IconData("Truck Field Un", "\U0000E58E", Styles.Solid, new string[] { "UN", "United Nations", "aid", "delivery", "field truck", "humanitarian", "logistics", "supplies", "transport", "truck", "vehicle" });
        private static IconData _TruckFront;
        public static IconData FA_TruckFront => _TruckFront ??= new IconData("Truck Front", "\U0000E2B7", Styles.Solid, new string[] { "cargo", "delivery", "freight", "front view", "lorry", "shipping", "shuttle", "transport", "truck", "van", "vehicle" });
        private static IconData _TruckMedical;
        public static IconData FA_TruckMedical => _TruckMedical ??= new IconData("Truck Medical", "\U0000F0F9", Styles.Solid, new string[] { "aid", "ambulance", "clinic", "emergency", "emt", "er", "health", "hospital", "medical", "mobile", "paramedic", "rescue", "support", "vehicle" });
        private static IconData _TruckMonster;
        public static IconData FA_TruckMonster => _TruckMonster ??= new IconData("Truck Monster", "\U0000F63B", Styles.Solid, new string[] { "4x4", "dirt", "large tires", "monster truck", "offroad", "racing", "stunt", "truck", "vehicle", "wheels" });
        private static IconData _TruckMoving;
        public static IconData FA_TruckMoving => _TruckMoving ??= new IconData("Truck Moving", "\U0000F4DF", Styles.Solid, new string[] { "cargo", "delivery", "freight", "inventory", "load", "logistics", "moving", "relocation", "rental", "shipping", "transport", "truck", "van", "vehicle" });
        private static IconData _TruckPickup;
        public static IconData FA_TruckPickup => _TruckPickup ??= new IconData("Truck Pickup", "\U0000F63C", Styles.Solid, new string[] { "cargo", "light truck", "pickup", "pickup truck", "pickup truck bed", "pickup truck cab", "pickup truck icon", "pickup truck vehicle", "truck", "utility truck", "vehicle", "work truck" });
        private static IconData _TruckPlane;
        public static IconData FA_TruckPlane => _TruckPlane ??= new IconData("Truck Plane", "\U0000E58F", Styles.Solid, new string[] { "air freight", "airplane", "cargo", "delivery", "freight", "logistics", "plane", "shipping", "transport", "transport truck", "transport vehicle", "truck", "vehicle" });
        private static IconData _TruckRampBox;
        public static IconData FA_TruckRampBox => _TruckRampBox ??= new IconData("Truck Ramp Box", "\U0000F4DE", Styles.Solid, new string[] { "box", "cargo", "delivery", "freight", "inventory", "loading", "logistics", "moving", "package", "ramp", "rental", "shipping", "transport", "truck", "vehicle" });
        private static IconData _Tty;
        public static IconData FA_Tty => _Tty ??= new IconData("Tty", "\U0000F1E4", Styles.Solid, new string[] { "TTY", "accessibility", "assistive device", "communication", "communication device", "deaf", "relay service", "telephone", "teletypewriter", "text", "text phone" });
        private static IconData _Tumblr;
        public static IconData FA_Tumblr => _Tumblr ??= new IconData("Tumblr", "\U0000F173", Styles.Brands, new string[] { "blogging", "microblogging", "social media", "social network", "tmb", "tumblr", "tumblr logo" });
        private static IconData _TurkishLiraSign;
        public static IconData FA_TurkishLiraSign => _TurkishLiraSign ??= new IconData("Turkish Lira Sign", "\U0000E2BB", Styles.Solid, new string[] { "TRY", "Turkish Lira", "Turkish Lira Sign", "Turkish currency", "cash", "currency", "financial", "lira", "money", "payment" });
        private static IconData _TurnDown;
        public static IconData FA_TurnDown => _TurnDown ??= new IconData("Turn Down", "\U0000F3BE", Styles.Solid, new string[] { "arrow", "arrow bend", "arrow turning", "curve down", "curved arrow", "direction", "down", "navigation", "rotate down", "turn down" });
        private static IconData _TurnUp;
        public static IconData FA_TurnUp => _TurnUp ??= new IconData("Turn Up", "\U0000F3BF", Styles.Solid, new string[] { "arrow", "boost", "increase", "level-up", "raise", "right arrow curving up", "turn up", "upward curve", "volume up" });
        private static IconData _Tv;
        public static IconData FA_Tv => _Tv ??= new IconData("Tv", "\U0000F26C", Styles.Solid, new string[] { "broadcast", "display", "entertainment", "flat screen", "home theater", "monitor", "screen", "smart tv", "television", "tv", "tv set", "video" });
        private static IconData _Twitch;
        public static IconData FA_Twitch => _Twitch ??= new IconData("Twitch", "\U0000F1E8", Styles.Brands, new string[] { "broadcast", "chat", "esports", "gaming", "live", "platform", "streamer", "streaming", "twitch", "twitch.tv", "video game" });
        private static IconData _Twitter;
        public static IconData FA_Twitter => _Twitter ??= new IconData("Twitter", "\U0000F099", Styles.Brands, new string[] { "bird", "microblogging", "social media", "social network", "tweet", "tweets", "twitter", "x platform" });
        private static IconData _Typescript;
        public static IconData FA_Typescript => _Typescript ??= new IconData("Typescript", "\U0000E840", Styles.Brands, new string[] { });
        private static IconData _Typo3;
        public static IconData FA_Typo3 => _Typo3 ??= new IconData("Typo3", "\U0000F42B", Styles.Brands, new string[] { "cms", "content management", "content management system", "open source", "php", "typo", "typo3", "web development" });
        private static IconData _U;
        public static IconData FA_U => _U ??= new IconData("U", "\U00000055", Styles.Solid, new string[] { "alphabet", "character", "latin letter u", "letter u", "lowercase u", "symbol", "uppercase u" });
        private static IconData _Uber;
        public static IconData FA_Uber => _Uber ??= new IconData("Uber", "\U0000F402", Styles.Brands, new string[] { "Uber", "app", "car service", "driver", "mobility", "ride", "rideshare", "taxi", "transportation", "travel" });
        private static IconData _Ubuntu;
        public static IconData FA_Ubuntu => _Ubuntu ??= new IconData("Ubuntu", "\U0000F7DF", Styles.Brands, new string[] { "canonical", "distro", "linux", "linux distribution", "open source", "operating system", "os", "ubuntu" });
        private static IconData _Uikit;
        public static IconData FA_Uikit => _Uikit ??= new IconData("Uikit", "\U0000F403", Styles.Brands, new string[] { "components", "design system", "framework", "frontend", "toolkit", "ui kit", "uikit", "user interface", "web development" });
        private static IconData _Ultralytics;
        public static IconData FA_Ultralytics => _Ultralytics ??= new IconData("Ultralytics", "\U0000E86D", Styles.Brands, new string[] { });
        private static IconData _UltralyticsHub;
        public static IconData FA_UltralyticsHub => _UltralyticsHub ??= new IconData("Ultralytics Hub", "\U0000E86E", Styles.Brands, new string[] { });
        private static IconData _UltralyticsYolo;
        public static IconData FA_UltralyticsYolo => _UltralyticsYolo ??= new IconData("Ultralytics Yolo", "\U0000E86F", Styles.Brands, new string[] { });
        private static IconData _Umbraco;
        public static IconData FA_Umbraco => _Umbraco ??= new IconData("Umbraco", "\U0000F8E8", Styles.Brands, new string[] { ".net", "cms", "content management", "dotnet", "open source", "platform", "umbraco", "web development", "website" });
        private static IconData _Umbrella;
        public static IconData FA_Umbrella => _Umbrella ??= new IconData("Umbrella", "\U0000F0E9", Styles.Solid, new string[] { "drizzle", "protection", "rain", "shade", "shelter", "storm", "umbrella", "waterproof", "weather", "wet" });
        private static IconData _UmbrellaBeach;
        public static IconData FA_UmbrellaBeach => _UmbrellaBeach ??= new IconData("Umbrella Beach", "\U0000F5CA", Styles.Solid, new string[] { "beach", "holiday", "protection", "recreation", "resort", "sand", "seaside", "shade", "summer", "sun", "sunshade", "tropical", "umbrella", "vacation" });
        private static IconData _Uncharted;
        public static IconData FA_Uncharted => _Uncharted ??= new IconData("Uncharted", "\U0000E084", Styles.Brands, new string[] { "action game", "adventure game", "naughty dog", "playstation", "ps4", "ps5", "treasure hunt", "uncharted", "uncharted game", "uncharted series" });
        private static IconData _Underline;
        public static IconData FA_Underline => _Underline ??= new IconData("Underline", "\U0000F0CD", Styles.Solid, new string[] { "edit", "emphasis", "emphasize", "formatting", "highlight", "style", "text", "typography", "underline", "writing" });
        private static IconData _Uniregistry;
        public static IconData FA_Uniregistry => _Uniregistry ??= new IconData("Uniregistry", "\U0000F404", Styles.Brands, new string[] { "domain marketplace", "domain name", "domain registrar", "domain registration", "uniregistry", "web domains" });
        private static IconData _Unison;
        public static IconData FA_Unison => _Unison ??= new IconData("Unison", "\U0000E854", Styles.Brands, new string[] { });
        private static IconData _Unity;
        public static IconData FA_Unity => _Unity ??= new IconData("Unity", "\U0000E049", Styles.Brands, new string[] { "3d", "cross-platform", "developer", "game development", "game engine", "gaming", "interactive", "real-time", "unity", "unity3d" });
        private static IconData _UniversalAccess;
        public static IconData FA_UniversalAccess => _UniversalAccess ??= new IconData("Universal Access", "\U0000F29A", Styles.Solid, new string[] { "access", "accessibility", "assistive", "disability", "disabled", "handicap", "inclusive", "people", "universal access", "users", "wheelchair" });
        private static IconData _Unlock;
        public static IconData FA_Unlock => _Unlock ??= new IconData("Unlock", "\U0000F09C", Styles.Solid, new string[] { "access", "admin", "key", "lock", "open", "padlock", "password", "permission", "privacy", "protect", "security", "unlock", "unlocked" });
        private static IconData _UnlockKeyhole;
        public static IconData FA_UnlockKeyhole => _UnlockKeyhole ??= new IconData("Unlock Keyhole", "\U0000F13E", Styles.Solid, new string[] { "access", "admin", "authentication", "key", "keyhole", "open lock", "password", "privacy", "protect", "security", "unlock", "unlocked" });
        private static IconData _UnrealEngine;
        public static IconData FA_UnrealEngine => _UnrealEngine ??= new IconData("Unreal Engine", "\U0000E85C", Styles.Brands, new string[] { });
        private static IconData _Unsplash;
        public static IconData FA_Unsplash => _Unsplash ??= new IconData("Unsplash", "\U0000E07C", Styles.Brands, new string[] { "free images", "images", "photo platform", "photo sharing", "photography", "photos", "pictures", "stock photos", "unsplash" });
        private static IconData _Untappd;
        public static IconData FA_Untappd => _Untappd ??= new IconData("Untappd", "\U0000F405", Styles.Brands, new string[] { "app", "beer", "beer lover", "brewery", "check-in", "craft beer", "drinks", "rating", "social", "untappd" });
        private static IconData _UpDown;
        public static IconData FA_UpDown => _UpDown ??= new IconData("Up Down", "\U0000F338", Styles.Solid, new string[] { "adjust", "arrow", "arrows-v", "direction", "down arrow", "expand", "height", "move", "resize", "scroll", "tall", "up arrow", "up-down", "vertical" });
        private static IconData _UpDownLeftRight;
        public static IconData FA_UpDownLeftRight => _UpDownLeftRight ??= new IconData("Up Down Left Right", "\U0000F0B2", Styles.Solid, new string[] { "adjust", "arrow", "arrows", "compass", "directions", "drag", "enlarge", "expand", "four-way", "move", "navigation", "pointer", "position", "reorder", "resize" });
        private static IconData _UpLong;
        public static IconData FA_UpLong => _UpLong ??= new IconData("Up Long", "\U0000F30C", Styles.Solid, new string[] { "arrow", "arrow-up", "direction", "increase", "long-arrow-up", "move up", "rise", "up", "upgrade", "upload", "upward" });
        private static IconData _UpRightAndDownLeftFromCenter;
        public static IconData FA_UpRightAndDownLeftFromCenter => _UpRightAndDownLeftFromCenter ??= new IconData("Up Right And Down Left From Center", "\U0000F424", Styles.Solid, new string[] { "arrows", "diagonal", "enlarge", "expand", "fullscreen", "grow", "increase", "maximize", "resize", "scale", "zoom" });
        private static IconData _UpRightFromSquare;
        public static IconData FA_UpRightFromSquare => _UpRightFromSquare ??= new IconData("Up Right From Square", "\U0000F35D", Styles.Solid, new string[] { "arrow-up-right", "export", "external-link", "launch", "link", "new", "open", "outside", "redirect", "share", "window" });
        private static IconData _Upload;
        public static IconData FA_Upload => _Upload ??= new IconData("Upload", "\U0000F093", Styles.Solid, new string[] { "arrow up", "backup", "cloud", "data transfer", "import", "publish", "save", "send", "send file", "transfer", "upload" });
        private static IconData _Ups;
        public static IconData FA_Ups => _Ups ??= new IconData("Ups", "\U0000F7E0", Styles.Brands, new string[] { "UPS", "United Parcel Service", "courier", "delivery", "freight", "logistics", "package", "parcel", "shipping" });
        private static IconData _Upwork;
        public static IconData FA_Upwork => _Upwork ??= new IconData("Upwork", "\U0000E641", Styles.Brands, new string[] { "contract work", "freelance", "freelancer", "freelancing platform", "gig economy", "online jobs", "remote work", "upwork", "work marketplace" });
        private static IconData _Usb;
        public static IconData FA_Usb => _Usb ??= new IconData("Usb", "\U0000F287", Styles.Brands, new string[] { "connector", "data transfer", "external drive", "flash drive", "memory stick", "port", "storage", "thumb drive", "universal serial bus", "usb" });
        private static IconData _User;
        public static IconData FA_User => _User ??= new IconData("User", "\U0000F007", Styles.Regular | Styles.Solid, new string[] { "account", "avatar", "default", "employee", "gender-neutral", "identity", "individual", "member", "person", "profile", "silhouette", "user", "username" });
        private static IconData _UserAstronaut;
        public static IconData FA_UserAstronaut => _UserAstronaut ??= new IconData("User Astronaut", "\U0000F4FB", Styles.Solid, new string[] { "astronaut", "avatar", "cosmonaut", "explorer", "helmet", "nasa", "space", "space suit", "space traveler", "spaceman", "suit" });
        private static IconData _UserCheck;
        public static IconData FA_UserCheck => _UserCheck ??= new IconData("User Check", "\U0000F4FC", Styles.Solid, new string[] { "active", "approve", "check", "confirm", "employee", "enabled", "person", "user", "validate", "verified", "working" });
        private static IconData _UserClock;
        public static IconData FA_UserClock => _UserClock ??= new IconData("User Clock", "\U0000F4FD", Styles.Solid, new string[] { "attendance", "clock", "employee", "login-time", "person", "profile", "punctuality", "schedule", "shift", "time", "timer", "user", "working-hours" });
        private static IconData _UserDoctor;
        public static IconData FA_UserDoctor => _UserDoctor ??= new IconData("User Doctor", "\U0000F0F0", Styles.Solid, new string[] { "covid-19", "doctor", "health", "healthcare", "medical", "nurse", "occupation", "physician", "profile", "surgeon", "worker" });
        private static IconData _UserGear;
        public static IconData FA_UserGear => _UserGear ??= new IconData("User Gear", "\U0000F4FE", Styles.Solid, new string[] { "account", "employee", "gear", "people", "person", "preferences", "profile", "settings", "user", "user-management", "users" });
        private static IconData _UserGraduate;
        public static IconData FA_UserGraduate => _UserGraduate ??= new IconData("User Graduate", "\U0000F501", Styles.Solid, new string[] { "academic", "cap", "diploma", "education", "graduate", "graduation", "learner", "mortarboard", "person", "student", "user" });
        private static IconData _UserGroup;
        public static IconData FA_UserGroup => _UserGroup ??= new IconData("User Group", "\U0000F500", Styles.Solid, new string[] { "community", "crowd", "employees", "group", "members", "people", "silhouettes", "team", "together", "user", "users" });
        private static IconData _UserInjured;
        public static IconData FA_UserInjured => _UserInjured ??= new IconData("User Injured", "\U0000F728", Styles.Solid, new string[] { "accident", "accident victim", "disabled", "emergency", "employee", "health", "hurt", "injured", "injury", "medical", "person", "safety", "user", "worker" });
        private static IconData _UserLock;
        public static IconData FA_UserLock => _UserLock ??= new IconData("User Lock", "\U0000F502", Styles.Solid, new string[] { "access", "account", "employee", "lock", "login", "padlock", "privacy", "profile", "protected", "secure", "security", "user" });
        private static IconData _UserMinus;
        public static IconData FA_UserMinus => _UserMinus ??= new IconData("User Minus", "\U0000F503", Styles.Solid, new string[] { "delete", "employee", "minus", "negative", "remove", "remove-account", "remove-person", "remove-user", "subtract", "user" });
        private static IconData _UserNinja;
        public static IconData FA_UserNinja => _UserNinja ??= new IconData("User Ninja", "\U0000F504", Styles.Solid, new string[] { "assassin", "avatar", "covert", "deadly", "fighter", "hidden", "ninja", "shadow", "silent", "sneaky", "spy", "stealth", "stealthy", "warrior" });
        private static IconData _UserNurse;
        public static IconData FA_UserNurse => _UserNurse ??= new IconData("User Nurse", "\U0000F82F", Styles.Solid, new string[] { "caregiver", "covid-19", "doctor", "health", "healthcare", "hospital", "medical", "midwife", "nurse", "physician", "practitioner", "surgeon", "worker" });
        private static IconData _UserPen;
        public static IconData FA_UserPen => _UserPen ??= new IconData("User Pen", "\U0000F4FF", Styles.Solid, new string[] { "account", "avatar", "edit", "employee", "modify", "people", "person", "profile", "user", "users" });
        private static IconData _UserPlus;
        public static IconData FA_UserPlus => _UserPlus ??= new IconData("User Plus", "\U0000F234", Styles.Solid, new string[] { "add", "add user", "avatar", "create user", "employee", "follow", "join", "member", "new user", "person", "plus", "positive", "profile", "sign up", "signup", "team", "user" });
        private static IconData _UserSecret;
        public static IconData FA_UserSecret => _UserSecret ??= new IconData("User Secret", "\U0000F21B", Styles.Solid, new string[] { "anonymous", "detective", "disguise", "hidden", "identity", "incognito", "person", "privacy", "secret", "sleuth", "spy", "user" });
        private static IconData _UserShield;
        public static IconData FA_UserShield => _UserShield ??= new IconData("User Shield", "\U0000F505", Styles.Solid, new string[] { "account", "employee", "guard", "privacy", "profile", "protect", "protection", "safety", "security", "shield", "user" });
        private static IconData _UserSlash;
        public static IconData FA_UserSlash => _UserSlash ??= new IconData("User Slash", "\U0000F506", Styles.Solid, new string[] { "ban", "block", "disable", "disconnect", "employee", "forbidden", "no user", "remove", "user disabled", "user off" });
        private static IconData _UserTag;
        public static IconData FA_UserTag => _UserTag ??= new IconData("User Tag", "\U0000F507", Styles.Solid, new string[] { "account", "avatar", "contact", "employee", "identity", "member", "people", "person", "profile", "user" });
        private static IconData _UserTie;
        public static IconData FA_UserTie => _UserTie ??= new IconData("User Tie", "\U0000F508", Styles.Solid, new string[] { "administrator", "avatar", "business", "clothing", "employee", "executive", "formal", "manager", "office", "person", "professional", "profile", "suit", "tie", "user" });
        private static IconData _UserXmark;
        public static IconData FA_UserXmark => _UserXmark ??= new IconData("User Xmark", "\U0000F235", Styles.Solid, new string[] { "block", "cancel", "close", "delete", "deny", "employee", "reject", "remove", "uncheck", "user", "x" });
        private static IconData _Users;
        public static IconData FA_Users => _Users ??= new IconData("Users", "\U0000F0C0", Styles.Solid, new string[] { "accounts", "collaboration", "community", "contacts", "employees", "group", "members", "people", "persons", "profiles", "team", "user", "users" });
        private static IconData _UsersBetweenLines;
        public static IconData FA_UsersBetweenLines => _UsersBetweenLines ??= new IconData("Users Between Lines", "\U0000E591", Styles.Solid, new string[] { "crowd", "employees", "group", "multiple", "people", "team", "together", "users" });
        private static IconData _UsersGear;
        public static IconData FA_UsersGear => _UsersGear ??= new IconData("Users Gear", "\U0000F509", Styles.Solid, new string[] { "administration", "employee", "gear", "group", "manage", "people", "settings", "team", "user management", "users" });
        private static IconData _UsersLine;
        public static IconData FA_UsersLine => _UsersLine ??= new IconData("Users Line", "\U0000E592", Styles.Solid, new string[] { "community", "crowd", "employee", "group", "members", "people", "team", "together", "users" });
        private static IconData _UsersRays;
        public static IconData FA_UsersRays => _UsersRays ??= new IconData("Users Rays", "\U0000E593", Styles.Solid, new string[] { "audience", "community", "crowd", "employees", "focused", "group", "people", "rays", "team", "users" });
        private static IconData _UsersRectangle;
        public static IconData FA_UsersRectangle => _UsersRectangle ??= new IconData("Users Rectangle", "\U0000E594", Styles.Solid, new string[] { "community", "contacts", "crowd", "employees", "group", "members", "people", "profile", "team", "users" });
        private static IconData _UsersSlash;
        public static IconData FA_UsersSlash => _UsersSlash ??= new IconData("Users Slash", "\U0000E073", Styles.Solid, new string[] { "banned", "blocked", "disabled", "disconnect", "employee", "group", "no access", "people", "removed", "slash", "user", "users" });
        private static IconData _UsersViewfinder;
        public static IconData FA_UsersViewfinder => _UsersViewfinder ??= new IconData("Users Viewfinder", "\U0000E595", Styles.Solid, new string[] { "audience", "crowd", "focus", "group", "highlight", "identify", "people", "selection", "spotlight", "targeted", "user", "zoom" });
        private static IconData _Usps;
        public static IconData FA_Usps => _Usps ??= new IconData("Usps", "\U0000F7E1", Styles.Brands, new string[] { "American", "USA", "USPS", "United States Postal Service", "delivery", "mail", "package", "postal", "shipping" });
        private static IconData _Ussunnah;
        public static IconData FA_Ussunnah => _Ussunnah ??= new IconData("Ussunnah", "\U0000F407", Styles.Brands, new string[] { "brand", "islamic", "muslim", "sunnah", "us sunnah", "ussunnah" });
        private static IconData _Utensils;
        public static IconData FA_Utensils => _Utensils ??= new IconData("Utensils", "\U0000F2E7", Styles.Solid, new string[] { "cooking", "cutlery", "dining", "dinner", "eat", "eating utensils", "food", "fork", "knife", "meal", "restaurant", "silverware", "spoon", "tableware" });
        private static IconData _V;
        public static IconData FA_V => _V ??= new IconData("V", "\U00000056", Styles.Solid, new string[] { "alphabet", "capital v", "character", "letter v", "lowercase v", "symbol", "typography" });
        private static IconData _Vaadin;
        public static IconData FA_Vaadin => _Vaadin ??= new IconData("Vaadin", "\U0000F408", Styles.Brands, new string[] { "frontend framework", "java web framework", "open source", "ui toolkit", "vaadin", "vaadin framework", "web components" });
        private static IconData _VanShuttle;
        public static IconData FA_VanShuttle => _VanShuttle ??= new IconData("Van Shuttle", "\U0000F5B6", Styles.Solid, new string[] { "airport", "commute", "minibus", "passenger", "public-transportation", "ride", "shuttle", "transit", "transportation", "travel", "van", "vehicle" });
        private static IconData _Vault;
        public static IconData FA_Vault => _Vault ??= new IconData("Vault", "\U0000E2C5", Styles.Solid, new string[] { "bank", "deposit", "finance", "investment", "lock", "money", "premium", "privacy", "protection", "safe", "salary", "savings", "secure", "treasure", "vault" });
        private static IconData _Venmo;
        public static IconData FA_Venmo => _Venmo ??= new IconData("Venmo", "\U0000E85A", Styles.Brands, new string[] { });
        private static IconData _VenmoV;
        public static IconData FA_VenmoV => _VenmoV ??= new IconData("Venmo V", "\U0000E85B", Styles.Brands, new string[] { });
        private static IconData _Venus;
        public static IconData FA_Venus => _Venus ??= new IconData("Venus", "\U0000F221", Styles.Solid, new string[] { "female", "female gender", "female gender symbol", "female icon", "female sex", "female sign", "female symbol", "feminism", "gender", "girl", "woman", "woman symbol" });
        private static IconData _VenusDouble;
        public static IconData FA_VenusDouble => _VenusDouble ??= new IconData("Venus Double", "\U0000F226", Styles.Solid, new string[] { "LGBTQ", "double venus", "female", "female couple", "female symbol", "feminism", "gender", "gender identity", "lesbian", "queer", "womanhood", "women" });
        private static IconData _VenusMars;
        public static IconData FA_VenusMars => _VenusMars ??= new IconData("Venus Mars", "\U0000F228", Styles.Solid, new string[] { "female", "gender", "gender identity", "gender signs", "gender symbols", "heterosexual", "interlocked", "male", "male and female", "relationship", "sex" });
        private static IconData _Vest;
        public static IconData FA_Vest => _Vest ??= new IconData("Vest", "\U0000E085", Styles.Solid, new string[] { "apparel", "biker", "clothing", "fashion", "outerwear", "sleeveless", "style", "vest", "waistcoat" });
        private static IconData _VestPatches;
        public static IconData FA_VestPatches => _VestPatches ??= new IconData("Vest Patches", "\U0000E086", Styles.Solid, new string[] { "biker", "club", "emblem", "fashion", "insignia", "jacket", "motorcycle", "patches", "style", "vest" });
        private static IconData _Viacoin;
        public static IconData FA_Viacoin => _Viacoin ??= new IconData("Viacoin", "\U0000F237", Styles.Brands, new string[] { "altcoin", "blockchain", "crypto", "cryptocurrency", "digital currency", "viacoin", "vtc" });
        private static IconData _Viadeo;
        public static IconData FA_Viadeo => _Viadeo ??= new IconData("Viadeo", "\U0000F2A9", Styles.Brands, new string[] { "business networking", "career", "jobs", "professional network", "professional profile", "social network", "viadeo" });
        private static IconData _Vial;
        public static IconData FA_Vial => _Vial ??= new IconData("Vial", "\U0000F492", Styles.Solid, new string[] { "ampule", "chemistry", "container", "drug", "experiment", "flask", "lab", "laboratory", "medicine", "pharmaceutical", "sample", "science", "test", "test tube", "vial" });
        private static IconData _VialCircleCheck;
        public static IconData FA_VialCircleCheck => _VialCircleCheck ??= new IconData("Vial Circle Check", "\U0000E596", Styles.Solid, new string[] { "ampule", "approved", "check", "chemical", "chemistry", "confirmed", "health", "lab", "laboratory", "medicine", "ok", "success", "test tube", "vaccine", "validate", "vial", "working" });
        private static IconData _VialVirus;
        public static IconData FA_VialVirus => _VialVirus ??= new IconData("Vial Virus", "\U0000E597", Styles.Solid, new string[] { "ampule", "coronavirus", "covid-19", "flu", "immunization", "infection", "lab", "laboratory", "medicine", "pandemic", "syringe", "test", "test tube", "vaccine", "vial", "virus" });
        private static IconData _Vials;
        public static IconData FA_Vials => _Vials ??= new IconData("Vials", "\U0000F493", Styles.Solid, new string[] { "ampule", "chemistry", "experiment", "lab", "laboratory", "medical", "research", "sample", "science", "test tube", "testing", "vial" });
        private static IconData _Viber;
        public static IconData FA_Viber => _Viber ??= new IconData("Viber", "\U0000F409", Styles.Brands, new string[] { "calls", "chat", "communication", "instant message", "messaging", "mobile app", "text", "viber", "viber messenger", "voip" });
        private static IconData _Video;
        public static IconData FA_Video => _Video ??= new IconData("Video", "\U0000F03D", Styles.Solid, new string[] { "camcorder", "camera", "clip", "film", "footage", "media", "movie", "playback", "record", "recording", "streaming", "video", "video-camera" });
        private static IconData _VideoSlash;
        public static IconData FA_VideoSlash => _VideoSlash ??= new IconData("Video Slash", "\U0000F4E2", Styles.Solid, new string[] { "block", "camera off", "disabled", "disconnect", "film", "hide", "mute", "no video", "off", "record", "stop", "video" });
        private static IconData _Vihara;
        public static IconData FA_Vihara => _Vihara ??= new IconData("Vihara", "\U0000F6A7", Styles.Solid, new string[] { "buddhism", "buddhist", "meditation", "monastery", "religious building", "sanctuary", "shrine", "spiritual center", "temple" });
        private static IconData _Vim;
        public static IconData FA_Vim => _Vim ??= new IconData("Vim", "\U0000E88A", Styles.Brands, new string[] { });
        private static IconData _Vimeo;
        public static IconData FA_Vimeo => _Vimeo ??= new IconData("Vimeo", "\U0000F40A", Styles.Brands, new string[] { "film", "media", "movies", "online video", "streaming", "video", "video platform", "videos", "vimeo" });
        private static IconData _VimeoV;
        public static IconData FA_VimeoV => _VimeoV ??= new IconData("Vimeo V", "\U0000F27D", Styles.Brands, new string[] { "platform", "social media", "streaming", "video", "vimeo", "vimeo logo" });
        private static IconData _Vine;
        public static IconData FA_Vine => _Vine ??= new IconData("Vine", "\U0000F1CA", Styles.Brands, new string[] { "app", "brand", "looping video", "platform", "short video", "six seconds", "social media", "video", "vine", "vineapp" });
        private static IconData _Virgo;
        public static IconData FA_Virgo => _Virgo ??= new IconData("Virgo", "\U0000E850", Styles.Solid, new string[] { "astrology", "august", "constellation", "earth sign", "horoscope", "maiden", "september", "sign", "stars", "virgin", "virgo", "zodiac" });
        private static IconData _Virus;
        public static IconData FA_Virus => _Virus ??= new IconData("Virus", "\U0000E074", Styles.Solid, new string[] { "bug", "contagion", "coronavirus", "covid-19", "disease", "flu", "illness", "infection", "outbreak", "pandemic", "pathogen", "sick", "vaccine", "viral", "virus" });
        private static IconData _VirusCovid;
        public static IconData FA_VirusCovid => _VirusCovid ??= new IconData("Virus Covid", "\U0000E4A8", Styles.Solid, new string[] { "contagion", "coronavirus", "covid", "covid-19", "disease", "epidemic", "health", "infection", "outbreak", "pandemic", "vaccine", "viral", "virus" });
        private static IconData _VirusCovidSlash;
        public static IconData FA_VirusCovidSlash => _VirusCovidSlash ??= new IconData("Virus Covid Slash", "\U0000E4A9", Styles.Solid, new string[] { "blocked", "bug", "covid-19", "disabled", "disease", "health", "infection", "no virus", "pandemic", "quarantine", "stop virus", "viral", "virus" });
        private static IconData _VirusSlash;
        public static IconData FA_VirusSlash => _VirusSlash ??= new IconData("Virus Slash", "\U0000E075", Styles.Solid, new string[] { "antivirus", "blocked", "bug", "coronavirus", "covid-19", "cure", "disabled", "eliminate", "flu", "health", "infection", "no virus", "pandemic", "protection", "sick", "vaccine", "viral", "virus" });
        private static IconData _Viruses;
        public static IconData FA_Viruses => _Viruses ??= new IconData("Viruses", "\U0000E076", Styles.Solid, new string[] { "bugs", "contagious", "coronavirus", "covid-19", "disease", "flu", "illness", "infection", "pandemic", "pathogen", "sick", "spread", "vaccine", "viral", "virus", "viruses" });
        private static IconData _Vk;
        public static IconData FA_Vk => _Vk ??= new IconData("Vk", "\U0000F189", Styles.Brands, new string[] { "chat", "community", "messaging", "network", "russian", "social", "social media", "vk", "vkontakte" });
        private static IconData _Vnv;
        public static IconData FA_Vnv => _Vnv ??= new IconData("Vnv", "\U0000F40B", Styles.Brands, new string[] { "vnv", "vnv brand", "vnv logo", "vnv network" });
        private static IconData _Voicemail;
        public static IconData FA_Voicemail => _Voicemail ??= new IconData("Voicemail", "\U0000F897", Styles.Solid, new string[] { "answering machine", "audio message", "inbox", "message", "missed call", "phone", "phone message", "recorded message", "voice message", "voicemail" });
        private static IconData _Volcano;
        public static IconData FA_Volcano => _Volcano ??= new IconData("Volcano", "\U0000F770", Styles.Solid, new string[] { "caldera", "crater", "eruption", "eruption cloud", "geology", "lava", "magma", "mountain", "natural disaster", "smoke", "volcanic activity", "volcanic ash", "volcanic mountain", "volcano" });
        private static IconData _Volleyball;
        public static IconData FA_Volleyball => _Volleyball ??= new IconData("Volleyball", "\U0000F45F", Styles.Solid, new string[] { "ball", "beach", "court", "game", "indoor", "net", "olympics", "outdoor", "serve", "spike", "sport", "team sport", "volleyball" });
        private static IconData _Volume;
        public static IconData FA_Volume => _Volume ??= new IconData("Volume", "\U0000F6A8", Styles.Solid, new string[] { "audio", "audio level", "media", "music", "sound", "sound control", "speaker", "speaker medium", "volume", "volume control" });
        private static IconData _VolumeHigh;
        public static IconData FA_VolumeHigh => _VolumeHigh ??= new IconData("Volume High", "\U0000F028", Styles.Solid, new string[] { "audio", "audio on", "high volume", "increase volume", "loud", "louder", "max volume", "music", "sound", "sound up", "speaker", "speaker on", "volume" });
        private static IconData _VolumeLow;
        public static IconData FA_VolumeLow => _VolumeLow ??= new IconData("Volume Low", "\U0000F027", Styles.Solid, new string[] { "audio", "audio control", "decrease", "low volume", "mute", "quiet", "quieter", "reduce", "soft", "sound", "sound level", "speaker", "volume" });
        private static IconData _VolumeOff;
        public static IconData FA_VolumeOff => _VolumeOff ??= new IconData("Volume Off", "\U0000F026", Styles.Solid, new string[] { "audio off", "disable sound", "music off", "mute", "no sound", "quiet", "silent", "sound off", "speaker off", "volume mute" });
        private static IconData _VolumeXmark;
        public static IconData FA_VolumeXmark => _VolumeXmark ??= new IconData("Volume Xmark", "\U0000F6A9", Styles.Solid, new string[] { "audio", "audio off", "disable sound", "mute", "mute speaker", "no sound", "off", "silent", "sound", "speaker", "volume" });
        private static IconData _VrCardboard;
        public static IconData FA_VrCardboard => _VrCardboard ??= new IconData("Vr Cardboard", "\U0000F729", Styles.Solid, new string[] { "3d", "augmented reality", "cardboard", "goggles", "google", "headset", "immersive", "virtual reality", "vr", "vr headset" });
        private static IconData _Vsco;
        public static IconData FA_Vsco => _Vsco ??= new IconData("Vsco", "\U0000E7DD", Styles.Brands, new string[] { "image editing", "photo editor", "photo filter", "photo sharing", "photography", "social media", "vsco", "vsco app" });
        private static IconData _Vuejs;
        public static IconData FA_Vuejs => _Vuejs ??= new IconData("Vuejs", "\U0000F41F", Styles.Brands, new string[] { "MVVM", "SPA", "UI", "framework", "frontend", "javascript", "js", "progressive framework", "vue", "vue.js", "web development" });
        private static IconData _W;
        public static IconData FA_W => _W ??= new IconData("W", "\U00000057", Styles.Solid, new string[] { "alphabet", "capital w", "character", "letter w", "lowercase w", "symbol", "text", "typography" });
        private static IconData _W3c;
        public static IconData FA_W3c => _W3c ??= new IconData("W3c", "\U0000E7DE", Styles.Brands, new string[] { "internet standards", "w3c", "web accessibility", "web design", "web development", "web standards", "web technologies", "world wide web consortium" });
        private static IconData _WalkieTalkie;
        public static IconData FA_WalkieTalkie => _WalkieTalkie ??= new IconData("Walkie Talkie", "\U0000F8EF", Styles.Solid, new string[] { "communication", "emergency radio", "field radio", "handheld radio", "intercom", "portable", "radio", "receiver", "talkie", "transmitter", "two-way radio", "walkie-talkie", "wireless" });
        private static IconData _Wallet;
        public static IconData FA_Wallet => _Wallet ??= new IconData("Wallet", "\U0000F555", Styles.Solid, new string[] { "billfold", "bills", "budget", "cash", "coins", "currency", "finance", "funds", "money", "payment", "pocketbook", "purse", "salary", "spending", "wallet" });
        private static IconData _WandMagic;
        public static IconData FA_WandMagic => _WandMagic ??= new IconData("Wand Magic", "\U0000F0D0", Styles.Solid, new string[] { "casting", "charm", "enchantment", "fantasy", "mage", "magic", "mystical", "sorcery", "spell", "supernatural", "wand", "witch", "wizard" });
        private static IconData _WandMagicSparkles;
        public static IconData FA_WandMagicSparkles => _WandMagicSparkles ??= new IconData("Wand Magic Sparkles", "\U0000E2CA", Styles.Solid, new string[] { "enchantment", "fantasy", "magic", "magic wand", "sorcery", "sparkle", "spell", "trick", "wand", "witch", "wizard" });
        private static IconData _WandSparkles;
        public static IconData FA_WandSparkles => _WandSparkles ??= new IconData("Wand Sparkles", "\U0000F72B", Styles.Solid, new string[] { "charm", "enchantment", "fantasy", "halloween", "holiday", "magic", "mystical", "sorcery", "sparkles", "spell", "supernatural", "wand", "witch", "wizard" });
        private static IconData _Warehouse;
        public static IconData FA_Warehouse => _Warehouse ??= new IconData("Warehouse", "\U0000F494", Styles.Solid, new string[] { "building", "depot", "distribution", "facility", "inventory", "logistics", "stockroom", "storage", "supply", "warehouse" });
        private static IconData _WatchmanMonitoring;
        public static IconData FA_WatchmanMonitoring => _WatchmanMonitoring ??= new IconData("Watchman Monitoring", "\U0000E087", Styles.Brands, new string[] { "IT monitoring", "brand", "monitoring", "network monitoring", "server monitoring", "system monitoring", "watchman", "watchman monitoring" });
        private static IconData _Water;
        public static IconData FA_Water => _Water ??= new IconData("Water", "\U0000F773", Styles.Solid, new string[] { "aqua", "drop", "fluid", "hydration", "lake", "liquid", "ocean", "refreshment", "river", "sea", "stream", "swim", "water", "wave", "wet" });
        private static IconData _WaterLadder;
        public static IconData FA_WaterLadder => _WaterLadder ??= new IconData("Water Ladder", "\U0000F5C5", Styles.Solid, new string[] { "aquatic", "boat", "climb", "dock", "ladder", "marine", "pool", "recreation", "safety", "swimming", "water" });
        private static IconData _WaveSquare;
        public static IconData FA_WaveSquare => _WaveSquare ??= new IconData("Wave Square", "\U0000F83E", Styles.Solid, new string[] { "audio", "data", "equalizer", "frequency", "graph", "monitor", "music", "oscillation", "pulse", "signal", "sound", "vibration", "wave", "waveform" });
        private static IconData _Waze;
        public static IconData FA_Waze => _Waze ??= new IconData("Waze", "\U0000F83F", Styles.Brands, new string[] { "commute", "directions", "driving", "gps", "maps", "navigation", "route", "traffic", "travel", "waze" });
        private static IconData _WebAwesome;
        public static IconData FA_WebAwesome => _WebAwesome ??= new IconData("Web Awesome", "\U0000E682", Styles.Brands | Styles.Solid, new string[] { "award", "awesome", "badge", "coding", "components", "crown", "developer", "frontend", "programming", "web" });
        private static IconData _Webflow;
        public static IconData FA_Webflow => _Webflow ??= new IconData("Webflow", "\U0000E65C", Styles.Brands, new string[] { "no-code", "web design", "web development", "web platform", "webflow", "webflow logo", "website builder" });
        private static IconData _Weebly;
        public static IconData FA_Weebly => _Weebly ??= new IconData("Weebly", "\U0000F5CC", Styles.Brands, new string[] { "drag and drop", "ecommerce", "online store", "site builder", "small business", "web design", "web hosting", "website builder", "website platform", "weebly" });
        private static IconData _Weibo;
        public static IconData FA_Weibo => _Weibo ??= new IconData("Weibo", "\U0000F18A", Styles.Brands, new string[] { "chinese social media", "microblog", "sina weibo", "social media", "social network", "weibo", "weibo logo" });
        private static IconData _WeightHanging;
        public static IconData FA_WeightHanging => _WeightHanging ??= new IconData("Weight Hanging", "\U0000F5CD", Styles.Solid, new string[] { "anvil", "balance", "exercise", "gym", "hanging", "heavy", "load", "measurement", "scale", "strength", "weight", "weightlifting" });
        private static IconData _WeightScale;
        public static IconData FA_WeightScale => _WeightScale ??= new IconData("Weight Scale", "\U0000F496", Styles.Solid, new string[] { "balance", "bathroom", "body", "fitness", "health", "mass", "measurement", "monitor", "scale", "tracking", "weigh", "weight" });
        private static IconData _Weixin;
        public static IconData FA_Weixin => _Weixin ??= new IconData("Weixin", "\U0000F1D7", Styles.Brands, new string[] { "chat", "chinese messenger", "instant messaging", "messaging", "mobile app", "social media", "wechat", "weixin", "weixin app" });
        private static IconData _Whatsapp;
        public static IconData FA_Whatsapp => _Whatsapp ??= new IconData("Whatsapp", "\U0000F232", Styles.Brands, new string[] { "call", "chat", "communication", "instant message", "messaging", "mobile chat", "social media", "text", "video call", "voice call", "whatsapp", "whatsapp messenger" });
        private static IconData _WheatAwn;
        public static IconData FA_WheatAwn => _WheatAwn ??= new IconData("Wheat Awn", "\U0000E2CD", Styles.Solid, new string[] { "agriculture", "autumn", "cereal", "crop", "fall", "farming", "grain", "harvest", "wheat" });
        private static IconData _WheatAwnCircleExclamation;
        public static IconData FA_WheatAwnCircleExclamation => _WheatAwnCircleExclamation ??= new IconData("Wheat Awn Circle Exclamation", "\U0000E598", Styles.Solid, new string[] { "agriculture", "alert", "allergy", "crop", "famine", "food", "gluten", "grain", "hunger", "starvation", "straw", "warning", "wheat" });
        private static IconData _Wheelchair;
        public static IconData FA_Wheelchair => _Wheelchair ??= new IconData("Wheelchair", "\U0000F193", Styles.Solid, new string[] { "accessibility", "accessible", "disabled", "handicap", "mobility", "people", "users", "wheelchair" });
        private static IconData _WheelchairMove;
        public static IconData FA_WheelchairMove => _WheelchairMove ??= new IconData("Wheelchair Move", "\U0000E2CE", Styles.Solid, new string[] { "access", "accessibility", "disabled", "handicap", "impairment", "mobility", "move", "physical disability", "transport", "wheelchair", "wheelchair symbol" });
        private static IconData _WhiskeyGlass;
        public static IconData FA_WhiskeyGlass => _WhiskeyGlass ??= new IconData("Whiskey Glass", "\U0000F7A0", Styles.Solid, new string[] { "alcohol", "bar", "beverage", "bourbon", "drink", "glass", "liquor", "neat", "rye", "scotch", "spirit", "tumbler", "tumbler glass", "whiskey", "whisky" });
        private static IconData _Whmcs;
        public static IconData FA_Whmcs => _Whmcs ??= new IconData("Whmcs", "\U0000F40D", Styles.Brands, new string[] { "automation", "billing", "client management", "hosting automation", "hosting control panel", "web hosting", "web services", "whmcs" });
        private static IconData _Wifi;
        public static IconData FA_Wifi => _Wifi ??= new IconData("Wifi", "\U0000F1EB", Styles.Solid, new string[] { "access point", "connection", "connectivity", "hotspot", "internet", "network", "online", "router", "signal", "wifi", "wifi network", "wifi signal", "wireless", "wireless internet", "wireless signal" });
        private static IconData _WikipediaW;
        public static IconData FA_WikipediaW => _WikipediaW ??= new IconData("Wikipedia W", "\U0000F266", Styles.Brands, new string[] { "encyclopedia", "information", "knowledge", "online encyclopedia", "reference", "wiki", "wiki logo", "wikipedia" });
        private static IconData _Wind;
        public static IconData FA_Wind => _Wind ??= new IconData("Wind", "\U0000F72E", Styles.Solid, new string[] { "air", "airflow", "blow", "breeze", "cyclone", "draft", "gust", "seasonal", "tornado", "ventilation", "weather", "windstorm", "windy" });
        private static IconData _WindowMaximize;
        public static IconData FA_WindowMaximize => _WindowMaximize ??= new IconData("Window Maximize", "\U0000F2D0", Styles.Regular | Styles.Solid, new string[] { "UI", "browser", "computer", "enlarge", "expand", "fullscreen", "interface", "maximize", "screen", "window" });
        private static IconData _WindowMinimize;
        public static IconData FA_WindowMinimize => _WindowMinimize ??= new IconData("Window Minimize", "\U0000F2D1", Styles.Regular | Styles.Solid, new string[] { "UI", "collapse", "desktop", "hide", "interface", "minimize", "reduce", "screen", "shrink", "window" });
        private static IconData _WindowRestore;
        public static IconData FA_WindowRestore => _WindowRestore ??= new IconData("Window Restore", "\U0000F2D2", Styles.Regular | Styles.Solid, new string[] { "application", "browser", "computer", "desktop", "interface", "maximize", "resize", "restore", "screen", "window" });
        private static IconData _Windows;
        public static IconData FA_Windows => _Windows ??= new IconData("Windows", "\U0000F17A", Styles.Brands, new string[] { "desktop", "laptop", "microsoft", "microsoft windows", "operating system", "os", "pc", "software", "windows" });
        private static IconData _WineBottle;
        public static IconData FA_WineBottle => _WineBottle ??= new IconData("Wine Bottle", "\U0000F72F", Styles.Solid, new string[] { "alcohol", "beverage", "bottle", "cabernet", "cork", "drink", "grapes", "merlot", "red wine", "sauvignon", "vineyard", "vintage", "white wine", "wine", "winery" });
        private static IconData _WineGlass;
        public static IconData FA_WineGlass => _WineGlass ??= new IconData("Wine Glass", "\U0000F4E3", Styles.Solid, new string[] { "alcohol", "bar", "beverage", "cabernet", "celebration", "cocktail", "drink", "glass", "grapes", "merlot", "red wine", "sauvignon", "toast", "white wine", "wine", "wine glass" });
        private static IconData _WineGlassEmpty;
        public static IconData FA_WineGlassEmpty => _WineGlassEmpty ??= new IconData("Wine Glass Empty", "\U0000F5CE", Styles.Solid, new string[] { "alcohol", "bar", "beverage", "cheers", "cocktail", "drink", "empty", "glass", "grapes", "red wine", "toast", "white wine", "wine" });
        private static IconData _Wirsindhandwerk;
        public static IconData FA_Wirsindhandwerk => _Wirsindhandwerk ??= new IconData("Wirsindhandwerk", "\U0000E2D0", Styles.Brands, new string[] { "artisan", "craftsman", "german craftsmanship", "handwerk", "skilled worker", "trade", "wir sind handwerk" });
        private static IconData _Wix;
        public static IconData FA_Wix => _Wix ??= new IconData("Wix", "\U0000F5CF", Styles.Brands, new string[] { "online platform", "site builder", "web design", "web hosting", "website builder", "website platform", "wix", "wix.com" });
        private static IconData _WizardsOfTheCoast;
        public static IconData FA_WizardsOfTheCoast => _WizardsOfTheCoast ??= new IconData("Wizards Of The Coast", "\U0000F730", Styles.Brands, new string[] { "Dungeons & Dragons", "Wizards of the Coast", "collectible card game", "d&d", "dnd", "fantasy", "gaming", "magic the gathering", "mtg", "role-playing game", "rpg", "tabletop" });
        private static IconData _Wodu;
        public static IconData FA_Wodu => _Wodu ??= new IconData("Wodu", "\U0000E088", Styles.Brands, new string[] { "Wodu", "Wodu app", "Wodu brand", "Wodu logo", "Wodu platform", "Wodu service" });
        private static IconData _WolfPackBattalion;
        public static IconData FA_WolfPackBattalion => _WolfPackBattalion ??= new IconData("Wolf Pack Battalion", "\U0000F514", Styles.Brands, new string[] { "battalion", "group", "military unit", "pack", "squad", "tactical", "team", "unit", "wolf", "wolf pack" });
        private static IconData _WonSign;
        public static IconData FA_WonSign => _WonSign ??= new IconData("Won Sign", "\U0000F159", Styles.Solid, new string[] { "KRW", "Korean currency", "South Korea", "currency", "currency symbol", "financial", "money", "symbol", "won", "won sign" });
        private static IconData _Wordpress;
        public static IconData FA_Wordpress => _Wordpress ??= new IconData("Wordpress", "\U0000F19A", Styles.Brands, new string[] { "blog", "blogging platform", "cms", "content management", "open source", "php", "publishing", "website", "wordpress", "wp" });
        private static IconData _WordpressSimple;
        public static IconData FA_WordpressSimple => _WordpressSimple ??= new IconData("Wordpress Simple", "\U0000F411", Styles.Brands, new string[] { "blog", "cms", "content management", "platform", "publishing", "website", "wordpress", "wp" });
        private static IconData _Worm;
        public static IconData FA_Worm => _Worm ??= new IconData("Worm", "\U0000E599", Styles.Solid, new string[] { "bug", "compost", "crawl", "dirt", "earthworm", "garden", "insect", "nature", "pest", "slimy", "soil", "worm", "wriggle" });
        private static IconData _Wpbeginner;
        public static IconData FA_Wpbeginner => _Wpbeginner ??= new IconData("Wpbeginner", "\U0000F297", Styles.Brands, new string[] { "wordpress beginner", "wordpress guide", "wordpress help", "wordpress learning", "wordpress tips", "wordpress tutorial", "wpbeginner" });
        private static IconData _Wpexplorer;
        public static IconData FA_Wpexplorer => _Wpexplorer ??= new IconData("Wpexplorer", "\U0000F2DE", Styles.Brands, new string[] { "blog", "tech blog", "tutorials", "web development", "website", "wordpress", "wp explorer", "wpexplorer" });
        private static IconData _Wpforms;
        public static IconData FA_Wpforms => _Wpforms ??= new IconData("Wpforms", "\U0000F298", Styles.Brands, new string[] { "contact form", "form builder", "form creation", "form plugin", "form software", "form tool", "online forms", "wordpress forms", "wordpress plugin", "wpforms" });
        private static IconData _Wpressr;
        public static IconData FA_Wpressr => _Wpressr ??= new IconData("Wpressr", "\U0000F3E4", Styles.Brands, new string[] { "blogging", "cms", "content management", "website", "wordpress", "wpressr" });
        private static IconData _Wrench;
        public static IconData FA_Wrench => _Wrench ??= new IconData("Wrench", "\U0000F0AD", Styles.Solid, new string[] { "adjust", "configuration", "construction", "equipment", "fix", "maintenance", "mechanic", "modify", "plumbing", "repair", "settings", "spanner", "tool", "update", "wrench" });
        private static IconData _X;
        public static IconData FA_X => _X ??= new IconData("X", "\U00000058", Styles.Solid, new string[] { "cancel", "clear", "close", "cross", "delete", "dismiss", "exit", "letter x", "multiply", "remove", "uncheck", "x" });
        private static IconData _XRay;
        public static IconData FA_XRay => _XRay ??= new IconData("X Ray", "\U0000F497", Styles.Solid, new string[] { "bone scan", "bones", "clinic", "diagnostic", "fracture", "health", "hospital", "imaging", "medical", "radiology", "scan", "skeleton", "transparent", "x-ray", "xray" });
        private static IconData _XTwitter;
        public static IconData FA_XTwitter => _XTwitter ??= new IconData("X Twitter", "\U0000E61B", Styles.Brands, new string[] { "blue bird", "microblogging", "social", "social media", "social network", "tweet", "tweets", "twitter", "x" });
        private static IconData _Xbox;
        public static IconData FA_Xbox => _Xbox ??= new IconData("Xbox", "\U0000F412", Styles.Brands, new string[] { "microsoft xbox", "xbox", "xbox brand", "xbox console", "xbox controller", "xbox game", "xbox gaming", "xbox series" });
        private static IconData _Xing;
        public static IconData FA_Xing => _Xing ??= new IconData("Xing", "\U0000F168", Styles.Brands, new string[] { "business networking", "career", "jobs", "networking site", "professional network", "professional profile", "social network", "xing", "xing logo" });
        private static IconData _Xmark;
        public static IconData FA_Xmark => _Xmark ??= new IconData("Xmark", "\U0000F00D", Styles.Solid, new string[] { "cancel", "cancel sign", "close", "cross", "cross mark", "delete", "deny", "dismissal", "error", "exit", "incorrect", "multiplication", "multiply", "no", "problem", "reject", "remove", "stop", "wrong", "x" });
        private static IconData _XmarksLines;
        public static IconData FA_XmarksLines => _XmarksLines ??= new IconData("Xmarks Lines", "\U0000E59A", Styles.Solid, new string[] { "barricade", "barrier", "block", "caution", "closed", "danger", "fence", "no entry", "restricted", "roadblock", "stop", "warning" });
        private static IconData _Xmpp;
        public static IconData FA_Xmpp => _Xmpp ??= new IconData("Xmpp", "\U0000E864", Styles.Brands, new string[] { });
        private static IconData _Y;
        public static IconData FA_Y => _Y ??= new IconData("Y", "\U00000059", Styles.Solid, new string[] { "alphabet", "capital y", "character", "letter y", "lowercase y", "symbol", "text", "typography", "yay", "yes" });
        private static IconData _YCombinator;
        public static IconData FA_YCombinator => _YCombinator ??= new IconData("Y Combinator", "\U0000F23B", Styles.Brands, new string[] { "accelerator", "entrepreneurship", "seed funding", "startup", "tech incubator", "venture capital", "y combinator", "yc" });
        private static IconData _Yahoo;
        public static IconData FA_Yahoo => _Yahoo ??= new IconData("Yahoo", "\U0000F19E", Styles.Brands, new string[] { "internet company", "verizon", "yahoo", "yahoo brand", "yahoo finance", "yahoo logo", "yahoo mail", "yahoo messenger", "yahoo search", "yahoo sports" });
        private static IconData _Yammer;
        public static IconData FA_Yammer => _Yammer ??= new IconData("Yammer", "\U0000F840", Styles.Brands, new string[] { "collaboration tool", "corporate messaging", "enterprise social network", "microsoft 365", "microsoft yammer", "office 365", "team communication", "workplace chat", "yammer" });
        private static IconData _Yandex;
        public static IconData FA_Yandex => _Yandex ??= new IconData("Yandex", "\U0000F413", Styles.Brands, new string[] { "internet", "russian search engine", "search", "technology", "web", "yandex", "yandex browser", "yandex mail", "yandex maps", "yandex taxi" });
        private static IconData _YandexInternational;
        public static IconData FA_YandexInternational => _YandexInternational ??= new IconData("Yandex International", "\U0000F414", Styles.Brands, new string[] { "internet", "russian tech", "search engine", "technology", "web", "yandex", "yandex international", "yandex logo" });
        private static IconData _Yarn;
        public static IconData FA_Yarn => _Yarn ??= new IconData("Yarn", "\U0000F7E3", Styles.Brands, new string[] { "craft", "crochet", "fabric", "fiber", "knitting", "sewing", "textile", "thread", "wool", "yarn" });
        private static IconData _Yelp;
        public static IconData FA_Yelp => _Yelp ??= new IconData("Yelp", "\U0000F1E9", Styles.Brands, new string[] { "business", "food", "local", "places", "ratings", "recommendations", "restaurant", "reviews", "services", "yelp" });
        private static IconData _YenSign;
        public static IconData FA_YenSign => _YenSign ??= new IconData("Yen Sign", "\U0000F157", Styles.Solid, new string[] { "Japanese currency", "Japanese yen", "currency", "finance", "money", "payment", "price", "symbol", "yen", "yen sign" });
        private static IconData _YinYang;
        public static IconData FA_YinYang => _YinYang ??= new IconData("Yin Yang", "\U0000F6AD", Styles.Solid, new string[] { "balance", "daoism", "duality", "eastern religion", "harmony", "opposites", "philosophy", "spirituality", "symbol", "tao", "taoism", "taoist", "yang", "yin", "yin yang" });
        private static IconData _Yoast;
        public static IconData FA_Yoast => _Yoast ??= new IconData("Yoast", "\U0000F2B1", Styles.Brands, new string[] { "content optimization", "plugin", "search engine optimization", "seo", "seo tool", "website ranking", "wordpress", "yoast", "yoast seo" });
        private static IconData _Youtube;
        public static IconData FA_Youtube => _Youtube ??= new IconData("Youtube", "\U0000F167", Styles.Brands, new string[] { "broadcast", "channel", "media", "online video", "play", "streaming", "video", "video platform", "vlog", "youtube" });
        private static IconData _Z;
        public static IconData FA_Z => _Z ??= new IconData("Z", "\U0000005A", Styles.Solid, new string[] { "alphabet z", "character z", "latin letter", "letter z", "lowercase z", "symbol z", "uppercase z" });
        private static IconData _Zhihu;
        public static IconData FA_Zhihu => _Zhihu ??= new IconData("Zhihu", "\U0000F63F", Styles.Brands, new string[] { "answers", "chinese q&a", "community", "knowledge sharing", "question", "social network", "zhihu", "知乎" });
        private static IconData _Zoom;
        public static IconData FA_Zoom => _Zoom ??= new IconData("Zoom", "\U0000E87B", Styles.Brands, new string[] { });
        private static IconData _Zulip;
        public static IconData FA_Zulip => _Zulip ??= new IconData("Zulip", "\U0000E853", Styles.Brands, new string[] { });

        private static ReadOnlyCollection<IconData> _all;
        public static ReadOnlyCollection<IconData> All => _all ??= new ReadOnlyCollection<IconData>(new IconData[]
        {
            FA_0,
            FA_1,
            FA_2,
            FA_3,
            FA_4,
            FA_5,
            FA_6,
            FA_7,
            FA_8,
            FA_9,
            FA_42Group,
            FA_500px,
            FA_A,
            FA_AccessibleIcon,
            FA_Accusoft,
            FA_AddressBook,
            FA_AddressCard,
            FA_Adn,
            FA_Adversal,
            FA_Affiliatetheme,
            FA_Airbnb,
            FA_AlarmClock,
            FA_Algolia,
            FA_AlignCenter,
            FA_AlignJustify,
            FA_AlignLeft,
            FA_AlignRight,
            FA_Alipay,
            FA_Amazon,
            FA_AmazonPay,
            FA_Amilia,
            FA_Anchor,
            FA_AnchorCircleCheck,
            FA_AnchorCircleExclamation,
            FA_AnchorCircleXmark,
            FA_AnchorLock,
            FA_Android,
            FA_Angellist,
            FA_AngleDown,
            FA_AngleLeft,
            FA_AngleRight,
            FA_AngleUp,
            FA_AnglesDown,
            FA_AnglesLeft,
            FA_AnglesRight,
            FA_AnglesUp,
            FA_Angrycreative,
            FA_Angular,
            FA_Ankh,
            FA_AppStore,
            FA_AppStoreIos,
            FA_Apper,
            FA_Apple,
            FA_ApplePay,
            FA_AppleWhole,
            FA_Aquarius,
            FA_ArchLinux,
            FA_Archway,
            FA_Aries,
            FA_ArrowDown,
            FA_ArrowDown19,
            FA_ArrowDown91,
            FA_ArrowDownAZ,
            FA_ArrowDownLong,
            FA_ArrowDownShortWide,
            FA_ArrowDownUpAcrossLine,
            FA_ArrowDownUpLock,
            FA_ArrowDownWideShort,
            FA_ArrowDownZA,
            FA_ArrowLeft,
            FA_ArrowLeftLong,
            FA_ArrowPointer,
            FA_ArrowRight,
            FA_ArrowRightArrowLeft,
            FA_ArrowRightFromBracket,
            FA_ArrowRightLong,
            FA_ArrowRightToBracket,
            FA_ArrowRightToCity,
            FA_ArrowRotateLeft,
            FA_ArrowRotateRight,
            FA_ArrowTrendDown,
            FA_ArrowTrendUp,
            FA_ArrowTurnDown,
            FA_ArrowTurnUp,
            FA_ArrowUp,
            FA_ArrowUp19,
            FA_ArrowUp91,
            FA_ArrowUpAZ,
            FA_ArrowUpFromBracket,
            FA_ArrowUpFromGroundWater,
            FA_ArrowUpFromWaterPump,
            FA_ArrowUpLong,
            FA_ArrowUpRightDots,
            FA_ArrowUpRightFromSquare,
            FA_ArrowUpShortWide,
            FA_ArrowUpWideShort,
            FA_ArrowUpZA,
            FA_ArrowsDownToLine,
            FA_ArrowsDownToPeople,
            FA_ArrowsLeftRight,
            FA_ArrowsLeftRightToLine,
            FA_ArrowsRotate,
            FA_ArrowsSpin,
            FA_ArrowsSplitUpAndLeft,
            FA_ArrowsToCircle,
            FA_ArrowsToDot,
            FA_ArrowsToEye,
            FA_ArrowsTurnRight,
            FA_ArrowsTurnToDots,
            FA_ArrowsUpDown,
            FA_ArrowsUpDownLeftRight,
            FA_ArrowsUpToLine,
            FA_Artstation,
            FA_Asterisk,
            FA_Asymmetrik,
            FA_At,
            FA_Atlassian,
            FA_Atom,
            FA_Audible,
            FA_AudioDescription,
            FA_AustralSign,
            FA_Autoprefixer,
            FA_Avianex,
            FA_Aviato,
            FA_Award,
            FA_Aws,
            FA_B,
            FA_Baby,
            FA_BabyCarriage,
            FA_Backward,
            FA_BackwardFast,
            FA_BackwardStep,
            FA_Bacon,
            FA_Bacteria,
            FA_Bacterium,
            FA_BagShopping,
            FA_Bahai,
            FA_BahtSign,
            FA_Ban,
            FA_BanSmoking,
            FA_Bandage,
            FA_Bandcamp,
            FA_BangladeshiTakaSign,
            FA_Barcode,
            FA_Bars,
            FA_BarsProgress,
            FA_BarsStaggered,
            FA_Baseball,
            FA_BaseballBatBall,
            FA_BasketShopping,
            FA_Basketball,
            FA_Bath,
            FA_BatteryEmpty,
            FA_BatteryFull,
            FA_BatteryHalf,
            FA_BatteryQuarter,
            FA_BatteryThreeQuarters,
            FA_BattleNet,
            FA_Bed,
            FA_BedPulse,
            FA_BeerMugEmpty,
            FA_Behance,
            FA_Bell,
            FA_BellConcierge,
            FA_BellSlash,
            FA_BezierCurve,
            FA_Bicycle,
            FA_Bilibili,
            FA_Bimobject,
            FA_Binoculars,
            FA_Biohazard,
            FA_Bitbucket,
            FA_Bitcoin,
            FA_BitcoinSign,
            FA_Bity,
            FA_BlackTie,
            FA_Blackberry,
            FA_Blender,
            FA_BlenderPhone,
            FA_Blog,
            FA_Blogger,
            FA_BloggerB,
            FA_Bluesky,
            FA_Bluetooth,
            FA_BluetoothB,
            FA_BoardGameGeek,
            FA_Bold,
            FA_Bolt,
            FA_BoltLightning,
            FA_Bomb,
            FA_Bone,
            FA_Bong,
            FA_Book,
            FA_BookAtlas,
            FA_BookBible,
            FA_BookBookmark,
            FA_BookJournalWhills,
            FA_BookMedical,
            FA_BookOpen,
            FA_BookOpenReader,
            FA_BookQuran,
            FA_BookSkull,
            FA_BookTanakh,
            FA_Bookmark,
            FA_Bootstrap,
            FA_BorderAll,
            FA_BorderNone,
            FA_BorderTopLeft,
            FA_BoreHole,
            FA_Bots,
            FA_BottleDroplet,
            FA_BottleWater,
            FA_BowlFood,
            FA_BowlRice,
            FA_BowlingBall,
            FA_Box,
            FA_BoxArchive,
            FA_BoxOpen,
            FA_BoxTissue,
            FA_BoxesPacking,
            FA_BoxesStacked,
            FA_Braille,
            FA_Brain,
            FA_Brave,
            FA_BraveReverse,
            FA_BrazilianRealSign,
            FA_BreadSlice,
            FA_Bridge,
            FA_BridgeCircleCheck,
            FA_BridgeCircleExclamation,
            FA_BridgeCircleXmark,
            FA_BridgeLock,
            FA_BridgeWater,
            FA_Briefcase,
            FA_BriefcaseMedical,
            FA_Broom,
            FA_BroomBall,
            FA_Brush,
            FA_Btc,
            FA_Bucket,
            FA_Buffer,
            FA_Bug,
            FA_BugSlash,
            FA_Bugs,
            FA_Building,
            FA_BuildingCircleArrowRight,
            FA_BuildingCircleCheck,
            FA_BuildingCircleExclamation,
            FA_BuildingCircleXmark,
            FA_BuildingColumns,
            FA_BuildingFlag,
            FA_BuildingLock,
            FA_BuildingNgo,
            FA_BuildingShield,
            FA_BuildingUn,
            FA_BuildingUser,
            FA_BuildingWheat,
            FA_Bullhorn,
            FA_Bullseye,
            FA_Burger,
            FA_Buromobelexperte,
            FA_Burst,
            FA_Bus,
            FA_BusSide,
            FA_BusSimple,
            FA_BusinessTime,
            FA_BuyNLarge,
            FA_Buysellads,
            FA_C,
            FA_CableCar,
            FA_CakeCandles,
            FA_Calculator,
            FA_Calendar,
            FA_CalendarCheck,
            FA_CalendarDay,
            FA_CalendarDays,
            FA_CalendarMinus,
            FA_CalendarPlus,
            FA_CalendarWeek,
            FA_CalendarXmark,
            FA_Camera,
            FA_CameraRetro,
            FA_CameraRotate,
            FA_Campground,
            FA_CanadianMapleLeaf,
            FA_Cancer,
            FA_CandyCane,
            FA_Cannabis,
            FA_Capricorn,
            FA_Capsules,
            FA_Car,
            FA_CarBattery,
            FA_CarBurst,
            FA_CarOn,
            FA_CarRear,
            FA_CarSide,
            FA_CarTunnel,
            FA_Caravan,
            FA_CaretDown,
            FA_CaretLeft,
            FA_CaretRight,
            FA_CaretUp,
            FA_Carrot,
            FA_CartArrowDown,
            FA_CartFlatbed,
            FA_CartFlatbedSuitcase,
            FA_CartPlus,
            FA_CartShopping,
            FA_CashApp,
            FA_CashRegister,
            FA_Cat,
            FA_CcAmazonPay,
            FA_CcAmex,
            FA_CcApplePay,
            FA_CcDinersClub,
            FA_CcDiscover,
            FA_CcJcb,
            FA_CcMastercard,
            FA_CcPaypal,
            FA_CcStripe,
            FA_CcVisa,
            FA_CediSign,
            FA_CentSign,
            FA_Centercode,
            FA_Centos,
            FA_Certificate,
            FA_Chair,
            FA_Chalkboard,
            FA_ChalkboardUser,
            FA_ChampagneGlasses,
            FA_ChargingStation,
            FA_ChartArea,
            FA_ChartBar,
            FA_ChartColumn,
            FA_ChartDiagram,
            FA_ChartGantt,
            FA_ChartLine,
            FA_ChartPie,
            FA_ChartSimple,
            FA_Check,
            FA_CheckDouble,
            FA_CheckToSlot,
            FA_Cheese,
            FA_Chess,
            FA_ChessBishop,
            FA_ChessBoard,
            FA_ChessKing,
            FA_ChessKnight,
            FA_ChessPawn,
            FA_ChessQueen,
            FA_ChessRook,
            FA_ChevronDown,
            FA_ChevronLeft,
            FA_ChevronRight,
            FA_ChevronUp,
            FA_Child,
            FA_ChildCombatant,
            FA_ChildDress,
            FA_ChildReaching,
            FA_Children,
            FA_Chrome,
            FA_Chromecast,
            FA_Church,
            FA_Circle,
            FA_CircleArrowDown,
            FA_CircleArrowLeft,
            FA_CircleArrowRight,
            FA_CircleArrowUp,
            FA_CircleCheck,
            FA_CircleChevronDown,
            FA_CircleChevronLeft,
            FA_CircleChevronRight,
            FA_CircleChevronUp,
            FA_CircleDollarToSlot,
            FA_CircleDot,
            FA_CircleDown,
            FA_CircleExclamation,
            FA_CircleH,
            FA_CircleHalfStroke,
            FA_CircleInfo,
            FA_CircleLeft,
            FA_CircleMinus,
            FA_CircleNodes,
            FA_CircleNotch,
            FA_CirclePause,
            FA_CirclePlay,
            FA_CirclePlus,
            FA_CircleQuestion,
            FA_CircleRadiation,
            FA_CircleRight,
            FA_CircleStop,
            FA_CircleUp,
            FA_CircleUser,
            FA_CircleXmark,
            FA_CircleZulip,
            FA_City,
            FA_Clapperboard,
            FA_Claude,
            FA_Clipboard,
            FA_ClipboardCheck,
            FA_ClipboardList,
            FA_ClipboardQuestion,
            FA_ClipboardUser,
            FA_Clock,
            FA_ClockRotateLeft,
            FA_Clone,
            FA_ClosedCaptioning,
            FA_ClosedCaptioningSlash,
            FA_Cloud,
            FA_CloudArrowDown,
            FA_CloudArrowUp,
            FA_CloudBolt,
            FA_CloudMeatball,
            FA_CloudMoon,
            FA_CloudMoonRain,
            FA_CloudRain,
            FA_CloudShowersHeavy,
            FA_CloudShowersWater,
            FA_CloudSun,
            FA_CloudSunRain,
            FA_Cloudflare,
            FA_Cloudscale,
            FA_Cloudsmith,
            FA_Cloudversify,
            FA_Clover,
            FA_Cmplid,
            FA_Code,
            FA_CodeBranch,
            FA_CodeCommit,
            FA_CodeCompare,
            FA_CodeFork,
            FA_CodeMerge,
            FA_CodePullRequest,
            FA_Codepen,
            FA_Codiepie,
            FA_Coins,
            FA_ColonSign,
            FA_Comment,
            FA_CommentDollar,
            FA_CommentDots,
            FA_CommentMedical,
            FA_CommentNodes,
            FA_CommentSlash,
            FA_CommentSms,
            FA_Comments,
            FA_CommentsDollar,
            FA_CompactDisc,
            FA_Compass,
            FA_CompassDrafting,
            FA_Compress,
            FA_Computer,
            FA_ComputerMouse,
            FA_Confluence,
            FA_Connectdevelop,
            FA_Contao,
            FA_Cookie,
            FA_CookieBite,
            FA_Copy,
            FA_Copyright,
            FA_CottonBureau,
            FA_Couch,
            FA_Cow,
            FA_Cpanel,
            FA_CreativeCommons,
            FA_CreativeCommonsBy,
            FA_CreativeCommonsNc,
            FA_CreativeCommonsNcEu,
            FA_CreativeCommonsNcJp,
            FA_CreativeCommonsNd,
            FA_CreativeCommonsPd,
            FA_CreativeCommonsPdAlt,
            FA_CreativeCommonsRemix,
            FA_CreativeCommonsSa,
            FA_CreativeCommonsSampling,
            FA_CreativeCommonsSamplingPlus,
            FA_CreativeCommonsShare,
            FA_CreativeCommonsZero,
            FA_CreditCard,
            FA_CriticalRole,
            FA_Crop,
            FA_CropSimple,
            FA_Cross,
            FA_Crosshairs,
            FA_Crow,
            FA_Crown,
            FA_Crutch,
            FA_CruzeiroSign,
            FA_Css,
            FA_Css3,
            FA_Css3Alt,
            FA_Cube,
            FA_Cubes,
            FA_CubesStacked,
            FA_Cuttlefish,
            FA_D,
            FA_DAndD,
            FA_DAndDBeyond,
            FA_Dailymotion,
            FA_DartLang,
            FA_Dashcube,
            FA_Database,
            FA_Debian,
            FA_Deezer,
            FA_DeleteLeft,
            FA_Delicious,
            FA_Democrat,
            FA_Deploydog,
            FA_Deskpro,
            FA_Desktop,
            FA_Dev,
            FA_Deviantart,
            FA_Dharmachakra,
            FA_Dhl,
            FA_DiagramNext,
            FA_DiagramPredecessor,
            FA_DiagramProject,
            FA_DiagramSuccessor,
            FA_Diamond,
            FA_DiamondTurnRight,
            FA_Diaspora,
            FA_Dice,
            FA_DiceD20,
            FA_DiceD6,
            FA_DiceFive,
            FA_DiceFour,
            FA_DiceOne,
            FA_DiceSix,
            FA_DiceThree,
            FA_DiceTwo,
            FA_Digg,
            FA_DigitalOcean,
            FA_Discord,
            FA_Discourse,
            FA_Disease,
            FA_Display,
            FA_Disqus,
            FA_Divide,
            FA_Dna,
            FA_Dochub,
            FA_Docker,
            FA_Dog,
            FA_DollarSign,
            FA_Dolly,
            FA_DongSign,
            FA_DoorClosed,
            FA_DoorOpen,
            FA_Dove,
            FA_DownLeftAndUpRightToCenter,
            FA_DownLong,
            FA_Download,
            FA_Draft2digital,
            FA_Dragon,
            FA_DrawPolygon,
            FA_Dribbble,
            FA_Dropbox,
            FA_Droplet,
            FA_DropletSlash,
            FA_Drum,
            FA_DrumSteelpan,
            FA_DrumstickBite,
            FA_Drupal,
            FA_Dumbbell,
            FA_Dumpster,
            FA_DumpsterFire,
            FA_Dungeon,
            FA_Duolingo,
            FA_Dyalog,
            FA_E,
            FA_EarDeaf,
            FA_EarListen,
            FA_Earlybirds,
            FA_EarthAfrica,
            FA_EarthAmericas,
            FA_EarthAsia,
            FA_EarthEurope,
            FA_EarthOceania,
            FA_Ebay,
            FA_Edge,
            FA_EdgeLegacy,
            FA_Egg,
            FA_Eject,
            FA_Elementor,
            FA_Elevator,
            FA_Eleventy,
            FA_Ellipsis,
            FA_EllipsisVertical,
            FA_Ello,
            FA_Ember,
            FA_Empire,
            FA_Envelope,
            FA_EnvelopeCircleCheck,
            FA_EnvelopeOpen,
            FA_EnvelopeOpenText,
            FA_EnvelopesBulk,
            FA_Envira,
            FA_Equals,
            FA_Eraser,
            FA_Erlang,
            FA_Ethereum,
            FA_Ethernet,
            FA_Etsy,
            FA_EuroSign,
            FA_Evernote,
            FA_Exclamation,
            FA_Expand,
            FA_Expeditedssl,
            FA_Explosion,
            FA_Eye,
            FA_EyeDropper,
            FA_EyeLowVision,
            FA_EyeSlash,
            FA_F,
            FA_FaceAngry,
            FA_FaceDizzy,
            FA_FaceFlushed,
            FA_FaceFrown,
            FA_FaceFrownOpen,
            FA_FaceGrimace,
            FA_FaceGrin,
            FA_FaceGrinBeam,
            FA_FaceGrinBeamSweat,
            FA_FaceGrinHearts,
            FA_FaceGrinSquint,
            FA_FaceGrinSquintTears,
            FA_FaceGrinStars,
            FA_FaceGrinTears,
            FA_FaceGrinTongue,
            FA_FaceGrinTongueSquint,
            FA_FaceGrinTongueWink,
            FA_FaceGrinWide,
            FA_FaceGrinWink,
            FA_FaceKiss,
            FA_FaceKissBeam,
            FA_FaceKissWinkHeart,
            FA_FaceLaugh,
            FA_FaceLaughBeam,
            FA_FaceLaughSquint,
            FA_FaceLaughWink,
            FA_FaceMeh,
            FA_FaceMehBlank,
            FA_FaceRollingEyes,
            FA_FaceSadCry,
            FA_FaceSadTear,
            FA_FaceSmile,
            FA_FaceSmileBeam,
            FA_FaceSmileWink,
            FA_FaceSurprise,
            FA_FaceTired,
            FA_Facebook,
            FA_FacebookF,
            FA_FacebookMessenger,
            FA_Fan,
            FA_FantasyFlightGames,
            FA_Faucet,
            FA_FaucetDrip,
            FA_Fax,
            FA_Feather,
            FA_FeatherPointed,
            FA_Fedex,
            FA_Fediverse,
            FA_Fedora,
            FA_Ferry,
            FA_Figma,
            FA_File,
            FA_FileArrowDown,
            FA_FileArrowUp,
            FA_FileAudio,
            FA_FileCircleCheck,
            FA_FileCircleExclamation,
            FA_FileCircleMinus,
            FA_FileCirclePlus,
            FA_FileCircleQuestion,
            FA_FileCircleXmark,
            FA_FileCode,
            FA_FileContract,
            FA_FileCsv,
            FA_FileExcel,
            FA_FileExport,
            FA_FileFragment,
            FA_FileHalfDashed,
            FA_FileImage,
            FA_FileImport,
            FA_FileInvoice,
            FA_FileInvoiceDollar,
            FA_FileLines,
            FA_FileMedical,
            FA_FilePdf,
            FA_FilePen,
            FA_FilePowerpoint,
            FA_FilePrescription,
            FA_FileShield,
            FA_FileSignature,
            FA_FileVideo,
            FA_FileWaveform,
            FA_FileWord,
            FA_FileZipper,
            FA_FilesPinwheel,
            FA_Fill,
            FA_FillDrip,
            FA_Film,
            FA_Filter,
            FA_FilterCircleDollar,
            FA_FilterCircleXmark,
            FA_Fingerprint,
            FA_Fire,
            FA_FireBurner,
            FA_FireExtinguisher,
            FA_FireFlameCurved,
            FA_FireFlameSimple,
            FA_Firefox,
            FA_FirefoxBrowser,
            FA_FirstOrder,
            FA_FirstOrderAlt,
            FA_Firstdraft,
            FA_Fish,
            FA_FishFins,
            FA_Flag,
            FA_FlagCheckered,
            FA_FlagUsa,
            FA_Flask,
            FA_FlaskVial,
            FA_Flickr,
            FA_Flipboard,
            FA_FloppyDisk,
            FA_FlorinSign,
            FA_Flutter,
            FA_Fly,
            FA_Folder,
            FA_FolderClosed,
            FA_FolderMinus,
            FA_FolderOpen,
            FA_FolderPlus,
            FA_FolderTree,
            FA_Font,
            FA_FontAwesome,
            FA_Fonticons,
            FA_FonticonsFi,
            FA_Football,
            FA_Forgejo,
            FA_FortAwesome,
            FA_FortAwesomeAlt,
            FA_Forumbee,
            FA_Forward,
            FA_ForwardFast,
            FA_ForwardStep,
            FA_Foursquare,
            FA_FrancSign,
            FA_FreeCodeCamp,
            FA_Freebsd,
            FA_Frog,
            FA_Fulcrum,
            FA_Futbol,
            FA_G,
            FA_GalacticRepublic,
            FA_GalacticSenate,
            FA_Gamepad,
            FA_GasPump,
            FA_Gauge,
            FA_GaugeHigh,
            FA_GaugeSimple,
            FA_GaugeSimpleHigh,
            FA_Gavel,
            FA_Gear,
            FA_Gears,
            FA_Gem,
            FA_Gemini,
            FA_Genderless,
            FA_GetPocket,
            FA_Gg,
            FA_GgCircle,
            FA_Ghost,
            FA_Gift,
            FA_Gifts,
            FA_Git,
            FA_GitAlt,
            FA_Gitee,
            FA_Github,
            FA_GithubAlt,
            FA_Gitkraken,
            FA_Gitlab,
            FA_Gitter,
            FA_GlassWater,
            FA_GlassWaterDroplet,
            FA_Glasses,
            FA_Glide,
            FA_GlideG,
            FA_Globaleaks,
            FA_Globe,
            FA_Gofore,
            FA_Golang,
            FA_GolfBallTee,
            FA_Goodreads,
            FA_GoodreadsG,
            FA_Google,
            FA_GoogleDrive,
            FA_GooglePay,
            FA_GooglePlay,
            FA_GooglePlus,
            FA_GooglePlusG,
            FA_GoogleScholar,
            FA_GoogleWallet,
            FA_Gopuram,
            FA_GraduationCap,
            FA_Gratipay,
            FA_Grav,
            FA_GreaterThan,
            FA_GreaterThanEqual,
            FA_Grip,
            FA_GripLines,
            FA_GripLinesVertical,
            FA_GripVertical,
            FA_Gripfire,
            FA_GroupArrowsRotate,
            FA_Grunt,
            FA_GuaraniSign,
            FA_Guilded,
            FA_Guitar,
            FA_Gulp,
            FA_Gun,
            FA_H,
            FA_HackerNews,
            FA_Hackerrank,
            FA_Hammer,
            FA_Hamsa,
            FA_Hand,
            FA_HandBackFist,
            FA_HandDots,
            FA_HandFist,
            FA_HandHolding,
            FA_HandHoldingDollar,
            FA_HandHoldingDroplet,
            FA_HandHoldingHand,
            FA_HandHoldingHeart,
            FA_HandHoldingMedical,
            FA_HandLizard,
            FA_HandMiddleFinger,
            FA_HandPeace,
            FA_HandPointDown,
            FA_HandPointLeft,
            FA_HandPointRight,
            FA_HandPointUp,
            FA_HandPointer,
            FA_HandScissors,
            FA_HandSparkles,
            FA_HandSpock,
            FA_Handcuffs,
            FA_Hands,
            FA_HandsAslInterpreting,
            FA_HandsBound,
            FA_HandsBubbles,
            FA_HandsClapping,
            FA_HandsHolding,
            FA_HandsHoldingChild,
            FA_HandsHoldingCircle,
            FA_HandsPraying,
            FA_Handshake,
            FA_HandshakeAngle,
            FA_HandshakeSlash,
            FA_Hanukiah,
            FA_HardDrive,
            FA_Hashnode,
            FA_Hashtag,
            FA_HatCowboy,
            FA_HatCowboySide,
            FA_HatWizard,
            FA_HeadSideCough,
            FA_HeadSideCoughSlash,
            FA_HeadSideMask,
            FA_HeadSideVirus,
            FA_Heading,
            FA_Headphones,
            FA_Headset,
            FA_Heart,
            FA_HeartCircleBolt,
            FA_HeartCircleCheck,
            FA_HeartCircleExclamation,
            FA_HeartCircleMinus,
            FA_HeartCirclePlus,
            FA_HeartCircleXmark,
            FA_HeartCrack,
            FA_HeartPulse,
            FA_Helicopter,
            FA_HelicopterSymbol,
            FA_HelmetSafety,
            FA_HelmetUn,
            FA_Hexagon,
            FA_HexagonNodes,
            FA_HexagonNodesBolt,
            FA_Highlighter,
            FA_HillAvalanche,
            FA_HillRockslide,
            FA_Hippo,
            FA_Hips,
            FA_HireAHelper,
            FA_Hive,
            FA_HockeyPuck,
            FA_HollyBerry,
            FA_Hooli,
            FA_Hornbill,
            FA_Horse,
            FA_HorseHead,
            FA_Hospital,
            FA_HospitalUser,
            FA_HotTubPerson,
            FA_Hotdog,
            FA_Hotel,
            FA_Hotjar,
            FA_Hourglass,
            FA_HourglassEnd,
            FA_HourglassHalf,
            FA_HourglassStart,
            FA_House,
            FA_HouseChimney,
            FA_HouseChimneyCrack,
            FA_HouseChimneyMedical,
            FA_HouseChimneyUser,
            FA_HouseChimneyWindow,
            FA_HouseCircleCheck,
            FA_HouseCircleExclamation,
            FA_HouseCircleXmark,
            FA_HouseCrack,
            FA_HouseFire,
            FA_HouseFlag,
            FA_HouseFloodWater,
            FA_HouseFloodWaterCircleArrowRight,
            FA_HouseLaptop,
            FA_HouseLock,
            FA_HouseMedical,
            FA_HouseMedicalCircleCheck,
            FA_HouseMedicalCircleExclamation,
            FA_HouseMedicalCircleXmark,
            FA_HouseMedicalFlag,
            FA_HouseSignal,
            FA_HouseTsunami,
            FA_HouseUser,
            FA_Houzz,
            FA_HryvniaSign,
            FA_Html5,
            FA_Hubspot,
            FA_HuggingFace,
            FA_Hurricane,
            FA_I,
            FA_ICursor,
            FA_IceCream,
            FA_Icicles,
            FA_Icons,
            FA_IdBadge,
            FA_IdCard,
            FA_IdCardClip,
            FA_Ideal,
            FA_Igloo,
            FA_Image,
            FA_ImagePortrait,
            FA_Images,
            FA_Imdb,
            FA_Inbox,
            FA_Indent,
            FA_IndianRupeeSign,
            FA_Industry,
            FA_Infinity,
            FA_Info,
            FA_Instagram,
            FA_Instalod,
            FA_Intercom,
            FA_InternetExplorer,
            FA_Invision,
            FA_Ioxhost,
            FA_Italic,
            FA_ItchIo,
            FA_Itunes,
            FA_ItunesNote,
            FA_J,
            FA_Jar,
            FA_JarWheat,
            FA_Java,
            FA_Jedi,
            FA_JediOrder,
            FA_Jenkins,
            FA_JetFighter,
            FA_JetFighterUp,
            FA_Jira,
            FA_Joget,
            FA_Joint,
            FA_Joomla,
            FA_Js,
            FA_Jsfiddle,
            FA_JugDetergent,
            FA_Julia,
            FA_Jxl,
            FA_K,
            FA_Kaaba,
            FA_Kaggle,
            FA_KakaoTalk,
            FA_Key,
            FA_Keybase,
            FA_Keyboard,
            FA_Keycdn,
            FA_Khanda,
            FA_Kickstarter,
            FA_KickstarterK,
            FA_KipSign,
            FA_KitMedical,
            FA_KitchenSet,
            FA_KiwiBird,
            FA_KoFi,
            FA_Korvue,
            FA_Kubernetes,
            FA_L,
            FA_LandMineOn,
            FA_Landmark,
            FA_LandmarkDome,
            FA_LandmarkFlag,
            FA_Language,
            FA_Laptop,
            FA_LaptopCode,
            FA_LaptopFile,
            FA_LaptopMedical,
            FA_Laravel,
            FA_LariSign,
            FA_Lastfm,
            FA_LayerGroup,
            FA_Leaf,
            FA_Leanpub,
            FA_Leetcode,
            FA_LeftLong,
            FA_LeftRight,
            FA_Lemon,
            FA_Leo,
            FA_Less,
            FA_LessThan,
            FA_LessThanEqual,
            FA_Letterboxd,
            FA_Libra,
            FA_LifeRing,
            FA_Lightbulb,
            FA_Line,
            FA_LinesLeaning,
            FA_Link,
            FA_LinkSlash,
            FA_Linkedin,
            FA_LinkedinIn,
            FA_Linktree,
            FA_Linode,
            FA_Linux,
            FA_LiraSign,
            FA_List,
            FA_ListCheck,
            FA_ListOl,
            FA_ListUl,
            FA_LitecoinSign,
            FA_LocationArrow,
            FA_LocationCrosshairs,
            FA_LocationDot,
            FA_LocationPin,
            FA_LocationPinLock,
            FA_Lock,
            FA_LockOpen,
            FA_Locust,
            FA_Lumon,
            FA_LumonDrop,
            FA_Lungs,
            FA_LungsVirus,
            FA_Lyft,
            FA_M,
            FA_Magento,
            FA_Magnet,
            FA_MagnifyingGlass,
            FA_MagnifyingGlassArrowRight,
            FA_MagnifyingGlassChart,
            FA_MagnifyingGlassDollar,
            FA_MagnifyingGlassLocation,
            FA_MagnifyingGlassMinus,
            FA_MagnifyingGlassPlus,
            FA_Mailchimp,
            FA_ManatSign,
            FA_Mandalorian,
            FA_Map,
            FA_MapLocation,
            FA_MapLocationDot,
            FA_MapPin,
            FA_Markdown,
            FA_Marker,
            FA_Mars,
            FA_MarsAndVenus,
            FA_MarsAndVenusBurst,
            FA_MarsDouble,
            FA_MarsStroke,
            FA_MarsStrokeRight,
            FA_MarsStrokeUp,
            FA_MartiniGlass,
            FA_MartiniGlassCitrus,
            FA_MartiniGlassEmpty,
            FA_Mask,
            FA_MaskFace,
            FA_MaskVentilator,
            FA_MasksTheater,
            FA_Mastodon,
            FA_MattressPillow,
            FA_Maxcdn,
            FA_Maximize,
            FA_Mdb,
            FA_Medal,
            FA_Medapps,
            FA_Medium,
            FA_Medrt,
            FA_Meetup,
            FA_Megaport,
            FA_Memory,
            FA_Mendeley,
            FA_Menorah,
            FA_Mercury,
            FA_Message,
            FA_Meta,
            FA_Meteor,
            FA_Microblog,
            FA_Microchip,
            FA_Microphone,
            FA_MicrophoneLines,
            FA_MicrophoneLinesSlash,
            FA_MicrophoneSlash,
            FA_Microscope,
            FA_Microsoft,
            FA_MillSign,
            FA_Minimize,
            FA_Mintbit,
            FA_Minus,
            FA_Mitten,
            FA_Mix,
            FA_Mixcloud,
            FA_Mixer,
            FA_Mizuni,
            FA_Mobile,
            FA_MobileButton,
            FA_MobileRetro,
            FA_MobileScreen,
            FA_MobileScreenButton,
            FA_MobileVibrate,
            FA_Modx,
            FA_Monero,
            FA_MoneyBill,
            FA_MoneyBill1,
            FA_MoneyBill1Wave,
            FA_MoneyBillTransfer,
            FA_MoneyBillTrendUp,
            FA_MoneyBillWave,
            FA_MoneyBillWheat,
            FA_MoneyBills,
            FA_MoneyCheck,
            FA_MoneyCheckDollar,
            FA_Monument,
            FA_Moon,
            FA_MortarPestle,
            FA_Mosque,
            FA_Mosquito,
            FA_MosquitoNet,
            FA_Motorcycle,
            FA_Mound,
            FA_Mountain,
            FA_MountainCity,
            FA_MountainSun,
            FA_MugHot,
            FA_MugSaucer,
            FA_Music,
            FA_N,
            FA_NairaSign,
            FA_Napster,
            FA_Neos,
            FA_NetworkWired,
            FA_Neuter,
            FA_Newspaper,
            FA_NfcDirectional,
            FA_NfcSymbol,
            FA_Nimblr,
            FA_Node,
            FA_NodeJs,
            FA_NonBinary,
            FA_NotEqual,
            FA_Notdef,
            FA_NoteSticky,
            FA_NotesMedical,
            FA_Notion,
            FA_Npm,
            FA_Ns8,
            FA_Nutritionix,
            FA_O,
            FA_ObjectGroup,
            FA_ObjectUngroup,
            FA_Obsidian,
            FA_Octagon,
            FA_OctopusDeploy,
            FA_Odnoklassniki,
            FA_Odysee,
            FA_OilCan,
            FA_OilWell,
            FA_OldRepublic,
            FA_Om,
            FA_Openai,
            FA_Opencart,
            FA_Openid,
            FA_Openstreetmap,
            FA_Opensuse,
            FA_Opera,
            FA_OptinMonster,
            FA_Orcid,
            FA_Osi,
            FA_Otter,
            FA_Outdent,
            FA_P,
            FA_Padlet,
            FA_Page4,
            FA_Pagelines,
            FA_Pager,
            FA_PaintRoller,
            FA_Paintbrush,
            FA_Palette,
            FA_Palfed,
            FA_Pallet,
            FA_Pandora,
            FA_Panorama,
            FA_PaperPlane,
            FA_Paperclip,
            FA_ParachuteBox,
            FA_Paragraph,
            FA_Passport,
            FA_Paste,
            FA_Patreon,
            FA_Pause,
            FA_Paw,
            FA_Paypal,
            FA_Peace,
            FA_Pen,
            FA_PenClip,
            FA_PenFancy,
            FA_PenNib,
            FA_PenRuler,
            FA_PenToSquare,
            FA_Pencil,
            FA_Pentagon,
            FA_PeopleArrows,
            FA_PeopleCarryBox,
            FA_PeopleGroup,
            FA_PeopleLine,
            FA_PeoplePulling,
            FA_PeopleRobbery,
            FA_PeopleRoof,
            FA_PepperHot,
            FA_Perbyte,
            FA_Percent,
            FA_Periscope,
            FA_Person,
            FA_PersonArrowDownToLine,
            FA_PersonArrowUpFromLine,
            FA_PersonBiking,
            FA_PersonBooth,
            FA_PersonBreastfeeding,
            FA_PersonBurst,
            FA_PersonCane,
            FA_PersonChalkboard,
            FA_PersonCircleCheck,
            FA_PersonCircleExclamation,
            FA_PersonCircleMinus,
            FA_PersonCirclePlus,
            FA_PersonCircleQuestion,
            FA_PersonCircleXmark,
            FA_PersonDigging,
            FA_PersonDotsFromLine,
            FA_PersonDress,
            FA_PersonDressBurst,
            FA_PersonDrowning,
            FA_PersonFalling,
            FA_PersonFallingBurst,
            FA_PersonHalfDress,
            FA_PersonHarassing,
            FA_PersonHiking,
            FA_PersonMilitaryPointing,
            FA_PersonMilitaryRifle,
            FA_PersonMilitaryToPerson,
            FA_PersonPraying,
            FA_PersonPregnant,
            FA_PersonRays,
            FA_PersonRifle,
            FA_PersonRunning,
            FA_PersonShelter,
            FA_PersonSkating,
            FA_PersonSkiing,
            FA_PersonSkiingNordic,
            FA_PersonSnowboarding,
            FA_PersonSwimming,
            FA_PersonThroughWindow,
            FA_PersonWalking,
            FA_PersonWalkingArrowLoopLeft,
            FA_PersonWalkingArrowRight,
            FA_PersonWalkingDashedLineArrowRight,
            FA_PersonWalkingLuggage,
            FA_PersonWalkingWithCane,
            FA_PesetaSign,
            FA_PesoSign,
            FA_Phabricator,
            FA_PhoenixFramework,
            FA_PhoenixSquadron,
            FA_Phone,
            FA_PhoneFlip,
            FA_PhoneSlash,
            FA_PhoneVolume,
            FA_PhotoFilm,
            FA_Php,
            FA_PictureInPicture,
            FA_PiedPiper,
            FA_PiedPiperAlt,
            FA_PiedPiperHat,
            FA_PiedPiperPp,
            FA_PiggyBank,
            FA_Pills,
            FA_Pinterest,
            FA_PinterestP,
            FA_Pisces,
            FA_Pix,
            FA_Pixelfed,
            FA_Pixiv,
            FA_PizzaSlice,
            FA_PlaceOfWorship,
            FA_Plane,
            FA_PlaneArrival,
            FA_PlaneCircleCheck,
            FA_PlaneCircleExclamation,
            FA_PlaneCircleXmark,
            FA_PlaneDeparture,
            FA_PlaneLock,
            FA_PlaneSlash,
            FA_PlaneUp,
            FA_PlantWilt,
            FA_PlateWheat,
            FA_Play,
            FA_Playstation,
            FA_Plug,
            FA_PlugCircleBolt,
            FA_PlugCircleCheck,
            FA_PlugCircleExclamation,
            FA_PlugCircleMinus,
            FA_PlugCirclePlus,
            FA_PlugCircleXmark,
            FA_Plus,
            FA_PlusMinus,
            FA_Podcast,
            FA_Poo,
            FA_PooStorm,
            FA_Poop,
            FA_Postgresql,
            FA_PowerOff,
            FA_Prescription,
            FA_PrescriptionBottle,
            FA_PrescriptionBottleMedical,
            FA_Print,
            FA_ProductHunt,
            FA_PumpMedical,
            FA_PumpSoap,
            FA_Pushed,
            FA_PuzzlePiece,
            FA_Python,
            FA_Q,
            FA_Qq,
            FA_Qrcode,
            FA_Question,
            FA_Quinscape,
            FA_Quora,
            FA_QuoteLeft,
            FA_QuoteRight,
            FA_R,
            FA_RProject,
            FA_Radiation,
            FA_Radio,
            FA_Rainbow,
            FA_RankingStar,
            FA_RaspberryPi,
            FA_Ravelry,
            FA_React,
            FA_Reacteurope,
            FA_Readme,
            FA_Rebel,
            FA_Receipt,
            FA_RecordVinyl,
            FA_RectangleAd,
            FA_RectangleList,
            FA_RectangleXmark,
            FA_Recycle,
            FA_RedRiver,
            FA_Reddit,
            FA_RedditAlien,
            FA_Redhat,
            FA_Registered,
            FA_Renren,
            FA_Repeat,
            FA_Reply,
            FA_ReplyAll,
            FA_Replyd,
            FA_Republican,
            FA_Researchgate,
            FA_Resolving,
            FA_Restroom,
            FA_Retweet,
            FA_Rev,
            FA_Ribbon,
            FA_RightFromBracket,
            FA_RightLeft,
            FA_RightLong,
            FA_RightToBracket,
            FA_Ring,
            FA_Road,
            FA_RoadBarrier,
            FA_RoadBridge,
            FA_RoadCircleCheck,
            FA_RoadCircleExclamation,
            FA_RoadCircleXmark,
            FA_RoadLock,
            FA_RoadSpikes,
            FA_Robot,
            FA_Rocket,
            FA_Rocketchat,
            FA_Rockrms,
            FA_Rotate,
            FA_RotateLeft,
            FA_RotateRight,
            FA_Route,
            FA_Rss,
            FA_RubleSign,
            FA_Rug,
            FA_Ruler,
            FA_RulerCombined,
            FA_RulerHorizontal,
            FA_RulerVertical,
            FA_RupeeSign,
            FA_RupiahSign,
            FA_Rust,
            FA_S,
            FA_SackDollar,
            FA_SackXmark,
            FA_Safari,
            FA_Sagittarius,
            FA_Sailboat,
            FA_Salesforce,
            FA_Sass,
            FA_Satellite,
            FA_SatelliteDish,
            FA_ScaleBalanced,
            FA_ScaleUnbalanced,
            FA_ScaleUnbalancedFlip,
            FA_Scaleway,
            FA_Schlix,
            FA_School,
            FA_SchoolCircleCheck,
            FA_SchoolCircleExclamation,
            FA_SchoolCircleXmark,
            FA_SchoolFlag,
            FA_SchoolLock,
            FA_Scissors,
            FA_Scorpio,
            FA_Screenpal,
            FA_Screwdriver,
            FA_ScrewdriverWrench,
            FA_Scribd,
            FA_Scroll,
            FA_ScrollTorah,
            FA_SdCard,
            FA_Searchengin,
            FA_Section,
            FA_Seedling,
            FA_Sellcast,
            FA_Sellsy,
            FA_Septagon,
            FA_Server,
            FA_Servicestack,
            FA_Shapes,
            FA_Share,
            FA_ShareFromSquare,
            FA_ShareNodes,
            FA_SheetPlastic,
            FA_ShekelSign,
            FA_Shield,
            FA_ShieldCat,
            FA_ShieldDog,
            FA_ShieldHalved,
            FA_ShieldHeart,
            FA_ShieldVirus,
            FA_Ship,
            FA_Shirt,
            FA_Shirtsinbulk,
            FA_ShoePrints,
            FA_Shoelace,
            FA_Shop,
            FA_ShopLock,
            FA_ShopSlash,
            FA_Shopify,
            FA_Shopware,
            FA_Shower,
            FA_Shrimp,
            FA_Shuffle,
            FA_ShuttleSpace,
            FA_SignHanging,
            FA_Signal,
            FA_SignalMessenger,
            FA_Signature,
            FA_SignsPost,
            FA_SimCard,
            FA_Simplybuilt,
            FA_SingleQuoteLeft,
            FA_SingleQuoteRight,
            FA_Sink,
            FA_Sistrix,
            FA_Sitemap,
            FA_Sith,
            FA_Sitrox,
            FA_Sketch,
            FA_Skull,
            FA_SkullCrossbones,
            FA_Skyatlas,
            FA_Skype,
            FA_Slack,
            FA_Slash,
            FA_Sleigh,
            FA_Sliders,
            FA_Slideshare,
            FA_Smog,
            FA_Smoking,
            FA_Snapchat,
            FA_Snowflake,
            FA_Snowman,
            FA_Snowplow,
            FA_Soap,
            FA_Socks,
            FA_Solana,
            FA_SolarPanel,
            FA_Sort,
            FA_SortDown,
            FA_SortUp,
            FA_Soundcloud,
            FA_Sourcetree,
            FA_Spa,
            FA_SpaceAwesome,
            FA_SpaghettiMonsterFlying,
            FA_Speakap,
            FA_SpeakerDeck,
            FA_SpellCheck,
            FA_Spider,
            FA_Spinner,
            FA_Spiral,
            FA_Splotch,
            FA_Spoon,
            FA_Spotify,
            FA_SprayCan,
            FA_SprayCanSparkles,
            FA_Square,
            FA_SquareArrowUpRight,
            FA_SquareBehance,
            FA_SquareBinary,
            FA_SquareBluesky,
            FA_SquareCaretDown,
            FA_SquareCaretLeft,
            FA_SquareCaretRight,
            FA_SquareCaretUp,
            FA_SquareCheck,
            FA_SquareDeskpro,
            FA_SquareDribbble,
            FA_SquareEnvelope,
            FA_SquareFacebook,
            FA_SquareFigma,
            FA_SquareFontAwesome,
            FA_SquareFontAwesomeStroke,
            FA_SquareFull,
            FA_SquareGit,
            FA_SquareGithub,
            FA_SquareGitlab,
            FA_SquareGooglePlus,
            FA_SquareH,
            FA_SquareHackerNews,
            FA_SquareInstagram,
            FA_SquareJs,
            FA_SquareLastfm,
            FA_SquareLetterboxd,
            FA_SquareLinkedin,
            FA_SquareMinus,
            FA_SquareNfi,
            FA_SquareOdnoklassniki,
            FA_SquareParking,
            FA_SquarePen,
            FA_SquarePersonConfined,
            FA_SquarePhone,
            FA_SquarePhoneFlip,
            FA_SquarePiedPiper,
            FA_SquarePinterest,
            FA_SquarePlus,
            FA_SquarePollHorizontal,
            FA_SquarePollVertical,
            FA_SquareReddit,
            FA_SquareRootVariable,
            FA_SquareRss,
            FA_SquareShareNodes,
            FA_SquareSnapchat,
            FA_SquareSteam,
            FA_SquareThreads,
            FA_SquareTumblr,
            FA_SquareTwitter,
            FA_SquareUpRight,
            FA_SquareUpwork,
            FA_SquareViadeo,
            FA_SquareVimeo,
            FA_SquareVirus,
            FA_SquareWebAwesome,
            FA_SquareWebAwesomeStroke,
            FA_SquareWhatsapp,
            FA_SquareXTwitter,
            FA_SquareXing,
            FA_SquareXmark,
            FA_SquareYoutube,
            FA_Squarespace,
            FA_StackExchange,
            FA_StackOverflow,
            FA_Stackpath,
            FA_StaffSnake,
            FA_Stairs,
            FA_Stamp,
            FA_Stapler,
            FA_Star,
            FA_StarAndCrescent,
            FA_StarHalf,
            FA_StarHalfStroke,
            FA_StarOfDavid,
            FA_StarOfLife,
            FA_Staylinked,
            FA_Steam,
            FA_SteamSymbol,
            FA_SterlingSign,
            FA_Stethoscope,
            FA_StickerMule,
            FA_Stop,
            FA_Stopwatch,
            FA_Stopwatch20,
            FA_Store,
            FA_StoreSlash,
            FA_Strava,
            FA_StreetView,
            FA_Strikethrough,
            FA_Stripe,
            FA_StripeS,
            FA_Stroopwafel,
            FA_Stubber,
            FA_Studiovinari,
            FA_Stumbleupon,
            FA_StumbleuponCircle,
            FA_Subscript,
            FA_Suitcase,
            FA_SuitcaseMedical,
            FA_SuitcaseRolling,
            FA_Sun,
            FA_SunPlantWilt,
            FA_Superpowers,
            FA_Superscript,
            FA_Supple,
            FA_Supportnow,
            FA_Suse,
            FA_Svelte,
            FA_Swatchbook,
            FA_Swift,
            FA_Symfony,
            FA_Symfonycasts,
            FA_Synagogue,
            FA_Syringe,
            FA_T,
            FA_Table,
            FA_TableCells,
            FA_TableCellsColumnLock,
            FA_TableCellsLarge,
            FA_TableCellsRowLock,
            FA_TableCellsRowUnlock,
            FA_TableColumns,
            FA_TableList,
            FA_TableTennisPaddleBall,
            FA_Tablet,
            FA_TabletButton,
            FA_TabletScreenButton,
            FA_Tablets,
            FA_TachographDigital,
            FA_Tag,
            FA_Tags,
            FA_TailwindCss,
            FA_Tape,
            FA_Tarp,
            FA_TarpDroplet,
            FA_Taurus,
            FA_Taxi,
            FA_Teamspeak,
            FA_Teeth,
            FA_TeethOpen,
            FA_Telegram,
            FA_TemperatureArrowDown,
            FA_TemperatureArrowUp,
            FA_TemperatureEmpty,
            FA_TemperatureFull,
            FA_TemperatureHalf,
            FA_TemperatureHigh,
            FA_TemperatureLow,
            FA_TemperatureQuarter,
            FA_TemperatureThreeQuarters,
            FA_TencentWeibo,
            FA_TengeSign,
            FA_Tent,
            FA_TentArrowDownToLine,
            FA_TentArrowLeftRight,
            FA_TentArrowTurnLeft,
            FA_TentArrowsDown,
            FA_Tents,
            FA_Terminal,
            FA_Tex,
            FA_TextHeight,
            FA_TextSlash,
            FA_TextWidth,
            FA_TheRedYeti,
            FA_Themeco,
            FA_Themeisle,
            FA_Thermometer,
            FA_ThinkPeaks,
            FA_Threads,
            FA_Threema,
            FA_ThumbsDown,
            FA_ThumbsUp,
            FA_Thumbtack,
            FA_ThumbtackSlash,
            FA_Ticket,
            FA_TicketSimple,
            FA_Tidal,
            FA_Tiktok,
            FA_Timeline,
            FA_ToggleOff,
            FA_ToggleOn,
            FA_Toilet,
            FA_ToiletPaper,
            FA_ToiletPaperSlash,
            FA_ToiletPortable,
            FA_ToiletsPortable,
            FA_Toolbox,
            FA_Tooth,
            FA_TorBrowser,
            FA_ToriiGate,
            FA_Tornado,
            FA_TowerBroadcast,
            FA_TowerCell,
            FA_TowerObservation,
            FA_Tractor,
            FA_TradeFederation,
            FA_Trademark,
            FA_TrafficLight,
            FA_Trailer,
            FA_Train,
            FA_TrainSubway,
            FA_TrainTram,
            FA_Transgender,
            FA_Trash,
            FA_TrashArrowUp,
            FA_TrashCan,
            FA_TrashCanArrowUp,
            FA_Tree,
            FA_TreeCity,
            FA_Trello,
            FA_TriangleExclamation,
            FA_Trophy,
            FA_Trowel,
            FA_TrowelBricks,
            FA_Truck,
            FA_TruckArrowRight,
            FA_TruckDroplet,
            FA_TruckFast,
            FA_TruckField,
            FA_TruckFieldUn,
            FA_TruckFront,
            FA_TruckMedical,
            FA_TruckMonster,
            FA_TruckMoving,
            FA_TruckPickup,
            FA_TruckPlane,
            FA_TruckRampBox,
            FA_Tty,
            FA_Tumblr,
            FA_TurkishLiraSign,
            FA_TurnDown,
            FA_TurnUp,
            FA_Tv,
            FA_Twitch,
            FA_Twitter,
            FA_Typescript,
            FA_Typo3,
            FA_U,
            FA_Uber,
            FA_Ubuntu,
            FA_Uikit,
            FA_Ultralytics,
            FA_UltralyticsHub,
            FA_UltralyticsYolo,
            FA_Umbraco,
            FA_Umbrella,
            FA_UmbrellaBeach,
            FA_Uncharted,
            FA_Underline,
            FA_Uniregistry,
            FA_Unison,
            FA_Unity,
            FA_UniversalAccess,
            FA_Unlock,
            FA_UnlockKeyhole,
            FA_UnrealEngine,
            FA_Unsplash,
            FA_Untappd,
            FA_UpDown,
            FA_UpDownLeftRight,
            FA_UpLong,
            FA_UpRightAndDownLeftFromCenter,
            FA_UpRightFromSquare,
            FA_Upload,
            FA_Ups,
            FA_Upwork,
            FA_Usb,
            FA_User,
            FA_UserAstronaut,
            FA_UserCheck,
            FA_UserClock,
            FA_UserDoctor,
            FA_UserGear,
            FA_UserGraduate,
            FA_UserGroup,
            FA_UserInjured,
            FA_UserLock,
            FA_UserMinus,
            FA_UserNinja,
            FA_UserNurse,
            FA_UserPen,
            FA_UserPlus,
            FA_UserSecret,
            FA_UserShield,
            FA_UserSlash,
            FA_UserTag,
            FA_UserTie,
            FA_UserXmark,
            FA_Users,
            FA_UsersBetweenLines,
            FA_UsersGear,
            FA_UsersLine,
            FA_UsersRays,
            FA_UsersRectangle,
            FA_UsersSlash,
            FA_UsersViewfinder,
            FA_Usps,
            FA_Ussunnah,
            FA_Utensils,
            FA_V,
            FA_Vaadin,
            FA_VanShuttle,
            FA_Vault,
            FA_Venmo,
            FA_VenmoV,
            FA_Venus,
            FA_VenusDouble,
            FA_VenusMars,
            FA_Vest,
            FA_VestPatches,
            FA_Viacoin,
            FA_Viadeo,
            FA_Vial,
            FA_VialCircleCheck,
            FA_VialVirus,
            FA_Vials,
            FA_Viber,
            FA_Video,
            FA_VideoSlash,
            FA_Vihara,
            FA_Vim,
            FA_Vimeo,
            FA_VimeoV,
            FA_Vine,
            FA_Virgo,
            FA_Virus,
            FA_VirusCovid,
            FA_VirusCovidSlash,
            FA_VirusSlash,
            FA_Viruses,
            FA_Vk,
            FA_Vnv,
            FA_Voicemail,
            FA_Volcano,
            FA_Volleyball,
            FA_Volume,
            FA_VolumeHigh,
            FA_VolumeLow,
            FA_VolumeOff,
            FA_VolumeXmark,
            FA_VrCardboard,
            FA_Vsco,
            FA_Vuejs,
            FA_W,
            FA_W3c,
            FA_WalkieTalkie,
            FA_Wallet,
            FA_WandMagic,
            FA_WandMagicSparkles,
            FA_WandSparkles,
            FA_Warehouse,
            FA_WatchmanMonitoring,
            FA_Water,
            FA_WaterLadder,
            FA_WaveSquare,
            FA_Waze,
            FA_WebAwesome,
            FA_Webflow,
            FA_Weebly,
            FA_Weibo,
            FA_WeightHanging,
            FA_WeightScale,
            FA_Weixin,
            FA_Whatsapp,
            FA_WheatAwn,
            FA_WheatAwnCircleExclamation,
            FA_Wheelchair,
            FA_WheelchairMove,
            FA_WhiskeyGlass,
            FA_Whmcs,
            FA_Wifi,
            FA_WikipediaW,
            FA_Wind,
            FA_WindowMaximize,
            FA_WindowMinimize,
            FA_WindowRestore,
            FA_Windows,
            FA_WineBottle,
            FA_WineGlass,
            FA_WineGlassEmpty,
            FA_Wirsindhandwerk,
            FA_Wix,
            FA_WizardsOfTheCoast,
            FA_Wodu,
            FA_WolfPackBattalion,
            FA_WonSign,
            FA_Wordpress,
            FA_WordpressSimple,
            FA_Worm,
            FA_Wpbeginner,
            FA_Wpexplorer,
            FA_Wpforms,
            FA_Wpressr,
            FA_Wrench,
            FA_X,
            FA_XRay,
            FA_XTwitter,
            FA_Xbox,
            FA_Xing,
            FA_Xmark,
            FA_XmarksLines,
            FA_Xmpp,
            FA_Y,
            FA_YCombinator,
            FA_Yahoo,
            FA_Yammer,
            FA_Yandex,
            FA_YandexInternational,
            FA_Yarn,
            FA_Yelp,
            FA_YenSign,
            FA_YinYang,
            FA_Yoast,
            FA_Youtube,
            FA_Z,
            FA_Zhihu,
            FA_Zoom,
            FA_Zulip,
        });
        
        public static IconData GetByLabel(string v) => v switch
        {
            "0" => FA_0,
            "1" => FA_1,
            "2" => FA_2,
            "3" => FA_3,
            "4" => FA_4,
            "5" => FA_5,
            "6" => FA_6,
            "7" => FA_7,
            "8" => FA_8,
            "9" => FA_9,
            "42 Group" => FA_42Group,
            "500px" => FA_500px,
            "A" => FA_A,
            "Accessible Icon" => FA_AccessibleIcon,
            "Accusoft" => FA_Accusoft,
            "Address Book" => FA_AddressBook,
            "Address Card" => FA_AddressCard,
            "Adn" => FA_Adn,
            "Adversal" => FA_Adversal,
            "Affiliatetheme" => FA_Affiliatetheme,
            "Airbnb" => FA_Airbnb,
            "Alarm Clock" => FA_AlarmClock,
            "Algolia" => FA_Algolia,
            "Align Center" => FA_AlignCenter,
            "Align Justify" => FA_AlignJustify,
            "Align Left" => FA_AlignLeft,
            "Align Right" => FA_AlignRight,
            "Alipay" => FA_Alipay,
            "Amazon" => FA_Amazon,
            "Amazon Pay" => FA_AmazonPay,
            "Amilia" => FA_Amilia,
            "Anchor" => FA_Anchor,
            "Anchor Circle Check" => FA_AnchorCircleCheck,
            "Anchor Circle Exclamation" => FA_AnchorCircleExclamation,
            "Anchor Circle Xmark" => FA_AnchorCircleXmark,
            "Anchor Lock" => FA_AnchorLock,
            "Android" => FA_Android,
            "Angellist" => FA_Angellist,
            "Angle Down" => FA_AngleDown,
            "Angle Left" => FA_AngleLeft,
            "Angle Right" => FA_AngleRight,
            "Angle Up" => FA_AngleUp,
            "Angles Down" => FA_AnglesDown,
            "Angles Left" => FA_AnglesLeft,
            "Angles Right" => FA_AnglesRight,
            "Angles Up" => FA_AnglesUp,
            "Angrycreative" => FA_Angrycreative,
            "Angular" => FA_Angular,
            "Ankh" => FA_Ankh,
            "App Store" => FA_AppStore,
            "App Store Ios" => FA_AppStoreIos,
            "Apper" => FA_Apper,
            "Apple" => FA_Apple,
            "Apple Pay" => FA_ApplePay,
            "Apple Whole" => FA_AppleWhole,
            "Aquarius" => FA_Aquarius,
            "Arch Linux" => FA_ArchLinux,
            "Archway" => FA_Archway,
            "Aries" => FA_Aries,
            "Arrow Down" => FA_ArrowDown,
            "Arrow Down 1 9" => FA_ArrowDown19,
            "Arrow Down 9 1" => FA_ArrowDown91,
            "Arrow Down A Z" => FA_ArrowDownAZ,
            "Arrow Down Long" => FA_ArrowDownLong,
            "Arrow Down Short Wide" => FA_ArrowDownShortWide,
            "Arrow Down Up Across Line" => FA_ArrowDownUpAcrossLine,
            "Arrow Down Up Lock" => FA_ArrowDownUpLock,
            "Arrow Down Wide Short" => FA_ArrowDownWideShort,
            "Arrow Down Z A" => FA_ArrowDownZA,
            "Arrow Left" => FA_ArrowLeft,
            "Arrow Left Long" => FA_ArrowLeftLong,
            "Arrow Pointer" => FA_ArrowPointer,
            "Arrow Right" => FA_ArrowRight,
            "Arrow Right Arrow Left" => FA_ArrowRightArrowLeft,
            "Arrow Right From Bracket" => FA_ArrowRightFromBracket,
            "Arrow Right Long" => FA_ArrowRightLong,
            "Arrow Right To Bracket" => FA_ArrowRightToBracket,
            "Arrow Right To City" => FA_ArrowRightToCity,
            "Arrow Rotate Left" => FA_ArrowRotateLeft,
            "Arrow Rotate Right" => FA_ArrowRotateRight,
            "Arrow Trend Down" => FA_ArrowTrendDown,
            "Arrow Trend Up" => FA_ArrowTrendUp,
            "Arrow Turn Down" => FA_ArrowTurnDown,
            "Arrow Turn Up" => FA_ArrowTurnUp,
            "Arrow Up" => FA_ArrowUp,
            "Arrow Up 1 9" => FA_ArrowUp19,
            "Arrow Up 9 1" => FA_ArrowUp91,
            "Arrow Up A Z" => FA_ArrowUpAZ,
            "Arrow Up From Bracket" => FA_ArrowUpFromBracket,
            "Arrow Up From Ground Water" => FA_ArrowUpFromGroundWater,
            "Arrow Up From Water Pump" => FA_ArrowUpFromWaterPump,
            "Arrow Up Long" => FA_ArrowUpLong,
            "Arrow Up Right Dots" => FA_ArrowUpRightDots,
            "Arrow Up Right From Square" => FA_ArrowUpRightFromSquare,
            "Arrow Up Short Wide" => FA_ArrowUpShortWide,
            "Arrow Up Wide Short" => FA_ArrowUpWideShort,
            "Arrow Up Z A" => FA_ArrowUpZA,
            "Arrows Down To Line" => FA_ArrowsDownToLine,
            "Arrows Down To People" => FA_ArrowsDownToPeople,
            "Arrows Left Right" => FA_ArrowsLeftRight,
            "Arrows Left Right To Line" => FA_ArrowsLeftRightToLine,
            "Arrows Rotate" => FA_ArrowsRotate,
            "Arrows Spin" => FA_ArrowsSpin,
            "Arrows Split Up And Left" => FA_ArrowsSplitUpAndLeft,
            "Arrows To Circle" => FA_ArrowsToCircle,
            "Arrows To Dot" => FA_ArrowsToDot,
            "Arrows To Eye" => FA_ArrowsToEye,
            "Arrows Turn Right" => FA_ArrowsTurnRight,
            "Arrows Turn To Dots" => FA_ArrowsTurnToDots,
            "Arrows Up Down" => FA_ArrowsUpDown,
            "Arrows Up Down Left Right" => FA_ArrowsUpDownLeftRight,
            "Arrows Up To Line" => FA_ArrowsUpToLine,
            "Artstation" => FA_Artstation,
            "Asterisk" => FA_Asterisk,
            "Asymmetrik" => FA_Asymmetrik,
            "At" => FA_At,
            "Atlassian" => FA_Atlassian,
            "Atom" => FA_Atom,
            "Audible" => FA_Audible,
            "Audio Description" => FA_AudioDescription,
            "Austral Sign" => FA_AustralSign,
            "Autoprefixer" => FA_Autoprefixer,
            "Avianex" => FA_Avianex,
            "Aviato" => FA_Aviato,
            "Award" => FA_Award,
            "Aws" => FA_Aws,
            "B" => FA_B,
            "Baby" => FA_Baby,
            "Baby Carriage" => FA_BabyCarriage,
            "Backward" => FA_Backward,
            "Backward Fast" => FA_BackwardFast,
            "Backward Step" => FA_BackwardStep,
            "Bacon" => FA_Bacon,
            "Bacteria" => FA_Bacteria,
            "Bacterium" => FA_Bacterium,
            "Bag Shopping" => FA_BagShopping,
            "Bahai" => FA_Bahai,
            "Baht Sign" => FA_BahtSign,
            "Ban" => FA_Ban,
            "Ban Smoking" => FA_BanSmoking,
            "Bandage" => FA_Bandage,
            "Bandcamp" => FA_Bandcamp,
            "Bangladeshi Taka Sign" => FA_BangladeshiTakaSign,
            "Barcode" => FA_Barcode,
            "Bars" => FA_Bars,
            "Bars Progress" => FA_BarsProgress,
            "Bars Staggered" => FA_BarsStaggered,
            "Baseball" => FA_Baseball,
            "Baseball Bat Ball" => FA_BaseballBatBall,
            "Basket Shopping" => FA_BasketShopping,
            "Basketball" => FA_Basketball,
            "Bath" => FA_Bath,
            "Battery Empty" => FA_BatteryEmpty,
            "Battery Full" => FA_BatteryFull,
            "Battery Half" => FA_BatteryHalf,
            "Battery Quarter" => FA_BatteryQuarter,
            "Battery Three Quarters" => FA_BatteryThreeQuarters,
            "Battle Net" => FA_BattleNet,
            "Bed" => FA_Bed,
            "Bed Pulse" => FA_BedPulse,
            "Beer Mug Empty" => FA_BeerMugEmpty,
            "Behance" => FA_Behance,
            "Bell" => FA_Bell,
            "Bell Concierge" => FA_BellConcierge,
            "Bell Slash" => FA_BellSlash,
            "Bezier Curve" => FA_BezierCurve,
            "Bicycle" => FA_Bicycle,
            "Bilibili" => FA_Bilibili,
            "Bimobject" => FA_Bimobject,
            "Binoculars" => FA_Binoculars,
            "Biohazard" => FA_Biohazard,
            "Bitbucket" => FA_Bitbucket,
            "Bitcoin" => FA_Bitcoin,
            "Bitcoin Sign" => FA_BitcoinSign,
            "Bity" => FA_Bity,
            "Black Tie" => FA_BlackTie,
            "Blackberry" => FA_Blackberry,
            "Blender" => FA_Blender,
            "Blender Phone" => FA_BlenderPhone,
            "Blog" => FA_Blog,
            "Blogger" => FA_Blogger,
            "Blogger B" => FA_BloggerB,
            "Bluesky" => FA_Bluesky,
            "Bluetooth" => FA_Bluetooth,
            "Bluetooth B" => FA_BluetoothB,
            "Board Game Geek" => FA_BoardGameGeek,
            "Bold" => FA_Bold,
            "Bolt" => FA_Bolt,
            "Bolt Lightning" => FA_BoltLightning,
            "Bomb" => FA_Bomb,
            "Bone" => FA_Bone,
            "Bong" => FA_Bong,
            "Book" => FA_Book,
            "Book Atlas" => FA_BookAtlas,
            "Book Bible" => FA_BookBible,
            "Book Bookmark" => FA_BookBookmark,
            "Book Journal Whills" => FA_BookJournalWhills,
            "Book Medical" => FA_BookMedical,
            "Book Open" => FA_BookOpen,
            "Book Open Reader" => FA_BookOpenReader,
            "Book Quran" => FA_BookQuran,
            "Book Skull" => FA_BookSkull,
            "Book Tanakh" => FA_BookTanakh,
            "Bookmark" => FA_Bookmark,
            "Bootstrap" => FA_Bootstrap,
            "Border All" => FA_BorderAll,
            "Border None" => FA_BorderNone,
            "Border Top Left" => FA_BorderTopLeft,
            "Bore Hole" => FA_BoreHole,
            "Bots" => FA_Bots,
            "Bottle Droplet" => FA_BottleDroplet,
            "Bottle Water" => FA_BottleWater,
            "Bowl Food" => FA_BowlFood,
            "Bowl Rice" => FA_BowlRice,
            "Bowling Ball" => FA_BowlingBall,
            "Box" => FA_Box,
            "Box Archive" => FA_BoxArchive,
            "Box Open" => FA_BoxOpen,
            "Box Tissue" => FA_BoxTissue,
            "Boxes Packing" => FA_BoxesPacking,
            "Boxes Stacked" => FA_BoxesStacked,
            "Braille" => FA_Braille,
            "Brain" => FA_Brain,
            "Brave" => FA_Brave,
            "Brave Reverse" => FA_BraveReverse,
            "Brazilian Real Sign" => FA_BrazilianRealSign,
            "Bread Slice" => FA_BreadSlice,
            "Bridge" => FA_Bridge,
            "Bridge Circle Check" => FA_BridgeCircleCheck,
            "Bridge Circle Exclamation" => FA_BridgeCircleExclamation,
            "Bridge Circle Xmark" => FA_BridgeCircleXmark,
            "Bridge Lock" => FA_BridgeLock,
            "Bridge Water" => FA_BridgeWater,
            "Briefcase" => FA_Briefcase,
            "Briefcase Medical" => FA_BriefcaseMedical,
            "Broom" => FA_Broom,
            "Broom Ball" => FA_BroomBall,
            "Brush" => FA_Brush,
            "Btc" => FA_Btc,
            "Bucket" => FA_Bucket,
            "Buffer" => FA_Buffer,
            "Bug" => FA_Bug,
            "Bug Slash" => FA_BugSlash,
            "Bugs" => FA_Bugs,
            "Building" => FA_Building,
            "Building Circle Arrow Right" => FA_BuildingCircleArrowRight,
            "Building Circle Check" => FA_BuildingCircleCheck,
            "Building Circle Exclamation" => FA_BuildingCircleExclamation,
            "Building Circle Xmark" => FA_BuildingCircleXmark,
            "Building Columns" => FA_BuildingColumns,
            "Building Flag" => FA_BuildingFlag,
            "Building Lock" => FA_BuildingLock,
            "Building Ngo" => FA_BuildingNgo,
            "Building Shield" => FA_BuildingShield,
            "Building Un" => FA_BuildingUn,
            "Building User" => FA_BuildingUser,
            "Building Wheat" => FA_BuildingWheat,
            "Bullhorn" => FA_Bullhorn,
            "Bullseye" => FA_Bullseye,
            "Burger" => FA_Burger,
            "Buromobelexperte" => FA_Buromobelexperte,
            "Burst" => FA_Burst,
            "Bus" => FA_Bus,
            "Bus Side" => FA_BusSide,
            "Bus Simple" => FA_BusSimple,
            "Business Time" => FA_BusinessTime,
            "Buy N Large" => FA_BuyNLarge,
            "Buysellads" => FA_Buysellads,
            "C" => FA_C,
            "Cable Car" => FA_CableCar,
            "Cake Candles" => FA_CakeCandles,
            "Calculator" => FA_Calculator,
            "Calendar" => FA_Calendar,
            "Calendar Check" => FA_CalendarCheck,
            "Calendar Day" => FA_CalendarDay,
            "Calendar Days" => FA_CalendarDays,
            "Calendar Minus" => FA_CalendarMinus,
            "Calendar Plus" => FA_CalendarPlus,
            "Calendar Week" => FA_CalendarWeek,
            "Calendar Xmark" => FA_CalendarXmark,
            "Camera" => FA_Camera,
            "Camera Retro" => FA_CameraRetro,
            "Camera Rotate" => FA_CameraRotate,
            "Campground" => FA_Campground,
            "Canadian Maple Leaf" => FA_CanadianMapleLeaf,
            "Cancer" => FA_Cancer,
            "Candy Cane" => FA_CandyCane,
            "Cannabis" => FA_Cannabis,
            "Capricorn" => FA_Capricorn,
            "Capsules" => FA_Capsules,
            "Car" => FA_Car,
            "Car Battery" => FA_CarBattery,
            "Car Burst" => FA_CarBurst,
            "Car On" => FA_CarOn,
            "Car Rear" => FA_CarRear,
            "Car Side" => FA_CarSide,
            "Car Tunnel" => FA_CarTunnel,
            "Caravan" => FA_Caravan,
            "Caret Down" => FA_CaretDown,
            "Caret Left" => FA_CaretLeft,
            "Caret Right" => FA_CaretRight,
            "Caret Up" => FA_CaretUp,
            "Carrot" => FA_Carrot,
            "Cart Arrow Down" => FA_CartArrowDown,
            "Cart Flatbed" => FA_CartFlatbed,
            "Cart Flatbed Suitcase" => FA_CartFlatbedSuitcase,
            "Cart Plus" => FA_CartPlus,
            "Cart Shopping" => FA_CartShopping,
            "Cash App" => FA_CashApp,
            "Cash Register" => FA_CashRegister,
            "Cat" => FA_Cat,
            "Cc Amazon Pay" => FA_CcAmazonPay,
            "Cc Amex" => FA_CcAmex,
            "Cc Apple Pay" => FA_CcApplePay,
            "Cc Diners Club" => FA_CcDinersClub,
            "Cc Discover" => FA_CcDiscover,
            "Cc Jcb" => FA_CcJcb,
            "Cc Mastercard" => FA_CcMastercard,
            "Cc Paypal" => FA_CcPaypal,
            "Cc Stripe" => FA_CcStripe,
            "Cc Visa" => FA_CcVisa,
            "Cedi Sign" => FA_CediSign,
            "Cent Sign" => FA_CentSign,
            "Centercode" => FA_Centercode,
            "Centos" => FA_Centos,
            "Certificate" => FA_Certificate,
            "Chair" => FA_Chair,
            "Chalkboard" => FA_Chalkboard,
            "Chalkboard User" => FA_ChalkboardUser,
            "Champagne Glasses" => FA_ChampagneGlasses,
            "Charging Station" => FA_ChargingStation,
            "Chart Area" => FA_ChartArea,
            "Chart Bar" => FA_ChartBar,
            "Chart Column" => FA_ChartColumn,
            "Chart Diagram" => FA_ChartDiagram,
            "Chart Gantt" => FA_ChartGantt,
            "Chart Line" => FA_ChartLine,
            "Chart Pie" => FA_ChartPie,
            "Chart Simple" => FA_ChartSimple,
            "Check" => FA_Check,
            "Check Double" => FA_CheckDouble,
            "Check To Slot" => FA_CheckToSlot,
            "Cheese" => FA_Cheese,
            "Chess" => FA_Chess,
            "Chess Bishop" => FA_ChessBishop,
            "Chess Board" => FA_ChessBoard,
            "Chess King" => FA_ChessKing,
            "Chess Knight" => FA_ChessKnight,
            "Chess Pawn" => FA_ChessPawn,
            "Chess Queen" => FA_ChessQueen,
            "Chess Rook" => FA_ChessRook,
            "Chevron Down" => FA_ChevronDown,
            "Chevron Left" => FA_ChevronLeft,
            "Chevron Right" => FA_ChevronRight,
            "Chevron Up" => FA_ChevronUp,
            "Child" => FA_Child,
            "Child Combatant" => FA_ChildCombatant,
            "Child Dress" => FA_ChildDress,
            "Child Reaching" => FA_ChildReaching,
            "Children" => FA_Children,
            "Chrome" => FA_Chrome,
            "Chromecast" => FA_Chromecast,
            "Church" => FA_Church,
            "Circle" => FA_Circle,
            "Circle Arrow Down" => FA_CircleArrowDown,
            "Circle Arrow Left" => FA_CircleArrowLeft,
            "Circle Arrow Right" => FA_CircleArrowRight,
            "Circle Arrow Up" => FA_CircleArrowUp,
            "Circle Check" => FA_CircleCheck,
            "Circle Chevron Down" => FA_CircleChevronDown,
            "Circle Chevron Left" => FA_CircleChevronLeft,
            "Circle Chevron Right" => FA_CircleChevronRight,
            "Circle Chevron Up" => FA_CircleChevronUp,
            "Circle Dollar To Slot" => FA_CircleDollarToSlot,
            "Circle Dot" => FA_CircleDot,
            "Circle Down" => FA_CircleDown,
            "Circle Exclamation" => FA_CircleExclamation,
            "Circle H" => FA_CircleH,
            "Circle Half Stroke" => FA_CircleHalfStroke,
            "Circle Info" => FA_CircleInfo,
            "Circle Left" => FA_CircleLeft,
            "Circle Minus" => FA_CircleMinus,
            "Circle Nodes" => FA_CircleNodes,
            "Circle Notch" => FA_CircleNotch,
            "Circle Pause" => FA_CirclePause,
            "Circle Play" => FA_CirclePlay,
            "Circle Plus" => FA_CirclePlus,
            "Circle Question" => FA_CircleQuestion,
            "Circle Radiation" => FA_CircleRadiation,
            "Circle Right" => FA_CircleRight,
            "Circle Stop" => FA_CircleStop,
            "Circle Up" => FA_CircleUp,
            "Circle User" => FA_CircleUser,
            "Circle Xmark" => FA_CircleXmark,
            "Circle Zulip" => FA_CircleZulip,
            "City" => FA_City,
            "Clapperboard" => FA_Clapperboard,
            "Claude" => FA_Claude,
            "Clipboard" => FA_Clipboard,
            "Clipboard Check" => FA_ClipboardCheck,
            "Clipboard List" => FA_ClipboardList,
            "Clipboard Question" => FA_ClipboardQuestion,
            "Clipboard User" => FA_ClipboardUser,
            "Clock" => FA_Clock,
            "Clock Rotate Left" => FA_ClockRotateLeft,
            "Clone" => FA_Clone,
            "Closed Captioning" => FA_ClosedCaptioning,
            "Closed Captioning Slash" => FA_ClosedCaptioningSlash,
            "Cloud" => FA_Cloud,
            "Cloud Arrow Down" => FA_CloudArrowDown,
            "Cloud Arrow Up" => FA_CloudArrowUp,
            "Cloud Bolt" => FA_CloudBolt,
            "Cloud Meatball" => FA_CloudMeatball,
            "Cloud Moon" => FA_CloudMoon,
            "Cloud Moon Rain" => FA_CloudMoonRain,
            "Cloud Rain" => FA_CloudRain,
            "Cloud Showers Heavy" => FA_CloudShowersHeavy,
            "Cloud Showers Water" => FA_CloudShowersWater,
            "Cloud Sun" => FA_CloudSun,
            "Cloud Sun Rain" => FA_CloudSunRain,
            "Cloudflare" => FA_Cloudflare,
            "Cloudscale" => FA_Cloudscale,
            "Cloudsmith" => FA_Cloudsmith,
            "Cloudversify" => FA_Cloudversify,
            "Clover" => FA_Clover,
            "Cmplid" => FA_Cmplid,
            "Code" => FA_Code,
            "Code Branch" => FA_CodeBranch,
            "Code Commit" => FA_CodeCommit,
            "Code Compare" => FA_CodeCompare,
            "Code Fork" => FA_CodeFork,
            "Code Merge" => FA_CodeMerge,
            "Code Pull Request" => FA_CodePullRequest,
            "Codepen" => FA_Codepen,
            "Codiepie" => FA_Codiepie,
            "Coins" => FA_Coins,
            "Colon Sign" => FA_ColonSign,
            "Comment" => FA_Comment,
            "Comment Dollar" => FA_CommentDollar,
            "Comment Dots" => FA_CommentDots,
            "Comment Medical" => FA_CommentMedical,
            "Comment Nodes" => FA_CommentNodes,
            "Comment Slash" => FA_CommentSlash,
            "Comment Sms" => FA_CommentSms,
            "Comments" => FA_Comments,
            "Comments Dollar" => FA_CommentsDollar,
            "Compact Disc" => FA_CompactDisc,
            "Compass" => FA_Compass,
            "Compass Drafting" => FA_CompassDrafting,
            "Compress" => FA_Compress,
            "Computer" => FA_Computer,
            "Computer Mouse" => FA_ComputerMouse,
            "Confluence" => FA_Confluence,
            "Connectdevelop" => FA_Connectdevelop,
            "Contao" => FA_Contao,
            "Cookie" => FA_Cookie,
            "Cookie Bite" => FA_CookieBite,
            "Copy" => FA_Copy,
            "Copyright" => FA_Copyright,
            "Cotton Bureau" => FA_CottonBureau,
            "Couch" => FA_Couch,
            "Cow" => FA_Cow,
            "Cpanel" => FA_Cpanel,
            "Creative Commons" => FA_CreativeCommons,
            "Creative Commons By" => FA_CreativeCommonsBy,
            "Creative Commons Nc" => FA_CreativeCommonsNc,
            "Creative Commons Nc Eu" => FA_CreativeCommonsNcEu,
            "Creative Commons Nc Jp" => FA_CreativeCommonsNcJp,
            "Creative Commons Nd" => FA_CreativeCommonsNd,
            "Creative Commons Pd" => FA_CreativeCommonsPd,
            "Creative Commons Pd Alt" => FA_CreativeCommonsPdAlt,
            "Creative Commons Remix" => FA_CreativeCommonsRemix,
            "Creative Commons Sa" => FA_CreativeCommonsSa,
            "Creative Commons Sampling" => FA_CreativeCommonsSampling,
            "Creative Commons Sampling Plus" => FA_CreativeCommonsSamplingPlus,
            "Creative Commons Share" => FA_CreativeCommonsShare,
            "Creative Commons Zero" => FA_CreativeCommonsZero,
            "Credit Card" => FA_CreditCard,
            "Critical Role" => FA_CriticalRole,
            "Crop" => FA_Crop,
            "Crop Simple" => FA_CropSimple,
            "Cross" => FA_Cross,
            "Crosshairs" => FA_Crosshairs,
            "Crow" => FA_Crow,
            "Crown" => FA_Crown,
            "Crutch" => FA_Crutch,
            "Cruzeiro Sign" => FA_CruzeiroSign,
            "Css" => FA_Css,
            "Css3" => FA_Css3,
            "Css3 Alt" => FA_Css3Alt,
            "Cube" => FA_Cube,
            "Cubes" => FA_Cubes,
            "Cubes Stacked" => FA_CubesStacked,
            "Cuttlefish" => FA_Cuttlefish,
            "D" => FA_D,
            "D And D" => FA_DAndD,
            "D And D Beyond" => FA_DAndDBeyond,
            "Dailymotion" => FA_Dailymotion,
            "Dart Lang" => FA_DartLang,
            "Dashcube" => FA_Dashcube,
            "Database" => FA_Database,
            "Debian" => FA_Debian,
            "Deezer" => FA_Deezer,
            "Delete Left" => FA_DeleteLeft,
            "Delicious" => FA_Delicious,
            "Democrat" => FA_Democrat,
            "Deploydog" => FA_Deploydog,
            "Deskpro" => FA_Deskpro,
            "Desktop" => FA_Desktop,
            "Dev" => FA_Dev,
            "Deviantart" => FA_Deviantart,
            "Dharmachakra" => FA_Dharmachakra,
            "Dhl" => FA_Dhl,
            "Diagram Next" => FA_DiagramNext,
            "Diagram Predecessor" => FA_DiagramPredecessor,
            "Diagram Project" => FA_DiagramProject,
            "Diagram Successor" => FA_DiagramSuccessor,
            "Diamond" => FA_Diamond,
            "Diamond Turn Right" => FA_DiamondTurnRight,
            "Diaspora" => FA_Diaspora,
            "Dice" => FA_Dice,
            "Dice D20" => FA_DiceD20,
            "Dice D6" => FA_DiceD6,
            "Dice Five" => FA_DiceFive,
            "Dice Four" => FA_DiceFour,
            "Dice One" => FA_DiceOne,
            "Dice Six" => FA_DiceSix,
            "Dice Three" => FA_DiceThree,
            "Dice Two" => FA_DiceTwo,
            "Digg" => FA_Digg,
            "Digital Ocean" => FA_DigitalOcean,
            "Discord" => FA_Discord,
            "Discourse" => FA_Discourse,
            "Disease" => FA_Disease,
            "Display" => FA_Display,
            "Disqus" => FA_Disqus,
            "Divide" => FA_Divide,
            "Dna" => FA_Dna,
            "Dochub" => FA_Dochub,
            "Docker" => FA_Docker,
            "Dog" => FA_Dog,
            "Dollar Sign" => FA_DollarSign,
            "Dolly" => FA_Dolly,
            "Dong Sign" => FA_DongSign,
            "Door Closed" => FA_DoorClosed,
            "Door Open" => FA_DoorOpen,
            "Dove" => FA_Dove,
            "Down Left And Up Right To Center" => FA_DownLeftAndUpRightToCenter,
            "Down Long" => FA_DownLong,
            "Download" => FA_Download,
            "Draft2digital" => FA_Draft2digital,
            "Dragon" => FA_Dragon,
            "Draw Polygon" => FA_DrawPolygon,
            "Dribbble" => FA_Dribbble,
            "Dropbox" => FA_Dropbox,
            "Droplet" => FA_Droplet,
            "Droplet Slash" => FA_DropletSlash,
            "Drum" => FA_Drum,
            "Drum Steelpan" => FA_DrumSteelpan,
            "Drumstick Bite" => FA_DrumstickBite,
            "Drupal" => FA_Drupal,
            "Dumbbell" => FA_Dumbbell,
            "Dumpster" => FA_Dumpster,
            "Dumpster Fire" => FA_DumpsterFire,
            "Dungeon" => FA_Dungeon,
            "Duolingo" => FA_Duolingo,
            "Dyalog" => FA_Dyalog,
            "E" => FA_E,
            "Ear Deaf" => FA_EarDeaf,
            "Ear Listen" => FA_EarListen,
            "Earlybirds" => FA_Earlybirds,
            "Earth Africa" => FA_EarthAfrica,
            "Earth Americas" => FA_EarthAmericas,
            "Earth Asia" => FA_EarthAsia,
            "Earth Europe" => FA_EarthEurope,
            "Earth Oceania" => FA_EarthOceania,
            "Ebay" => FA_Ebay,
            "Edge" => FA_Edge,
            "Edge Legacy" => FA_EdgeLegacy,
            "Egg" => FA_Egg,
            "Eject" => FA_Eject,
            "Elementor" => FA_Elementor,
            "Elevator" => FA_Elevator,
            "Eleventy" => FA_Eleventy,
            "Ellipsis" => FA_Ellipsis,
            "Ellipsis Vertical" => FA_EllipsisVertical,
            "Ello" => FA_Ello,
            "Ember" => FA_Ember,
            "Empire" => FA_Empire,
            "Envelope" => FA_Envelope,
            "Envelope Circle Check" => FA_EnvelopeCircleCheck,
            "Envelope Open" => FA_EnvelopeOpen,
            "Envelope Open Text" => FA_EnvelopeOpenText,
            "Envelopes Bulk" => FA_EnvelopesBulk,
            "Envira" => FA_Envira,
            "Equals" => FA_Equals,
            "Eraser" => FA_Eraser,
            "Erlang" => FA_Erlang,
            "Ethereum" => FA_Ethereum,
            "Ethernet" => FA_Ethernet,
            "Etsy" => FA_Etsy,
            "Euro Sign" => FA_EuroSign,
            "Evernote" => FA_Evernote,
            "Exclamation" => FA_Exclamation,
            "Expand" => FA_Expand,
            "Expeditedssl" => FA_Expeditedssl,
            "Explosion" => FA_Explosion,
            "Eye" => FA_Eye,
            "Eye Dropper" => FA_EyeDropper,
            "Eye Low Vision" => FA_EyeLowVision,
            "Eye Slash" => FA_EyeSlash,
            "F" => FA_F,
            "Face Angry" => FA_FaceAngry,
            "Face Dizzy" => FA_FaceDizzy,
            "Face Flushed" => FA_FaceFlushed,
            "Face Frown" => FA_FaceFrown,
            "Face Frown Open" => FA_FaceFrownOpen,
            "Face Grimace" => FA_FaceGrimace,
            "Face Grin" => FA_FaceGrin,
            "Face Grin Beam" => FA_FaceGrinBeam,
            "Face Grin Beam Sweat" => FA_FaceGrinBeamSweat,
            "Face Grin Hearts" => FA_FaceGrinHearts,
            "Face Grin Squint" => FA_FaceGrinSquint,
            "Face Grin Squint Tears" => FA_FaceGrinSquintTears,
            "Face Grin Stars" => FA_FaceGrinStars,
            "Face Grin Tears" => FA_FaceGrinTears,
            "Face Grin Tongue" => FA_FaceGrinTongue,
            "Face Grin Tongue Squint" => FA_FaceGrinTongueSquint,
            "Face Grin Tongue Wink" => FA_FaceGrinTongueWink,
            "Face Grin Wide" => FA_FaceGrinWide,
            "Face Grin Wink" => FA_FaceGrinWink,
            "Face Kiss" => FA_FaceKiss,
            "Face Kiss Beam" => FA_FaceKissBeam,
            "Face Kiss Wink Heart" => FA_FaceKissWinkHeart,
            "Face Laugh" => FA_FaceLaugh,
            "Face Laugh Beam" => FA_FaceLaughBeam,
            "Face Laugh Squint" => FA_FaceLaughSquint,
            "Face Laugh Wink" => FA_FaceLaughWink,
            "Face Meh" => FA_FaceMeh,
            "Face Meh Blank" => FA_FaceMehBlank,
            "Face Rolling Eyes" => FA_FaceRollingEyes,
            "Face Sad Cry" => FA_FaceSadCry,
            "Face Sad Tear" => FA_FaceSadTear,
            "Face Smile" => FA_FaceSmile,
            "Face Smile Beam" => FA_FaceSmileBeam,
            "Face Smile Wink" => FA_FaceSmileWink,
            "Face Surprise" => FA_FaceSurprise,
            "Face Tired" => FA_FaceTired,
            "Facebook" => FA_Facebook,
            "Facebook F" => FA_FacebookF,
            "Facebook Messenger" => FA_FacebookMessenger,
            "Fan" => FA_Fan,
            "Fantasy Flight Games" => FA_FantasyFlightGames,
            "Faucet" => FA_Faucet,
            "Faucet Drip" => FA_FaucetDrip,
            "Fax" => FA_Fax,
            "Feather" => FA_Feather,
            "Feather Pointed" => FA_FeatherPointed,
            "Fedex" => FA_Fedex,
            "Fediverse" => FA_Fediverse,
            "Fedora" => FA_Fedora,
            "Ferry" => FA_Ferry,
            "Figma" => FA_Figma,
            "File" => FA_File,
            "File Arrow Down" => FA_FileArrowDown,
            "File Arrow Up" => FA_FileArrowUp,
            "File Audio" => FA_FileAudio,
            "File Circle Check" => FA_FileCircleCheck,
            "File Circle Exclamation" => FA_FileCircleExclamation,
            "File Circle Minus" => FA_FileCircleMinus,
            "File Circle Plus" => FA_FileCirclePlus,
            "File Circle Question" => FA_FileCircleQuestion,
            "File Circle Xmark" => FA_FileCircleXmark,
            "File Code" => FA_FileCode,
            "File Contract" => FA_FileContract,
            "File Csv" => FA_FileCsv,
            "File Excel" => FA_FileExcel,
            "File Export" => FA_FileExport,
            "File Fragment" => FA_FileFragment,
            "File Half Dashed" => FA_FileHalfDashed,
            "File Image" => FA_FileImage,
            "File Import" => FA_FileImport,
            "File Invoice" => FA_FileInvoice,
            "File Invoice Dollar" => FA_FileInvoiceDollar,
            "File Lines" => FA_FileLines,
            "File Medical" => FA_FileMedical,
            "File Pdf" => FA_FilePdf,
            "File Pen" => FA_FilePen,
            "File Powerpoint" => FA_FilePowerpoint,
            "File Prescription" => FA_FilePrescription,
            "File Shield" => FA_FileShield,
            "File Signature" => FA_FileSignature,
            "File Video" => FA_FileVideo,
            "File Waveform" => FA_FileWaveform,
            "File Word" => FA_FileWord,
            "File Zipper" => FA_FileZipper,
            "Files Pinwheel" => FA_FilesPinwheel,
            "Fill" => FA_Fill,
            "Fill Drip" => FA_FillDrip,
            "Film" => FA_Film,
            "Filter" => FA_Filter,
            "Filter Circle Dollar" => FA_FilterCircleDollar,
            "Filter Circle Xmark" => FA_FilterCircleXmark,
            "Fingerprint" => FA_Fingerprint,
            "Fire" => FA_Fire,
            "Fire Burner" => FA_FireBurner,
            "Fire Extinguisher" => FA_FireExtinguisher,
            "Fire Flame Curved" => FA_FireFlameCurved,
            "Fire Flame Simple" => FA_FireFlameSimple,
            "Firefox" => FA_Firefox,
            "Firefox Browser" => FA_FirefoxBrowser,
            "First Order" => FA_FirstOrder,
            "First Order Alt" => FA_FirstOrderAlt,
            "Firstdraft" => FA_Firstdraft,
            "Fish" => FA_Fish,
            "Fish Fins" => FA_FishFins,
            "Flag" => FA_Flag,
            "Flag Checkered" => FA_FlagCheckered,
            "Flag Usa" => FA_FlagUsa,
            "Flask" => FA_Flask,
            "Flask Vial" => FA_FlaskVial,
            "Flickr" => FA_Flickr,
            "Flipboard" => FA_Flipboard,
            "Floppy Disk" => FA_FloppyDisk,
            "Florin Sign" => FA_FlorinSign,
            "Flutter" => FA_Flutter,
            "Fly" => FA_Fly,
            "Folder" => FA_Folder,
            "Folder Closed" => FA_FolderClosed,
            "Folder Minus" => FA_FolderMinus,
            "Folder Open" => FA_FolderOpen,
            "Folder Plus" => FA_FolderPlus,
            "Folder Tree" => FA_FolderTree,
            "Font" => FA_Font,
            "Font Awesome" => FA_FontAwesome,
            "Fonticons" => FA_Fonticons,
            "Fonticons Fi" => FA_FonticonsFi,
            "Football" => FA_Football,
            "Forgejo" => FA_Forgejo,
            "Fort Awesome" => FA_FortAwesome,
            "Fort Awesome Alt" => FA_FortAwesomeAlt,
            "Forumbee" => FA_Forumbee,
            "Forward" => FA_Forward,
            "Forward Fast" => FA_ForwardFast,
            "Forward Step" => FA_ForwardStep,
            "Foursquare" => FA_Foursquare,
            "Franc Sign" => FA_FrancSign,
            "Free Code Camp" => FA_FreeCodeCamp,
            "Freebsd" => FA_Freebsd,
            "Frog" => FA_Frog,
            "Fulcrum" => FA_Fulcrum,
            "Futbol" => FA_Futbol,
            "G" => FA_G,
            "Galactic Republic" => FA_GalacticRepublic,
            "Galactic Senate" => FA_GalacticSenate,
            "Gamepad" => FA_Gamepad,
            "Gas Pump" => FA_GasPump,
            "Gauge" => FA_Gauge,
            "Gauge High" => FA_GaugeHigh,
            "Gauge Simple" => FA_GaugeSimple,
            "Gauge Simple High" => FA_GaugeSimpleHigh,
            "Gavel" => FA_Gavel,
            "Gear" => FA_Gear,
            "Gears" => FA_Gears,
            "Gem" => FA_Gem,
            "Gemini" => FA_Gemini,
            "Genderless" => FA_Genderless,
            "Get Pocket" => FA_GetPocket,
            "Gg" => FA_Gg,
            "Gg Circle" => FA_GgCircle,
            "Ghost" => FA_Ghost,
            "Gift" => FA_Gift,
            "Gifts" => FA_Gifts,
            "Git" => FA_Git,
            "Git Alt" => FA_GitAlt,
            "Gitee" => FA_Gitee,
            "Github" => FA_Github,
            "Github Alt" => FA_GithubAlt,
            "Gitkraken" => FA_Gitkraken,
            "Gitlab" => FA_Gitlab,
            "Gitter" => FA_Gitter,
            "Glass Water" => FA_GlassWater,
            "Glass Water Droplet" => FA_GlassWaterDroplet,
            "Glasses" => FA_Glasses,
            "Glide" => FA_Glide,
            "Glide G" => FA_GlideG,
            "Globaleaks" => FA_Globaleaks,
            "Globe" => FA_Globe,
            "Gofore" => FA_Gofore,
            "Golang" => FA_Golang,
            "Golf Ball Tee" => FA_GolfBallTee,
            "Goodreads" => FA_Goodreads,
            "Goodreads G" => FA_GoodreadsG,
            "Google" => FA_Google,
            "Google Drive" => FA_GoogleDrive,
            "Google Pay" => FA_GooglePay,
            "Google Play" => FA_GooglePlay,
            "Google Plus" => FA_GooglePlus,
            "Google Plus G" => FA_GooglePlusG,
            "Google Scholar" => FA_GoogleScholar,
            "Google Wallet" => FA_GoogleWallet,
            "Gopuram" => FA_Gopuram,
            "Graduation Cap" => FA_GraduationCap,
            "Gratipay" => FA_Gratipay,
            "Grav" => FA_Grav,
            "Greater Than" => FA_GreaterThan,
            "Greater Than Equal" => FA_GreaterThanEqual,
            "Grip" => FA_Grip,
            "Grip Lines" => FA_GripLines,
            "Grip Lines Vertical" => FA_GripLinesVertical,
            "Grip Vertical" => FA_GripVertical,
            "Gripfire" => FA_Gripfire,
            "Group Arrows Rotate" => FA_GroupArrowsRotate,
            "Grunt" => FA_Grunt,
            "Guarani Sign" => FA_GuaraniSign,
            "Guilded" => FA_Guilded,
            "Guitar" => FA_Guitar,
            "Gulp" => FA_Gulp,
            "Gun" => FA_Gun,
            "H" => FA_H,
            "Hacker News" => FA_HackerNews,
            "Hackerrank" => FA_Hackerrank,
            "Hammer" => FA_Hammer,
            "Hamsa" => FA_Hamsa,
            "Hand" => FA_Hand,
            "Hand Back Fist" => FA_HandBackFist,
            "Hand Dots" => FA_HandDots,
            "Hand Fist" => FA_HandFist,
            "Hand Holding" => FA_HandHolding,
            "Hand Holding Dollar" => FA_HandHoldingDollar,
            "Hand Holding Droplet" => FA_HandHoldingDroplet,
            "Hand Holding Hand" => FA_HandHoldingHand,
            "Hand Holding Heart" => FA_HandHoldingHeart,
            "Hand Holding Medical" => FA_HandHoldingMedical,
            "Hand Lizard" => FA_HandLizard,
            "Hand Middle Finger" => FA_HandMiddleFinger,
            "Hand Peace" => FA_HandPeace,
            "Hand Point Down" => FA_HandPointDown,
            "Hand Point Left" => FA_HandPointLeft,
            "Hand Point Right" => FA_HandPointRight,
            "Hand Point Up" => FA_HandPointUp,
            "Hand Pointer" => FA_HandPointer,
            "Hand Scissors" => FA_HandScissors,
            "Hand Sparkles" => FA_HandSparkles,
            "Hand Spock" => FA_HandSpock,
            "Handcuffs" => FA_Handcuffs,
            "Hands" => FA_Hands,
            "Hands Asl Interpreting" => FA_HandsAslInterpreting,
            "Hands Bound" => FA_HandsBound,
            "Hands Bubbles" => FA_HandsBubbles,
            "Hands Clapping" => FA_HandsClapping,
            "Hands Holding" => FA_HandsHolding,
            "Hands Holding Child" => FA_HandsHoldingChild,
            "Hands Holding Circle" => FA_HandsHoldingCircle,
            "Hands Praying" => FA_HandsPraying,
            "Handshake" => FA_Handshake,
            "Handshake Angle" => FA_HandshakeAngle,
            "Handshake Slash" => FA_HandshakeSlash,
            "Hanukiah" => FA_Hanukiah,
            "Hard Drive" => FA_HardDrive,
            "Hashnode" => FA_Hashnode,
            "Hashtag" => FA_Hashtag,
            "Hat Cowboy" => FA_HatCowboy,
            "Hat Cowboy Side" => FA_HatCowboySide,
            "Hat Wizard" => FA_HatWizard,
            "Head Side Cough" => FA_HeadSideCough,
            "Head Side Cough Slash" => FA_HeadSideCoughSlash,
            "Head Side Mask" => FA_HeadSideMask,
            "Head Side Virus" => FA_HeadSideVirus,
            "Heading" => FA_Heading,
            "Headphones" => FA_Headphones,
            "Headset" => FA_Headset,
            "Heart" => FA_Heart,
            "Heart Circle Bolt" => FA_HeartCircleBolt,
            "Heart Circle Check" => FA_HeartCircleCheck,
            "Heart Circle Exclamation" => FA_HeartCircleExclamation,
            "Heart Circle Minus" => FA_HeartCircleMinus,
            "Heart Circle Plus" => FA_HeartCirclePlus,
            "Heart Circle Xmark" => FA_HeartCircleXmark,
            "Heart Crack" => FA_HeartCrack,
            "Heart Pulse" => FA_HeartPulse,
            "Helicopter" => FA_Helicopter,
            "Helicopter Symbol" => FA_HelicopterSymbol,
            "Helmet Safety" => FA_HelmetSafety,
            "Helmet Un" => FA_HelmetUn,
            "Hexagon" => FA_Hexagon,
            "Hexagon Nodes" => FA_HexagonNodes,
            "Hexagon Nodes Bolt" => FA_HexagonNodesBolt,
            "Highlighter" => FA_Highlighter,
            "Hill Avalanche" => FA_HillAvalanche,
            "Hill Rockslide" => FA_HillRockslide,
            "Hippo" => FA_Hippo,
            "Hips" => FA_Hips,
            "Hire A Helper" => FA_HireAHelper,
            "Hive" => FA_Hive,
            "Hockey Puck" => FA_HockeyPuck,
            "Holly Berry" => FA_HollyBerry,
            "Hooli" => FA_Hooli,
            "Hornbill" => FA_Hornbill,
            "Horse" => FA_Horse,
            "Horse Head" => FA_HorseHead,
            "Hospital" => FA_Hospital,
            "Hospital User" => FA_HospitalUser,
            "Hot Tub Person" => FA_HotTubPerson,
            "Hotdog" => FA_Hotdog,
            "Hotel" => FA_Hotel,
            "Hotjar" => FA_Hotjar,
            "Hourglass" => FA_Hourglass,
            "Hourglass End" => FA_HourglassEnd,
            "Hourglass Half" => FA_HourglassHalf,
            "Hourglass Start" => FA_HourglassStart,
            "House" => FA_House,
            "House Chimney" => FA_HouseChimney,
            "House Chimney Crack" => FA_HouseChimneyCrack,
            "House Chimney Medical" => FA_HouseChimneyMedical,
            "House Chimney User" => FA_HouseChimneyUser,
            "House Chimney Window" => FA_HouseChimneyWindow,
            "House Circle Check" => FA_HouseCircleCheck,
            "House Circle Exclamation" => FA_HouseCircleExclamation,
            "House Circle Xmark" => FA_HouseCircleXmark,
            "House Crack" => FA_HouseCrack,
            "House Fire" => FA_HouseFire,
            "House Flag" => FA_HouseFlag,
            "House Flood Water" => FA_HouseFloodWater,
            "House Flood Water Circle Arrow Right" => FA_HouseFloodWaterCircleArrowRight,
            "House Laptop" => FA_HouseLaptop,
            "House Lock" => FA_HouseLock,
            "House Medical" => FA_HouseMedical,
            "House Medical Circle Check" => FA_HouseMedicalCircleCheck,
            "House Medical Circle Exclamation" => FA_HouseMedicalCircleExclamation,
            "House Medical Circle Xmark" => FA_HouseMedicalCircleXmark,
            "House Medical Flag" => FA_HouseMedicalFlag,
            "House Signal" => FA_HouseSignal,
            "House Tsunami" => FA_HouseTsunami,
            "House User" => FA_HouseUser,
            "Houzz" => FA_Houzz,
            "Hryvnia Sign" => FA_HryvniaSign,
            "Html5" => FA_Html5,
            "Hubspot" => FA_Hubspot,
            "Hugging Face" => FA_HuggingFace,
            "Hurricane" => FA_Hurricane,
            "I" => FA_I,
            "I Cursor" => FA_ICursor,
            "Ice Cream" => FA_IceCream,
            "Icicles" => FA_Icicles,
            "Icons" => FA_Icons,
            "Id Badge" => FA_IdBadge,
            "Id Card" => FA_IdCard,
            "Id Card Clip" => FA_IdCardClip,
            "Ideal" => FA_Ideal,
            "Igloo" => FA_Igloo,
            "Image" => FA_Image,
            "Image Portrait" => FA_ImagePortrait,
            "Images" => FA_Images,
            "Imdb" => FA_Imdb,
            "Inbox" => FA_Inbox,
            "Indent" => FA_Indent,
            "Indian Rupee Sign" => FA_IndianRupeeSign,
            "Industry" => FA_Industry,
            "Infinity" => FA_Infinity,
            "Info" => FA_Info,
            "Instagram" => FA_Instagram,
            "Instalod" => FA_Instalod,
            "Intercom" => FA_Intercom,
            "Internet Explorer" => FA_InternetExplorer,
            "Invision" => FA_Invision,
            "Ioxhost" => FA_Ioxhost,
            "Italic" => FA_Italic,
            "Itch Io" => FA_ItchIo,
            "Itunes" => FA_Itunes,
            "Itunes Note" => FA_ItunesNote,
            "J" => FA_J,
            "Jar" => FA_Jar,
            "Jar Wheat" => FA_JarWheat,
            "Java" => FA_Java,
            "Jedi" => FA_Jedi,
            "Jedi Order" => FA_JediOrder,
            "Jenkins" => FA_Jenkins,
            "Jet Fighter" => FA_JetFighter,
            "Jet Fighter Up" => FA_JetFighterUp,
            "Jira" => FA_Jira,
            "Joget" => FA_Joget,
            "Joint" => FA_Joint,
            "Joomla" => FA_Joomla,
            "Js" => FA_Js,
            "Jsfiddle" => FA_Jsfiddle,
            "Jug Detergent" => FA_JugDetergent,
            "Julia" => FA_Julia,
            "Jxl" => FA_Jxl,
            "K" => FA_K,
            "Kaaba" => FA_Kaaba,
            "Kaggle" => FA_Kaggle,
            "Kakao Talk" => FA_KakaoTalk,
            "Key" => FA_Key,
            "Keybase" => FA_Keybase,
            "Keyboard" => FA_Keyboard,
            "Keycdn" => FA_Keycdn,
            "Khanda" => FA_Khanda,
            "Kickstarter" => FA_Kickstarter,
            "Kickstarter K" => FA_KickstarterK,
            "Kip Sign" => FA_KipSign,
            "Kit Medical" => FA_KitMedical,
            "Kitchen Set" => FA_KitchenSet,
            "Kiwi Bird" => FA_KiwiBird,
            "Ko Fi" => FA_KoFi,
            "Korvue" => FA_Korvue,
            "Kubernetes" => FA_Kubernetes,
            "L" => FA_L,
            "Land Mine On" => FA_LandMineOn,
            "Landmark" => FA_Landmark,
            "Landmark Dome" => FA_LandmarkDome,
            "Landmark Flag" => FA_LandmarkFlag,
            "Language" => FA_Language,
            "Laptop" => FA_Laptop,
            "Laptop Code" => FA_LaptopCode,
            "Laptop File" => FA_LaptopFile,
            "Laptop Medical" => FA_LaptopMedical,
            "Laravel" => FA_Laravel,
            "Lari Sign" => FA_LariSign,
            "Lastfm" => FA_Lastfm,
            "Layer Group" => FA_LayerGroup,
            "Leaf" => FA_Leaf,
            "Leanpub" => FA_Leanpub,
            "Leetcode" => FA_Leetcode,
            "Left Long" => FA_LeftLong,
            "Left Right" => FA_LeftRight,
            "Lemon" => FA_Lemon,
            "Leo" => FA_Leo,
            "Less" => FA_Less,
            "Less Than" => FA_LessThan,
            "Less Than Equal" => FA_LessThanEqual,
            "Letterboxd" => FA_Letterboxd,
            "Libra" => FA_Libra,
            "Life Ring" => FA_LifeRing,
            "Lightbulb" => FA_Lightbulb,
            "Line" => FA_Line,
            "Lines Leaning" => FA_LinesLeaning,
            "Link" => FA_Link,
            "Link Slash" => FA_LinkSlash,
            "Linkedin" => FA_Linkedin,
            "Linkedin In" => FA_LinkedinIn,
            "Linktree" => FA_Linktree,
            "Linode" => FA_Linode,
            "Linux" => FA_Linux,
            "Lira Sign" => FA_LiraSign,
            "List" => FA_List,
            "List Check" => FA_ListCheck,
            "List Ol" => FA_ListOl,
            "List Ul" => FA_ListUl,
            "Litecoin Sign" => FA_LitecoinSign,
            "Location Arrow" => FA_LocationArrow,
            "Location Crosshairs" => FA_LocationCrosshairs,
            "Location Dot" => FA_LocationDot,
            "Location Pin" => FA_LocationPin,
            "Location Pin Lock" => FA_LocationPinLock,
            "Lock" => FA_Lock,
            "Lock Open" => FA_LockOpen,
            "Locust" => FA_Locust,
            "Lumon" => FA_Lumon,
            "Lumon Drop" => FA_LumonDrop,
            "Lungs" => FA_Lungs,
            "Lungs Virus" => FA_LungsVirus,
            "Lyft" => FA_Lyft,
            "M" => FA_M,
            "Magento" => FA_Magento,
            "Magnet" => FA_Magnet,
            "Magnifying Glass" => FA_MagnifyingGlass,
            "Magnifying Glass Arrow Right" => FA_MagnifyingGlassArrowRight,
            "Magnifying Glass Chart" => FA_MagnifyingGlassChart,
            "Magnifying Glass Dollar" => FA_MagnifyingGlassDollar,
            "Magnifying Glass Location" => FA_MagnifyingGlassLocation,
            "Magnifying Glass Minus" => FA_MagnifyingGlassMinus,
            "Magnifying Glass Plus" => FA_MagnifyingGlassPlus,
            "Mailchimp" => FA_Mailchimp,
            "Manat Sign" => FA_ManatSign,
            "Mandalorian" => FA_Mandalorian,
            "Map" => FA_Map,
            "Map Location" => FA_MapLocation,
            "Map Location Dot" => FA_MapLocationDot,
            "Map Pin" => FA_MapPin,
            "Markdown" => FA_Markdown,
            "Marker" => FA_Marker,
            "Mars" => FA_Mars,
            "Mars And Venus" => FA_MarsAndVenus,
            "Mars And Venus Burst" => FA_MarsAndVenusBurst,
            "Mars Double" => FA_MarsDouble,
            "Mars Stroke" => FA_MarsStroke,
            "Mars Stroke Right" => FA_MarsStrokeRight,
            "Mars Stroke Up" => FA_MarsStrokeUp,
            "Martini Glass" => FA_MartiniGlass,
            "Martini Glass Citrus" => FA_MartiniGlassCitrus,
            "Martini Glass Empty" => FA_MartiniGlassEmpty,
            "Mask" => FA_Mask,
            "Mask Face" => FA_MaskFace,
            "Mask Ventilator" => FA_MaskVentilator,
            "Masks Theater" => FA_MasksTheater,
            "Mastodon" => FA_Mastodon,
            "Mattress Pillow" => FA_MattressPillow,
            "Maxcdn" => FA_Maxcdn,
            "Maximize" => FA_Maximize,
            "Mdb" => FA_Mdb,
            "Medal" => FA_Medal,
            "Medapps" => FA_Medapps,
            "Medium" => FA_Medium,
            "Medrt" => FA_Medrt,
            "Meetup" => FA_Meetup,
            "Megaport" => FA_Megaport,
            "Memory" => FA_Memory,
            "Mendeley" => FA_Mendeley,
            "Menorah" => FA_Menorah,
            "Mercury" => FA_Mercury,
            "Message" => FA_Message,
            "Meta" => FA_Meta,
            "Meteor" => FA_Meteor,
            "Microblog" => FA_Microblog,
            "Microchip" => FA_Microchip,
            "Microphone" => FA_Microphone,
            "Microphone Lines" => FA_MicrophoneLines,
            "Microphone Lines Slash" => FA_MicrophoneLinesSlash,
            "Microphone Slash" => FA_MicrophoneSlash,
            "Microscope" => FA_Microscope,
            "Microsoft" => FA_Microsoft,
            "Mill Sign" => FA_MillSign,
            "Minimize" => FA_Minimize,
            "Mintbit" => FA_Mintbit,
            "Minus" => FA_Minus,
            "Mitten" => FA_Mitten,
            "Mix" => FA_Mix,
            "Mixcloud" => FA_Mixcloud,
            "Mixer" => FA_Mixer,
            "Mizuni" => FA_Mizuni,
            "Mobile" => FA_Mobile,
            "Mobile Button" => FA_MobileButton,
            "Mobile Retro" => FA_MobileRetro,
            "Mobile Screen" => FA_MobileScreen,
            "Mobile Screen Button" => FA_MobileScreenButton,
            "Mobile Vibrate" => FA_MobileVibrate,
            "Modx" => FA_Modx,
            "Monero" => FA_Monero,
            "Money Bill" => FA_MoneyBill,
            "Money Bill 1" => FA_MoneyBill1,
            "Money Bill 1 Wave" => FA_MoneyBill1Wave,
            "Money Bill Transfer" => FA_MoneyBillTransfer,
            "Money Bill Trend Up" => FA_MoneyBillTrendUp,
            "Money Bill Wave" => FA_MoneyBillWave,
            "Money Bill Wheat" => FA_MoneyBillWheat,
            "Money Bills" => FA_MoneyBills,
            "Money Check" => FA_MoneyCheck,
            "Money Check Dollar" => FA_MoneyCheckDollar,
            "Monument" => FA_Monument,
            "Moon" => FA_Moon,
            "Mortar Pestle" => FA_MortarPestle,
            "Mosque" => FA_Mosque,
            "Mosquito" => FA_Mosquito,
            "Mosquito Net" => FA_MosquitoNet,
            "Motorcycle" => FA_Motorcycle,
            "Mound" => FA_Mound,
            "Mountain" => FA_Mountain,
            "Mountain City" => FA_MountainCity,
            "Mountain Sun" => FA_MountainSun,
            "Mug Hot" => FA_MugHot,
            "Mug Saucer" => FA_MugSaucer,
            "Music" => FA_Music,
            "N" => FA_N,
            "Naira Sign" => FA_NairaSign,
            "Napster" => FA_Napster,
            "Neos" => FA_Neos,
            "Network Wired" => FA_NetworkWired,
            "Neuter" => FA_Neuter,
            "Newspaper" => FA_Newspaper,
            "Nfc Directional" => FA_NfcDirectional,
            "Nfc Symbol" => FA_NfcSymbol,
            "Nimblr" => FA_Nimblr,
            "Node" => FA_Node,
            "Node Js" => FA_NodeJs,
            "Non Binary" => FA_NonBinary,
            "Not Equal" => FA_NotEqual,
            "Notdef" => FA_Notdef,
            "Note Sticky" => FA_NoteSticky,
            "Notes Medical" => FA_NotesMedical,
            "Notion" => FA_Notion,
            "Npm" => FA_Npm,
            "Ns8" => FA_Ns8,
            "Nutritionix" => FA_Nutritionix,
            "O" => FA_O,
            "Object Group" => FA_ObjectGroup,
            "Object Ungroup" => FA_ObjectUngroup,
            "Obsidian" => FA_Obsidian,
            "Octagon" => FA_Octagon,
            "Octopus Deploy" => FA_OctopusDeploy,
            "Odnoklassniki" => FA_Odnoklassniki,
            "Odysee" => FA_Odysee,
            "Oil Can" => FA_OilCan,
            "Oil Well" => FA_OilWell,
            "Old Republic" => FA_OldRepublic,
            "Om" => FA_Om,
            "Openai" => FA_Openai,
            "Opencart" => FA_Opencart,
            "Openid" => FA_Openid,
            "Openstreetmap" => FA_Openstreetmap,
            "Opensuse" => FA_Opensuse,
            "Opera" => FA_Opera,
            "Optin Monster" => FA_OptinMonster,
            "Orcid" => FA_Orcid,
            "Osi" => FA_Osi,
            "Otter" => FA_Otter,
            "Outdent" => FA_Outdent,
            "P" => FA_P,
            "Padlet" => FA_Padlet,
            "Page4" => FA_Page4,
            "Pagelines" => FA_Pagelines,
            "Pager" => FA_Pager,
            "Paint Roller" => FA_PaintRoller,
            "Paintbrush" => FA_Paintbrush,
            "Palette" => FA_Palette,
            "Palfed" => FA_Palfed,
            "Pallet" => FA_Pallet,
            "Pandora" => FA_Pandora,
            "Panorama" => FA_Panorama,
            "Paper Plane" => FA_PaperPlane,
            "Paperclip" => FA_Paperclip,
            "Parachute Box" => FA_ParachuteBox,
            "Paragraph" => FA_Paragraph,
            "Passport" => FA_Passport,
            "Paste" => FA_Paste,
            "Patreon" => FA_Patreon,
            "Pause" => FA_Pause,
            "Paw" => FA_Paw,
            "Paypal" => FA_Paypal,
            "Peace" => FA_Peace,
            "Pen" => FA_Pen,
            "Pen Clip" => FA_PenClip,
            "Pen Fancy" => FA_PenFancy,
            "Pen Nib" => FA_PenNib,
            "Pen Ruler" => FA_PenRuler,
            "Pen To Square" => FA_PenToSquare,
            "Pencil" => FA_Pencil,
            "Pentagon" => FA_Pentagon,
            "People Arrows" => FA_PeopleArrows,
            "People Carry Box" => FA_PeopleCarryBox,
            "People Group" => FA_PeopleGroup,
            "People Line" => FA_PeopleLine,
            "People Pulling" => FA_PeoplePulling,
            "People Robbery" => FA_PeopleRobbery,
            "People Roof" => FA_PeopleRoof,
            "Pepper Hot" => FA_PepperHot,
            "Perbyte" => FA_Perbyte,
            "Percent" => FA_Percent,
            "Periscope" => FA_Periscope,
            "Person" => FA_Person,
            "Person Arrow Down To Line" => FA_PersonArrowDownToLine,
            "Person Arrow Up From Line" => FA_PersonArrowUpFromLine,
            "Person Biking" => FA_PersonBiking,
            "Person Booth" => FA_PersonBooth,
            "Person Breastfeeding" => FA_PersonBreastfeeding,
            "Person Burst" => FA_PersonBurst,
            "Person Cane" => FA_PersonCane,
            "Person Chalkboard" => FA_PersonChalkboard,
            "Person Circle Check" => FA_PersonCircleCheck,
            "Person Circle Exclamation" => FA_PersonCircleExclamation,
            "Person Circle Minus" => FA_PersonCircleMinus,
            "Person Circle Plus" => FA_PersonCirclePlus,
            "Person Circle Question" => FA_PersonCircleQuestion,
            "Person Circle Xmark" => FA_PersonCircleXmark,
            "Person Digging" => FA_PersonDigging,
            "Person Dots From Line" => FA_PersonDotsFromLine,
            "Person Dress" => FA_PersonDress,
            "Person Dress Burst" => FA_PersonDressBurst,
            "Person Drowning" => FA_PersonDrowning,
            "Person Falling" => FA_PersonFalling,
            "Person Falling Burst" => FA_PersonFallingBurst,
            "Person Half Dress" => FA_PersonHalfDress,
            "Person Harassing" => FA_PersonHarassing,
            "Person Hiking" => FA_PersonHiking,
            "Person Military Pointing" => FA_PersonMilitaryPointing,
            "Person Military Rifle" => FA_PersonMilitaryRifle,
            "Person Military To Person" => FA_PersonMilitaryToPerson,
            "Person Praying" => FA_PersonPraying,
            "Person Pregnant" => FA_PersonPregnant,
            "Person Rays" => FA_PersonRays,
            "Person Rifle" => FA_PersonRifle,
            "Person Running" => FA_PersonRunning,
            "Person Shelter" => FA_PersonShelter,
            "Person Skating" => FA_PersonSkating,
            "Person Skiing" => FA_PersonSkiing,
            "Person Skiing Nordic" => FA_PersonSkiingNordic,
            "Person Snowboarding" => FA_PersonSnowboarding,
            "Person Swimming" => FA_PersonSwimming,
            "Person Through Window" => FA_PersonThroughWindow,
            "Person Walking" => FA_PersonWalking,
            "Person Walking Arrow Loop Left" => FA_PersonWalkingArrowLoopLeft,
            "Person Walking Arrow Right" => FA_PersonWalkingArrowRight,
            "Person Walking Dashed Line Arrow Right" => FA_PersonWalkingDashedLineArrowRight,
            "Person Walking Luggage" => FA_PersonWalkingLuggage,
            "Person Walking With Cane" => FA_PersonWalkingWithCane,
            "Peseta Sign" => FA_PesetaSign,
            "Peso Sign" => FA_PesoSign,
            "Phabricator" => FA_Phabricator,
            "Phoenix Framework" => FA_PhoenixFramework,
            "Phoenix Squadron" => FA_PhoenixSquadron,
            "Phone" => FA_Phone,
            "Phone Flip" => FA_PhoneFlip,
            "Phone Slash" => FA_PhoneSlash,
            "Phone Volume" => FA_PhoneVolume,
            "Photo Film" => FA_PhotoFilm,
            "Php" => FA_Php,
            "Picture In Picture" => FA_PictureInPicture,
            "Pied Piper" => FA_PiedPiper,
            "Pied Piper Alt" => FA_PiedPiperAlt,
            "Pied Piper Hat" => FA_PiedPiperHat,
            "Pied Piper Pp" => FA_PiedPiperPp,
            "Piggy Bank" => FA_PiggyBank,
            "Pills" => FA_Pills,
            "Pinterest" => FA_Pinterest,
            "Pinterest P" => FA_PinterestP,
            "Pisces" => FA_Pisces,
            "Pix" => FA_Pix,
            "Pixelfed" => FA_Pixelfed,
            "Pixiv" => FA_Pixiv,
            "Pizza Slice" => FA_PizzaSlice,
            "Place Of Worship" => FA_PlaceOfWorship,
            "Plane" => FA_Plane,
            "Plane Arrival" => FA_PlaneArrival,
            "Plane Circle Check" => FA_PlaneCircleCheck,
            "Plane Circle Exclamation" => FA_PlaneCircleExclamation,
            "Plane Circle Xmark" => FA_PlaneCircleXmark,
            "Plane Departure" => FA_PlaneDeparture,
            "Plane Lock" => FA_PlaneLock,
            "Plane Slash" => FA_PlaneSlash,
            "Plane Up" => FA_PlaneUp,
            "Plant Wilt" => FA_PlantWilt,
            "Plate Wheat" => FA_PlateWheat,
            "Play" => FA_Play,
            "Playstation" => FA_Playstation,
            "Plug" => FA_Plug,
            "Plug Circle Bolt" => FA_PlugCircleBolt,
            "Plug Circle Check" => FA_PlugCircleCheck,
            "Plug Circle Exclamation" => FA_PlugCircleExclamation,
            "Plug Circle Minus" => FA_PlugCircleMinus,
            "Plug Circle Plus" => FA_PlugCirclePlus,
            "Plug Circle Xmark" => FA_PlugCircleXmark,
            "Plus" => FA_Plus,
            "Plus Minus" => FA_PlusMinus,
            "Podcast" => FA_Podcast,
            "Poo" => FA_Poo,
            "Poo Storm" => FA_PooStorm,
            "Poop" => FA_Poop,
            "Postgresql" => FA_Postgresql,
            "Power Off" => FA_PowerOff,
            "Prescription" => FA_Prescription,
            "Prescription Bottle" => FA_PrescriptionBottle,
            "Prescription Bottle Medical" => FA_PrescriptionBottleMedical,
            "Print" => FA_Print,
            "Product Hunt" => FA_ProductHunt,
            "Pump Medical" => FA_PumpMedical,
            "Pump Soap" => FA_PumpSoap,
            "Pushed" => FA_Pushed,
            "Puzzle Piece" => FA_PuzzlePiece,
            "Python" => FA_Python,
            "Q" => FA_Q,
            "Qq" => FA_Qq,
            "Qrcode" => FA_Qrcode,
            "Question" => FA_Question,
            "Quinscape" => FA_Quinscape,
            "Quora" => FA_Quora,
            "Quote Left" => FA_QuoteLeft,
            "Quote Right" => FA_QuoteRight,
            "R" => FA_R,
            "R Project" => FA_RProject,
            "Radiation" => FA_Radiation,
            "Radio" => FA_Radio,
            "Rainbow" => FA_Rainbow,
            "Ranking Star" => FA_RankingStar,
            "Raspberry Pi" => FA_RaspberryPi,
            "Ravelry" => FA_Ravelry,
            "React" => FA_React,
            "Reacteurope" => FA_Reacteurope,
            "Readme" => FA_Readme,
            "Rebel" => FA_Rebel,
            "Receipt" => FA_Receipt,
            "Record Vinyl" => FA_RecordVinyl,
            "Rectangle Ad" => FA_RectangleAd,
            "Rectangle List" => FA_RectangleList,
            "Rectangle Xmark" => FA_RectangleXmark,
            "Recycle" => FA_Recycle,
            "Red River" => FA_RedRiver,
            "Reddit" => FA_Reddit,
            "Reddit Alien" => FA_RedditAlien,
            "Redhat" => FA_Redhat,
            "Registered" => FA_Registered,
            "Renren" => FA_Renren,
            "Repeat" => FA_Repeat,
            "Reply" => FA_Reply,
            "Reply All" => FA_ReplyAll,
            "Replyd" => FA_Replyd,
            "Republican" => FA_Republican,
            "Researchgate" => FA_Researchgate,
            "Resolving" => FA_Resolving,
            "Restroom" => FA_Restroom,
            "Retweet" => FA_Retweet,
            "Rev" => FA_Rev,
            "Ribbon" => FA_Ribbon,
            "Right From Bracket" => FA_RightFromBracket,
            "Right Left" => FA_RightLeft,
            "Right Long" => FA_RightLong,
            "Right To Bracket" => FA_RightToBracket,
            "Ring" => FA_Ring,
            "Road" => FA_Road,
            "Road Barrier" => FA_RoadBarrier,
            "Road Bridge" => FA_RoadBridge,
            "Road Circle Check" => FA_RoadCircleCheck,
            "Road Circle Exclamation" => FA_RoadCircleExclamation,
            "Road Circle Xmark" => FA_RoadCircleXmark,
            "Road Lock" => FA_RoadLock,
            "Road Spikes" => FA_RoadSpikes,
            "Robot" => FA_Robot,
            "Rocket" => FA_Rocket,
            "Rocketchat" => FA_Rocketchat,
            "Rockrms" => FA_Rockrms,
            "Rotate" => FA_Rotate,
            "Rotate Left" => FA_RotateLeft,
            "Rotate Right" => FA_RotateRight,
            "Route" => FA_Route,
            "Rss" => FA_Rss,
            "Ruble Sign" => FA_RubleSign,
            "Rug" => FA_Rug,
            "Ruler" => FA_Ruler,
            "Ruler Combined" => FA_RulerCombined,
            "Ruler Horizontal" => FA_RulerHorizontal,
            "Ruler Vertical" => FA_RulerVertical,
            "Rupee Sign" => FA_RupeeSign,
            "Rupiah Sign" => FA_RupiahSign,
            "Rust" => FA_Rust,
            "S" => FA_S,
            "Sack Dollar" => FA_SackDollar,
            "Sack Xmark" => FA_SackXmark,
            "Safari" => FA_Safari,
            "Sagittarius" => FA_Sagittarius,
            "Sailboat" => FA_Sailboat,
            "Salesforce" => FA_Salesforce,
            "Sass" => FA_Sass,
            "Satellite" => FA_Satellite,
            "Satellite Dish" => FA_SatelliteDish,
            "Scale Balanced" => FA_ScaleBalanced,
            "Scale Unbalanced" => FA_ScaleUnbalanced,
            "Scale Unbalanced Flip" => FA_ScaleUnbalancedFlip,
            "Scaleway" => FA_Scaleway,
            "Schlix" => FA_Schlix,
            "School" => FA_School,
            "School Circle Check" => FA_SchoolCircleCheck,
            "School Circle Exclamation" => FA_SchoolCircleExclamation,
            "School Circle Xmark" => FA_SchoolCircleXmark,
            "School Flag" => FA_SchoolFlag,
            "School Lock" => FA_SchoolLock,
            "Scissors" => FA_Scissors,
            "Scorpio" => FA_Scorpio,
            "Screenpal" => FA_Screenpal,
            "Screwdriver" => FA_Screwdriver,
            "Screwdriver Wrench" => FA_ScrewdriverWrench,
            "Scribd" => FA_Scribd,
            "Scroll" => FA_Scroll,
            "Scroll Torah" => FA_ScrollTorah,
            "Sd Card" => FA_SdCard,
            "Searchengin" => FA_Searchengin,
            "Section" => FA_Section,
            "Seedling" => FA_Seedling,
            "Sellcast" => FA_Sellcast,
            "Sellsy" => FA_Sellsy,
            "Septagon" => FA_Septagon,
            "Server" => FA_Server,
            "Servicestack" => FA_Servicestack,
            "Shapes" => FA_Shapes,
            "Share" => FA_Share,
            "Share From Square" => FA_ShareFromSquare,
            "Share Nodes" => FA_ShareNodes,
            "Sheet Plastic" => FA_SheetPlastic,
            "Shekel Sign" => FA_ShekelSign,
            "Shield" => FA_Shield,
            "Shield Cat" => FA_ShieldCat,
            "Shield Dog" => FA_ShieldDog,
            "Shield Halved" => FA_ShieldHalved,
            "Shield Heart" => FA_ShieldHeart,
            "Shield Virus" => FA_ShieldVirus,
            "Ship" => FA_Ship,
            "Shirt" => FA_Shirt,
            "Shirtsinbulk" => FA_Shirtsinbulk,
            "Shoe Prints" => FA_ShoePrints,
            "Shoelace" => FA_Shoelace,
            "Shop" => FA_Shop,
            "Shop Lock" => FA_ShopLock,
            "Shop Slash" => FA_ShopSlash,
            "Shopify" => FA_Shopify,
            "Shopware" => FA_Shopware,
            "Shower" => FA_Shower,
            "Shrimp" => FA_Shrimp,
            "Shuffle" => FA_Shuffle,
            "Shuttle Space" => FA_ShuttleSpace,
            "Sign Hanging" => FA_SignHanging,
            "Signal" => FA_Signal,
            "Signal Messenger" => FA_SignalMessenger,
            "Signature" => FA_Signature,
            "Signs Post" => FA_SignsPost,
            "Sim Card" => FA_SimCard,
            "Simplybuilt" => FA_Simplybuilt,
            "Single Quote Left" => FA_SingleQuoteLeft,
            "Single Quote Right" => FA_SingleQuoteRight,
            "Sink" => FA_Sink,
            "Sistrix" => FA_Sistrix,
            "Sitemap" => FA_Sitemap,
            "Sith" => FA_Sith,
            "Sitrox" => FA_Sitrox,
            "Sketch" => FA_Sketch,
            "Skull" => FA_Skull,
            "Skull Crossbones" => FA_SkullCrossbones,
            "Skyatlas" => FA_Skyatlas,
            "Skype" => FA_Skype,
            "Slack" => FA_Slack,
            "Slash" => FA_Slash,
            "Sleigh" => FA_Sleigh,
            "Sliders" => FA_Sliders,
            "Slideshare" => FA_Slideshare,
            "Smog" => FA_Smog,
            "Smoking" => FA_Smoking,
            "Snapchat" => FA_Snapchat,
            "Snowflake" => FA_Snowflake,
            "Snowman" => FA_Snowman,
            "Snowplow" => FA_Snowplow,
            "Soap" => FA_Soap,
            "Socks" => FA_Socks,
            "Solana" => FA_Solana,
            "Solar Panel" => FA_SolarPanel,
            "Sort" => FA_Sort,
            "Sort Down" => FA_SortDown,
            "Sort Up" => FA_SortUp,
            "Soundcloud" => FA_Soundcloud,
            "Sourcetree" => FA_Sourcetree,
            "Spa" => FA_Spa,
            "Space Awesome" => FA_SpaceAwesome,
            "Spaghetti Monster Flying" => FA_SpaghettiMonsterFlying,
            "Speakap" => FA_Speakap,
            "Speaker Deck" => FA_SpeakerDeck,
            "Spell Check" => FA_SpellCheck,
            "Spider" => FA_Spider,
            "Spinner" => FA_Spinner,
            "Spiral" => FA_Spiral,
            "Splotch" => FA_Splotch,
            "Spoon" => FA_Spoon,
            "Spotify" => FA_Spotify,
            "Spray Can" => FA_SprayCan,
            "Spray Can Sparkles" => FA_SprayCanSparkles,
            "Square" => FA_Square,
            "Square Arrow Up Right" => FA_SquareArrowUpRight,
            "Square Behance" => FA_SquareBehance,
            "Square Binary" => FA_SquareBinary,
            "Square Bluesky" => FA_SquareBluesky,
            "Square Caret Down" => FA_SquareCaretDown,
            "Square Caret Left" => FA_SquareCaretLeft,
            "Square Caret Right" => FA_SquareCaretRight,
            "Square Caret Up" => FA_SquareCaretUp,
            "Square Check" => FA_SquareCheck,
            "Square Deskpro" => FA_SquareDeskpro,
            "Square Dribbble" => FA_SquareDribbble,
            "Square Envelope" => FA_SquareEnvelope,
            "Square Facebook" => FA_SquareFacebook,
            "Square Figma" => FA_SquareFigma,
            "Square Font Awesome" => FA_SquareFontAwesome,
            "Square Font Awesome Stroke" => FA_SquareFontAwesomeStroke,
            "Square Full" => FA_SquareFull,
            "Square Git" => FA_SquareGit,
            "Square Github" => FA_SquareGithub,
            "Square Gitlab" => FA_SquareGitlab,
            "Square Google Plus" => FA_SquareGooglePlus,
            "Square H" => FA_SquareH,
            "Square Hacker News" => FA_SquareHackerNews,
            "Square Instagram" => FA_SquareInstagram,
            "Square Js" => FA_SquareJs,
            "Square Lastfm" => FA_SquareLastfm,
            "Square Letterboxd" => FA_SquareLetterboxd,
            "Square Linkedin" => FA_SquareLinkedin,
            "Square Minus" => FA_SquareMinus,
            "Square Nfi" => FA_SquareNfi,
            "Square Odnoklassniki" => FA_SquareOdnoklassniki,
            "Square Parking" => FA_SquareParking,
            "Square Pen" => FA_SquarePen,
            "Square Person Confined" => FA_SquarePersonConfined,
            "Square Phone" => FA_SquarePhone,
            "Square Phone Flip" => FA_SquarePhoneFlip,
            "Square Pied Piper" => FA_SquarePiedPiper,
            "Square Pinterest" => FA_SquarePinterest,
            "Square Plus" => FA_SquarePlus,
            "Square Poll Horizontal" => FA_SquarePollHorizontal,
            "Square Poll Vertical" => FA_SquarePollVertical,
            "Square Reddit" => FA_SquareReddit,
            "Square Root Variable" => FA_SquareRootVariable,
            "Square Rss" => FA_SquareRss,
            "Square Share Nodes" => FA_SquareShareNodes,
            "Square Snapchat" => FA_SquareSnapchat,
            "Square Steam" => FA_SquareSteam,
            "Square Threads" => FA_SquareThreads,
            "Square Tumblr" => FA_SquareTumblr,
            "Square Twitter" => FA_SquareTwitter,
            "Square Up Right" => FA_SquareUpRight,
            "Square Upwork" => FA_SquareUpwork,
            "Square Viadeo" => FA_SquareViadeo,
            "Square Vimeo" => FA_SquareVimeo,
            "Square Virus" => FA_SquareVirus,
            "Square Web Awesome" => FA_SquareWebAwesome,
            "Square Web Awesome Stroke" => FA_SquareWebAwesomeStroke,
            "Square Whatsapp" => FA_SquareWhatsapp,
            "Square X Twitter" => FA_SquareXTwitter,
            "Square Xing" => FA_SquareXing,
            "Square Xmark" => FA_SquareXmark,
            "Square Youtube" => FA_SquareYoutube,
            "Squarespace" => FA_Squarespace,
            "Stack Exchange" => FA_StackExchange,
            "Stack Overflow" => FA_StackOverflow,
            "Stackpath" => FA_Stackpath,
            "Staff Snake" => FA_StaffSnake,
            "Stairs" => FA_Stairs,
            "Stamp" => FA_Stamp,
            "Stapler" => FA_Stapler,
            "Star" => FA_Star,
            "Star And Crescent" => FA_StarAndCrescent,
            "Star Half" => FA_StarHalf,
            "Star Half Stroke" => FA_StarHalfStroke,
            "Star Of David" => FA_StarOfDavid,
            "Star Of Life" => FA_StarOfLife,
            "Staylinked" => FA_Staylinked,
            "Steam" => FA_Steam,
            "Steam Symbol" => FA_SteamSymbol,
            "Sterling Sign" => FA_SterlingSign,
            "Stethoscope" => FA_Stethoscope,
            "Sticker Mule" => FA_StickerMule,
            "Stop" => FA_Stop,
            "Stopwatch" => FA_Stopwatch,
            "Stopwatch 20" => FA_Stopwatch20,
            "Store" => FA_Store,
            "Store Slash" => FA_StoreSlash,
            "Strava" => FA_Strava,
            "Street View" => FA_StreetView,
            "Strikethrough" => FA_Strikethrough,
            "Stripe" => FA_Stripe,
            "Stripe S" => FA_StripeS,
            "Stroopwafel" => FA_Stroopwafel,
            "Stubber" => FA_Stubber,
            "Studiovinari" => FA_Studiovinari,
            "Stumbleupon" => FA_Stumbleupon,
            "Stumbleupon Circle" => FA_StumbleuponCircle,
            "Subscript" => FA_Subscript,
            "Suitcase" => FA_Suitcase,
            "Suitcase Medical" => FA_SuitcaseMedical,
            "Suitcase Rolling" => FA_SuitcaseRolling,
            "Sun" => FA_Sun,
            "Sun Plant Wilt" => FA_SunPlantWilt,
            "Superpowers" => FA_Superpowers,
            "Superscript" => FA_Superscript,
            "Supple" => FA_Supple,
            "Supportnow" => FA_Supportnow,
            "Suse" => FA_Suse,
            "Svelte" => FA_Svelte,
            "Swatchbook" => FA_Swatchbook,
            "Swift" => FA_Swift,
            "Symfony" => FA_Symfony,
            "Symfonycasts" => FA_Symfonycasts,
            "Synagogue" => FA_Synagogue,
            "Syringe" => FA_Syringe,
            "T" => FA_T,
            "Table" => FA_Table,
            "Table Cells" => FA_TableCells,
            "Table Cells Column Lock" => FA_TableCellsColumnLock,
            "Table Cells Large" => FA_TableCellsLarge,
            "Table Cells Row Lock" => FA_TableCellsRowLock,
            "Table Cells Row Unlock" => FA_TableCellsRowUnlock,
            "Table Columns" => FA_TableColumns,
            "Table List" => FA_TableList,
            "Table Tennis Paddle Ball" => FA_TableTennisPaddleBall,
            "Tablet" => FA_Tablet,
            "Tablet Button" => FA_TabletButton,
            "Tablet Screen Button" => FA_TabletScreenButton,
            "Tablets" => FA_Tablets,
            "Tachograph Digital" => FA_TachographDigital,
            "Tag" => FA_Tag,
            "Tags" => FA_Tags,
            "Tailwind Css" => FA_TailwindCss,
            "Tape" => FA_Tape,
            "Tarp" => FA_Tarp,
            "Tarp Droplet" => FA_TarpDroplet,
            "Taurus" => FA_Taurus,
            "Taxi" => FA_Taxi,
            "Teamspeak" => FA_Teamspeak,
            "Teeth" => FA_Teeth,
            "Teeth Open" => FA_TeethOpen,
            "Telegram" => FA_Telegram,
            "Temperature Arrow Down" => FA_TemperatureArrowDown,
            "Temperature Arrow Up" => FA_TemperatureArrowUp,
            "Temperature Empty" => FA_TemperatureEmpty,
            "Temperature Full" => FA_TemperatureFull,
            "Temperature Half" => FA_TemperatureHalf,
            "Temperature High" => FA_TemperatureHigh,
            "Temperature Low" => FA_TemperatureLow,
            "Temperature Quarter" => FA_TemperatureQuarter,
            "Temperature Three Quarters" => FA_TemperatureThreeQuarters,
            "Tencent Weibo" => FA_TencentWeibo,
            "Tenge Sign" => FA_TengeSign,
            "Tent" => FA_Tent,
            "Tent Arrow Down To Line" => FA_TentArrowDownToLine,
            "Tent Arrow Left Right" => FA_TentArrowLeftRight,
            "Tent Arrow Turn Left" => FA_TentArrowTurnLeft,
            "Tent Arrows Down" => FA_TentArrowsDown,
            "Tents" => FA_Tents,
            "Terminal" => FA_Terminal,
            "Tex" => FA_Tex,
            "Text Height" => FA_TextHeight,
            "Text Slash" => FA_TextSlash,
            "Text Width" => FA_TextWidth,
            "The Red Yeti" => FA_TheRedYeti,
            "Themeco" => FA_Themeco,
            "Themeisle" => FA_Themeisle,
            "Thermometer" => FA_Thermometer,
            "Think Peaks" => FA_ThinkPeaks,
            "Threads" => FA_Threads,
            "Threema" => FA_Threema,
            "Thumbs Down" => FA_ThumbsDown,
            "Thumbs Up" => FA_ThumbsUp,
            "Thumbtack" => FA_Thumbtack,
            "Thumbtack Slash" => FA_ThumbtackSlash,
            "Ticket" => FA_Ticket,
            "Ticket Simple" => FA_TicketSimple,
            "Tidal" => FA_Tidal,
            "Tiktok" => FA_Tiktok,
            "Timeline" => FA_Timeline,
            "Toggle Off" => FA_ToggleOff,
            "Toggle On" => FA_ToggleOn,
            "Toilet" => FA_Toilet,
            "Toilet Paper" => FA_ToiletPaper,
            "Toilet Paper Slash" => FA_ToiletPaperSlash,
            "Toilet Portable" => FA_ToiletPortable,
            "Toilets Portable" => FA_ToiletsPortable,
            "Toolbox" => FA_Toolbox,
            "Tooth" => FA_Tooth,
            "Tor Browser" => FA_TorBrowser,
            "Torii Gate" => FA_ToriiGate,
            "Tornado" => FA_Tornado,
            "Tower Broadcast" => FA_TowerBroadcast,
            "Tower Cell" => FA_TowerCell,
            "Tower Observation" => FA_TowerObservation,
            "Tractor" => FA_Tractor,
            "Trade Federation" => FA_TradeFederation,
            "Trademark" => FA_Trademark,
            "Traffic Light" => FA_TrafficLight,
            "Trailer" => FA_Trailer,
            "Train" => FA_Train,
            "Train Subway" => FA_TrainSubway,
            "Train Tram" => FA_TrainTram,
            "Transgender" => FA_Transgender,
            "Trash" => FA_Trash,
            "Trash Arrow Up" => FA_TrashArrowUp,
            "Trash Can" => FA_TrashCan,
            "Trash Can Arrow Up" => FA_TrashCanArrowUp,
            "Tree" => FA_Tree,
            "Tree City" => FA_TreeCity,
            "Trello" => FA_Trello,
            "Triangle Exclamation" => FA_TriangleExclamation,
            "Trophy" => FA_Trophy,
            "Trowel" => FA_Trowel,
            "Trowel Bricks" => FA_TrowelBricks,
            "Truck" => FA_Truck,
            "Truck Arrow Right" => FA_TruckArrowRight,
            "Truck Droplet" => FA_TruckDroplet,
            "Truck Fast" => FA_TruckFast,
            "Truck Field" => FA_TruckField,
            "Truck Field Un" => FA_TruckFieldUn,
            "Truck Front" => FA_TruckFront,
            "Truck Medical" => FA_TruckMedical,
            "Truck Monster" => FA_TruckMonster,
            "Truck Moving" => FA_TruckMoving,
            "Truck Pickup" => FA_TruckPickup,
            "Truck Plane" => FA_TruckPlane,
            "Truck Ramp Box" => FA_TruckRampBox,
            "Tty" => FA_Tty,
            "Tumblr" => FA_Tumblr,
            "Turkish Lira Sign" => FA_TurkishLiraSign,
            "Turn Down" => FA_TurnDown,
            "Turn Up" => FA_TurnUp,
            "Tv" => FA_Tv,
            "Twitch" => FA_Twitch,
            "Twitter" => FA_Twitter,
            "Typescript" => FA_Typescript,
            "Typo3" => FA_Typo3,
            "U" => FA_U,
            "Uber" => FA_Uber,
            "Ubuntu" => FA_Ubuntu,
            "Uikit" => FA_Uikit,
            "Ultralytics" => FA_Ultralytics,
            "Ultralytics Hub" => FA_UltralyticsHub,
            "Ultralytics Yolo" => FA_UltralyticsYolo,
            "Umbraco" => FA_Umbraco,
            "Umbrella" => FA_Umbrella,
            "Umbrella Beach" => FA_UmbrellaBeach,
            "Uncharted" => FA_Uncharted,
            "Underline" => FA_Underline,
            "Uniregistry" => FA_Uniregistry,
            "Unison" => FA_Unison,
            "Unity" => FA_Unity,
            "Universal Access" => FA_UniversalAccess,
            "Unlock" => FA_Unlock,
            "Unlock Keyhole" => FA_UnlockKeyhole,
            "Unreal Engine" => FA_UnrealEngine,
            "Unsplash" => FA_Unsplash,
            "Untappd" => FA_Untappd,
            "Up Down" => FA_UpDown,
            "Up Down Left Right" => FA_UpDownLeftRight,
            "Up Long" => FA_UpLong,
            "Up Right And Down Left From Center" => FA_UpRightAndDownLeftFromCenter,
            "Up Right From Square" => FA_UpRightFromSquare,
            "Upload" => FA_Upload,
            "Ups" => FA_Ups,
            "Upwork" => FA_Upwork,
            "Usb" => FA_Usb,
            "User" => FA_User,
            "User Astronaut" => FA_UserAstronaut,
            "User Check" => FA_UserCheck,
            "User Clock" => FA_UserClock,
            "User Doctor" => FA_UserDoctor,
            "User Gear" => FA_UserGear,
            "User Graduate" => FA_UserGraduate,
            "User Group" => FA_UserGroup,
            "User Injured" => FA_UserInjured,
            "User Lock" => FA_UserLock,
            "User Minus" => FA_UserMinus,
            "User Ninja" => FA_UserNinja,
            "User Nurse" => FA_UserNurse,
            "User Pen" => FA_UserPen,
            "User Plus" => FA_UserPlus,
            "User Secret" => FA_UserSecret,
            "User Shield" => FA_UserShield,
            "User Slash" => FA_UserSlash,
            "User Tag" => FA_UserTag,
            "User Tie" => FA_UserTie,
            "User Xmark" => FA_UserXmark,
            "Users" => FA_Users,
            "Users Between Lines" => FA_UsersBetweenLines,
            "Users Gear" => FA_UsersGear,
            "Users Line" => FA_UsersLine,
            "Users Rays" => FA_UsersRays,
            "Users Rectangle" => FA_UsersRectangle,
            "Users Slash" => FA_UsersSlash,
            "Users Viewfinder" => FA_UsersViewfinder,
            "Usps" => FA_Usps,
            "Ussunnah" => FA_Ussunnah,
            "Utensils" => FA_Utensils,
            "V" => FA_V,
            "Vaadin" => FA_Vaadin,
            "Van Shuttle" => FA_VanShuttle,
            "Vault" => FA_Vault,
            "Venmo" => FA_Venmo,
            "Venmo V" => FA_VenmoV,
            "Venus" => FA_Venus,
            "Venus Double" => FA_VenusDouble,
            "Venus Mars" => FA_VenusMars,
            "Vest" => FA_Vest,
            "Vest Patches" => FA_VestPatches,
            "Viacoin" => FA_Viacoin,
            "Viadeo" => FA_Viadeo,
            "Vial" => FA_Vial,
            "Vial Circle Check" => FA_VialCircleCheck,
            "Vial Virus" => FA_VialVirus,
            "Vials" => FA_Vials,
            "Viber" => FA_Viber,
            "Video" => FA_Video,
            "Video Slash" => FA_VideoSlash,
            "Vihara" => FA_Vihara,
            "Vim" => FA_Vim,
            "Vimeo" => FA_Vimeo,
            "Vimeo V" => FA_VimeoV,
            "Vine" => FA_Vine,
            "Virgo" => FA_Virgo,
            "Virus" => FA_Virus,
            "Virus Covid" => FA_VirusCovid,
            "Virus Covid Slash" => FA_VirusCovidSlash,
            "Virus Slash" => FA_VirusSlash,
            "Viruses" => FA_Viruses,
            "Vk" => FA_Vk,
            "Vnv" => FA_Vnv,
            "Voicemail" => FA_Voicemail,
            "Volcano" => FA_Volcano,
            "Volleyball" => FA_Volleyball,
            "Volume" => FA_Volume,
            "Volume High" => FA_VolumeHigh,
            "Volume Low" => FA_VolumeLow,
            "Volume Off" => FA_VolumeOff,
            "Volume Xmark" => FA_VolumeXmark,
            "Vr Cardboard" => FA_VrCardboard,
            "Vsco" => FA_Vsco,
            "Vuejs" => FA_Vuejs,
            "W" => FA_W,
            "W3c" => FA_W3c,
            "Walkie Talkie" => FA_WalkieTalkie,
            "Wallet" => FA_Wallet,
            "Wand Magic" => FA_WandMagic,
            "Wand Magic Sparkles" => FA_WandMagicSparkles,
            "Wand Sparkles" => FA_WandSparkles,
            "Warehouse" => FA_Warehouse,
            "Watchman Monitoring" => FA_WatchmanMonitoring,
            "Water" => FA_Water,
            "Water Ladder" => FA_WaterLadder,
            "Wave Square" => FA_WaveSquare,
            "Waze" => FA_Waze,
            "Web Awesome" => FA_WebAwesome,
            "Webflow" => FA_Webflow,
            "Weebly" => FA_Weebly,
            "Weibo" => FA_Weibo,
            "Weight Hanging" => FA_WeightHanging,
            "Weight Scale" => FA_WeightScale,
            "Weixin" => FA_Weixin,
            "Whatsapp" => FA_Whatsapp,
            "Wheat Awn" => FA_WheatAwn,
            "Wheat Awn Circle Exclamation" => FA_WheatAwnCircleExclamation,
            "Wheelchair" => FA_Wheelchair,
            "Wheelchair Move" => FA_WheelchairMove,
            "Whiskey Glass" => FA_WhiskeyGlass,
            "Whmcs" => FA_Whmcs,
            "Wifi" => FA_Wifi,
            "Wikipedia W" => FA_WikipediaW,
            "Wind" => FA_Wind,
            "Window Maximize" => FA_WindowMaximize,
            "Window Minimize" => FA_WindowMinimize,
            "Window Restore" => FA_WindowRestore,
            "Windows" => FA_Windows,
            "Wine Bottle" => FA_WineBottle,
            "Wine Glass" => FA_WineGlass,
            "Wine Glass Empty" => FA_WineGlassEmpty,
            "Wirsindhandwerk" => FA_Wirsindhandwerk,
            "Wix" => FA_Wix,
            "Wizards Of The Coast" => FA_WizardsOfTheCoast,
            "Wodu" => FA_Wodu,
            "Wolf Pack Battalion" => FA_WolfPackBattalion,
            "Won Sign" => FA_WonSign,
            "Wordpress" => FA_Wordpress,
            "Wordpress Simple" => FA_WordpressSimple,
            "Worm" => FA_Worm,
            "Wpbeginner" => FA_Wpbeginner,
            "Wpexplorer" => FA_Wpexplorer,
            "Wpforms" => FA_Wpforms,
            "Wpressr" => FA_Wpressr,
            "Wrench" => FA_Wrench,
            "X" => FA_X,
            "X Ray" => FA_XRay,
            "X Twitter" => FA_XTwitter,
            "Xbox" => FA_Xbox,
            "Xing" => FA_Xing,
            "Xmark" => FA_Xmark,
            "Xmarks Lines" => FA_XmarksLines,
            "Xmpp" => FA_Xmpp,
            "Y" => FA_Y,
            "Y Combinator" => FA_YCombinator,
            "Yahoo" => FA_Yahoo,
            "Yammer" => FA_Yammer,
            "Yandex" => FA_Yandex,
            "Yandex International" => FA_YandexInternational,
            "Yarn" => FA_Yarn,
            "Yelp" => FA_Yelp,
            "Yen Sign" => FA_YenSign,
            "Yin Yang" => FA_YinYang,
            "Yoast" => FA_Yoast,
            "Youtube" => FA_Youtube,
            "Z" => FA_Z,
            "Zhihu" => FA_Zhihu,
            "Zoom" => FA_Zoom,
            "Zulip" => FA_Zulip,
        };
        
        public static IconData GetByUnicode(string v) => v switch
        {
            "\U00000030" => FA_0,
            "\U00000031" => FA_1,
            "\U00000032" => FA_2,
            "\U00000033" => FA_3,
            "\U00000034" => FA_4,
            "\U00000035" => FA_5,
            "\U00000036" => FA_6,
            "\U00000037" => FA_7,
            "\U00000038" => FA_8,
            "\U00000039" => FA_9,
            "\U0000E080" => FA_42Group,
            "\U0000F26E" => FA_500px,
            "\U00000041" => FA_A,
            "\U0000F368" => FA_AccessibleIcon,
            "\U0000F369" => FA_Accusoft,
            "\U0000F2B9" => FA_AddressBook,
            "\U0000F2BB" => FA_AddressCard,
            "\U0000F170" => FA_Adn,
            "\U0000F36A" => FA_Adversal,
            "\U0000F36B" => FA_Affiliatetheme,
            "\U0000F834" => FA_Airbnb,
            "\U0000F34E" => FA_AlarmClock,
            "\U0000F36C" => FA_Algolia,
            "\U0000F037" => FA_AlignCenter,
            "\U0000F039" => FA_AlignJustify,
            "\U0000F036" => FA_AlignLeft,
            "\U0000F038" => FA_AlignRight,
            "\U0000F642" => FA_Alipay,
            "\U0000F270" => FA_Amazon,
            "\U0000F42C" => FA_AmazonPay,
            "\U0000F36D" => FA_Amilia,
            "\U0000F13D" => FA_Anchor,
            "\U0000E4AA" => FA_AnchorCircleCheck,
            "\U0000E4AB" => FA_AnchorCircleExclamation,
            "\U0000E4AC" => FA_AnchorCircleXmark,
            "\U0000E4AD" => FA_AnchorLock,
            "\U0000F17B" => FA_Android,
            "\U0000F209" => FA_Angellist,
            "\U0000F107" => FA_AngleDown,
            "\U0000F104" => FA_AngleLeft,
            "\U0000F105" => FA_AngleRight,
            "\U0000F106" => FA_AngleUp,
            "\U0000F103" => FA_AnglesDown,
            "\U0000F100" => FA_AnglesLeft,
            "\U0000F101" => FA_AnglesRight,
            "\U0000F102" => FA_AnglesUp,
            "\U0000F36E" => FA_Angrycreative,
            "\U0000F420" => FA_Angular,
            "\U0000F644" => FA_Ankh,
            "\U0000F36F" => FA_AppStore,
            "\U0000F370" => FA_AppStoreIos,
            "\U0000F371" => FA_Apper,
            "\U0000F179" => FA_Apple,
            "\U0000F415" => FA_ApplePay,
            "\U0000F5D1" => FA_AppleWhole,
            "\U0000E845" => FA_Aquarius,
            "\U0000E867" => FA_ArchLinux,
            "\U0000F557" => FA_Archway,
            "\U0000E846" => FA_Aries,
            "\U0000F063" => FA_ArrowDown,
            "\U0000F162" => FA_ArrowDown19,
            "\U0000F886" => FA_ArrowDown91,
            "\U0000F15D" => FA_ArrowDownAZ,
            "\U0000F175" => FA_ArrowDownLong,
            "\U0000F884" => FA_ArrowDownShortWide,
            "\U0000E4AF" => FA_ArrowDownUpAcrossLine,
            "\U0000E4B0" => FA_ArrowDownUpLock,
            "\U0000F160" => FA_ArrowDownWideShort,
            "\U0000F881" => FA_ArrowDownZA,
            "\U0000F060" => FA_ArrowLeft,
            "\U0000F177" => FA_ArrowLeftLong,
            "\U0000F245" => FA_ArrowPointer,
            "\U0000F061" => FA_ArrowRight,
            "\U0000F0EC" => FA_ArrowRightArrowLeft,
            "\U0000F08B" => FA_ArrowRightFromBracket,
            "\U0000F178" => FA_ArrowRightLong,
            "\U0000F090" => FA_ArrowRightToBracket,
            "\U0000E4B3" => FA_ArrowRightToCity,
            "\U0000F0E2" => FA_ArrowRotateLeft,
            "\U0000F01E" => FA_ArrowRotateRight,
            "\U0000E097" => FA_ArrowTrendDown,
            "\U0000E098" => FA_ArrowTrendUp,
            "\U0000F149" => FA_ArrowTurnDown,
            "\U0000F148" => FA_ArrowTurnUp,
            "\U0000F062" => FA_ArrowUp,
            "\U0000F163" => FA_ArrowUp19,
            "\U0000F887" => FA_ArrowUp91,
            "\U0000F15E" => FA_ArrowUpAZ,
            "\U0000E09A" => FA_ArrowUpFromBracket,
            "\U0000E4B5" => FA_ArrowUpFromGroundWater,
            "\U0000E4B6" => FA_ArrowUpFromWaterPump,
            "\U0000F176" => FA_ArrowUpLong,
            "\U0000E4B7" => FA_ArrowUpRightDots,
            "\U0000F08E" => FA_ArrowUpRightFromSquare,
            "\U0000F885" => FA_ArrowUpShortWide,
            "\U0000F161" => FA_ArrowUpWideShort,
            "\U0000F882" => FA_ArrowUpZA,
            "\U0000E4B8" => FA_ArrowsDownToLine,
            "\U0000E4B9" => FA_ArrowsDownToPeople,
            "\U0000F07E" => FA_ArrowsLeftRight,
            "\U0000E4BA" => FA_ArrowsLeftRightToLine,
            "\U0000F021" => FA_ArrowsRotate,
            "\U0000E4BB" => FA_ArrowsSpin,
            "\U0000E4BC" => FA_ArrowsSplitUpAndLeft,
            "\U0000E4BD" => FA_ArrowsToCircle,
            "\U0000E4BE" => FA_ArrowsToDot,
            "\U0000E4BF" => FA_ArrowsToEye,
            "\U0000E4C0" => FA_ArrowsTurnRight,
            "\U0000E4C1" => FA_ArrowsTurnToDots,
            "\U0000F07D" => FA_ArrowsUpDown,
            "\U0000F047" => FA_ArrowsUpDownLeftRight,
            "\U0000E4C2" => FA_ArrowsUpToLine,
            "\U0000F77A" => FA_Artstation,
            "\U0000002A" => FA_Asterisk,
            "\U0000F372" => FA_Asymmetrik,
            "\U00000040" => FA_At,
            "\U0000F77B" => FA_Atlassian,
            "\U0000F5D2" => FA_Atom,
            "\U0000F373" => FA_Audible,
            "\U0000F29E" => FA_AudioDescription,
            "\U0000E0A9" => FA_AustralSign,
            "\U0000F41C" => FA_Autoprefixer,
            "\U0000F374" => FA_Avianex,
            "\U0000F421" => FA_Aviato,
            "\U0000F559" => FA_Award,
            "\U0000F375" => FA_Aws,
            "\U00000042" => FA_B,
            "\U0000F77C" => FA_Baby,
            "\U0000F77D" => FA_BabyCarriage,
            "\U0000F04A" => FA_Backward,
            "\U0000F049" => FA_BackwardFast,
            "\U0000F048" => FA_BackwardStep,
            "\U0000F7E5" => FA_Bacon,
            "\U0000E059" => FA_Bacteria,
            "\U0000E05A" => FA_Bacterium,
            "\U0000F290" => FA_BagShopping,
            "\U0000F666" => FA_Bahai,
            "\U0000E0AC" => FA_BahtSign,
            "\U0000F05E" => FA_Ban,
            "\U0000F54D" => FA_BanSmoking,
            "\U0000F462" => FA_Bandage,
            "\U0000F2D5" => FA_Bandcamp,
            "\U0000E2E6" => FA_BangladeshiTakaSign,
            "\U0000F02A" => FA_Barcode,
            "\U0000F0C9" => FA_Bars,
            "\U0000F828" => FA_BarsProgress,
            "\U0000F550" => FA_BarsStaggered,
            "\U0000F433" => FA_Baseball,
            "\U0000F432" => FA_BaseballBatBall,
            "\U0000F291" => FA_BasketShopping,
            "\U0000F434" => FA_Basketball,
            "\U0000F2CD" => FA_Bath,
            "\U0000F244" => FA_BatteryEmpty,
            "\U0000F240" => FA_BatteryFull,
            "\U0000F242" => FA_BatteryHalf,
            "\U0000F243" => FA_BatteryQuarter,
            "\U0000F241" => FA_BatteryThreeQuarters,
            "\U0000F835" => FA_BattleNet,
            "\U0000F236" => FA_Bed,
            "\U0000F487" => FA_BedPulse,
            "\U0000F0FC" => FA_BeerMugEmpty,
            "\U0000F1B4" => FA_Behance,
            "\U0000F0F3" => FA_Bell,
            "\U0000F562" => FA_BellConcierge,
            "\U0000F1F6" => FA_BellSlash,
            "\U0000F55B" => FA_BezierCurve,
            "\U0000F206" => FA_Bicycle,
            "\U0000E3D9" => FA_Bilibili,
            "\U0000F378" => FA_Bimobject,
            "\U0000F1E5" => FA_Binoculars,
            "\U0000F780" => FA_Biohazard,
            "\U0000F171" => FA_Bitbucket,
            "\U0000F379" => FA_Bitcoin,
            "\U0000E0B4" => FA_BitcoinSign,
            "\U0000F37A" => FA_Bity,
            "\U0000F27E" => FA_BlackTie,
            "\U0000F37B" => FA_Blackberry,
            "\U0000F517" => FA_Blender,
            "\U0000F6B6" => FA_BlenderPhone,
            "\U0000F781" => FA_Blog,
            "\U0000F37C" => FA_Blogger,
            "\U0000F37D" => FA_BloggerB,
            "\U0000E671" => FA_Bluesky,
            "\U0000F293" => FA_Bluetooth,
            "\U0000F294" => FA_BluetoothB,
            "\U0000E855" => FA_BoardGameGeek,
            "\U0000F032" => FA_Bold,
            "\U0000F0E7" => FA_Bolt,
            "\U0000E0B7" => FA_BoltLightning,
            "\U0000F1E2" => FA_Bomb,
            "\U0000F5D7" => FA_Bone,
            "\U0000F55C" => FA_Bong,
            "\U0000F02D" => FA_Book,
            "\U0000F558" => FA_BookAtlas,
            "\U0000F647" => FA_BookBible,
            "\U0000E0BB" => FA_BookBookmark,
            "\U0000F66A" => FA_BookJournalWhills,
            "\U0000F7E6" => FA_BookMedical,
            "\U0000F518" => FA_BookOpen,
            "\U0000F5DA" => FA_BookOpenReader,
            "\U0000F687" => FA_BookQuran,
            "\U0000F6B7" => FA_BookSkull,
            "\U0000F827" => FA_BookTanakh,
            "\U0000F02E" => FA_Bookmark,
            "\U0000F836" => FA_Bootstrap,
            "\U0000F84C" => FA_BorderAll,
            "\U0000F850" => FA_BorderNone,
            "\U0000F853" => FA_BorderTopLeft,
            "\U0000E4C3" => FA_BoreHole,
            "\U0000E340" => FA_Bots,
            "\U0000E4C4" => FA_BottleDroplet,
            "\U0000E4C5" => FA_BottleWater,
            "\U0000E4C6" => FA_BowlFood,
            "\U0000E2EB" => FA_BowlRice,
            "\U0000F436" => FA_BowlingBall,
            "\U0000F466" => FA_Box,
            "\U0000F187" => FA_BoxArchive,
            "\U0000F49E" => FA_BoxOpen,
            "\U0000E05B" => FA_BoxTissue,
            "\U0000E4C7" => FA_BoxesPacking,
            "\U0000F468" => FA_BoxesStacked,
            "\U0000F2A1" => FA_Braille,
            "\U0000F5DC" => FA_Brain,
            "\U0000E63C" => FA_Brave,
            "\U0000E63D" => FA_BraveReverse,
            "\U0000E46C" => FA_BrazilianRealSign,
            "\U0000F7EC" => FA_BreadSlice,
            "\U0000E4C8" => FA_Bridge,
            "\U0000E4C9" => FA_BridgeCircleCheck,
            "\U0000E4CA" => FA_BridgeCircleExclamation,
            "\U0000E4CB" => FA_BridgeCircleXmark,
            "\U0000E4CC" => FA_BridgeLock,
            "\U0000E4CE" => FA_BridgeWater,
            "\U0000F0B1" => FA_Briefcase,
            "\U0000F469" => FA_BriefcaseMedical,
            "\U0000F51A" => FA_Broom,
            "\U0000F458" => FA_BroomBall,
            "\U0000F55D" => FA_Brush,
            "\U0000F15A" => FA_Btc,
            "\U0000E4CF" => FA_Bucket,
            "\U0000F837" => FA_Buffer,
            "\U0000F188" => FA_Bug,
            "\U0000E490" => FA_BugSlash,
            "\U0000E4D0" => FA_Bugs,
            "\U0000F1AD" => FA_Building,
            "\U0000E4D1" => FA_BuildingCircleArrowRight,
            "\U0000E4D2" => FA_BuildingCircleCheck,
            "\U0000E4D3" => FA_BuildingCircleExclamation,
            "\U0000E4D4" => FA_BuildingCircleXmark,
            "\U0000F19C" => FA_BuildingColumns,
            "\U0000E4D5" => FA_BuildingFlag,
            "\U0000E4D6" => FA_BuildingLock,
            "\U0000E4D7" => FA_BuildingNgo,
            "\U0000E4D8" => FA_BuildingShield,
            "\U0000E4D9" => FA_BuildingUn,
            "\U0000E4DA" => FA_BuildingUser,
            "\U0000E4DB" => FA_BuildingWheat,
            "\U0000F0A1" => FA_Bullhorn,
            "\U0000F140" => FA_Bullseye,
            "\U0000F805" => FA_Burger,
            "\U0000F37F" => FA_Buromobelexperte,
            "\U0000E4DC" => FA_Burst,
            "\U0000F207" => FA_Bus,
            "\U0000E81D" => FA_BusSide,
            "\U0000F55E" => FA_BusSimple,
            "\U0000F64A" => FA_BusinessTime,
            "\U0000F8A6" => FA_BuyNLarge,
            "\U0000F20D" => FA_Buysellads,
            "\U00000043" => FA_C,
            "\U0000F7DA" => FA_CableCar,
            "\U0000F1FD" => FA_CakeCandles,
            "\U0000F1EC" => FA_Calculator,
            "\U0000F133" => FA_Calendar,
            "\U0000F274" => FA_CalendarCheck,
            "\U0000F783" => FA_CalendarDay,
            "\U0000F073" => FA_CalendarDays,
            "\U0000F272" => FA_CalendarMinus,
            "\U0000F271" => FA_CalendarPlus,
            "\U0000F784" => FA_CalendarWeek,
            "\U0000F273" => FA_CalendarXmark,
            "\U0000F030" => FA_Camera,
            "\U0000F083" => FA_CameraRetro,
            "\U0000E0D8" => FA_CameraRotate,
            "\U0000F6BB" => FA_Campground,
            "\U0000F785" => FA_CanadianMapleLeaf,
            "\U0000E847" => FA_Cancer,
            "\U0000F786" => FA_CandyCane,
            "\U0000F55F" => FA_Cannabis,
            "\U0000E848" => FA_Capricorn,
            "\U0000F46B" => FA_Capsules,
            "\U0000F1B9" => FA_Car,
            "\U0000F5DF" => FA_CarBattery,
            "\U0000F5E1" => FA_CarBurst,
            "\U0000E4DD" => FA_CarOn,
            "\U0000F5DE" => FA_CarRear,
            "\U0000F5E4" => FA_CarSide,
            "\U0000E4DE" => FA_CarTunnel,
            "\U0000F8FF" => FA_Caravan,
            "\U0000F0D7" => FA_CaretDown,
            "\U0000F0D9" => FA_CaretLeft,
            "\U0000F0DA" => FA_CaretRight,
            "\U0000F0D8" => FA_CaretUp,
            "\U0000F787" => FA_Carrot,
            "\U0000F218" => FA_CartArrowDown,
            "\U0000F474" => FA_CartFlatbed,
            "\U0000F59D" => FA_CartFlatbedSuitcase,
            "\U0000F217" => FA_CartPlus,
            "\U0000F07A" => FA_CartShopping,
            "\U0000E7D4" => FA_CashApp,
            "\U0000F788" => FA_CashRegister,
            "\U0000F6BE" => FA_Cat,
            "\U0000F42D" => FA_CcAmazonPay,
            "\U0000F1F3" => FA_CcAmex,
            "\U0000F416" => FA_CcApplePay,
            "\U0000F24C" => FA_CcDinersClub,
            "\U0000F1F2" => FA_CcDiscover,
            "\U0000F24B" => FA_CcJcb,
            "\U0000F1F1" => FA_CcMastercard,
            "\U0000F1F4" => FA_CcPaypal,
            "\U0000F1F5" => FA_CcStripe,
            "\U0000F1F0" => FA_CcVisa,
            "\U0000E0DF" => FA_CediSign,
            "\U0000E3F5" => FA_CentSign,
            "\U0000F380" => FA_Centercode,
            "\U0000F789" => FA_Centos,
            "\U0000F0A3" => FA_Certificate,
            "\U0000F6C0" => FA_Chair,
            "\U0000F51B" => FA_Chalkboard,
            "\U0000F51C" => FA_ChalkboardUser,
            "\U0000F79F" => FA_ChampagneGlasses,
            "\U0000F5E7" => FA_ChargingStation,
            "\U0000F1FE" => FA_ChartArea,
            "\U0000F080" => FA_ChartBar,
            "\U0000E0E3" => FA_ChartColumn,
            "\U0000E695" => FA_ChartDiagram,
            "\U0000E0E4" => FA_ChartGantt,
            "\U0000F201" => FA_ChartLine,
            "\U0000F200" => FA_ChartPie,
            "\U0000E473" => FA_ChartSimple,
            "\U0000F00C" => FA_Check,
            "\U0000F560" => FA_CheckDouble,
            "\U0000F772" => FA_CheckToSlot,
            "\U0000F7EF" => FA_Cheese,
            "\U0000F439" => FA_Chess,
            "\U0000F43A" => FA_ChessBishop,
            "\U0000F43C" => FA_ChessBoard,
            "\U0000F43F" => FA_ChessKing,
            "\U0000F441" => FA_ChessKnight,
            "\U0000F443" => FA_ChessPawn,
            "\U0000F445" => FA_ChessQueen,
            "\U0000F447" => FA_ChessRook,
            "\U0000F078" => FA_ChevronDown,
            "\U0000F053" => FA_ChevronLeft,
            "\U0000F054" => FA_ChevronRight,
            "\U0000F077" => FA_ChevronUp,
            "\U0000F1AE" => FA_Child,
            "\U0000E4E0" => FA_ChildCombatant,
            "\U0000E59C" => FA_ChildDress,
            "\U0000E59D" => FA_ChildReaching,
            "\U0000E4E1" => FA_Children,
            "\U0000F268" => FA_Chrome,
            "\U0000F838" => FA_Chromecast,
            "\U0000F51D" => FA_Church,
            "\U0000F111" => FA_Circle,
            "\U0000F0AB" => FA_CircleArrowDown,
            "\U0000F0A8" => FA_CircleArrowLeft,
            "\U0000F0A9" => FA_CircleArrowRight,
            "\U0000F0AA" => FA_CircleArrowUp,
            "\U0000F058" => FA_CircleCheck,
            "\U0000F13A" => FA_CircleChevronDown,
            "\U0000F137" => FA_CircleChevronLeft,
            "\U0000F138" => FA_CircleChevronRight,
            "\U0000F139" => FA_CircleChevronUp,
            "\U0000F4B9" => FA_CircleDollarToSlot,
            "\U0000F192" => FA_CircleDot,
            "\U0000F358" => FA_CircleDown,
            "\U0000F06A" => FA_CircleExclamation,
            "\U0000F47E" => FA_CircleH,
            "\U0000F042" => FA_CircleHalfStroke,
            "\U0000F05A" => FA_CircleInfo,
            "\U0000F359" => FA_CircleLeft,
            "\U0000F056" => FA_CircleMinus,
            "\U0000E4E2" => FA_CircleNodes,
            "\U0000F1CE" => FA_CircleNotch,
            "\U0000F28B" => FA_CirclePause,
            "\U0000F144" => FA_CirclePlay,
            "\U0000F055" => FA_CirclePlus,
            "\U0000F059" => FA_CircleQuestion,
            "\U0000F7BA" => FA_CircleRadiation,
            "\U0000F35A" => FA_CircleRight,
            "\U0000F28D" => FA_CircleStop,
            "\U0000F35B" => FA_CircleUp,
            "\U0000F2BD" => FA_CircleUser,
            "\U0000F057" => FA_CircleXmark,
            "\U0000E851" => FA_CircleZulip,
            "\U0000F64F" => FA_City,
            "\U0000E131" => FA_Clapperboard,
            "\U0000E861" => FA_Claude,
            "\U0000F328" => FA_Clipboard,
            "\U0000F46C" => FA_ClipboardCheck,
            "\U0000F46D" => FA_ClipboardList,
            "\U0000E4E3" => FA_ClipboardQuestion,
            "\U0000F7F3" => FA_ClipboardUser,
            "\U0000F017" => FA_Clock,
            "\U0000F1DA" => FA_ClockRotateLeft,
            "\U0000F24D" => FA_Clone,
            "\U0000F20A" => FA_ClosedCaptioning,
            "\U0000E135" => FA_ClosedCaptioningSlash,
            "\U0000F0C2" => FA_Cloud,
            "\U0000F0ED" => FA_CloudArrowDown,
            "\U0000F0EE" => FA_CloudArrowUp,
            "\U0000F76C" => FA_CloudBolt,
            "\U0000F73B" => FA_CloudMeatball,
            "\U0000F6C3" => FA_CloudMoon,
            "\U0000F73C" => FA_CloudMoonRain,
            "\U0000F73D" => FA_CloudRain,
            "\U0000F740" => FA_CloudShowersHeavy,
            "\U0000E4E4" => FA_CloudShowersWater,
            "\U0000F6C4" => FA_CloudSun,
            "\U0000F743" => FA_CloudSunRain,
            "\U0000E07D" => FA_Cloudflare,
            "\U0000F383" => FA_Cloudscale,
            "\U0000F384" => FA_Cloudsmith,
            "\U0000F385" => FA_Cloudversify,
            "\U0000E139" => FA_Clover,
            "\U0000E360" => FA_Cmplid,
            "\U0000F121" => FA_Code,
            "\U0000F126" => FA_CodeBranch,
            "\U0000F386" => FA_CodeCommit,
            "\U0000E13A" => FA_CodeCompare,
            "\U0000E13B" => FA_CodeFork,
            "\U0000F387" => FA_CodeMerge,
            "\U0000E13C" => FA_CodePullRequest,
            "\U0000F1CB" => FA_Codepen,
            "\U0000F284" => FA_Codiepie,
            "\U0000F51E" => FA_Coins,
            "\U0000E140" => FA_ColonSign,
            "\U0000F075" => FA_Comment,
            "\U0000F651" => FA_CommentDollar,
            "\U0000F4AD" => FA_CommentDots,
            "\U0000F7F5" => FA_CommentMedical,
            "\U0000E696" => FA_CommentNodes,
            "\U0000F4B3" => FA_CommentSlash,
            "\U0000F7CD" => FA_CommentSms,
            "\U0000F086" => FA_Comments,
            "\U0000F653" => FA_CommentsDollar,
            "\U0000F51F" => FA_CompactDisc,
            "\U0000F14E" => FA_Compass,
            "\U0000F568" => FA_CompassDrafting,
            "\U0000F066" => FA_Compress,
            "\U0000E4E5" => FA_Computer,
            "\U0000F8CC" => FA_ComputerMouse,
            "\U0000F78D" => FA_Confluence,
            "\U0000F20E" => FA_Connectdevelop,
            "\U0000F26D" => FA_Contao,
            "\U0000F563" => FA_Cookie,
            "\U0000F564" => FA_CookieBite,
            "\U0000F0C5" => FA_Copy,
            "\U0000F1F9" => FA_Copyright,
            "\U0000F89E" => FA_CottonBureau,
            "\U0000F4B8" => FA_Couch,
            "\U0000F6C8" => FA_Cow,
            "\U0000F388" => FA_Cpanel,
            "\U0000F25E" => FA_CreativeCommons,
            "\U0000F4E7" => FA_CreativeCommonsBy,
            "\U0000F4E8" => FA_CreativeCommonsNc,
            "\U0000F4E9" => FA_CreativeCommonsNcEu,
            "\U0000F4EA" => FA_CreativeCommonsNcJp,
            "\U0000F4EB" => FA_CreativeCommonsNd,
            "\U0000F4EC" => FA_CreativeCommonsPd,
            "\U0000F4ED" => FA_CreativeCommonsPdAlt,
            "\U0000F4EE" => FA_CreativeCommonsRemix,
            "\U0000F4EF" => FA_CreativeCommonsSa,
            "\U0000F4F0" => FA_CreativeCommonsSampling,
            "\U0000F4F1" => FA_CreativeCommonsSamplingPlus,
            "\U0000F4F2" => FA_CreativeCommonsShare,
            "\U0000F4F3" => FA_CreativeCommonsZero,
            "\U0000F09D" => FA_CreditCard,
            "\U0000F6C9" => FA_CriticalRole,
            "\U0000F125" => FA_Crop,
            "\U0000F565" => FA_CropSimple,
            "\U0000F654" => FA_Cross,
            "\U0000F05B" => FA_Crosshairs,
            "\U0000F520" => FA_Crow,
            "\U0000F521" => FA_Crown,
            "\U0000F7F7" => FA_Crutch,
            "\U0000E152" => FA_CruzeiroSign,
            "\U0000E6A2" => FA_Css,
            "\U0000F13C" => FA_Css3,
            "\U0000F38B" => FA_Css3Alt,
            "\U0000F1B2" => FA_Cube,
            "\U0000F1B3" => FA_Cubes,
            "\U0000E4E6" => FA_CubesStacked,
            "\U0000F38C" => FA_Cuttlefish,
            "\U00000044" => FA_D,
            "\U0000F38D" => FA_DAndD,
            "\U0000F6CA" => FA_DAndDBeyond,
            "\U0000E052" => FA_Dailymotion,
            "\U0000E693" => FA_DartLang,
            "\U0000F210" => FA_Dashcube,
            "\U0000F1C0" => FA_Database,
            "\U0000E60B" => FA_Debian,
            "\U0000E077" => FA_Deezer,
            "\U0000F55A" => FA_DeleteLeft,
            "\U0000F1A5" => FA_Delicious,
            "\U0000F747" => FA_Democrat,
            "\U0000F38E" => FA_Deploydog,
            "\U0000F38F" => FA_Deskpro,
            "\U0000F390" => FA_Desktop,
            "\U0000F6CC" => FA_Dev,
            "\U0000F1BD" => FA_Deviantart,
            "\U0000F655" => FA_Dharmachakra,
            "\U0000F790" => FA_Dhl,
            "\U0000E476" => FA_DiagramNext,
            "\U0000E477" => FA_DiagramPredecessor,
            "\U0000F542" => FA_DiagramProject,
            "\U0000E47A" => FA_DiagramSuccessor,
            "\U0000F219" => FA_Diamond,
            "\U0000F5EB" => FA_DiamondTurnRight,
            "\U0000F791" => FA_Diaspora,
            "\U0000F522" => FA_Dice,
            "\U0000F6CF" => FA_DiceD20,
            "\U0000F6D1" => FA_DiceD6,
            "\U0000F523" => FA_DiceFive,
            "\U0000F524" => FA_DiceFour,
            "\U0000F525" => FA_DiceOne,
            "\U0000F526" => FA_DiceSix,
            "\U0000F527" => FA_DiceThree,
            "\U0000F528" => FA_DiceTwo,
            "\U0000F1A6" => FA_Digg,
            "\U0000F391" => FA_DigitalOcean,
            "\U0000F392" => FA_Discord,
            "\U0000F393" => FA_Discourse,
            "\U0000F7FA" => FA_Disease,
            "\U0000E163" => FA_Display,
            "\U0000E7D5" => FA_Disqus,
            "\U0000F529" => FA_Divide,
            "\U0000F471" => FA_Dna,
            "\U0000F394" => FA_Dochub,
            "\U0000F395" => FA_Docker,
            "\U0000F6D3" => FA_Dog,
            "\U00000024" => FA_DollarSign,
            "\U0000F472" => FA_Dolly,
            "\U0000E169" => FA_DongSign,
            "\U0000F52A" => FA_DoorClosed,
            "\U0000F52B" => FA_DoorOpen,
            "\U0000F4BA" => FA_Dove,
            "\U0000F422" => FA_DownLeftAndUpRightToCenter,
            "\U0000F309" => FA_DownLong,
            "\U0000F019" => FA_Download,
            "\U0000F396" => FA_Draft2digital,
            "\U0000F6D5" => FA_Dragon,
            "\U0000F5EE" => FA_DrawPolygon,
            "\U0000F17D" => FA_Dribbble,
            "\U0000F16B" => FA_Dropbox,
            "\U0000F043" => FA_Droplet,
            "\U0000F5C7" => FA_DropletSlash,
            "\U0000F569" => FA_Drum,
            "\U0000F56A" => FA_DrumSteelpan,
            "\U0000F6D7" => FA_DrumstickBite,
            "\U0000F1A9" => FA_Drupal,
            "\U0000F44B" => FA_Dumbbell,
            "\U0000F793" => FA_Dumpster,
            "\U0000F794" => FA_DumpsterFire,
            "\U0000F6D9" => FA_Dungeon,
            "\U0000E812" => FA_Duolingo,
            "\U0000F399" => FA_Dyalog,
            "\U00000045" => FA_E,
            "\U0000F2A4" => FA_EarDeaf,
            "\U0000F2A2" => FA_EarListen,
            "\U0000F39A" => FA_Earlybirds,
            "\U0000F57C" => FA_EarthAfrica,
            "\U0000F57D" => FA_EarthAmericas,
            "\U0000F57E" => FA_EarthAsia,
            "\U0000F7A2" => FA_EarthEurope,
            "\U0000E47B" => FA_EarthOceania,
            "\U0000F4F4" => FA_Ebay,
            "\U0000F282" => FA_Edge,
            "\U0000E078" => FA_EdgeLegacy,
            "\U0000F7FB" => FA_Egg,
            "\U0000F052" => FA_Eject,
            "\U0000F430" => FA_Elementor,
            "\U0000E16D" => FA_Elevator,
            "\U0000E7D6" => FA_Eleventy,
            "\U0000F141" => FA_Ellipsis,
            "\U0000F142" => FA_EllipsisVertical,
            "\U0000F5F1" => FA_Ello,
            "\U0000F423" => FA_Ember,
            "\U0000F1D1" => FA_Empire,
            "\U0000F0E0" => FA_Envelope,
            "\U0000E4E8" => FA_EnvelopeCircleCheck,
            "\U0000F2B6" => FA_EnvelopeOpen,
            "\U0000F658" => FA_EnvelopeOpenText,
            "\U0000F674" => FA_EnvelopesBulk,
            "\U0000F299" => FA_Envira,
            "\U0000003D" => FA_Equals,
            "\U0000F12D" => FA_Eraser,
            "\U0000F39D" => FA_Erlang,
            "\U0000F42E" => FA_Ethereum,
            "\U0000F796" => FA_Ethernet,
            "\U0000F2D7" => FA_Etsy,
            "\U0000F153" => FA_EuroSign,
            "\U0000F839" => FA_Evernote,
            "\U00000021" => FA_Exclamation,
            "\U0000F065" => FA_Expand,
            "\U0000F23E" => FA_Expeditedssl,
            "\U0000E4E9" => FA_Explosion,
            "\U0000F06E" => FA_Eye,
            "\U0000F1FB" => FA_EyeDropper,
            "\U0000F2A8" => FA_EyeLowVision,
            "\U0000F070" => FA_EyeSlash,
            "\U00000046" => FA_F,
            "\U0000F556" => FA_FaceAngry,
            "\U0000F567" => FA_FaceDizzy,
            "\U0000F579" => FA_FaceFlushed,
            "\U0000F119" => FA_FaceFrown,
            "\U0000F57A" => FA_FaceFrownOpen,
            "\U0000F57F" => FA_FaceGrimace,
            "\U0000F580" => FA_FaceGrin,
            "\U0000F582" => FA_FaceGrinBeam,
            "\U0000F583" => FA_FaceGrinBeamSweat,
            "\U0000F584" => FA_FaceGrinHearts,
            "\U0000F585" => FA_FaceGrinSquint,
            "\U0000F586" => FA_FaceGrinSquintTears,
            "\U0000F587" => FA_FaceGrinStars,
            "\U0000F588" => FA_FaceGrinTears,
            "\U0000F589" => FA_FaceGrinTongue,
            "\U0000F58A" => FA_FaceGrinTongueSquint,
            "\U0000F58B" => FA_FaceGrinTongueWink,
            "\U0000F581" => FA_FaceGrinWide,
            "\U0000F58C" => FA_FaceGrinWink,
            "\U0000F596" => FA_FaceKiss,
            "\U0000F597" => FA_FaceKissBeam,
            "\U0000F598" => FA_FaceKissWinkHeart,
            "\U0000F599" => FA_FaceLaugh,
            "\U0000F59A" => FA_FaceLaughBeam,
            "\U0000F59B" => FA_FaceLaughSquint,
            "\U0000F59C" => FA_FaceLaughWink,
            "\U0000F11A" => FA_FaceMeh,
            "\U0000F5A4" => FA_FaceMehBlank,
            "\U0000F5A5" => FA_FaceRollingEyes,
            "\U0000F5B3" => FA_FaceSadCry,
            "\U0000F5B4" => FA_FaceSadTear,
            "\U0000F118" => FA_FaceSmile,
            "\U0000F5B8" => FA_FaceSmileBeam,
            "\U0000F4DA" => FA_FaceSmileWink,
            "\U0000F5C2" => FA_FaceSurprise,
            "\U0000F5C8" => FA_FaceTired,
            "\U0000F09A" => FA_Facebook,
            "\U0000F39E" => FA_FacebookF,
            "\U0000F39F" => FA_FacebookMessenger,
            "\U0000F863" => FA_Fan,
            "\U0000F6DC" => FA_FantasyFlightGames,
            "\U0000E005" => FA_Faucet,
            "\U0000E006" => FA_FaucetDrip,
            "\U0000F1AC" => FA_Fax,
            "\U0000F52D" => FA_Feather,
            "\U0000F56B" => FA_FeatherPointed,
            "\U0000F797" => FA_Fedex,
            "\U0000E865" => FA_Fediverse,
            "\U0000F798" => FA_Fedora,
            "\U0000E4EA" => FA_Ferry,
            "\U0000F799" => FA_Figma,
            "\U0000F15B" => FA_File,
            "\U0000F56D" => FA_FileArrowDown,
            "\U0000F574" => FA_FileArrowUp,
            "\U0000F1C7" => FA_FileAudio,
            "\U0000E5A0" => FA_FileCircleCheck,
            "\U0000E4EB" => FA_FileCircleExclamation,
            "\U0000E4ED" => FA_FileCircleMinus,
            "\U0000E494" => FA_FileCirclePlus,
            "\U0000E4EF" => FA_FileCircleQuestion,
            "\U0000E5A1" => FA_FileCircleXmark,
            "\U0000F1C9" => FA_FileCode,
            "\U0000F56C" => FA_FileContract,
            "\U0000F6DD" => FA_FileCsv,
            "\U0000F1C3" => FA_FileExcel,
            "\U0000F56E" => FA_FileExport,
            "\U0000E697" => FA_FileFragment,
            "\U0000E698" => FA_FileHalfDashed,
            "\U0000F1C5" => FA_FileImage,
            "\U0000F56F" => FA_FileImport,
            "\U0000F570" => FA_FileInvoice,
            "\U0000F571" => FA_FileInvoiceDollar,
            "\U0000F15C" => FA_FileLines,
            "\U0000F477" => FA_FileMedical,
            "\U0000F1C1" => FA_FilePdf,
            "\U0000F31C" => FA_FilePen,
            "\U0000F1C4" => FA_FilePowerpoint,
            "\U0000F572" => FA_FilePrescription,
            "\U0000E4F0" => FA_FileShield,
            "\U0000F573" => FA_FileSignature,
            "\U0000F1C8" => FA_FileVideo,
            "\U0000F478" => FA_FileWaveform,
            "\U0000F1C2" => FA_FileWord,
            "\U0000F1C6" => FA_FileZipper,
            "\U0000E69F" => FA_FilesPinwheel,
            "\U0000F575" => FA_Fill,
            "\U0000F576" => FA_FillDrip,
            "\U0000F008" => FA_Film,
            "\U0000F0B0" => FA_Filter,
            "\U0000F662" => FA_FilterCircleDollar,
            "\U0000E17B" => FA_FilterCircleXmark,
            "\U0000F577" => FA_Fingerprint,
            "\U0000F06D" => FA_Fire,
            "\U0000E4F1" => FA_FireBurner,
            "\U0000F134" => FA_FireExtinguisher,
            "\U0000F7E4" => FA_FireFlameCurved,
            "\U0000F46A" => FA_FireFlameSimple,
            "\U0000F269" => FA_Firefox,
            "\U0000E007" => FA_FirefoxBrowser,
            "\U0000F2B0" => FA_FirstOrder,
            "\U0000F50A" => FA_FirstOrderAlt,
            "\U0000F3A1" => FA_Firstdraft,
            "\U0000F578" => FA_Fish,
            "\U0000E4F2" => FA_FishFins,
            "\U0000F024" => FA_Flag,
            "\U0000F11E" => FA_FlagCheckered,
            "\U0000F74D" => FA_FlagUsa,
            "\U0000F0C3" => FA_Flask,
            "\U0000E4F3" => FA_FlaskVial,
            "\U0000F16E" => FA_Flickr,
            "\U0000F44D" => FA_Flipboard,
            "\U0000F0C7" => FA_FloppyDisk,
            "\U0000E184" => FA_FlorinSign,
            "\U0000E694" => FA_Flutter,
            "\U0000F417" => FA_Fly,
            "\U0000F07B" => FA_Folder,
            "\U0000E185" => FA_FolderClosed,
            "\U0000F65D" => FA_FolderMinus,
            "\U0000F07C" => FA_FolderOpen,
            "\U0000F65E" => FA_FolderPlus,
            "\U0000F802" => FA_FolderTree,
            "\U0000F031" => FA_Font,
            "\U0000F2B4" => FA_FontAwesome,
            "\U0000F280" => FA_Fonticons,
            "\U0000F3A2" => FA_FonticonsFi,
            "\U0000F44E" => FA_Football,
            "\U0000E860" => FA_Forgejo,
            "\U0000F286" => FA_FortAwesome,
            "\U0000F3A3" => FA_FortAwesomeAlt,
            "\U0000F211" => FA_Forumbee,
            "\U0000F04E" => FA_Forward,
            "\U0000F050" => FA_ForwardFast,
            "\U0000F051" => FA_ForwardStep,
            "\U0000F180" => FA_Foursquare,
            "\U0000E18F" => FA_FrancSign,
            "\U0000F2C5" => FA_FreeCodeCamp,
            "\U0000F3A4" => FA_Freebsd,
            "\U0000F52E" => FA_Frog,
            "\U0000F50B" => FA_Fulcrum,
            "\U0000F1E3" => FA_Futbol,
            "\U00000047" => FA_G,
            "\U0000F50C" => FA_GalacticRepublic,
            "\U0000F50D" => FA_GalacticSenate,
            "\U0000F11B" => FA_Gamepad,
            "\U0000F52F" => FA_GasPump,
            "\U0000F624" => FA_Gauge,
            "\U0000F625" => FA_GaugeHigh,
            "\U0000F629" => FA_GaugeSimple,
            "\U0000F62A" => FA_GaugeSimpleHigh,
            "\U0000F0E3" => FA_Gavel,
            "\U0000F013" => FA_Gear,
            "\U0000F085" => FA_Gears,
            "\U0000F3A5" => FA_Gem,
            "\U0000E849" => FA_Gemini,
            "\U0000F22D" => FA_Genderless,
            "\U0000F265" => FA_GetPocket,
            "\U0000F260" => FA_Gg,
            "\U0000F261" => FA_GgCircle,
            "\U0000F6E2" => FA_Ghost,
            "\U0000F06B" => FA_Gift,
            "\U0000F79C" => FA_Gifts,
            "\U0000F1D3" => FA_Git,
            "\U0000F841" => FA_GitAlt,
            "\U0000E863" => FA_Gitee,
            "\U0000F09B" => FA_Github,
            "\U0000F113" => FA_GithubAlt,
            "\U0000F3A6" => FA_Gitkraken,
            "\U0000F296" => FA_Gitlab,
            "\U0000F426" => FA_Gitter,
            "\U0000E4F4" => FA_GlassWater,
            "\U0000E4F5" => FA_GlassWaterDroplet,
            "\U0000F530" => FA_Glasses,
            "\U0000F2A5" => FA_Glide,
            "\U0000F2A6" => FA_GlideG,
            "\U0000E85D" => FA_Globaleaks,
            "\U0000F0AC" => FA_Globe,
            "\U0000F3A7" => FA_Gofore,
            "\U0000E40F" => FA_Golang,
            "\U0000F450" => FA_GolfBallTee,
            "\U0000F3A8" => FA_Goodreads,
            "\U0000F3A9" => FA_GoodreadsG,
            "\U0000F1A0" => FA_Google,
            "\U0000F3AA" => FA_GoogleDrive,
            "\U0000E079" => FA_GooglePay,
            "\U0000F3AB" => FA_GooglePlay,
            "\U0000F2B3" => FA_GooglePlus,
            "\U0000F0D5" => FA_GooglePlusG,
            "\U0000E63B" => FA_GoogleScholar,
            "\U0000F1EE" => FA_GoogleWallet,
            "\U0000F664" => FA_Gopuram,
            "\U0000F19D" => FA_GraduationCap,
            "\U0000F184" => FA_Gratipay,
            "\U0000F2D6" => FA_Grav,
            "\U0000003E" => FA_GreaterThan,
            "\U0000F532" => FA_GreaterThanEqual,
            "\U0000F58D" => FA_Grip,
            "\U0000F7A4" => FA_GripLines,
            "\U0000F7A5" => FA_GripLinesVertical,
            "\U0000F58E" => FA_GripVertical,
            "\U0000F3AC" => FA_Gripfire,
            "\U0000E4F6" => FA_GroupArrowsRotate,
            "\U0000F3AD" => FA_Grunt,
            "\U0000E19A" => FA_GuaraniSign,
            "\U0000E07E" => FA_Guilded,
            "\U0000F7A6" => FA_Guitar,
            "\U0000F3AE" => FA_Gulp,
            "\U0000E19B" => FA_Gun,
            "\U00000048" => FA_H,
            "\U0000F1D4" => FA_HackerNews,
            "\U0000F5F7" => FA_Hackerrank,
            "\U0000F6E3" => FA_Hammer,
            "\U0000F665" => FA_Hamsa,
            "\U0000F256" => FA_Hand,
            "\U0000F255" => FA_HandBackFist,
            "\U0000F461" => FA_HandDots,
            "\U0000F6DE" => FA_HandFist,
            "\U0000F4BD" => FA_HandHolding,
            "\U0000F4C0" => FA_HandHoldingDollar,
            "\U0000F4C1" => FA_HandHoldingDroplet,
            "\U0000E4F7" => FA_HandHoldingHand,
            "\U0000F4BE" => FA_HandHoldingHeart,
            "\U0000E05C" => FA_HandHoldingMedical,
            "\U0000F258" => FA_HandLizard,
            "\U0000F806" => FA_HandMiddleFinger,
            "\U0000F25B" => FA_HandPeace,
            "\U0000F0A7" => FA_HandPointDown,
            "\U0000F0A5" => FA_HandPointLeft,
            "\U0000F0A4" => FA_HandPointRight,
            "\U0000F0A6" => FA_HandPointUp,
            "\U0000F25A" => FA_HandPointer,
            "\U0000F257" => FA_HandScissors,
            "\U0000E05D" => FA_HandSparkles,
            "\U0000F259" => FA_HandSpock,
            "\U0000E4F8" => FA_Handcuffs,
            "\U0000F2A7" => FA_Hands,
            "\U0000F2A3" => FA_HandsAslInterpreting,
            "\U0000E4F9" => FA_HandsBound,
            "\U0000E05E" => FA_HandsBubbles,
            "\U0000E1A8" => FA_HandsClapping,
            "\U0000F4C2" => FA_HandsHolding,
            "\U0000E4FA" => FA_HandsHoldingChild,
            "\U0000E4FB" => FA_HandsHoldingCircle,
            "\U0000F684" => FA_HandsPraying,
            "\U0000F2B5" => FA_Handshake,
            "\U0000F4C4" => FA_HandshakeAngle,
            "\U0000E060" => FA_HandshakeSlash,
            "\U0000F6E6" => FA_Hanukiah,
            "\U0000F0A0" => FA_HardDrive,
            "\U0000E499" => FA_Hashnode,
            "\U00000023" => FA_Hashtag,
            "\U0000F8C0" => FA_HatCowboy,
            "\U0000F8C1" => FA_HatCowboySide,
            "\U0000F6E8" => FA_HatWizard,
            "\U0000E061" => FA_HeadSideCough,
            "\U0000E062" => FA_HeadSideCoughSlash,
            "\U0000E063" => FA_HeadSideMask,
            "\U0000E064" => FA_HeadSideVirus,
            "\U0000F1DC" => FA_Heading,
            "\U0000F025" => FA_Headphones,
            "\U0000F590" => FA_Headset,
            "\U0000F004" => FA_Heart,
            "\U0000E4FC" => FA_HeartCircleBolt,
            "\U0000E4FD" => FA_HeartCircleCheck,
            "\U0000E4FE" => FA_HeartCircleExclamation,
            "\U0000E4FF" => FA_HeartCircleMinus,
            "\U0000E500" => FA_HeartCirclePlus,
            "\U0000E501" => FA_HeartCircleXmark,
            "\U0000F7A9" => FA_HeartCrack,
            "\U0000F21E" => FA_HeartPulse,
            "\U0000F533" => FA_Helicopter,
            "\U0000E502" => FA_HelicopterSymbol,
            "\U0000F807" => FA_HelmetSafety,
            "\U0000E503" => FA_HelmetUn,
            "\U0000F312" => FA_Hexagon,
            "\U0000E699" => FA_HexagonNodes,
            "\U0000E69A" => FA_HexagonNodesBolt,
            "\U0000F591" => FA_Highlighter,
            "\U0000E507" => FA_HillAvalanche,
            "\U0000E508" => FA_HillRockslide,
            "\U0000F6ED" => FA_Hippo,
            "\U0000F452" => FA_Hips,
            "\U0000F3B0" => FA_HireAHelper,
            "\U0000E07F" => FA_Hive,
            "\U0000F453" => FA_HockeyPuck,
            "\U0000F7AA" => FA_HollyBerry,
            "\U0000F427" => FA_Hooli,
            "\U0000F592" => FA_Hornbill,
            "\U0000F6F0" => FA_Horse,
            "\U0000F7AB" => FA_HorseHead,
            "\U0000F0F8" => FA_Hospital,
            "\U0000F80D" => FA_HospitalUser,
            "\U0000F593" => FA_HotTubPerson,
            "\U0000F80F" => FA_Hotdog,
            "\U0000F594" => FA_Hotel,
            "\U0000F3B1" => FA_Hotjar,
            "\U0000F254" => FA_Hourglass,
            "\U0000F253" => FA_HourglassEnd,
            "\U0000F252" => FA_HourglassHalf,
            "\U0000F251" => FA_HourglassStart,
            "\U0000F015" => FA_House,
            "\U0000E3AF" => FA_HouseChimney,
            "\U0000F6F1" => FA_HouseChimneyCrack,
            "\U0000F7F2" => FA_HouseChimneyMedical,
            "\U0000E065" => FA_HouseChimneyUser,
            "\U0000E00D" => FA_HouseChimneyWindow,
            "\U0000E509" => FA_HouseCircleCheck,
            "\U0000E50A" => FA_HouseCircleExclamation,
            "\U0000E50B" => FA_HouseCircleXmark,
            "\U0000E3B1" => FA_HouseCrack,
            "\U0000E50C" => FA_HouseFire,
            "\U0000E50D" => FA_HouseFlag,
            "\U0000E50E" => FA_HouseFloodWater,
            "\U0000E50F" => FA_HouseFloodWaterCircleArrowRight,
            "\U0000E066" => FA_HouseLaptop,
            "\U0000E510" => FA_HouseLock,
            "\U0000E3B2" => FA_HouseMedical,
            "\U0000E511" => FA_HouseMedicalCircleCheck,
            "\U0000E512" => FA_HouseMedicalCircleExclamation,
            "\U0000E513" => FA_HouseMedicalCircleXmark,
            "\U0000E514" => FA_HouseMedicalFlag,
            "\U0000E012" => FA_HouseSignal,
            "\U0000E515" => FA_HouseTsunami,
            "\U0000E1B0" => FA_HouseUser,
            "\U0000F27C" => FA_Houzz,
            "\U0000F6F2" => FA_HryvniaSign,
            "\U0000F13B" => FA_Html5,
            "\U0000F3B2" => FA_Hubspot,
            "\U0000E869" => FA_HuggingFace,
            "\U0000F751" => FA_Hurricane,
            "\U00000049" => FA_I,
            "\U0000F246" => FA_ICursor,
            "\U0000F810" => FA_IceCream,
            "\U0000F7AD" => FA_Icicles,
            "\U0000F86D" => FA_Icons,
            "\U0000F2C1" => FA_IdBadge,
            "\U0000F2C2" => FA_IdCard,
            "\U0000F47F" => FA_IdCardClip,
            "\U0000E013" => FA_Ideal,
            "\U0000F7AE" => FA_Igloo,
            "\U0000F03E" => FA_Image,
            "\U0000F3E0" => FA_ImagePortrait,
            "\U0000F302" => FA_Images,
            "\U0000F2D8" => FA_Imdb,
            "\U0000F01C" => FA_Inbox,
            "\U0000F03C" => FA_Indent,
            "\U0000E1BC" => FA_IndianRupeeSign,
            "\U0000F275" => FA_Industry,
            "\U0000F534" => FA_Infinity,
            "\U0000F129" => FA_Info,
            "\U0000F16D" => FA_Instagram,
            "\U0000E081" => FA_Instalod,
            "\U0000F7AF" => FA_Intercom,
            "\U0000F26B" => FA_InternetExplorer,
            "\U0000F7B0" => FA_Invision,
            "\U0000F208" => FA_Ioxhost,
            "\U0000F033" => FA_Italic,
            "\U0000F83A" => FA_ItchIo,
            "\U0000F3B4" => FA_Itunes,
            "\U0000F3B5" => FA_ItunesNote,
            "\U0000004A" => FA_J,
            "\U0000E516" => FA_Jar,
            "\U0000E517" => FA_JarWheat,
            "\U0000F4E4" => FA_Java,
            "\U0000F669" => FA_Jedi,
            "\U0000F50E" => FA_JediOrder,
            "\U0000F3B6" => FA_Jenkins,
            "\U0000F0FB" => FA_JetFighter,
            "\U0000E518" => FA_JetFighterUp,
            "\U0000F7B1" => FA_Jira,
            "\U0000F3B7" => FA_Joget,
            "\U0000F595" => FA_Joint,
            "\U0000F1AA" => FA_Joomla,
            "\U0000F3B8" => FA_Js,
            "\U0000F1CC" => FA_Jsfiddle,
            "\U0000E519" => FA_JugDetergent,
            "\U0000E852" => FA_Julia,
            "\U0000E67B" => FA_Jxl,
            "\U0000004B" => FA_K,
            "\U0000F66B" => FA_Kaaba,
            "\U0000F5FA" => FA_Kaggle,
            "\U0000E7D7" => FA_KakaoTalk,
            "\U0000F084" => FA_Key,
            "\U0000F4F5" => FA_Keybase,
            "\U0000F11C" => FA_Keyboard,
            "\U0000F3BA" => FA_Keycdn,
            "\U0000F66D" => FA_Khanda,
            "\U0000F3BB" => FA_Kickstarter,
            "\U0000F3BC" => FA_KickstarterK,
            "\U0000E1C4" => FA_KipSign,
            "\U0000F479" => FA_KitMedical,
            "\U0000E51A" => FA_KitchenSet,
            "\U0000F535" => FA_KiwiBird,
            "\U0000E856" => FA_KoFi,
            "\U0000F42F" => FA_Korvue,
            "\U0000E857" => FA_Kubernetes,
            "\U0000004C" => FA_L,
            "\U0000E51B" => FA_LandMineOn,
            "\U0000F66F" => FA_Landmark,
            "\U0000F752" => FA_LandmarkDome,
            "\U0000E51C" => FA_LandmarkFlag,
            "\U0000F1AB" => FA_Language,
            "\U0000F109" => FA_Laptop,
            "\U0000F5FC" => FA_LaptopCode,
            "\U0000E51D" => FA_LaptopFile,
            "\U0000F812" => FA_LaptopMedical,
            "\U0000F3BD" => FA_Laravel,
            "\U0000E1C8" => FA_LariSign,
            "\U0000F202" => FA_Lastfm,
            "\U0000F5FD" => FA_LayerGroup,
            "\U0000F06C" => FA_Leaf,
            "\U0000F212" => FA_Leanpub,
            "\U0000E86A" => FA_Leetcode,
            "\U0000F30A" => FA_LeftLong,
            "\U0000F337" => FA_LeftRight,
            "\U0000F094" => FA_Lemon,
            "\U0000E84A" => FA_Leo,
            "\U0000F41D" => FA_Less,
            "\U0000003C" => FA_LessThan,
            "\U0000F537" => FA_LessThanEqual,
            "\U0000E62D" => FA_Letterboxd,
            "\U0000E84B" => FA_Libra,
            "\U0000F1CD" => FA_LifeRing,
            "\U0000F0EB" => FA_Lightbulb,
            "\U0000F3C0" => FA_Line,
            "\U0000E51E" => FA_LinesLeaning,
            "\U0000F0C1" => FA_Link,
            "\U0000F127" => FA_LinkSlash,
            "\U0000F08C" => FA_Linkedin,
            "\U0000F0E1" => FA_LinkedinIn,
            "\U0000E7D8" => FA_Linktree,
            "\U0000F2B8" => FA_Linode,
            "\U0000F17C" => FA_Linux,
            "\U0000F195" => FA_LiraSign,
            "\U0000F03A" => FA_List,
            "\U0000F0AE" => FA_ListCheck,
            "\U0000F0CB" => FA_ListOl,
            "\U0000F0CA" => FA_ListUl,
            "\U0000E1D3" => FA_LitecoinSign,
            "\U0000F124" => FA_LocationArrow,
            "\U0000F601" => FA_LocationCrosshairs,
            "\U0000F3C5" => FA_LocationDot,
            "\U0000F041" => FA_LocationPin,
            "\U0000E51F" => FA_LocationPinLock,
            "\U0000F023" => FA_Lock,
            "\U0000F3C1" => FA_LockOpen,
            "\U0000E520" => FA_Locust,
            "\U0000E7E2" => FA_Lumon,
            "\U0000E7E3" => FA_LumonDrop,
            "\U0000F604" => FA_Lungs,
            "\U0000E067" => FA_LungsVirus,
            "\U0000F3C3" => FA_Lyft,
            "\U0000004D" => FA_M,
            "\U0000F3C4" => FA_Magento,
            "\U0000F076" => FA_Magnet,
            "\U0000F002" => FA_MagnifyingGlass,
            "\U0000E521" => FA_MagnifyingGlassArrowRight,
            "\U0000E522" => FA_MagnifyingGlassChart,
            "\U0000F688" => FA_MagnifyingGlassDollar,
            "\U0000F689" => FA_MagnifyingGlassLocation,
            "\U0000F010" => FA_MagnifyingGlassMinus,
            "\U0000F00E" => FA_MagnifyingGlassPlus,
            "\U0000F59E" => FA_Mailchimp,
            "\U0000E1D5" => FA_ManatSign,
            "\U0000F50F" => FA_Mandalorian,
            "\U0000F279" => FA_Map,
            "\U0000F59F" => FA_MapLocation,
            "\U0000F5A0" => FA_MapLocationDot,
            "\U0000F276" => FA_MapPin,
            "\U0000F60F" => FA_Markdown,
            "\U0000F5A1" => FA_Marker,
            "\U0000F222" => FA_Mars,
            "\U0000F224" => FA_MarsAndVenus,
            "\U0000E523" => FA_MarsAndVenusBurst,
            "\U0000F227" => FA_MarsDouble,
            "\U0000F229" => FA_MarsStroke,
            "\U0000F22B" => FA_MarsStrokeRight,
            "\U0000F22A" => FA_MarsStrokeUp,
            "\U0000F57B" => FA_MartiniGlass,
            "\U0000F561" => FA_MartiniGlassCitrus,
            "\U0000F000" => FA_MartiniGlassEmpty,
            "\U0000F6FA" => FA_Mask,
            "\U0000E1D7" => FA_MaskFace,
            "\U0000E524" => FA_MaskVentilator,
            "\U0000F630" => FA_MasksTheater,
            "\U0000F4F6" => FA_Mastodon,
            "\U0000E525" => FA_MattressPillow,
            "\U0000F136" => FA_Maxcdn,
            "\U0000F31E" => FA_Maximize,
            "\U0000F8CA" => FA_Mdb,
            "\U0000F5A2" => FA_Medal,
            "\U0000F3C6" => FA_Medapps,
            "\U0000F23A" => FA_Medium,
            "\U0000F3C8" => FA_Medrt,
            "\U0000F2E0" => FA_Meetup,
            "\U0000F5A3" => FA_Megaport,
            "\U0000F538" => FA_Memory,
            "\U0000F7B3" => FA_Mendeley,
            "\U0000F676" => FA_Menorah,
            "\U0000F223" => FA_Mercury,
            "\U0000F27A" => FA_Message,
            "\U0000E49B" => FA_Meta,
            "\U0000F753" => FA_Meteor,
            "\U0000E01A" => FA_Microblog,
            "\U0000F2DB" => FA_Microchip,
            "\U0000F130" => FA_Microphone,
            "\U0000F3C9" => FA_MicrophoneLines,
            "\U0000F539" => FA_MicrophoneLinesSlash,
            "\U0000F131" => FA_MicrophoneSlash,
            "\U0000F610" => FA_Microscope,
            "\U0000F3CA" => FA_Microsoft,
            "\U0000E1ED" => FA_MillSign,
            "\U0000F78C" => FA_Minimize,
            "\U0000E62F" => FA_Mintbit,
            "\U0000F068" => FA_Minus,
            "\U0000F7B5" => FA_Mitten,
            "\U0000F3CB" => FA_Mix,
            "\U0000F289" => FA_Mixcloud,
            "\U0000E056" => FA_Mixer,
            "\U0000F3CC" => FA_Mizuni,
            "\U0000F3CE" => FA_Mobile,
            "\U0000F10B" => FA_MobileButton,
            "\U0000E527" => FA_MobileRetro,
            "\U0000F3CF" => FA_MobileScreen,
            "\U0000F3CD" => FA_MobileScreenButton,
            "\U0000E816" => FA_MobileVibrate,
            "\U0000F285" => FA_Modx,
            "\U0000F3D0" => FA_Monero,
            "\U0000F0D6" => FA_MoneyBill,
            "\U0000F3D1" => FA_MoneyBill1,
            "\U0000F53B" => FA_MoneyBill1Wave,
            "\U0000E528" => FA_MoneyBillTransfer,
            "\U0000E529" => FA_MoneyBillTrendUp,
            "\U0000F53A" => FA_MoneyBillWave,
            "\U0000E52A" => FA_MoneyBillWheat,
            "\U0000E1F3" => FA_MoneyBills,
            "\U0000F53C" => FA_MoneyCheck,
            "\U0000F53D" => FA_MoneyCheckDollar,
            "\U0000F5A6" => FA_Monument,
            "\U0000F186" => FA_Moon,
            "\U0000F5A7" => FA_MortarPestle,
            "\U0000F678" => FA_Mosque,
            "\U0000E52B" => FA_Mosquito,
            "\U0000E52C" => FA_MosquitoNet,
            "\U0000F21C" => FA_Motorcycle,
            "\U0000E52D" => FA_Mound,
            "\U0000F6FC" => FA_Mountain,
            "\U0000E52E" => FA_MountainCity,
            "\U0000E52F" => FA_MountainSun,
            "\U0000F7B6" => FA_MugHot,
            "\U0000F0F4" => FA_MugSaucer,
            "\U0000F001" => FA_Music,
            "\U0000004E" => FA_N,
            "\U0000E1F6" => FA_NairaSign,
            "\U0000F3D2" => FA_Napster,
            "\U0000F612" => FA_Neos,
            "\U0000F6FF" => FA_NetworkWired,
            "\U0000F22C" => FA_Neuter,
            "\U0000F1EA" => FA_Newspaper,
            "\U0000E530" => FA_NfcDirectional,
            "\U0000E531" => FA_NfcSymbol,
            "\U0000F5A8" => FA_Nimblr,
            "\U0000F419" => FA_Node,
            "\U0000F3D3" => FA_NodeJs,
            "\U0000E807" => FA_NonBinary,
            "\U0000F53E" => FA_NotEqual,
            "\U0000E1FE" => FA_Notdef,
            "\U0000F249" => FA_NoteSticky,
            "\U0000F481" => FA_NotesMedical,
            "\U0000E7D9" => FA_Notion,
            "\U0000F3D4" => FA_Npm,
            "\U0000F3D5" => FA_Ns8,
            "\U0000F3D6" => FA_Nutritionix,
            "\U0000004F" => FA_O,
            "\U0000F247" => FA_ObjectGroup,
            "\U0000F248" => FA_ObjectUngroup,
            "\U0000E879" => FA_Obsidian,
            "\U0000F306" => FA_Octagon,
            "\U0000E082" => FA_OctopusDeploy,
            "\U0000F263" => FA_Odnoklassniki,
            "\U0000E5C6" => FA_Odysee,
            "\U0000F613" => FA_OilCan,
            "\U0000E532" => FA_OilWell,
            "\U0000F510" => FA_OldRepublic,
            "\U0000F679" => FA_Om,
            "\U0000E7CF" => FA_Openai,
            "\U0000F23D" => FA_Opencart,
            "\U0000F19B" => FA_Openid,
            "\U0000E86B" => FA_Openstreetmap,
            "\U0000E62B" => FA_Opensuse,
            "\U0000F26A" => FA_Opera,
            "\U0000F23C" => FA_OptinMonster,
            "\U0000F8D2" => FA_Orcid,
            "\U0000F41A" => FA_Osi,
            "\U0000F700" => FA_Otter,
            "\U0000F03B" => FA_Outdent,
            "\U00000050" => FA_P,
            "\U0000E4A0" => FA_Padlet,
            "\U0000F3D7" => FA_Page4,
            "\U0000F18C" => FA_Pagelines,
            "\U0000F815" => FA_Pager,
            "\U0000F5AA" => FA_PaintRoller,
            "\U0000F1FC" => FA_Paintbrush,
            "\U0000F53F" => FA_Palette,
            "\U0000F3D8" => FA_Palfed,
            "\U0000F482" => FA_Pallet,
            "\U0000E7DA" => FA_Pandora,
            "\U0000E209" => FA_Panorama,
            "\U0000F1D8" => FA_PaperPlane,
            "\U0000F0C6" => FA_Paperclip,
            "\U0000F4CD" => FA_ParachuteBox,
            "\U0000F1DD" => FA_Paragraph,
            "\U0000F5AB" => FA_Passport,
            "\U0000F0EA" => FA_Paste,
            "\U0000F3D9" => FA_Patreon,
            "\U0000F04C" => FA_Pause,
            "\U0000F1B0" => FA_Paw,
            "\U0000F1ED" => FA_Paypal,
            "\U0000F67C" => FA_Peace,
            "\U0000F304" => FA_Pen,
            "\U0000F305" => FA_PenClip,
            "\U0000F5AC" => FA_PenFancy,
            "\U0000F5AD" => FA_PenNib,
            "\U0000F5AE" => FA_PenRuler,
            "\U0000F044" => FA_PenToSquare,
            "\U0000F303" => FA_Pencil,
            "\U0000E790" => FA_Pentagon,
            "\U0000E068" => FA_PeopleArrows,
            "\U0000F4CE" => FA_PeopleCarryBox,
            "\U0000E533" => FA_PeopleGroup,
            "\U0000E534" => FA_PeopleLine,
            "\U0000E535" => FA_PeoplePulling,
            "\U0000E536" => FA_PeopleRobbery,
            "\U0000E537" => FA_PeopleRoof,
            "\U0000F816" => FA_PepperHot,
            "\U0000E083" => FA_Perbyte,
            "\U00000025" => FA_Percent,
            "\U0000F3DA" => FA_Periscope,
            "\U0000F183" => FA_Person,
            "\U0000E538" => FA_PersonArrowDownToLine,
            "\U0000E539" => FA_PersonArrowUpFromLine,
            "\U0000F84A" => FA_PersonBiking,
            "\U0000F756" => FA_PersonBooth,
            "\U0000E53A" => FA_PersonBreastfeeding,
            "\U0000E53B" => FA_PersonBurst,
            "\U0000E53C" => FA_PersonCane,
            "\U0000E53D" => FA_PersonChalkboard,
            "\U0000E53E" => FA_PersonCircleCheck,
            "\U0000E53F" => FA_PersonCircleExclamation,
            "\U0000E540" => FA_PersonCircleMinus,
            "\U0000E541" => FA_PersonCirclePlus,
            "\U0000E542" => FA_PersonCircleQuestion,
            "\U0000E543" => FA_PersonCircleXmark,
            "\U0000F85E" => FA_PersonDigging,
            "\U0000F470" => FA_PersonDotsFromLine,
            "\U0000F182" => FA_PersonDress,
            "\U0000E544" => FA_PersonDressBurst,
            "\U0000E545" => FA_PersonDrowning,
            "\U0000E546" => FA_PersonFalling,
            "\U0000E547" => FA_PersonFallingBurst,
            "\U0000E548" => FA_PersonHalfDress,
            "\U0000E549" => FA_PersonHarassing,
            "\U0000F6EC" => FA_PersonHiking,
            "\U0000E54A" => FA_PersonMilitaryPointing,
            "\U0000E54B" => FA_PersonMilitaryRifle,
            "\U0000E54C" => FA_PersonMilitaryToPerson,
            "\U0000F683" => FA_PersonPraying,
            "\U0000E31E" => FA_PersonPregnant,
            "\U0000E54D" => FA_PersonRays,
            "\U0000E54E" => FA_PersonRifle,
            "\U0000F70C" => FA_PersonRunning,
            "\U0000E54F" => FA_PersonShelter,
            "\U0000F7C5" => FA_PersonSkating,
            "\U0000F7C9" => FA_PersonSkiing,
            "\U0000F7CA" => FA_PersonSkiingNordic,
            "\U0000F7CE" => FA_PersonSnowboarding,
            "\U0000F5C4" => FA_PersonSwimming,
            "\U0000E5A9" => FA_PersonThroughWindow,
            "\U0000F554" => FA_PersonWalking,
            "\U0000E551" => FA_PersonWalkingArrowLoopLeft,
            "\U0000E552" => FA_PersonWalkingArrowRight,
            "\U0000E553" => FA_PersonWalkingDashedLineArrowRight,
            "\U0000E554" => FA_PersonWalkingLuggage,
            "\U0000F29D" => FA_PersonWalkingWithCane,
            "\U0000E221" => FA_PesetaSign,
            "\U0000E222" => FA_PesoSign,
            "\U0000F3DB" => FA_Phabricator,
            "\U0000F3DC" => FA_PhoenixFramework,
            "\U0000F511" => FA_PhoenixSquadron,
            "\U0000F095" => FA_Phone,
            "\U0000F879" => FA_PhoneFlip,
            "\U0000F3DD" => FA_PhoneSlash,
            "\U0000F2A0" => FA_PhoneVolume,
            "\U0000F87C" => FA_PhotoFilm,
            "\U0000F457" => FA_Php,
            "\U0000E80B" => FA_PictureInPicture,
            "\U0000F2AE" => FA_PiedPiper,
            "\U0000F1A8" => FA_PiedPiperAlt,
            "\U0000F4E5" => FA_PiedPiperHat,
            "\U0000F1A7" => FA_PiedPiperPp,
            "\U0000F4D3" => FA_PiggyBank,
            "\U0000F484" => FA_Pills,
            "\U0000F0D2" => FA_Pinterest,
            "\U0000F231" => FA_PinterestP,
            "\U0000E84C" => FA_Pisces,
            "\U0000E43A" => FA_Pix,
            "\U0000E7DB" => FA_Pixelfed,
            "\U0000E640" => FA_Pixiv,
            "\U0000F818" => FA_PizzaSlice,
            "\U0000F67F" => FA_PlaceOfWorship,
            "\U0000F072" => FA_Plane,
            "\U0000F5AF" => FA_PlaneArrival,
            "\U0000E555" => FA_PlaneCircleCheck,
            "\U0000E556" => FA_PlaneCircleExclamation,
            "\U0000E557" => FA_PlaneCircleXmark,
            "\U0000F5B0" => FA_PlaneDeparture,
            "\U0000E558" => FA_PlaneLock,
            "\U0000E069" => FA_PlaneSlash,
            "\U0000E22D" => FA_PlaneUp,
            "\U0000E5AA" => FA_PlantWilt,
            "\U0000E55A" => FA_PlateWheat,
            "\U0000F04B" => FA_Play,
            "\U0000F3DF" => FA_Playstation,
            "\U0000F1E6" => FA_Plug,
            "\U0000E55B" => FA_PlugCircleBolt,
            "\U0000E55C" => FA_PlugCircleCheck,
            "\U0000E55D" => FA_PlugCircleExclamation,
            "\U0000E55E" => FA_PlugCircleMinus,
            "\U0000E55F" => FA_PlugCirclePlus,
            "\U0000E560" => FA_PlugCircleXmark,
            "\U0000002B" => FA_Plus,
            "\U0000E43C" => FA_PlusMinus,
            "\U0000F2CE" => FA_Podcast,
            "\U0000F2FE" => FA_Poo,
            "\U0000F75A" => FA_PooStorm,
            "\U0000F619" => FA_Poop,
            "\U0000E858" => FA_Postgresql,
            "\U0000F011" => FA_PowerOff,
            "\U0000F5B1" => FA_Prescription,
            "\U0000F485" => FA_PrescriptionBottle,
            "\U0000F486" => FA_PrescriptionBottleMedical,
            "\U0000F02F" => FA_Print,
            "\U0000F288" => FA_ProductHunt,
            "\U0000E06A" => FA_PumpMedical,
            "\U0000E06B" => FA_PumpSoap,
            "\U0000F3E1" => FA_Pushed,
            "\U0000F12E" => FA_PuzzlePiece,
            "\U0000F3E2" => FA_Python,
            "\U00000051" => FA_Q,
            "\U0000F1D6" => FA_Qq,
            "\U0000F029" => FA_Qrcode,
            "\U0000003F" => FA_Question,
            "\U0000F459" => FA_Quinscape,
            "\U0000F2C4" => FA_Quora,
            "\U0000F10D" => FA_QuoteLeft,
            "\U0000F10E" => FA_QuoteRight,
            "\U00000052" => FA_R,
            "\U0000F4F7" => FA_RProject,
            "\U0000F7B9" => FA_Radiation,
            "\U0000F8D7" => FA_Radio,
            "\U0000F75B" => FA_Rainbow,
            "\U0000E561" => FA_RankingStar,
            "\U0000F7BB" => FA_RaspberryPi,
            "\U0000F2D9" => FA_Ravelry,
            "\U0000F41B" => FA_React,
            "\U0000F75D" => FA_Reacteurope,
            "\U0000F4D5" => FA_Readme,
            "\U0000F1D0" => FA_Rebel,
            "\U0000F543" => FA_Receipt,
            "\U0000F8D9" => FA_RecordVinyl,
            "\U0000F641" => FA_RectangleAd,
            "\U0000F022" => FA_RectangleList,
            "\U0000F410" => FA_RectangleXmark,
            "\U0000F1B8" => FA_Recycle,
            "\U0000F3E3" => FA_RedRiver,
            "\U0000F1A1" => FA_Reddit,
            "\U0000F281" => FA_RedditAlien,
            "\U0000F7BC" => FA_Redhat,
            "\U0000F25D" => FA_Registered,
            "\U0000F18B" => FA_Renren,
            "\U0000F363" => FA_Repeat,
            "\U0000F3E5" => FA_Reply,
            "\U0000F122" => FA_ReplyAll,
            "\U0000F3E6" => FA_Replyd,
            "\U0000F75E" => FA_Republican,
            "\U0000F4F8" => FA_Researchgate,
            "\U0000F3E7" => FA_Resolving,
            "\U0000F7BD" => FA_Restroom,
            "\U0000F079" => FA_Retweet,
            "\U0000F5B2" => FA_Rev,
            "\U0000F4D6" => FA_Ribbon,
            "\U0000F2F5" => FA_RightFromBracket,
            "\U0000F362" => FA_RightLeft,
            "\U0000F30B" => FA_RightLong,
            "\U0000F2F6" => FA_RightToBracket,
            "\U0000F70B" => FA_Ring,
            "\U0000F018" => FA_Road,
            "\U0000E562" => FA_RoadBarrier,
            "\U0000E563" => FA_RoadBridge,
            "\U0000E564" => FA_RoadCircleCheck,
            "\U0000E565" => FA_RoadCircleExclamation,
            "\U0000E566" => FA_RoadCircleXmark,
            "\U0000E567" => FA_RoadLock,
            "\U0000E568" => FA_RoadSpikes,
            "\U0000F544" => FA_Robot,
            "\U0000F135" => FA_Rocket,
            "\U0000F3E8" => FA_Rocketchat,
            "\U0000F3E9" => FA_Rockrms,
            "\U0000F2F1" => FA_Rotate,
            "\U0000F2EA" => FA_RotateLeft,
            "\U0000F2F9" => FA_RotateRight,
            "\U0000F4D7" => FA_Route,
            "\U0000F09E" => FA_Rss,
            "\U0000F158" => FA_RubleSign,
            "\U0000E569" => FA_Rug,
            "\U0000F545" => FA_Ruler,
            "\U0000F546" => FA_RulerCombined,
            "\U0000F547" => FA_RulerHorizontal,
            "\U0000F548" => FA_RulerVertical,
            "\U0000F156" => FA_RupeeSign,
            "\U0000E23D" => FA_RupiahSign,
            "\U0000E07A" => FA_Rust,
            "\U00000053" => FA_S,
            "\U0000F81D" => FA_SackDollar,
            "\U0000E56A" => FA_SackXmark,
            "\U0000F267" => FA_Safari,
            "\U0000E84D" => FA_Sagittarius,
            "\U0000E445" => FA_Sailboat,
            "\U0000F83B" => FA_Salesforce,
            "\U0000F41E" => FA_Sass,
            "\U0000F7BF" => FA_Satellite,
            "\U0000F7C0" => FA_SatelliteDish,
            "\U0000F24E" => FA_ScaleBalanced,
            "\U0000F515" => FA_ScaleUnbalanced,
            "\U0000F516" => FA_ScaleUnbalancedFlip,
            "\U0000E859" => FA_Scaleway,
            "\U0000F3EA" => FA_Schlix,
            "\U0000F549" => FA_School,
            "\U0000E56B" => FA_SchoolCircleCheck,
            "\U0000E56C" => FA_SchoolCircleExclamation,
            "\U0000E56D" => FA_SchoolCircleXmark,
            "\U0000E56E" => FA_SchoolFlag,
            "\U0000E56F" => FA_SchoolLock,
            "\U0000F0C4" => FA_Scissors,
            "\U0000E84E" => FA_Scorpio,
            "\U0000E570" => FA_Screenpal,
            "\U0000F54A" => FA_Screwdriver,
            "\U0000F7D9" => FA_ScrewdriverWrench,
            "\U0000F28A" => FA_Scribd,
            "\U0000F70E" => FA_Scroll,
            "\U0000F6A0" => FA_ScrollTorah,
            "\U0000F7C2" => FA_SdCard,
            "\U0000F3EB" => FA_Searchengin,
            "\U0000E447" => FA_Section,
            "\U0000F4D8" => FA_Seedling,
            "\U0000F2DA" => FA_Sellcast,
            "\U0000F213" => FA_Sellsy,
            "\U0000E820" => FA_Septagon,
            "\U0000F233" => FA_Server,
            "\U0000F3EC" => FA_Servicestack,
            "\U0000F61F" => FA_Shapes,
            "\U0000F064" => FA_Share,
            "\U0000F14D" => FA_ShareFromSquare,
            "\U0000F1E0" => FA_ShareNodes,
            "\U0000E571" => FA_SheetPlastic,
            "\U0000F20B" => FA_ShekelSign,
            "\U0000F132" => FA_Shield,
            "\U0000E572" => FA_ShieldCat,
            "\U0000E573" => FA_ShieldDog,
            "\U0000F3ED" => FA_ShieldHalved,
            "\U0000E574" => FA_ShieldHeart,
            "\U0000E06C" => FA_ShieldVirus,
            "\U0000F21A" => FA_Ship,
            "\U0000F553" => FA_Shirt,
            "\U0000F214" => FA_Shirtsinbulk,
            "\U0000F54B" => FA_ShoePrints,
            "\U0000E60C" => FA_Shoelace,
            "\U0000F54F" => FA_Shop,
            "\U0000E4A5" => FA_ShopLock,
            "\U0000E070" => FA_ShopSlash,
            "\U0000E057" => FA_Shopify,
            "\U0000F5B5" => FA_Shopware,
            "\U0000F2CC" => FA_Shower,
            "\U0000E448" => FA_Shrimp,
            "\U0000F074" => FA_Shuffle,
            "\U0000F197" => FA_ShuttleSpace,
            "\U0000F4D9" => FA_SignHanging,
            "\U0000F012" => FA_Signal,
            "\U0000E663" => FA_SignalMessenger,
            "\U0000F5B7" => FA_Signature,
            "\U0000F277" => FA_SignsPost,
            "\U0000F7C4" => FA_SimCard,
            "\U0000F215" => FA_Simplybuilt,
            "\U0000E81B" => FA_SingleQuoteLeft,
            "\U0000E81C" => FA_SingleQuoteRight,
            "\U0000E06D" => FA_Sink,
            "\U0000F3EE" => FA_Sistrix,
            "\U0000F0E8" => FA_Sitemap,
            "\U0000F512" => FA_Sith,
            "\U0000E44A" => FA_Sitrox,
            "\U0000F7C6" => FA_Sketch,
            "\U0000F54C" => FA_Skull,
            "\U0000F714" => FA_SkullCrossbones,
            "\U0000F216" => FA_Skyatlas,
            "\U0000F17E" => FA_Skype,
            "\U0000F198" => FA_Slack,
            "\U0000F715" => FA_Slash,
            "\U0000F7CC" => FA_Sleigh,
            "\U0000F1DE" => FA_Sliders,
            "\U0000F1E7" => FA_Slideshare,
            "\U0000F75F" => FA_Smog,
            "\U0000F48D" => FA_Smoking,
            "\U0000F2AB" => FA_Snapchat,
            "\U0000F2DC" => FA_Snowflake,
            "\U0000F7D0" => FA_Snowman,
            "\U0000F7D2" => FA_Snowplow,
            "\U0000E06E" => FA_Soap,
            "\U0000F696" => FA_Socks,
            "\U0000E85E" => FA_Solana,
            "\U0000F5BA" => FA_SolarPanel,
            "\U0000F0DC" => FA_Sort,
            "\U0000F0DD" => FA_SortDown,
            "\U0000F0DE" => FA_SortUp,
            "\U0000F1BE" => FA_Soundcloud,
            "\U0000F7D3" => FA_Sourcetree,
            "\U0000F5BB" => FA_Spa,
            "\U0000E5AC" => FA_SpaceAwesome,
            "\U0000F67B" => FA_SpaghettiMonsterFlying,
            "\U0000F3F3" => FA_Speakap,
            "\U0000F83C" => FA_SpeakerDeck,
            "\U0000F891" => FA_SpellCheck,
            "\U0000F717" => FA_Spider,
            "\U0000F110" => FA_Spinner,
            "\U0000E80A" => FA_Spiral,
            "\U0000F5BC" => FA_Splotch,
            "\U0000F2E5" => FA_Spoon,
            "\U0000F1BC" => FA_Spotify,
            "\U0000F5BD" => FA_SprayCan,
            "\U0000F5D0" => FA_SprayCanSparkles,
            "\U0000F0C8" => FA_Square,
            "\U0000F14C" => FA_SquareArrowUpRight,
            "\U0000F1B5" => FA_SquareBehance,
            "\U0000E69B" => FA_SquareBinary,
            "\U0000E6A3" => FA_SquareBluesky,
            "\U0000F150" => FA_SquareCaretDown,
            "\U0000F191" => FA_SquareCaretLeft,
            "\U0000F152" => FA_SquareCaretRight,
            "\U0000F151" => FA_SquareCaretUp,
            "\U0000F14A" => FA_SquareCheck,
            "\U0000E844" => FA_SquareDeskpro,
            "\U0000F397" => FA_SquareDribbble,
            "\U0000F199" => FA_SquareEnvelope,
            "\U0000F082" => FA_SquareFacebook,
            "\U0000E7E4" => FA_SquareFigma,
            "\U0000E5AD" => FA_SquareFontAwesome,
            "\U0000F35C" => FA_SquareFontAwesomeStroke,
            "\U0000F45C" => FA_SquareFull,
            "\U0000F1D2" => FA_SquareGit,
            "\U0000F092" => FA_SquareGithub,
            "\U0000E5AE" => FA_SquareGitlab,
            "\U0000F0D4" => FA_SquareGooglePlus,
            "\U0000F0FD" => FA_SquareH,
            "\U0000F3AF" => FA_SquareHackerNews,
            "\U0000E055" => FA_SquareInstagram,
            "\U0000F3B9" => FA_SquareJs,
            "\U0000F203" => FA_SquareLastfm,
            "\U0000E62E" => FA_SquareLetterboxd,
            "\U0000E7D0" => FA_SquareLinkedin,
            "\U0000F146" => FA_SquareMinus,
            "\U0000E576" => FA_SquareNfi,
            "\U0000F264" => FA_SquareOdnoklassniki,
            "\U0000F540" => FA_SquareParking,
            "\U0000F14B" => FA_SquarePen,
            "\U0000E577" => FA_SquarePersonConfined,
            "\U0000F098" => FA_SquarePhone,
            "\U0000F87B" => FA_SquarePhoneFlip,
            "\U0000E01E" => FA_SquarePiedPiper,
            "\U0000F0D3" => FA_SquarePinterest,
            "\U0000F0FE" => FA_SquarePlus,
            "\U0000F682" => FA_SquarePollHorizontal,
            "\U0000F681" => FA_SquarePollVertical,
            "\U0000F1A2" => FA_SquareReddit,
            "\U0000F698" => FA_SquareRootVariable,
            "\U0000F143" => FA_SquareRss,
            "\U0000F1E1" => FA_SquareShareNodes,
            "\U0000F2AD" => FA_SquareSnapchat,
            "\U0000F1B7" => FA_SquareSteam,
            "\U0000E619" => FA_SquareThreads,
            "\U0000F174" => FA_SquareTumblr,
            "\U0000F081" => FA_SquareTwitter,
            "\U0000F360" => FA_SquareUpRight,
            "\U0000E67C" => FA_SquareUpwork,
            "\U0000F2AA" => FA_SquareViadeo,
            "\U0000F194" => FA_SquareVimeo,
            "\U0000E578" => FA_SquareVirus,
            "\U0000E683" => FA_SquareWebAwesome,
            "\U0000E684" => FA_SquareWebAwesomeStroke,
            "\U0000F40C" => FA_SquareWhatsapp,
            "\U0000E61A" => FA_SquareXTwitter,
            "\U0000F169" => FA_SquareXing,
            "\U0000F2D3" => FA_SquareXmark,
            "\U0000F431" => FA_SquareYoutube,
            "\U0000F5BE" => FA_Squarespace,
            "\U0000F18D" => FA_StackExchange,
            "\U0000F16C" => FA_StackOverflow,
            "\U0000F842" => FA_Stackpath,
            "\U0000E579" => FA_StaffSnake,
            "\U0000E289" => FA_Stairs,
            "\U0000F5BF" => FA_Stamp,
            "\U0000E5AF" => FA_Stapler,
            "\U0000F005" => FA_Star,
            "\U0000F699" => FA_StarAndCrescent,
            "\U0000F089" => FA_StarHalf,
            "\U0000F5C0" => FA_StarHalfStroke,
            "\U0000F69A" => FA_StarOfDavid,
            "\U0000F621" => FA_StarOfLife,
            "\U0000F3F5" => FA_Staylinked,
            "\U0000F1B6" => FA_Steam,
            "\U0000F3F6" => FA_SteamSymbol,
            "\U0000F154" => FA_SterlingSign,
            "\U0000F0F1" => FA_Stethoscope,
            "\U0000F3F7" => FA_StickerMule,
            "\U0000F04D" => FA_Stop,
            "\U0000F2F2" => FA_Stopwatch,
            "\U0000E06F" => FA_Stopwatch20,
            "\U0000F54E" => FA_Store,
            "\U0000E071" => FA_StoreSlash,
            "\U0000F428" => FA_Strava,
            "\U0000F21D" => FA_StreetView,
            "\U0000F0CC" => FA_Strikethrough,
            "\U0000F429" => FA_Stripe,
            "\U0000F42A" => FA_StripeS,
            "\U0000F551" => FA_Stroopwafel,
            "\U0000E5C7" => FA_Stubber,
            "\U0000F3F8" => FA_Studiovinari,
            "\U0000F1A4" => FA_Stumbleupon,
            "\U0000F1A3" => FA_StumbleuponCircle,
            "\U0000F12C" => FA_Subscript,
            "\U0000F0F2" => FA_Suitcase,
            "\U0000F0FA" => FA_SuitcaseMedical,
            "\U0000F5C1" => FA_SuitcaseRolling,
            "\U0000F185" => FA_Sun,
            "\U0000E57A" => FA_SunPlantWilt,
            "\U0000F2DD" => FA_Superpowers,
            "\U0000F12B" => FA_Superscript,
            "\U0000F3F9" => FA_Supple,
            "\U0000E833" => FA_Supportnow,
            "\U0000F7D6" => FA_Suse,
            "\U0000E868" => FA_Svelte,
            "\U0000F5C3" => FA_Swatchbook,
            "\U0000F8E1" => FA_Swift,
            "\U0000F83D" => FA_Symfony,
            "\U0000E8AB" => FA_Symfonycasts,
            "\U0000F69B" => FA_Synagogue,
            "\U0000F48E" => FA_Syringe,
            "\U00000054" => FA_T,
            "\U0000F0CE" => FA_Table,
            "\U0000F00A" => FA_TableCells,
            "\U0000E678" => FA_TableCellsColumnLock,
            "\U0000F009" => FA_TableCellsLarge,
            "\U0000E67A" => FA_TableCellsRowLock,
            "\U0000E691" => FA_TableCellsRowUnlock,
            "\U0000F0DB" => FA_TableColumns,
            "\U0000F00B" => FA_TableList,
            "\U0000F45D" => FA_TableTennisPaddleBall,
            "\U0000F3FB" => FA_Tablet,
            "\U0000F10A" => FA_TabletButton,
            "\U0000F3FA" => FA_TabletScreenButton,
            "\U0000F490" => FA_Tablets,
            "\U0000F566" => FA_TachographDigital,
            "\U0000F02B" => FA_Tag,
            "\U0000F02C" => FA_Tags,
            "\U0000E866" => FA_TailwindCss,
            "\U0000F4DB" => FA_Tape,
            "\U0000E57B" => FA_Tarp,
            "\U0000E57C" => FA_TarpDroplet,
            "\U0000E84F" => FA_Taurus,
            "\U0000F1BA" => FA_Taxi,
            "\U0000F4F9" => FA_Teamspeak,
            "\U0000F62E" => FA_Teeth,
            "\U0000F62F" => FA_TeethOpen,
            "\U0000F2C6" => FA_Telegram,
            "\U0000E03F" => FA_TemperatureArrowDown,
            "\U0000E040" => FA_TemperatureArrowUp,
            "\U0000F2CB" => FA_TemperatureEmpty,
            "\U0000F2C7" => FA_TemperatureFull,
            "\U0000F2C9" => FA_TemperatureHalf,
            "\U0000F769" => FA_TemperatureHigh,
            "\U0000F76B" => FA_TemperatureLow,
            "\U0000F2CA" => FA_TemperatureQuarter,
            "\U0000F2C8" => FA_TemperatureThreeQuarters,
            "\U0000F1D5" => FA_TencentWeibo,
            "\U0000F7D7" => FA_TengeSign,
            "\U0000E57D" => FA_Tent,
            "\U0000E57E" => FA_TentArrowDownToLine,
            "\U0000E57F" => FA_TentArrowLeftRight,
            "\U0000E580" => FA_TentArrowTurnLeft,
            "\U0000E581" => FA_TentArrowsDown,
            "\U0000E582" => FA_Tents,
            "\U0000F120" => FA_Terminal,
            "\U0000E7FF" => FA_Tex,
            "\U0000F034" => FA_TextHeight,
            "\U0000F87D" => FA_TextSlash,
            "\U0000F035" => FA_TextWidth,
            "\U0000F69D" => FA_TheRedYeti,
            "\U0000F5C6" => FA_Themeco,
            "\U0000F2B2" => FA_Themeisle,
            "\U0000F491" => FA_Thermometer,
            "\U0000F731" => FA_ThinkPeaks,
            "\U0000E618" => FA_Threads,
            "\U0000E85F" => FA_Threema,
            "\U0000F165" => FA_ThumbsDown,
            "\U0000F164" => FA_ThumbsUp,
            "\U0000F08D" => FA_Thumbtack,
            "\U0000E68F" => FA_ThumbtackSlash,
            "\U0000F145" => FA_Ticket,
            "\U0000F3FF" => FA_TicketSimple,
            "\U0000E7DC" => FA_Tidal,
            "\U0000E07B" => FA_Tiktok,
            "\U0000E29C" => FA_Timeline,
            "\U0000F204" => FA_ToggleOff,
            "\U0000F205" => FA_ToggleOn,
            "\U0000F7D8" => FA_Toilet,
            "\U0000F71E" => FA_ToiletPaper,
            "\U0000E072" => FA_ToiletPaperSlash,
            "\U0000E583" => FA_ToiletPortable,
            "\U0000E584" => FA_ToiletsPortable,
            "\U0000F552" => FA_Toolbox,
            "\U0000F5C9" => FA_Tooth,
            "\U0000E838" => FA_TorBrowser,
            "\U0000F6A1" => FA_ToriiGate,
            "\U0000F76F" => FA_Tornado,
            "\U0000F519" => FA_TowerBroadcast,
            "\U0000E585" => FA_TowerCell,
            "\U0000E586" => FA_TowerObservation,
            "\U0000F722" => FA_Tractor,
            "\U0000F513" => FA_TradeFederation,
            "\U0000F25C" => FA_Trademark,
            "\U0000F637" => FA_TrafficLight,
            "\U0000E041" => FA_Trailer,
            "\U0000F238" => FA_Train,
            "\U0000F239" => FA_TrainSubway,
            "\U0000E5B4" => FA_TrainTram,
            "\U0000F225" => FA_Transgender,
            "\U0000F1F8" => FA_Trash,
            "\U0000F829" => FA_TrashArrowUp,
            "\U0000F2ED" => FA_TrashCan,
            "\U0000F82A" => FA_TrashCanArrowUp,
            "\U0000F1BB" => FA_Tree,
            "\U0000E587" => FA_TreeCity,
            "\U0000F181" => FA_Trello,
            "\U0000F071" => FA_TriangleExclamation,
            "\U0000F091" => FA_Trophy,
            "\U0000E589" => FA_Trowel,
            "\U0000E58A" => FA_TrowelBricks,
            "\U0000F0D1" => FA_Truck,
            "\U0000E58B" => FA_TruckArrowRight,
            "\U0000E58C" => FA_TruckDroplet,
            "\U0000F48B" => FA_TruckFast,
            "\U0000E58D" => FA_TruckField,
            "\U0000E58E" => FA_TruckFieldUn,
            "\U0000E2B7" => FA_TruckFront,
            "\U0000F0F9" => FA_TruckMedical,
            "\U0000F63B" => FA_TruckMonster,
            "\U0000F4DF" => FA_TruckMoving,
            "\U0000F63C" => FA_TruckPickup,
            "\U0000E58F" => FA_TruckPlane,
            "\U0000F4DE" => FA_TruckRampBox,
            "\U0000F1E4" => FA_Tty,
            "\U0000F173" => FA_Tumblr,
            "\U0000E2BB" => FA_TurkishLiraSign,
            "\U0000F3BE" => FA_TurnDown,
            "\U0000F3BF" => FA_TurnUp,
            "\U0000F26C" => FA_Tv,
            "\U0000F1E8" => FA_Twitch,
            "\U0000F099" => FA_Twitter,
            "\U0000E840" => FA_Typescript,
            "\U0000F42B" => FA_Typo3,
            "\U00000055" => FA_U,
            "\U0000F402" => FA_Uber,
            "\U0000F7DF" => FA_Ubuntu,
            "\U0000F403" => FA_Uikit,
            "\U0000E86D" => FA_Ultralytics,
            "\U0000E86E" => FA_UltralyticsHub,
            "\U0000E86F" => FA_UltralyticsYolo,
            "\U0000F8E8" => FA_Umbraco,
            "\U0000F0E9" => FA_Umbrella,
            "\U0000F5CA" => FA_UmbrellaBeach,
            "\U0000E084" => FA_Uncharted,
            "\U0000F0CD" => FA_Underline,
            "\U0000F404" => FA_Uniregistry,
            "\U0000E854" => FA_Unison,
            "\U0000E049" => FA_Unity,
            "\U0000F29A" => FA_UniversalAccess,
            "\U0000F09C" => FA_Unlock,
            "\U0000F13E" => FA_UnlockKeyhole,
            "\U0000E85C" => FA_UnrealEngine,
            "\U0000E07C" => FA_Unsplash,
            "\U0000F405" => FA_Untappd,
            "\U0000F338" => FA_UpDown,
            "\U0000F0B2" => FA_UpDownLeftRight,
            "\U0000F30C" => FA_UpLong,
            "\U0000F424" => FA_UpRightAndDownLeftFromCenter,
            "\U0000F35D" => FA_UpRightFromSquare,
            "\U0000F093" => FA_Upload,
            "\U0000F7E0" => FA_Ups,
            "\U0000E641" => FA_Upwork,
            "\U0000F287" => FA_Usb,
            "\U0000F007" => FA_User,
            "\U0000F4FB" => FA_UserAstronaut,
            "\U0000F4FC" => FA_UserCheck,
            "\U0000F4FD" => FA_UserClock,
            "\U0000F0F0" => FA_UserDoctor,
            "\U0000F4FE" => FA_UserGear,
            "\U0000F501" => FA_UserGraduate,
            "\U0000F500" => FA_UserGroup,
            "\U0000F728" => FA_UserInjured,
            "\U0000F502" => FA_UserLock,
            "\U0000F503" => FA_UserMinus,
            "\U0000F504" => FA_UserNinja,
            "\U0000F82F" => FA_UserNurse,
            "\U0000F4FF" => FA_UserPen,
            "\U0000F234" => FA_UserPlus,
            "\U0000F21B" => FA_UserSecret,
            "\U0000F505" => FA_UserShield,
            "\U0000F506" => FA_UserSlash,
            "\U0000F507" => FA_UserTag,
            "\U0000F508" => FA_UserTie,
            "\U0000F235" => FA_UserXmark,
            "\U0000F0C0" => FA_Users,
            "\U0000E591" => FA_UsersBetweenLines,
            "\U0000F509" => FA_UsersGear,
            "\U0000E592" => FA_UsersLine,
            "\U0000E593" => FA_UsersRays,
            "\U0000E594" => FA_UsersRectangle,
            "\U0000E073" => FA_UsersSlash,
            "\U0000E595" => FA_UsersViewfinder,
            "\U0000F7E1" => FA_Usps,
            "\U0000F407" => FA_Ussunnah,
            "\U0000F2E7" => FA_Utensils,
            "\U00000056" => FA_V,
            "\U0000F408" => FA_Vaadin,
            "\U0000F5B6" => FA_VanShuttle,
            "\U0000E2C5" => FA_Vault,
            "\U0000E85A" => FA_Venmo,
            "\U0000E85B" => FA_VenmoV,
            "\U0000F221" => FA_Venus,
            "\U0000F226" => FA_VenusDouble,
            "\U0000F228" => FA_VenusMars,
            "\U0000E085" => FA_Vest,
            "\U0000E086" => FA_VestPatches,
            "\U0000F237" => FA_Viacoin,
            "\U0000F2A9" => FA_Viadeo,
            "\U0000F492" => FA_Vial,
            "\U0000E596" => FA_VialCircleCheck,
            "\U0000E597" => FA_VialVirus,
            "\U0000F493" => FA_Vials,
            "\U0000F409" => FA_Viber,
            "\U0000F03D" => FA_Video,
            "\U0000F4E2" => FA_VideoSlash,
            "\U0000F6A7" => FA_Vihara,
            "\U0000E88A" => FA_Vim,
            "\U0000F40A" => FA_Vimeo,
            "\U0000F27D" => FA_VimeoV,
            "\U0000F1CA" => FA_Vine,
            "\U0000E850" => FA_Virgo,
            "\U0000E074" => FA_Virus,
            "\U0000E4A8" => FA_VirusCovid,
            "\U0000E4A9" => FA_VirusCovidSlash,
            "\U0000E075" => FA_VirusSlash,
            "\U0000E076" => FA_Viruses,
            "\U0000F189" => FA_Vk,
            "\U0000F40B" => FA_Vnv,
            "\U0000F897" => FA_Voicemail,
            "\U0000F770" => FA_Volcano,
            "\U0000F45F" => FA_Volleyball,
            "\U0000F6A8" => FA_Volume,
            "\U0000F028" => FA_VolumeHigh,
            "\U0000F027" => FA_VolumeLow,
            "\U0000F026" => FA_VolumeOff,
            "\U0000F6A9" => FA_VolumeXmark,
            "\U0000F729" => FA_VrCardboard,
            "\U0000E7DD" => FA_Vsco,
            "\U0000F41F" => FA_Vuejs,
            "\U00000057" => FA_W,
            "\U0000E7DE" => FA_W3c,
            "\U0000F8EF" => FA_WalkieTalkie,
            "\U0000F555" => FA_Wallet,
            "\U0000F0D0" => FA_WandMagic,
            "\U0000E2CA" => FA_WandMagicSparkles,
            "\U0000F72B" => FA_WandSparkles,
            "\U0000F494" => FA_Warehouse,
            "\U0000E087" => FA_WatchmanMonitoring,
            "\U0000F773" => FA_Water,
            "\U0000F5C5" => FA_WaterLadder,
            "\U0000F83E" => FA_WaveSquare,
            "\U0000F83F" => FA_Waze,
            "\U0000E682" => FA_WebAwesome,
            "\U0000E65C" => FA_Webflow,
            "\U0000F5CC" => FA_Weebly,
            "\U0000F18A" => FA_Weibo,
            "\U0000F5CD" => FA_WeightHanging,
            "\U0000F496" => FA_WeightScale,
            "\U0000F1D7" => FA_Weixin,
            "\U0000F232" => FA_Whatsapp,
            "\U0000E2CD" => FA_WheatAwn,
            "\U0000E598" => FA_WheatAwnCircleExclamation,
            "\U0000F193" => FA_Wheelchair,
            "\U0000E2CE" => FA_WheelchairMove,
            "\U0000F7A0" => FA_WhiskeyGlass,
            "\U0000F40D" => FA_Whmcs,
            "\U0000F1EB" => FA_Wifi,
            "\U0000F266" => FA_WikipediaW,
            "\U0000F72E" => FA_Wind,
            "\U0000F2D0" => FA_WindowMaximize,
            "\U0000F2D1" => FA_WindowMinimize,
            "\U0000F2D2" => FA_WindowRestore,
            "\U0000F17A" => FA_Windows,
            "\U0000F72F" => FA_WineBottle,
            "\U0000F4E3" => FA_WineGlass,
            "\U0000F5CE" => FA_WineGlassEmpty,
            "\U0000E2D0" => FA_Wirsindhandwerk,
            "\U0000F5CF" => FA_Wix,
            "\U0000F730" => FA_WizardsOfTheCoast,
            "\U0000E088" => FA_Wodu,
            "\U0000F514" => FA_WolfPackBattalion,
            "\U0000F159" => FA_WonSign,
            "\U0000F19A" => FA_Wordpress,
            "\U0000F411" => FA_WordpressSimple,
            "\U0000E599" => FA_Worm,
            "\U0000F297" => FA_Wpbeginner,
            "\U0000F2DE" => FA_Wpexplorer,
            "\U0000F298" => FA_Wpforms,
            "\U0000F3E4" => FA_Wpressr,
            "\U0000F0AD" => FA_Wrench,
            "\U00000058" => FA_X,
            "\U0000F497" => FA_XRay,
            "\U0000E61B" => FA_XTwitter,
            "\U0000F412" => FA_Xbox,
            "\U0000F168" => FA_Xing,
            "\U0000F00D" => FA_Xmark,
            "\U0000E59A" => FA_XmarksLines,
            "\U0000E864" => FA_Xmpp,
            "\U00000059" => FA_Y,
            "\U0000F23B" => FA_YCombinator,
            "\U0000F19E" => FA_Yahoo,
            "\U0000F840" => FA_Yammer,
            "\U0000F413" => FA_Yandex,
            "\U0000F414" => FA_YandexInternational,
            "\U0000F7E3" => FA_Yarn,
            "\U0000F1E9" => FA_Yelp,
            "\U0000F157" => FA_YenSign,
            "\U0000F6AD" => FA_YinYang,
            "\U0000F2B1" => FA_Yoast,
            "\U0000F167" => FA_Youtube,
            "\U0000005A" => FA_Z,
            "\U0000F63F" => FA_Zhihu,
            "\U0000E87B" => FA_Zoom,
            "\U0000E853" => FA_Zulip,
};
        
        public static List<IconData> Search(string v)
        {
            var results = new List<IconData>();
            Search(v, results);
            return results;
        }
        public static bool Search(string v, List<IconData> results)
        {
            results.Clear();
            foreach (var icon in All)
            {
                if (icon.Label.Contains(v, StringComparison.OrdinalIgnoreCase) ||
                    icon.Unicode.Contains(v, StringComparison.OrdinalIgnoreCase) ||
                    icon.SearchTerms.Any(term => term.Contains(v, StringComparison.OrdinalIgnoreCase)))
                {
                    results.Add(icon);
                }
            }
            return results.Count > 0;
        }
    }
}
// Regular (169): 0000E185,0000F004-0000F005,0000F007,0000F015,0000F017,0000F022,0000F024-0000F025,0000F02E,0000F030,0000F03E,0000F044,0000F057-0000F059,0000F06E,0000F070,0000F073,0000F075,0000F07B-0000F07C,0000F080,0000F086,0000F089,0000F094,0000F09D,0000F0A0,0000F0A4-0000F0A7,0000F0C2,0000F0C5,0000F0C7-0000F0C8,0000F0D1,0000F0E0,0000F0EA-0000F0EB,0000F0F3,0000F0F8,0000F0FE,0000F111,0000F118-0000F11A,0000F11C,0000F133,0000F144,0000F146,0000F14A,0000F14D-0000F14E,0000F150-0000F152,0000F15B-0000F15C,0000F164-0000F165,0000F185-0000F186,0000F191-0000F192,0000F1AD,0000F1C1-0000F1C9,0000F1CD,0000F1D8,0000F1E3,0000F1EA,0000F1F6,0000F1F9,0000F20A,0000F247-0000F249,0000F24D,0000F252,0000F254-0000F25B,0000F25D,0000F271-0000F274,0000F279-0000F27A,0000F28B,0000F28D,0000F2B4-0000F2B6,0000F2B9,0000F2BB,0000F2BD,0000F2C1-0000F2C2,0000F2D0-0000F2D2,0000F2DC,0000F2ED,0000F302,0000F328,0000F34E,0000F358-0000F35B,0000F3A5,0000F3D1,0000F410,0000F43A,0000F43F,0000F441,0000F443,0000F445,0000F447,0000F45C,0000F4AD,0000F4DA,0000F556,0000F567,0000F579-0000F57A,0000F57F-0000F58C,0000F596-0000F59C,0000F5A4-0000F5A5,0000F5B3-0000F5B4,0000F5B8,0000F5C0,0000F5C2,0000F5C8
// Solid (1422): 00000021,00000023-00000025,0000002A-0000002B,00000030-00000039,0000003C-0000005A,0000E005-0000E006,0000E00D,0000E012,0000E03F-0000E041,0000E059-0000E05E,0000E060-0000E076,0000E085-0000E086,0000E097-0000E098,0000E09A,0000E0A9,0000E0AC,0000E0B4,0000E0B7,0000E0BB,0000E0D8,0000E0DF,0000E0E3-0000E0E4,0000E131,0000E135,0000E139-0000E13C,0000E140,0000E152,0000E163,0000E169,0000E16D,0000E17B,0000E184-0000E185,0000E18F,0000E19A-0000E19B,0000E1A8,0000E1B0,0000E1BC,0000E1C4,0000E1C8,0000E1D3,0000E1D5,0000E1D7,0000E1ED,0000E1F3,0000E1F6,0000E1FE,0000E209,0000E221-0000E222,0000E22D,0000E23D,0000E289,0000E29C,0000E2B7,0000E2BB,0000E2C5,0000E2CA,0000E2CD-0000E2CE,0000E2E6,0000E2EB,0000E31E,0000E3AF,0000E3B1-0000E3B2,0000E3F5,0000E43C,0000E445,0000E447-0000E448,0000E46C,0000E473,0000E476-0000E477,0000E47A-0000E47B,0000E490,0000E494,0000E4A5,0000E4A8-0000E4AD,0000E4AF-0000E4B0,0000E4B3,0000E4B5-0000E4CC,0000E4CE-0000E4DE,0000E4E0-0000E4E6,0000E4E8-0000E4EB,0000E4ED,0000E4EF-0000E503,0000E507-0000E525,0000E527-0000E52F,0000E532-0000E54F,0000E551-0000E558,0000E55A-0000E56F,0000E571-0000E574,0000E576-0000E587,0000E589-0000E58F,0000E591-0000E59A,0000E59C-0000E59D,0000E5A0-0000E5A1,0000E5A9-0000E5AA,0000E5AF,0000E5B4,0000E678,0000E67A,0000E682,0000E68F,0000E691,0000E695-0000E69B,0000E790,0000E807,0000E80A-0000E80B,0000E816,0000E81B-0000E81D,0000E820,0000E845-0000E850,0000F000-0000F002,0000F004-0000F005,0000F007-0000F00E,0000F010-0000F013,0000F015,0000F017-0000F019,0000F01C,0000F01E,0000F021-0000F03E,0000F041-0000F044,0000F047-0000F04E,0000F050-0000F05B,0000F05E,0000F060-0000F066,0000F068,0000F06A-0000F06E,0000F070-0000F07E,0000F080,0000F083-0000F086,0000F089,0000F08B,0000F08D-0000F08E,0000F090-0000F091,0000F093-0000F095,0000F098,0000F09C-0000F09E,0000F0A0-0000F0A1,0000F0A3-0000F0AE,0000F0B0-0000F0B2,0000F0C0-0000F0CE,0000F0D0-0000F0D1,0000F0D6-0000F0DE,0000F0E0,0000F0E2-0000F0E3,0000F0E7-0000F0EE,0000F0F0-0000F0F4,0000F0F8-0000F0FE,0000F100-0000F107,0000F109-0000F10B,0000F10D-0000F10E,0000F110-0000F111,0000F118-0000F11C,0000F11E,0000F120-0000F122,0000F124-0000F127,0000F129,0000F12B-0000F12E,0000F130-0000F135,0000F137-0000F13A,0000F13D-0000F13E,0000F140-0000F146,0000F148-0000F14E,0000F150-0000F154,0000F156-0000F159,0000F15B-0000F15E,0000F160-0000F165,0000F175-0000F178,0000F182-0000F183,0000F185-0000F188,0000F191-0000F193,0000F195,0000F197,0000F199,0000F19C-0000F19D,0000F1AB-0000F1AE,0000F1B0,0000F1B2-0000F1B3,0000F1B8-0000F1BB,0000F1C0-0000F1C9,0000F1CD-0000F1CE,0000F1D8,0000F1DA,0000F1DC-0000F1DE,0000F1E0-0000F1E6,0000F1EA-0000F1EC,0000F1F6,0000F1F8-0000F1F9,0000F1FB-0000F1FE,0000F200-0000F201,0000F204-0000F207,0000F20A-0000F20B,0000F217-0000F21E,0000F221-0000F22D,0000F233-0000F236,0000F238-0000F239,0000F240-0000F249,0000F24D-0000F24E,0000F251-0000F25D,0000F26C,0000F271-0000F277,0000F279-0000F27A,0000F28B,0000F28D,0000F290-0000F291,0000F29A,0000F29D-0000F29E,0000F2A0-0000F2A4,0000F2A7-0000F2A8,0000F2B4-0000F2B6,0000F2B9,0000F2BB,0000F2BD,0000F2C1-0000F2C2,0000F2C7-0000F2CE,0000F2D0-0000F2D3,0000F2DB-0000F2DC,0000F2E5,0000F2E7,0000F2EA,0000F2ED,0000F2F1-0000F2F2,0000F2F5-0000F2F6,0000F2F9,0000F2FE,0000F302-0000F306,0000F309-0000F30C,0000F312,0000F31C,0000F31E,0000F328,0000F337-0000F338,0000F34E,0000F358-0000F35B,0000F35D,0000F360,0000F362-0000F363,0000F386-0000F387,0000F390,0000F3A5,0000F3BE-0000F3BF,0000F3C1,0000F3C5,0000F3C9,0000F3CD-0000F3CF,0000F3D1,0000F3DD,0000F3E0,0000F3E5,0000F3ED,0000F3FA-0000F3FB,0000F3FF,0000F410,0000F422,0000F424,0000F432-0000F434,0000F436,0000F439-0000F43A,0000F43C,0000F43F,0000F441,0000F443,0000F445,0000F447,0000F44B,0000F44E,0000F450,0000F453,0000F458,0000F45C-0000F45D,0000F45F,0000F461-0000F462,0000F466,0000F468-0000F46D,0000F470-0000F472,0000F474,0000F477-0000F479,0000F47E-0000F47F,0000F481-0000F482,0000F484-0000F487,0000F48B,0000F48D-0000F48E,0000F490-0000F494,0000F496-0000F497,0000F49E,0000F4AD,0000F4B3,0000F4B8-0000F4BA,0000F4BD-0000F4BE,0000F4C0-0000F4C2,0000F4C4,0000F4CD-0000F4CE,0000F4D3,0000F4D6-0000F4DB,0000F4DE-0000F4DF,0000F4E2-0000F4E3,0000F4FB-0000F509,0000F515-0000F52B,0000F52D-0000F530,0000F532-0000F535,0000F537-0000F540,0000F542-0000F58E,0000F590-0000F591,0000F593-0000F59D,0000F59F-0000F5A2,0000F5A4-0000F5A7,0000F5AA-0000F5B1,0000F5B3-0000F5B4,0000F5B6-0000F5B8,0000F5BA-0000F5BD,0000F5BF-0000F5C5,0000F5C7-0000F5CA,0000F5CD-0000F5CE,0000F5D0-0000F5D2,0000F5D7,0000F5DA,0000F5DC,0000F5DE-0000F5DF,0000F5E1,0000F5E4,0000F5E7,0000F5EB,0000F5EE,0000F5FC-0000F5FD,0000F601,0000F604,0000F610,0000F613,0000F619,0000F61F,0000F621,0000F624-0000F625,0000F629-0000F62A,0000F62E-0000F630,0000F637,0000F63B-0000F63C,0000F641,0000F644,0000F647,0000F64A,0000F64F,0000F651,0000F653-0000F655,0000F658,0000F65D-0000F65E,0000F662,0000F664-0000F666,0000F669-0000F66B,0000F66D,0000F66F,0000F674,0000F676,0000F678-0000F679,0000F67B-0000F67C,0000F67F,0000F681-0000F684,0000F687-0000F689,0000F696,0000F698-0000F69B,0000F6A0-0000F6A1,0000F6A7-0000F6A9,0000F6AD,0000F6B6-0000F6B7,0000F6BB,0000F6BE,0000F6C0,0000F6C3-0000F6C4,0000F6C8,0000F6CF,0000F6D1,0000F6D3,0000F6D5,0000F6D7,0000F6D9,0000F6DD-0000F6DE,0000F6E2-0000F6E3,0000F6E6,0000F6E8,0000F6EC-0000F6ED,0000F6F0-0000F6F2,0000F6FA,0000F6FC,0000F6FF-0000F700,0000F70B-0000F70C,0000F70E,0000F714-0000F715,0000F717,0000F71E,0000F722,0000F728-0000F729,0000F72B,0000F72E-0000F72F,0000F73B-0000F73D,0000F740,0000F743,0000F747,0000F74D,0000F751-0000F753,0000F756,0000F75A-0000F75B,0000F75E-0000F75F,0000F769,0000F76B-0000F76C,0000F76F-0000F770,0000F772-0000F773,0000F77C-0000F77D,0000F780-0000F781,0000F783-0000F784,0000F786-0000F788,0000F78C,0000F793-0000F794,0000F796,0000F79C,0000F79F-0000F7A0,0000F7A2,0000F7A4-0000F7A6,0000F7A9-0000F7AB,0000F7AD-0000F7AE,0000F7B5-0000F7B6,0000F7B9-0000F7BA,0000F7BD,0000F7BF-0000F7C0,0000F7C2,0000F7C4-0000F7C5,0000F7C9-0000F7CA,0000F7CC-0000F7CE,0000F7D0,0000F7D2,0000F7D7-0000F7DA,0000F7E4-0000F7E6,0000F7EC,0000F7EF,0000F7F2-0000F7F3,0000F7F5,0000F7F7,0000F7FA-0000F7FB,0000F802,0000F805-0000F807,0000F80D,0000F80F-0000F810,0000F812,0000F815-0000F816,0000F818,0000F81D,0000F827-0000F82A,0000F82F,0000F83E,0000F84A,0000F84C,0000F850,0000F853,0000F85E,0000F863,0000F86D,0000F879,0000F87B-0000F87D,0000F881-0000F882,0000F884-0000F887,0000F891,0000F897,0000F8C0-0000F8C1,0000F8CC,0000F8D7,0000F8D9,0000F8EF,0000F8FF
// Brands (550): 0000E007,0000E013,0000E01A,0000E01E,0000E049,0000E052,0000E055-0000E057,0000E077-0000E084,0000E087-0000E088,0000E2D0,0000E340,0000E360,0000E3D9,0000E40F,0000E43A,0000E44A,0000E499,0000E49B,0000E4A0,0000E530-0000E531,0000E570,0000E5AC-0000E5AE,0000E5C6-0000E5C7,0000E60B-0000E60C,0000E618-0000E61B,0000E62B,0000E62D-0000E62F,0000E63B-0000E63D,0000E640-0000E641,0000E65C,0000E663,0000E671,0000E67B-0000E67C,0000E682-0000E684,0000E693-0000E694,0000E69F,0000E6A2-0000E6A3,0000E7CF-0000E7D0,0000E7D4-0000E7DE,0000E7E2-0000E7E4,0000E7FF,0000E812,0000E833,0000E838,0000E840,0000E844,0000E851-0000E861,0000E863-0000E86B,0000E86D-0000E86F,0000E879,0000E87B,0000E88A,0000E8AB,0000F081-0000F082,0000F08C,0000F092,0000F099-0000F09B,0000F0D2-0000F0D5,0000F0E1,0000F113,0000F136,0000F13B-0000F13C,0000F15A,0000F167-0000F169,0000F16B-0000F16E,0000F170-0000F171,0000F173-0000F174,0000F179-0000F17E,0000F180-0000F181,0000F184,0000F189-0000F18D,0000F194,0000F198,0000F19A-0000F19B,0000F19E,0000F1A0-0000F1AA,0000F1B4-0000F1B7,0000F1BC-0000F1BE,0000F1CA-0000F1CC,0000F1D0-0000F1D7,0000F1E7-0000F1E9,0000F1ED-0000F1EE,0000F1F0-0000F1F5,0000F202-0000F203,0000F208-0000F209,0000F20D-0000F20E,0000F210-0000F216,0000F231-0000F232,0000F237,0000F23A-0000F23E,0000F24B-0000F24C,0000F25E,0000F260-0000F261,0000F263-0000F26B,0000F26D-0000F26E,0000F270,0000F27C-0000F27E,0000F280-0000F282,0000F284-0000F28A,0000F293-0000F294,0000F296-0000F299,0000F2A5-0000F2A6,0000F2A9-0000F2AB,0000F2AD-0000F2AE,0000F2B0-0000F2B4,0000F2B8,0000F2C4-0000F2C6,0000F2D5-0000F2DA,0000F2DD-0000F2DE,0000F2E0,0000F35C,0000F368-0000F375,0000F378-0000F37D,0000F37F-0000F380,0000F383-0000F385,0000F388,0000F38B-0000F38F,0000F391-0000F397,0000F399-0000F39A,0000F39D-0000F39F,0000F3A1-0000F3A4,0000F3A6-0000F3B2,0000F3B4-0000F3BD,0000F3C0,0000F3C3-0000F3C4,0000F3C6,0000F3C8,0000F3CA-0000F3CC,0000F3D0,0000F3D2-0000F3DC,0000F3DF,0000F3E1-0000F3E4,0000F3E6-0000F3EC,0000F3EE,0000F3F3,0000F3F5-0000F3F9,0000F402-0000F405,0000F407-0000F40D,0000F411-0000F417,0000F419-0000F421,0000F423,0000F426-0000F431,0000F44D,0000F452,0000F457,0000F459,0000F4D5,0000F4E4-0000F4E5,0000F4E7-0000F4F9,0000F50A-0000F514,0000F592,0000F59E,0000F5A3,0000F5A8,0000F5B2,0000F5B5,0000F5BE,0000F5C6,0000F5CC,0000F5CF,0000F5F1,0000F5F7,0000F5FA,0000F60F,0000F612,0000F63F,0000F642,0000F69D,0000F6C9-0000F6CA,0000F6CC,0000F6DC,0000F730-0000F731,0000F75D,0000F77A-0000F77B,0000F785,0000F789,0000F78D,0000F790-0000F791,0000F797-0000F799,0000F7AF-0000F7B1,0000F7B3,0000F7BB-0000F7BC,0000F7C6,0000F7D3,0000F7D6,0000F7DF-0000F7E1,0000F7E3,0000F834-0000F83D,0000F83F-0000F842,0000F89E,0000F8A6,0000F8CA,0000F8D2,0000F8E1,0000F8E8

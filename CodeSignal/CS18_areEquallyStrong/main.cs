bool areEquallyStrong(int yourLeft, int yourRight, int friendsLeft, int friendsRight) {
    int myStrong = (yourLeft > yourRight) ? yourLeft : yourRight;
            int friendsStrong = (friendsLeft > friendsRight) ? friendsLeft : friendsRight;
            if (myStrong == friendsStrong && Equals(yourLeft + yourRight, friendsLeft +                             friendsRight) == true)
            {
                return true;
            }
            return false;
}
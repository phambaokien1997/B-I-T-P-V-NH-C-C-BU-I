



        int a;
        int tong = 0;
        bool kq = true;

        do
        {
            console.writeline("nhap a:");
            a = int.parse(console.readline());
            kq = a < 0;
            if (kq)
                console.writeline("moi ban nhap lai");

            else
            {
                {
                    for (int i = 0; (i < a); i += 2)
                    {

                        tong += i;
                    }

                    console.writeline("tong=" + tong);

                }
            }
        } while (kq);
        console.readkey();


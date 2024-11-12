VAR anger = 0
VAR badending = 0
VAR goodending = 0

Hey klaus, how u doin?

 + [Been alr, just tired.]
 -> Lying1
 
 + [I've been stressed AF lmao...]
 -> Truth1
 
 + [I'm good]
 -> Lying1
 
 
=== Lying1 ===
U sure? I know ur under a lot of pressure keeping up ur image.

+ [Honestly idk how much longer i can keep it up.]
-> Truth2

+ [Yeah! I'm fine, dw.]
-> Lie2

+ [It's been a lot...like, a LOT.]
->Truth2


===Truth1===
I'm sure lol...do u think u can pull through? Ur making crazy bank rn.

*By lying to my fans?
->Stress1

*Honestly idk how much longer i can keep it up.
->Truth2

*I'm nervous...I think I might get caught soon.
->Stress1


===Truth2===
Idk what I'd do in ur situation...Just try to maintain ur persona until u have a plan.
*Thx, I'll figure it out.
->final

===Lie2===
Well...if u say so.
*I'll talk to u later! byeee
->final

===Stress1===
I mean, u ARE lying to ur audience. U might want to rethink if this is what u really want to do.
*Yeah lol...I'll think abt it.
->final

===final===
talk to u later Klaus! Be careful with ur fans btw...some of them seem kinda rabid lol.
~ goodending++
    -> END

VAR anger = 0
VAR badending = false

H-Hey...

 * Hello?
->MAIN1

 
 ===MAIN1===
OMG Hi Clawdia, I'm your biggest fan.

* Nice to meet you!
->POS1

* I get that a lot, lol.
~ anger++
->BAD1


===POS1===
N-nice to meet you too...

* So, what's up?
-> POS2

* Can I help you?
~ anger++
->BAD2

===BAD1===
What!? N-no, I promise that I'm your biggest fan.

* Idk about that.
~ anger++
->BAD2

* Well, thank you! I appriciate your dedication.
~ anger--
->POS2

* LOLLL okay.
~ anger--
->POS2


===POS2===
I was hoping we could become friends! I'm not weird or creepy like other guys.

* Oh...Uh, no. I don't think so.
~ anger++
->TOP1

* With that username? LOL
~ anger--
->MID1

* Sure! We can be friends.
->BOTTOM1


===BAD2===
I just want to be friends! Look, I even have all your merch...

*Oh, wow. That's a lot of pictures of my face.
~ anger--
->MID1

*Thanks for your support! That must've been expensive.
~ anger--
~ anger--
->BOTTOM1

*JESUS CHRIST???
~ anger++
->TOP1


===TOP1===
H-Huh? What's wrong? D-did I do something??

* No! I'm just surprised.
~ anger--
->BOTTOM2

* Yeah, you did! You're creeping me out!
~ anger++
~ anger++
->MID2

* I don't think being friends is in the cards for us.
~ anger++
->TOP2


===MID1===
Yeah!! Isn't it great?

* It's a bit creepy...
~ anger++
->MID2

* I never thought I'd have such a dedicated fan!
~ anger--
~ anger--
->BOTTOM2

* It's something alright.
~ anger--
->TOP2


===BOTTOM1===
Oh awesome!! Would you want to VC sometime?

* Sure!
->DEATH1

* Uh, not really.
->TOP2

* Maybe another time.
->TOP2

===DEATH1===
Well, why limit it to discord? Let's VC irl!
~ badending = true
-> END

===TOP2===
Well...can we chat? I have so much I want to talk to you about!

* Text chatting is fine by me.
~ anger--
->TOP3

* I'd honestly prefer if you stopped talking to me. You're a random guy!
~ anger++
->MID3

===MID2===
Creepy!? Why!?

* Why???? I think it's a bit obvious weirdo.
~ anger++
->BOTTOM3

* I'm just not loking to make friends with random people right now!
~ anger--
->MID3

===BOTTOM2===
I'm glad you like it! There's just no vtuber like you out there...

* Yup! I'm one of a kind.
~ anger--
->TOP3

* You're right. Most vtubers would've called you weird by now!
~ anger++
->BOTTOM3

===TOP3===
In that case...have you told anyone the truth?

* What?
-> MAIN2

* Idk what you're talking about.
->MAIN2

* ...
~ anger++
->MAIN2

===MID3===
Random!? I'm not random! I'm your biggest fan, I know so much about you...I even know your secret.

* What?
-> MAIN2

* Idk what you're talking about.
->MAIN2

* ...
~ anger++
->MAIN2

===BOTTOM3===
I-I'm weird!? I'n so so so sorry...I think we just got off on the wrong foot. Let me try again...have you told anyone about you know what?

* What?
-> MAIN2

* Idk what you're talking about.
->MAIN2

* ...
~ anger++
->MAIN2

===MAIN2===
You're always so cute Clawdia! Playing dumb is so adorable.

* I'm serious. I don't know what you're talking about.
->REAL1

* Who the Hell are you?
~ anger++
->NAME1

* ...
~ anger++
->ELI1

===NAME1===
I told you! I'm your biggest fan!! I even know your real name...

* My real name IS Claudia.
->REAL1

* Okay, you got me. My name is Claudia, not Clawdia.
->REAL1

*...
~ anger++
->ELI1

===REAL1===
Still playing dumb, hehe. Well, does this change anything?

158 Serpentina blvd, CA, 90006

* What the fuck????
->REAL2

* How did you get that????
->REAL2

* What is wrong with you????
->REAL2

===REAL2===
Calm down!! I can do a lot more than just find your address.

* ...okay.
~ anger--
-> REAL3

*...
~ anger++
->REAL3

===REAL3===
I just want to be friends!! Why don't we chat a bit more...

* Okay. What do you want to know?
~ anger--
->REAL4

* I've got nothing to say to you, creep.
->DEATH4

===REAL4===
I want to know about the real you. I know a lot about you, but I don't know about you inside...

* Uhhh....I like monster energy drink?
->REAL5

* I...like catgirls?
->REAL5

===REAL5===
That's surface level stuff. I figure I'll just come out and ask...

* Hold that thought!
->REAL6

===REAL6===
W-What?

* I have to prepare for the stream! I'll talk to you later! byeee
->REAL7

===REAL7===
Oh, of course! I totally lost track of time from our chat. Well, I'll talk to you soon then! :-)
-> END

===ELI1===

Hey. Answer me!

* What do you want from me?
~ anger--
->REAL3

*...
~ anger++
->ELI2

===ELI2===

ANSWER ME!

* What do you want from me?
~ anger--
->REAL3

*...
~ anger++
->ELI3

===ELI3===

ANSWERMEANSWERMEANSWERMEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE

* What do you want from me?
~ anger--
->REAL3

*...
->DEATH4

===DEATH4===
Don't want to talk anymore? That makes me sad...why don't we sort this out in person?

~ badending = true
    -> END

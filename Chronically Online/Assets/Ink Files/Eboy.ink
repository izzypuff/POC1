VAR anger = 0
VAR badending = 0
VAR goodending = 0

Yo! I saw your last stream, it was so dope.

* Yeah! Overwatch is really fun
~ anger--
->Right1

* Yeah! Fortnite is really fun
~ anger++
~ anger++
->Wrong1

* Yeah! Valorant is really fun
~ anger++
->Wrong1

===Right1===
Yesss it's my favorite game probably of all time.

* It's definitely up there!
~ anger--
-> Rank

* It's your favorite? There's probably better games...
~ anger++
->Huh

===Wrong1===
You didn't play that last stream. You played overwatch. I thought you were a super dedicated player?

* I am! I stream a lot so it's hard to keep track of every game I play live.
~ anger--
->Rank

* Oh, not really.
~ anger++
->Huh

===Huh===
Huh? But you've played it a ton! How could you not love it???

* It's just not my favorite, it's still a decent game!
~ anger--
-> Rank

* I literally only play for stream.
~ anger++
->Rank

* It's fun! I just think some other games are more my style!
~ anger--
~ anger--
->Rank

===Rank===
Well, what's your rank?

* Bronze 2
~ anger++
->Badrank

* Champion 4
~ anger++
~ anger++
->Badrank

* Platinum 3
~ anger--
->Goodrank

===Badrank===
Oh...wow.

* Is that bad?
~ anger--
->Badrank2

* Impressive, right?
~ anger++
->Badrank2

===Badrank2===
I just didn't expect that, lol.

* Well, I try my best!
->Ask

===Goodrank===
Yooo nice! You're pretty good. I'm actually in Grandmaster myself.

* That's awesome!
~ anger--
->Ask

* That's cool
~ anger++
->Ask

* Nice! You must no-life this game LOLL.
~ anger++
~ anger++
->Ask

===Ask===
Also, I've been meaning to ask...

* What's up?
~ anger--
->Play

* Spit it out!
~ anger++
->Play

* ??
~ anger--
->Play

===Play===
Would you want to play Overwatch together some time?

* Not right now, but at somepoint, sure.
~ anger--
->Why

* LOLLL no.
~ anger++
~ anger++
->Why2

* That might not be in the cards for us, lol.
~ anger++
->Why2

===Why===
Huh? Why not? We can squeeze in a match before your stream!

* I can't do that lol
~ anger++
->Snob

*Trust me, we'll play later.
~ anger--
->Alr

* I said later. Don't press me plese.
~ anger++
~ anger++
->Bitch

===Why2===
Why not? You know I'm really good from my rank, I can hold my own weight.

* I just don't play games with viewers.
~ anger++
->Snob

* I prefer playing games solo
~ anger--
->Alr

* Or you got carried hard LMAO.
~ anger++
~ anger++
->Bitch

===Snob===
Psh. Don't be a snob!

* It's just my preference, sorry.
~ anger--
->Alr

*I'm not being a snob. You're just being weird.
~ anger++
->Bitch

===Alr===
Well, alright. Would you want to VC instead? We could stop a few minutes before your stream.

* Honestly I think chat is better.
~ anger--
->CRINGE

* I don't think so.
~ anger++
->CRINGE

* Ew. With you? No chance LMFAO.
->DEATH1

===Bitch===
Jeez, okay bitch. I wasn't trying to be creepy, I just thought it'd be fun to game.

* Bitch??? Don't call me that, subhuman!
->DEATH1

* Woah, cool it man.
->CRINGE

* Calling me names doesn't make me want to play with you.
~ anger--
->Alr

===CRINGE===
Man, that's cringe. You're just another lame ass streamer who doesn't gaf about their fans!

* I'm sorry, I just have a lot on my plate.
~ anger--
~ anger--
->Mb

* If I vc'd with every fan, I'd never have time to stream!
->Excuse

* I do care about my fans! I care about you!
~ anger--
~ anger--
~ anger--
->Care

===Mb===
Oh, uh, my bad. I'm sorry. We can still play overwatch some time, right?

* Some time, sure. I'm just busy.
~ anger--
->Busy

* After what you just said? No.
->DEATH1

* Yeah! Just not at this moment.
~ anger--
~ anger--
->Busy


===Excuse===
Sounds like an excuse. I'm not asking you to vc with every fan, I'm asking you to vc with me!

* I just can't, I have a lot going on.
->Busy

* I get that, but I'm really busy.
~ anger--
->Busy


===Care===
You...care about me?

* Well...not you specifically.
->DEATH1

* Of course! I care deeply about all of my fans.
~ anger--
~ anger--
->Care2

* Yes! Again, I'm just super busy.
~ anger--
->Busy

===Busy===
What are you so busy with?

* Preparing new streams almost daily.
~ anger--
->Damn

* My personal life has been hectic.

->Damn

* Uni has been kicking my ass.

->Damn

===Damn===
Oh damn. I've been pretty busy too.

* with what?
->Hanzo

===Hanzo=== 
Maining Hanzo is a lot of work. I've been doing aim-training daily.

* If you think that's hard idk how you'll get a job, man.
->DEATH1

* Sounds tough!
~ anger--
->Tough

* Doesn't seem too tough to me.
~ anger++
->Tough

===Tough===
It is tough! Let me just say, Hanzo is a misunderstand character and people don't play him right.

* Hate to cut you off, but I've gotta get ready for stream now! I have a lot to prepare. 
-> FINAL

===Care2===
Well...I care about you too.

* I appriciate that bud!
~ anger++
->Ask2

* take it easy lover boy. I don't care like that.
->DEATH1

* You could prove it by giving me a dono during stream!
~ anger--
->bro

===Ask2===
Well...could I ask you something else?

* Hate to cut you off, but I've gotta get ready for stream now! I have a lot to prepare.
->FINAL

===bro===
Of course! I'll gladly drop a donation during tonight's stream.

* In that case, I should go prepare for stream. I'll see you there.
->FINAL

===FINAL===
No problem! We can chat later!
~ goodending++
->END

===DEATH1===
What!? Oh you're getting swatted bitch!
~ badending++
->END
























    -> END

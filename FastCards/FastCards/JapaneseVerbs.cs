using System;
using System.Collections.Generic;
using System.Text;

namespace FastCards
{
	class JapaneseVerbs
	{
		public static Deck Load()
		{
			Deck deck = new Deck
			{
				learnedCards = 0,
				name = "Japanese Verbs", //dictionary form JLPT N5 105

				cards = new List<Card>
				{
					new Card("会う", "au", "to meet"),
					new Card("開く", "aku", "to open"),
					new Card("開ける", "akeru", "to open"),
					new Card("あげる", "ageru", "to give"),
					new Card("遊ぶ", "asobu", "to play"),
					new Card("浴びる", "abiru", "to take a shower"),
					new Card("会う", "au", "to meet"),
					new Card("洗う", "arau", "to wash"),
					new Card("有る", "aru", "to exist"),	//to be
					new Card("ある", "aru", "to possess"),
					new Card("歩く", "aruku", "to walk"),
					new Card("言う", "iu", "to say"),
					new Card("行く", "iku", "to go"),
					new Card("いる", "iru", "to exist"), // need, must have, required
					new Card("入れる", "ireru", "to insert"), // put in
					new Card("歌う", "utau", "to sing"),
					new Card("生まれる", "umareru", "to be born"),
					new Card("売る", "uru", "to sell"),
					new Card("起きる	", "okiru", "to get up"), // stand up
					new Card("おく", "oku", "to put"),
					new Card("送る", "okuru", "to send"),
					new Card("押す", "osu", "to push"),
					new Card("覚える", "oboeru", "to memorize"), // to remember
					new Card("降りる", "oriru", "to get off"),
					new Card("終わる", "owaru", "to end"),
					new Card("買う", "kau", "to buy"),
					new Card("返す", "kaesu", "to return an object"),
					new Card("帰る", "kaeru", "to return home"),
					new Card("かかる", "kakaru", "to take"), // time or money
					new Card("書く", "kaku", "to write"),
					new Card("かける", "kakeru", "to wear"), // make a phone call
					new Card("貸す", "kasu", "to lend"),
					new Card("冠る", "kaburu", "to put on a hat"),
					new Card("借りる", "kariru", "to borrow"),
					new Card("消える", "kieru", "to go out"), // to vanish
					new Card("聞く", "kiku", "to listen"),
					new Card("切る", "kiru", "to cut"),
					new Card("着る", "kiru", "to wear"), //to put on
					new Card("来る", "kuru", "to come"),
					new Card("消す", "kesu", "to turn off"), // switch off
					new Card("答える", "kotaeru", "to answer"),
					new Card("困る", "komaru", "to be in trouble"),
					new Card("咲く", "saku", "to blossom"),
					new Card("さす", "sasu", "to open an umbrella"),
					new Card("死ぬ", "shinu", "to die"),
					new Card("閉まる", "shimaru", "to close"),
					new Card("閉める", "shimeru", "to close"),
					new Card("締める", "shimeru", "to fasten a belt"),
					new Card("知る", "shiru", "to know"),
					new Card("吸う", "suu", "to breath"), // to smoke
					new Card("住む", "sumu", "to live"), // to reside somewhere
					new Card("する", "suru", "to do"),
					new Card("座る", "suwaru", "to sit"),
					new Card("出す", "dasu", "to take out"), //to hand in
					new Card("立つ", "tatsu", "to stand"),
					new Card("頼む", "tanomu", "to ask"), //request
					new Card("食べる	", "taberu", "to eat"),
					new Card("違う", "chigau", "to be different"),
					new Card("使う", "tsukau", "to use"),
					new Card("疲れる", "tsukareru", "to get tired"),
					new Card("着く", "tsuku", "to arrive"),
					new Card("作る", "tsukuru", "to make"), //produce
					new Card("点ける", "tsukeru", "to turn on"),
					new Card("勤める", "tsutomeru", "to work for someone"),
					new Card("出かける", "dekakeru", "to go out"),
					new Card("出来る", "dekiru", "to be able to"),
					new Card("出る", "deru", "to leave"),
					new Card("飛ぶ", "tobu", "to fly"),
					new Card("止まる", "tomaru", "to stop"),
					new Card("取る", "toru", "to take"),
					new Card("撮る", "toru", "to take a photo"),
					new Card("鳴く", "naku", "to chirp"), // sing, mew, moo
					new Card("並ぶ", "narabu", "to form a line"),
					new Card("並べる", "naraberu", "to line up"),
					new Card("なる", "naru", "to become"),
					new Card("脱ぐ", "nugu", "to take of clothes"),
					new Card("寝る", "neru", "to sleep"),
					new Card("登る", "noboru", "to climb up"),
					new Card("飲む", "nomu", "to drink"),
					new Card("乗る", "noru", "to ride"), //to take
					new Card("入る", "hairu", "to enter"),
					new Card("履く", "haku", "to put on shoes"),
					new Card("始まる", "hajimaru", "to begin"),
					new Card("走る", "hashiru", "to run"),
					new Card("働く", "hataraku", "to work"),
					new Card("話す", "hanasu", "to talk"), // tell, speak
					new Card("張る", "haru", "to put something on"), //to stick
					new Card("晴れる", "hareru", "to clear up"),
					new Card("引く", "hiku", "to pull"),
					new Card("弾く", "hiku", "to play an instrument"),
					new Card("吹く", "fuku", "to blow"), //wind
					new Card("降る", "furu", "to fall"), //rain, snow
					new Card("曲がる", "magaru", "to turn"),
					new Card("待つ", "matsu", "to wait"),
					new Card("磨く", "migaku", "to polish"), //brush
					new Card("見せる", "miseru", "to show"),
					new Card("見る", "miru", "to see"), //watch
					new Card("持つ", "motsu", "to have"), //own
					new Card("休む", "yasumu", "to rest"),
					new Card("やる", "yaru", "to do"),
					new Card("呼ぶ", "yobu", "to call"),
					new Card("読む", "yomu", "to read"),
					new Card("分かる", "wakuru", "to understand"), //know
					new Card("忘れる", "wasureru", "to forget"),
					new Card("渡す", "watasu", "to hand over"),
					new Card("渡る", "wataru", "to cross")
				}
			};

			return deck;
		}
    }
}

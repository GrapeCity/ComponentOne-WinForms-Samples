using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace CandyBox
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private C1.Win.C1Chart.C1Chart c1Chart1;

		private int	numCandies = 10;
		private Array shapes = Enum.GetValues(typeof(C1.Win.C1Chart.SymbolShapeEnum));
		private int nScore	= 0;
		private int nTime	= 60;
		private int nHits	= 0;
		private int nLosts	= 0;

		private System.Timers.Timer stepTimer;
		private Random xPosRandom	= new Random();
		private Random colorRandom	= new Random(); 
		private Random shapeRandom	= new Random();
		private Random wordRandom	= new Random();
		private int count = 2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox rtWords; 


		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			InitializeComponent();

			rtWords.Visible = false;
			InitWords();
			stepTimer.Stop();
			InitChart();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )//!!VBReplace-Overrides-Overloads Overrides-
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.panel1 = new System.Windows.Forms.Panel();
			this.rtWords = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
			this.stepTimer = new System.Timers.Timer();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.stepTimer)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.rtWords,
																				 this.label2,
																				 this.label1,
																				 this.textBox1});
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(592, 80);
			this.panel1.TabIndex = 0;
			// 
			// rtWords
			// 
			this.rtWords.Location = new System.Drawing.Point(552, 32);
			this.rtWords.Name = "rtWords";
			this.rtWords.Size = new System.Drawing.Size(32, 24);
			this.rtWords.TabIndex = 5;
			this.rtWords.Text = "awake:clearing:correctly:cosmos:cradle:default:dine:dioxide:flux:glossary:handboo" +
				"k:jungle:longitude:monster:primitive:quantify:stillness:toad:whale:zinc:abide:ab" +
				"olish:absent:abstract:absurd:abundance:accessory:accord:acquaint:action:adhere:a" +
				"djacent:adjoin:adoption:adore:advertise:advocate:aerial:aerospace:affirm:agitati" +
				"on:agreeable:alas:album:alert:algebra:alien:alignment:allied:allowance:alongside" +
				":ally:alternate:amateur:ambient:ambiguous:ambitious:ample:amplitude:amusement:an" +
				"alogue:analogy:analytic:announce:annually:anode:answer:antarctic:antenna:antique" +
				":anybody:apparent:appendix:applaud:applause:apt:arc:arch:architect:arctic:array:" +
				"ascend:ascertain:ascribe:ashore:ass:assault:assert:assurance:astronomy:atom:atte" +
				"ndant:attorney:audience:author:automate:avail:aviation:awake:awful:awkward:axial" +
				":axis:axle:baby:bachelor:bacon:bacterium:badge:baffle:bait:balcony:bald:ballet:b" +
				"amboo:bandage:bandit:bank:banker:bankrupt:beetle:bend:bestow:between:beware:bewi" +
				"lder:bid:bishop:blast:blaze:bleach:blind:block:blond:blouse:blue:blunder:blush:b" +
				"oard:body:boiler:bore:bound:bourgeois:box:boycott:brace:brand:breakdown:breakfas" +
				"t:breed:bribe:bridge:bridle:broaden:bronze:brood:budget:buffalo:bug:bugle:bull:b" +
				"ulletin:bump:burglar:burial:burner:bushel:butt:buzz:bypass:by:cable:calculus:can" +
				":cane:cancel:capacitor:cape:captive:carry:cartoon:cartridge:catalogue:catalyst:c" +
				"ategory:cater:caution:cautious:cavity:cement:censor:cereal:certainty:challenge:c" +
				"hampion:charcoal:charge:charm:charter:clasp:classic:clatter:clearing:client:clim" +
				"ax:cling:clinic:clip:cloak:clockwise:closet:cloudy:clown:cluster:clutch:coach:co" +
				"ck:coffin:coherent:coin:coincide:coke:collide:colonial:colonist:combat:comedy:co" +
				"mmence:commend:commodity:compact:complaint:comply:composer:composite:conceit:con" +
				"ceive:concern:concert:conform:confront:conqueror:console:consul:consumer:contend" +
				":context:contrary:contrast:convert:convey:correctly:correlate:corrosion:corrupt:" +
				"cosmic:cosmos:couch:counsel:count:counter:courteous:courtesy:coward:crab:crack:c" +
				"radle:craft:crank:crash:credit:crisis:crisp:criterion:crooked:cross:cruelty:crui" +
				"se:cubic:cylinder:damn:datum:dazzle:deafen:deal:dealer:dean:decay:decidedly:deci" +
				"mal:decisive:decline:decompose:decree:dedicate:deem:deepen:default:deficient:def" +
				"ine:deflect:deform:defy:degrade:delegate:denial:denote:denounce:dentist:dependan" +
				"t:deposit:deprive:deputy:descent:desert:designate:desolate:dessert:destine:desti" +
				"ny:detach:detail:detain:detective:detector:develop:deviate:deviation:devotion:de" +
				"vour:diagnose:dictator:diesel:diet:difficult:dignity:diminish:dine:dioxide:diplo" +
				"ma:directory:discern:discount:discourse:disgrace:dismay:dismiss:disorder:dispatc" +
				"h:disperse:displace:disregard:dissipate:dissolve:distinct:distort:distract:diver" +
				"ge:diversion:divert:divine:dizzy:dock:doctrine:dome:domestic:dominant:dominate:d" +
				"oom:doubtless:dove:drain:drainage:drama:drastic:drawback:dreadful:dry:duke:dupli" +
				"cate:dust:dwarf:dwell:dynamic:dynamo:ear:earnings:eastward:echo:eclipse:ecology:" +
				"economics:edit:editorial:eject:elapse:elbow:electrode:elegant:elemental:elevate:" +
				"elevation:eloquence:embarrass:embassy:embody:embrace:emerge:emigrate:emission:em" +
				"pirical:enchant:enclosure:end:endanger:endeavor:endow:endurance:energetic:energi" +
				"ze:engage:enhance:enlighten:enrich:enroll:entitle:entreat:entry:episode:epoch:eq" +
				"uation:equator:erect:erosion:errand:escort:essence:essential:establish:estate:et" +
				"ernal:evaporate:even:evenly:evil:evolution:excel:except:excess:exclusive:excursi" +
				"on:excuse:execution:executive:exemplify:exert:exile:expect:expel:expire:explicit" +
				":extinct:extra:extract:extreme:fabricate:faction:fair:fake:fall:fantastic:fascin" +
				"ate:fastener:faultless:fearless:feel:fell:feminine:fence:ferrous:ferry:fertile:f" +
				"ighter:filament:fill:filter:filth:finance:finely:finite:fireplace:firework:firmn" +
				"ess:first:fission:fitness:fitting:fixture:flake:flame:flank:flannel:flap:flask:f" +
				"latten:flatter:flavour:flaw:flee:flexible:flight:fling:float:flock:fluctuate:flu" +
				"sh:flutter:flux:fly:foam:follow:follower:footpath:fore:foreign:foresee:forge:for" +
				"mal:formerly:formulate:forsake:fort:fortress:forum:forward:fossil:foster:foul:fo" +
				"wl:fraction:fracture:fragile:fragrant:frail:framework:freight:frequency:frequent" +
				":freshen:fret:friction:fright:frightful:fringe:fro:frock:frustrate:furious:furth" +
				"er:fury:fuse:fuss:gamble:gangster:gap:garage:garlic:garment:gather:gathering:gea" +
				"r:generate:geology:germ:gesture:gigantic:ginger:gleam:glider:global:glorify:glos" +
				"sary:glue:gnaw:goddess:goodness:gorilla:gorgeous:gossip:govern:grab:gracious:gra" +
				"dient:granite:grant:graphite:grassy:grateful:gravel:graze:grease:greed:grief:gri" +
				"m:grin:grind:groove:grope:gross:grove:growl:grumble:grunt:guilt:guitar:gust:gutt" +
				"er:hail:halve:ham:hamper:handbook:handicap:handout:handy:harbour:hard:hardy:harp" +
				":harsh:hatch:haughty:haul:haunt:hazard:head:heading:headlong:hearth:heater:heart" +
				"y:heave:heighten:herald:herb:herd:hesitate:hide:hike:hindrance:hinge:hip:hiss:hi" +
				"storian:historic:hit:hitherto:hoarse:hoe:hoist:hollow:homely:hook:hop:horizon:ho" +
				"rn:hose:hostage:hostess:hostile:hound:house:hover:howl:hug:hull:hum:humanity:hum" +
				"idity:hurl:hurrah:hurricane:hurt:hush:hydraulic:hymn:ice:icy:idealism:ideally:id" +
				"entical:idiot:idleness:ignite:ignorance:illusion:imitation:immerse:immigrate:imm" +
				"ortal:impart:impartial:implement:implore:impose:impress:improper:impulse:impurit" +
				"y:inasmuch:incapable:incense:incidence:incline:inclusive:indoor:induce:induction" +
				":indulge:inertia:infect:infer:inference:inferior:infinite:infinity:inflation:inf" +
				"luence:ingenious:ingenuity:inherent:initial:initially:initiate:inject:inland:inl" +
				"et:inorganic:input:insert:insight:insistent:inspector:ion:irritate:ivory:jack:ja" +
				"m:jealousy:jean:jelly:jerk:jewellery:jingle:jog:jug:junction:jungle:junior:kerne" +
				"l:kidnap:kidney:kilowatt:kindle:kinetic:kit:leakage:lease:length:lengthen:leopar" +
				"d:lessen:lever:liability:liable:lighter:likeness:lily:limb:limestone:limp:line:l" +
				"inear:liner:linger:lining:lipstick:literal:literally:literary:litter:lobby:local" +
				"ity:location:locust:lodging:lofty:log:longing:longitude:loosely:loosen:lounge:lu" +
				"bricate:luminous:lump:lunar:luncheon:luxurious:magician:magnet:magnetism:magnify" +
				":magnitude:maid:maiden:main:majesty:makeup:malice:mammal:manifest:mansion:maple:" +
				"margin:marginal:market:marsh:marshal:martyr:marvel:masculine:massacre:massive:ma" +
				"st:mature:mechanics:mechanism:meditate:melody:menace:mend:merciful:mercury:merit" +
				":mesh:mess:message:metallic:microwave:mighty:migrate:mild:milky:mingle:miniature" +
				":minimize:mint:mirror:mishief:miser:misery:mist:mistress:mitten:mixer:mob:mobili" +
				"ze:mock:modesty:modulate:module:molecular:momentary:monarch:monk:monopoly:monste" +
				"r:monstrous:moor:mop:morality:mortgage:mosque:moss:motel:motive:motorway:mount:m" +
				"ove:multitude:municipal:murmur:muscular:muse:mustard:mute:mystery:napkin:narrati" +
				"on:negative:negotiate:nest:net:network:neutron:nice:nickel:nickname:nightmare:no" +
				"minate:norm:northward:nose:notable:noted:notify:notion:notorious:nought:nourish:" +
				"novel:novelty:nucleus:number:numerical:nun:nursery:nut:oar:oath:obedience:obedie" +
				"nt:objective:oblige:obscure:observe:obstinate:offence:offensive:offer:offset:off" +
				"spring:ohm:olive:onward:opaque:operation:opium:optical:optimism:optimum:option:o" +
				"rchard:orchestra:orient:originate:ornament:otherwise:ought:outbreak:outcome:oute" +
				"rmost:outlaw:outlet:outline:outside:oval:over:overall:overflow:overhang:overhear" +
				":overlap:overload:overlook:overseas:overtake:overthrow:overwhelm:oxide:oxidize:o" +
				"yster:pace:pacific:pal:pamphlet:panel:panic:pant:panther:pantry:pants:paper:para" +
				"chute:parade:paragraph:paralyse:parameter:partition:passport:pasture:patent:path" +
				"etic:patriot:patriotic:patrol:patron:pattern:peacock:peak:peck:pedal:pedlar:peel" +
				":peer:penalty:pendulum:perch:perfect:peril:perimeter:periodic:perish:perpetual:p" +
				"erplex:persecute:persevere:persist:personnel:pertinent:pest:petition:petty:pickl" +
				"e:pier:pierce:pilgrim:pineapple:pious:pipe:pirate:piston:pitch:plague:ponder:pop" +
				":pope:porcelain:pore:portable:pose:position:positive:postal:postulate:poultry:pr" +
				"airie:preach:precede:pregnant:prejudice:preset:preside:press:pressure:prestige:p" +
				"resume:prevalent:prey:prick:primitive:printer:priority:prism:probe:producer:prof" +
				"ound:program:projector:prolong:promotion:promptly:propagate:propel:propeller:pro" +
				"per:prophecy:prudent:puff:pulley:pumpkin:punch:puppy:purify:pyjamas:qualify:quan" +
				"tify:quarterly:quartz:quench:quest:question:quiver:radial:radiant:radiator:radic" +
				"al:radius:raise:raisin:rally:ramble:ranch:random:range:rap:rapidity:rapture:rasc" +
				"al:rash:rate:rational:rattle:reactor:realistic:rear:reason:rebuke:receiver:recip" +
				"e:reckless:reckon:reclaim:reconcile:rectangle:rectify:reed:reef:reel:referee:ref" +
				"erence:refinery:refrain:refugee:regime:regiment:regulate:reign:reject:relay:reli" +
				"gion:remainder:repay:repeal:repel:replace:report:reproduce:reptile:requisite:res" +
				"ent:reserve:reside:resident:residual:resign:resolute:response:restrain:resultant" +
				":resume:retail:retard:retort:reveal:revenue:reverse:revive:revolve:ridicule:rigo" +
				"rous:rim:rinse:riot:rip:ripple:roam:roller:romance:romantic:rooster:rotate:routi" +
				"ne:row:royalty:ruby:rule:ruthless:safeguard:salmon:salute:sandwich:sardine:satel" +
				"lite:scan:scandal:scar:scarcity:scarlet:scheme:scoff:scope:scorch:scout:scramble" +
				":scrap:scratch:scripture:scrub:sculpture:seam:seaport:seaside:second:section:see" +
				"mingly:segment:selection:senator:sensation:senseless:sensible:sensor:sentiment:s" +
				"equence:sermon:serpent:set:severe:shabby:shade:shadowy:shady:shaft:sham:shame:sh" +
				"ameful:shark:sharply:shatter:sheer:shell:sheriff:shipment:shipwreck:shortage:sho" +
				"rtcut:shorten:shorthand:should:shoulder:shove:shovel:shower:shrill:shrimp:shrine" +
				":shrub:shrug:shutter:shuttle:sideways:siege:sift:sight:sign:signify:silicon:simp" +
				"le:sincerity:singular:sink:siren:sitting:situated:situation:skeleton:skip:slack:" +
				"slander:slang:slap:slaughter:slave:slide:slim:slit:slumber:smart:smash:smuggle:s" +
				"nack:snail:snap:sneer:sneeze:sniff:snob:snobbish:snore:sociology:sodium:sofa:sof" +
				"ten:softness:software:solar:solidify:solo:sorrowful:sovereign:souvenir:soy:spaci" +
				"ous:span:spatial:species:specimen:spectacle:spectator:spectrum:speculate:spheric" +
				"al:spice:spill:spiral:spite:splash:split:spokesman:squash:squat:squeeze:stabilit" +
				"y:stagger:stainless:stairway:stalk:stall:stammer:start:steady:steak:steal:stem:s" +
				"tereo:stern:stew:stiff:stiffness:stillness:sting:stitch:stone:storage:storm:stou" +
				"t:strait:strange:stray:stuffy:sturdy:subdivide:subdue:subject:subscribe:subscrip" +
				"t:substance:subtle:successor:suffice:suicide:suit:suitcase:sullen:summary:summit" +
				":summon:superb:supervise:support:suppress:surpass:surplus:survival:sweeten:sweet" +
				"ness:swell:switch:symmetry:symphony:symposium:symptom:synthesis:tabulate:tack:ta" +
				"ckle:tact:tactics:tangle:tanker:tape:taper:tar:team:tease:telex:tempt:tensile:te" +
				"rminal:terminate:terrace:terrify:terrorist:testify:theatre:theft:theme:theorem:t" +
				"heory:therein:thereof:thermal:thesis:thicken:thigh:thorough:thrash:thresh:thresh" +
				"old:thrifty:thrill:through:ticket:tickle:tighten:tightly:tile:tilt:timely:tireso" +
				"me:toad:token:tolerant:tone:torment:torpedo:torque:toss:tow:towards:tower:track:" +
				"trade:trader:tradesman:tragic:tramp:trample:tranquil:transform:traverse:tread:tr" +
				"easurer:trench:tribute:trifle:trigger:trivial:trolley:troop:tropic:tropical:trot" +
				":tug:tulip:tuna:turtle:tutor:twilight:twist:tyranny:tyrant:ultimate:unanimous:un" +
				"certain:underline:undertake:underwear:uneasy:unfit:unfold:uniformly:unique:unlim" +
				"ited:unlock:unpaid:untie:uphold:uproar:uranium:urge:usage:utensil:vaccinate:vali" +
				"dity:valuable:value:valve:vault:vector:veil:vein:velocity:velvet:vengeance:venti" +
				"late:verge:versatile:verse:version:versus:veto:vicinity:vicious:video:vigorous:v" +
				"igour:villa:vine:violate:violation:violent:virgin:virtual:visa:viscous:vision:vi" +
				"sit:vital:vitamin:vocation:void:volunteer:vow:vowel:vulgar:wade:wag:waggon:waitr" +
				"ess:walnut:ward:wardrobe:ware:warehouse:warfare:warning:warrant:wasp:wasteful:wa" +
				"tchful:watery:watt:waver:way:weaver:web:wedge:whale:wharf:what:whereby:whilst:wh" +
				"isker:whisper:white:whitewash:whoever:wholesome:widely:wield:willow:wind:winding" +
				":windmill:wisdom:wither:whereas:witty:woe:workpiece:workshop:worship:wrath:wrenc" +
				"h:wrestle:wretched:wring:wrinkle:xerox:yacht:yearn:yeast:yoke:yolk:youngster:zin" +
				"c";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(576, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "HOW TO PLAY: Input the word of each candy to hit it out. The ealier you hit, the " +
				"higher score you get.";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(352, 32);
			this.label1.TabIndex = 3;
			this.label1.Text = "This demo shows the usage of Area Chart and Bubble chart, you will see bubbles in" +
				" variant shapes, sizes, colors and positions. ";
			// 
			// textBox1
			// 
			this.textBox1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);	//!!VBPassThru
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.textBox1.Location = new System.Drawing.Point(376, 56);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(208, 20);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "";
			this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			// 
			// c1Chart1
			// 
			this.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c1Chart1.Location = new System.Drawing.Point(0, 80);
			this.c1Chart1.Name = "c1Chart1";
			this.c1Chart1.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><Axes><Axis Compass=\"South\" Min=\"" +
				"1\" UnitMajor=\"1\" UnitMinor=\"0.5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True" +
				"\" AutoMin=\"True\" _onTop=\"0\" Max=\"5\"><GridMajor AutoSpace=\"True\" Thickness=\"1\" Pa" +
				"ttern=\"Dash\" Color=\"LightGray\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Patte" +
				"rn=\"Dash\" Color=\"LightGray\" /><Text /></Axis><Axis Compass=\"West\" Min=\"8\" UnitMa" +
				"jor=\"2\" UnitMinor=\"1\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"" +
				"True\" _onTop=\"0\" Max=\"26\"><GridMajor AutoSpace=\"True\" Thickness=\"1\" Pattern=\"Das" +
				"h\" Color=\"LightGray\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Pattern=\"Dash\" " +
				"Color=\"LightGray\" /><Text /></Axis><Axis Compass=\"East\" Min=\"0\" UnitMajor=\"0\" Un" +
				"itMinor=\"0\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onT" +
				"op=\"0\" Max=\"0\"><GridMajor AutoSpace=\"True\" Thickness=\"1\" Pattern=\"Dash\" Color=\"L" +
				"ightGray\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Pattern=\"Dash\" Color=\"Ligh" +
				"tGray\" /><Text /></Axis></Axes><Header Compass=\"North\"><Text /></Header><ChartGr" +
				"oupsCollection><ChartGroup><Stacked>False</Stacked><HiLoData>FillFalling=True,Fi" +
				"llTransparent=True,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData><Name>" +
				"Group1</Name><ChartType>XYPlot</ChartType><Bar>ClusterOverlap=0,ClusterWidth=50<" +
				"/Bar><DataSerializer Hole=\"3.4028234663852886E+38\" DefaultSet=\"True\"><DataSeries" +
				"Collection><DataSeriesSerializer><LineStyle Thickness=\"1\" Pattern=\"Solid\" Color=" +
				"\"DarkGoldenrod\" /><Y3 /><SeriesLabel>series 0</SeriesLabel><DataTypes>Single;Sin" +
				"gle;Double;Double;Double</DataTypes><Y>20;22;19;24;25</Y><SymbolStyle Color=\"Cor" +
				"al\" Shape=\"Box\" /><Y1 /><X>1;2;3;4;5</X><Y2 /></DataSeriesSerializer><DataSeries" +
				"Serializer><LineStyle Thickness=\"1\" Pattern=\"Solid\" Color=\"DarkGray\" /><Y3 /><Se" +
				"riesLabel>series 1</SeriesLabel><DataTypes>Single;Single;Double;Double;Double</D" +
				"ataTypes><Y>8;12;10;12;15</Y><SymbolStyle Color=\"CornflowerBlue\" Shape=\"Dot\" /><" +
				"Y1 /><X>1;2;3;4;5</X><Y2 /></DataSeriesSerializer><DataSeriesSerializer><LineSty" +
				"le Thickness=\"1\" Pattern=\"Solid\" Color=\"DarkGreen\" /><Y3 /><SeriesLabel>series 2" +
				"</SeriesLabel><DataTypes>Single;Single;Double;Double;Double</DataTypes><Y>10;16;" +
				"17;15;23</Y><SymbolStyle Color=\"Cornsilk\" Shape=\"Tri\" /><Y1 /><X>1;2;3;4;5</X><Y" +
				"2 /></DataSeriesSerializer><DataSeriesSerializer><LineStyle Thickness=\"1\" Patter" +
				"n=\"Solid\" Color=\"DarkKhaki\" /><Y3 /><SeriesLabel>series 3</SeriesLabel><DataType" +
				"s>Single;Single;Double;Double;Double</DataTypes><Y>16;19;15;22;18</Y><SymbolStyl" +
				"e Color=\"Crimson\" Shape=\"Diamond\" /><Y1 /><X>1;2;3;4;5</X><Y2 /></DataSeriesSeri" +
				"alizer></DataSeriesCollection></DataSerializer><Bubble>EncodingMethod=Diameter,M" +
				"aximumSize=20,MinimumSize=5</Bubble><Polar>Degrees=True,PiRatioAnnotations=True," +
				"Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><ShowOutline>True" +
				"</ShowOutline><Pie>OtherOffset=0,Start=0</Pie></ChartGroup><ChartGroup><Stacked>" +
				"False</Stacked><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=False,S" +
				"howClose=True,ShowOpen=True</HiLoData><Name>Group2</Name><ChartType>XYPlot</Char" +
				"tType><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><DataSerializer Hole=\"3.4028234" +
				"663852886E+38\" /><Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</B" +
				"ubble><Polar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=" +
				"True,Filled=False,Start=0</Radar><ShowOutline>True</ShowOutline><Pie>OtherOffset" +
				"=0,Start=0</Pie></ChartGroup></ChartGroupsCollection><Footer Compass=\"South\"><Te" +
				"xt /></Footer><StyleCollection><NamedStyle><StyleData>Border=None,Control,1;</St" +
				"yleData><Name>PlotArea</Name><ParentName>Area</ParentName></NamedStyle><NamedSty" +
				"le><StyleData /><Name>Legend</Name><ParentName>Legend.default</ParentName></Name" +
				"dStyle><NamedStyle><StyleData>Border=None,Control,1;</StyleData><Name>Footer</Na" +
				"me><ParentName>Control</ParentName></NamedStyle><NamedStyle><StyleData /><Name>A" +
				"rea</Name><ParentName>Area.default</ParentName></NamedStyle><NamedStyle><StyleDa" +
				"ta /><Name>Control</Name><ParentName>Control.default</ParentName></NamedStyle><N" +
				"amedStyle><StyleData>Rotation=Rotate0;Border=None,Control,1;AlignHorz=Center;Bac" +
				"kColor=Transparent;Opaque=False;AlignVert=Bottom;</StyleData><Name>AxisX</Name><" +
				"ParentName>Area</ParentName></NamedStyle><NamedStyle><StyleData>Rotation=Rotate2" +
				"70;Border=None,Control,1;AlignHorz=Near;BackColor=Transparent;Opaque=False;Align" +
				"Vert=Center;</StyleData><Name>AxisY</Name><ParentName>Area</ParentName></NamedSt" +
				"yle><NamedStyle><StyleData /><Name>LabelStyleDefault</Name><ParentName>LabelStyl" +
				"eDefault.default</ParentName></NamedStyle><NamedStyle><StyleData>Border=None,Bla" +
				"ck,1;Wrap=False;AlignVert=Top;</StyleData><Name>Legend.default</Name><ParentName" +
				">Control</ParentName></NamedStyle><NamedStyle><StyleData>Border=None,Control,1;B" +
				"ackColor=Transparent;</StyleData><Name>LabelStyleDefault.default</Name><ParentNa" +
				"me>Control</ParentName></NamedStyle><NamedStyle><StyleData>Border=None,Control,1" +
				";</StyleData><Name>Header</Name><ParentName>Control</ParentName></NamedStyle><Na" +
				"medStyle><StyleData>ForeColor=ControlText;Border=None,Control,1;BackColor=Contro" +
				"l;</StyleData><Name>Control.default</Name><ParentName /></NamedStyle><NamedStyle" +
				"><StyleData>Rotation=Rotate90;Border=None,Transparent,1;AlignHorz=Far;BackColor=" +
				"Transparent;AlignVert=Center;</StyleData><Name>AxisY2</Name><ParentName>Area</Pa" +
				"rentName></NamedStyle><NamedStyle><StyleData>Border=None,Control,1;AlignVert=Top" +
				";</StyleData><Name>Area.default</Name><ParentName>Control</ParentName></NamedSty" +
				"le></StyleCollection><Legend Compass=\"East\" Visible=\"False\"><Text /></Legend><Ch" +
				"artArea /></Chart2DPropBag>";
			this.c1Chart1.Size = new System.Drawing.Size(592, 346);
			this.c1Chart1.TabIndex = 1;
			this.c1Chart1.SizeChanged += new System.EventHandler(this.c1Chart1_SizeChanged);
			this.c1Chart1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.c1Chart1_MouseDown);
			// 
			// stepTimer
			// 
			this.stepTimer.Enabled = true;
			this.stepTimer.Interval = 1000;
			this.stepTimer.SynchronizingObject = this;
			this.stepTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.stepTimer_Elapsed);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(592, 426);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.c1Chart1,
																		  this.panel1});
			this.MinimumSize = new System.Drawing.Size(600, 460);
			this.Name = "Form1";
			this.Text = "ComponentOne Chart for .NET Demo - CandyBox";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.stepTimer)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		/// <summary>
		/// Get a word by random
		/// </summary>
		/// <returns></returns>
		private string GetWord()
		{
			return (string) rtWords.Lines.GetValue(wordRandom.Next(0, rtWords.Lines.GetLength(0) - 1));
		}

		/// <summary>
		/// Set the status label
		/// </summary>
		private void SetStatusLabel()
		{
			string label = string.Format("Score: {0}  Hits: {1}  Lost: {2} Time: {3}", nScore, nHits, nLosts, nTime); 
			c1Chart1.Header.Text = label;
		}

		/// <summary>
		/// Initialize the Words
		/// </summary>
		private void InitWords()
		{
			this.rtWords.Text = this.rtWords.Text.Replace(':', '\n');
		}

		/// <summary>
		/// Initialize the Chart
		/// </summary>
		private void InitChart()
		{
			c1Chart1.BackColor = Color.DarkGray;
			c1Chart1.ChartArea.Margins.Left = 0;
			c1Chart1.ChartArea.Margins.Top = 0;
			c1Chart1.ChartArea.Margins.Right = 0;
			c1Chart1.ChartArea.Margins.Bottom = 0;

			c1Chart1.ChartArea.Style.BackColor = Color.SkyBlue;
			c1Chart1.ChartArea.Style.BackColor2 = Color.PaleGreen;
			c1Chart1.ChartArea.Style.GradientStyle = C1.Win.C1Chart.GradientStyleEnum.Vertical;
			c1Chart1.ChartArea.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Fillet;
			c1Chart1.ChartArea.Style.Border.Thickness = 6;


			// Setup the Header
			c1Chart1.Header.Compass = C1.Win.C1Chart.CompassEnum.North;
			c1Chart1.Header.Style.Font = new Font("Courier New", 12, FontStyle.Bold);
			c1Chart1.Header.Style.ForeColor = Color.Lime;
			c1Chart1.Header.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.RaisedBevel;
			c1Chart1.Header.Style.Border.Thickness = 2;
			c1Chart1.Header.Visible = true;
			SetStatusLabel();


			// Setup the Footer
			c1Chart1.Footer.Compass = C1.Win.C1Chart.CompassEnum.North;
			c1Chart1.Footer.Style.Font = new Font("Courier New", 12, FontStyle.Bold);
			c1Chart1.Footer.Style.ForeColor = Color.Blue;
			c1Chart1.Footer.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.RaisedBevel;
			c1Chart1.Footer.Style.Border.Thickness = 2;
			c1Chart1.Footer.Text = "Play";
			c1Chart1.Footer.Visible = true;

			SetHeaderAndFooterPos();

			// Setup the Axis X
			C1.Win.C1Chart.Axis xa = c1Chart1.ChartArea.AxisX;
			xa.AutoMax = false;
			xa.AutoMin = false;
			xa.AutoMajor = false;
			xa.AutoMinor = false;
			xa.Min = 0;
			xa.Max = 100;
			xa.TickMajor = C1.Win.C1Chart.TickMarksEnum.None; 
			xa.TickMinor = C1.Win.C1Chart.TickMarksEnum.None; 
			xa.TickLabels = C1.Win.C1Chart.TickLabelsEnum.None;
			xa.Thickness = 1;
			xa.Visible = true;

			// Setup the Axis Y
			C1.Win.C1Chart.Axis ya = c1Chart1.ChartArea.AxisY;
			ya.AutoMax = false;
			ya.AutoMin = false;
			ya.AutoMajor = false;
			ya.AutoMinor = false;
			ya.Min = 0;
			ya.Max = 100;
			ya.TickMajor = C1.Win.C1Chart.TickMarksEnum.None; 
			ya.TickMinor = C1.Win.C1Chart.TickMarksEnum.None; 
			ya.TickLabels = C1.Win.C1Chart.TickLabelsEnum.None;
			ya.Thickness = 1;

			// Setup the Axis Y2
			C1.Win.C1Chart.Axis y2a = c1Chart1.ChartArea.AxisY2;
			y2a.AutoMax = false;
			y2a.AutoMin = false;
			y2a.AutoMajor = false;
			y2a.AutoMinor = false;
			y2a.Min = 0;
			y2a.Max = 100;
			y2a.TickMajor = C1.Win.C1Chart.TickMarksEnum.None; 
			y2a.TickMinor = C1.Win.C1Chart.TickMarksEnum.None; 
			y2a.TickLabels = C1.Win.C1Chart.TickLabelsEnum.None;
			y2a.Visible = false;

			c1Chart1.ChartArea.PlotArea.Boxed = true;

			// Set the Group 0 to Bubble Chart
			C1.Win.C1Chart.ChartGroup group0 = c1Chart1.ChartGroups.Group0;
			group0.ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Bubble;
			group0.Bubble.MaximumSize = 30;
			group0.Bubble.MinimumSize = 3;

			group0.ChartData.SeriesList.RemoveAll(); 

			C1.Win.C1Chart.ChartDataSeries series = null;
			// Setup five dummy candies for size foundation, two of them are used for backgound, the sun
			for (int i = 0; i < 3; i++)
			{
				series = group0.ChartData.SeriesList.AddNewSeries();
				series.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Dot;
				series.SymbolStyle.Color = Color.Red;

				series.X.Length = 1;
				series.Y.Length = 1;
				series.Y1.Length = 1;
				series.X[0] = 0;
				series.Y[0] = -100;
				series.Y1[0] = i;
			}

			series = group0.ChartData.SeriesList.AddNewSeries();
			series.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Star;
			series.SymbolStyle.Color = Color.Gold;

			series.X.Length = 1;
			series.Y.Length = 1;
			series.Y1.Length = 1;
			series.X[0] = 10;
			series.Y[0] = 95;
			series.Y1[0] = 5;

			series = group0.ChartData.SeriesList.AddNewSeries();
			series.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Dot;
			series.SymbolStyle.Color = Color.Yellow;

			series.X.Length = 1;
			series.Y.Length = 1;
			series.Y1.Length = 1;
			series.X[0] = 10;
			series.Y[0] = 95;
			series.Y1[0] = 4;

            // Label style
			c1Chart1.ChartLabels.DefaultLabelStyle.ForeColor = SystemColors.InfoText;
			c1Chart1.ChartLabels.DefaultLabelStyle.BackColor = Color.FromArgb(90, SystemColors.Info);
			c1Chart1.ChartLabels.DefaultLabelStyle.Font = new Font("Arial", 10, FontStyle.Bold);

			// Set the Group 1 to Area Chart, the montain background
			C1.Win.C1Chart.ChartGroup group1 = c1Chart1.ChartGroups.Group1;
			group1.ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Area;
			group1.ChartData.SeriesList.RemoveAll();
			series = group1.ChartData.SeriesList.AddNewSeries();
			series.X.CopyDataIn(new int[]{0, 15, 30, 50, 80, 100}); 
			series.Y.CopyDataIn(new int[]{40, 70, 50, 90, 40, 70}); 
			series.LineStyle.Color = Color.DarkGoldenrod;
			series.FitType = C1.Win.C1Chart.FitTypeEnum.Spline;

			series = group1.ChartData.SeriesList.AddNewSeries();
			series.X.CopyDataIn(new int[]{0, 30, 60, 80, 100}); 
			series.Y.CopyDataIn(new int[]{30, 65, 50, 70, 50}); 
			series.LineStyle.Color = Color.ForestGreen;
			series.FitType = C1.Win.C1Chart.FitTypeEnum.Spline;

			series = group1.ChartData.SeriesList.AddNewSeries();
			series.X.CopyDataIn(new int[]{0, 20, 40, 60, 80, 100}); 
			series.Y.CopyDataIn(new int[]{15, 25, 15, 25, 15, 15}); 
			series.LineStyle.Color = Color.DarkMagenta;
			series.FitType = C1.Win.C1Chart.FitTypeEnum.Spline;
		}

		/// <summary>
		/// Start the game
		/// </summary>
		private void StartGame()
		{
			c1Chart1.Footer.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.InsetBevel;
			c1Chart1.Footer.Text = "Stop";

			nScore = 0;
			nTime	= 60;
			nHits	= 0;
			nLosts	= 0;

			SetStatusLabel();
			textBox1.Focus();
			stepTimer.Start();
		}

		/// <summary>
		/// Stop the game
		/// </summary>
		private void StopGame()
		{
			c1Chart1.Footer.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.RaisedBevel;
			c1Chart1.Footer.Text = "Play";

			stepTimer.Stop();
			textBox1.Focus();
		}

		/// <summary>
		/// Get a random shape
		/// </summary>
		/// <returns></returns>
		private C1.Win.C1Chart.SymbolShapeEnum GetShape()
		{
			C1.Win.C1Chart.SymbolShapeEnum shape = (C1.Win.C1Chart.SymbolShapeEnum)shapes.GetValue(shapeRandom.Next(0, shapes.GetLength(0)));
			while (shape == C1.Win.C1Chart.SymbolShapeEnum.None)
				shape = (C1.Win.C1Chart.SymbolShapeEnum)shapes.GetValue(shapeRandom.Next(0, shapes.GetLength(0)));

			return shape;
		}

		/// <summary>
		/// Pulse of the game
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void stepTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			this.stepTimer.Stop(); 

			nTime--;
			if (nTime < 0)
			{
				StopGame();
				return;
			}


			// A candy goes out of the region
			int i = 0;
			for(int index = 5; index < c1Chart1.ChartGroups[0].ChartData.SeriesList.Count; index++)
			{
				C1.Win.C1Chart.ChartDataSeries series = c1Chart1.ChartGroups[0].ChartData.SeriesList[index];
				series.Y[0] = (int)series.Y[0] + 10;

				if ((int)series.Y[0] > 100)
				{
					c1Chart1.ChartGroups[0].ChartData.SeriesList.Remove(series);
					c1Chart1.ChartLabels.LabelsCollection.RemoveAt(i);
			
					foreach(C1.Win.C1Chart.Label lbl in c1Chart1.ChartLabels.LabelsCollection)
					{
						lbl.AttachMethodData.SeriesIndex --;
					}

					nLosts++;
					break;
				}

				series.Y1[0] = (int)series.Y[0]/20;
				i++;
			}

			// It is time to give a new candy
			if (count >= 10/this.numCandies)
			{
				count = 0;

				C1.Win.C1Chart.ChartDataSeries series = this.c1Chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
				series.SymbolStyle.Shape = GetShape();
				series.SymbolStyle.Color = Color.FromArgb( xPosRandom.Next(0, 255), xPosRandom.Next(0, 255), xPosRandom.Next(0, 255));
				series.Display = C1.Win.C1Chart.SeriesDisplayEnum.Show;  

				series.X.Length = 1;
				series.Y.Length = 1;
				series.Y1.Length = 1;
				series.X[0] = xPosRandom.Next(10, 90);
				series.Y[0] = 10;
				series.Y1[0] = (int)series.Y[0]/20;

				C1.Win.C1Chart.Label lbl = c1Chart1.ChartLabels.LabelsCollection.AddNewLabel();
				lbl.Text = GetWord();
				lbl.AttachMethod = C1.Win.C1Chart.AttachMethodEnum.DataIndex;
				lbl.AttachMethodData.GroupIndex = 0;
				lbl.AttachMethodData.SeriesIndex = c1Chart1.ChartGroups[0].ChartData.SeriesList.Count - 1;
				lbl.AttachMethodData.PointIndex = 0;
				lbl.Compass = C1.Win.C1Chart.LabelCompassEnum.South; 
				lbl.Visible = true;
			}
			else
				count++;

			SetStatusLabel();
			this.stepTimer.Start(); 
		}

		/// <summary>
		/// Hit the candy with a text
		/// </summary>
		/// <param name="text"></param>
		private void Hit(string text)
		{
			int index = 0;
			bool find = false;
			foreach(C1.Win.C1Chart.Label lbl in c1Chart1.ChartLabels.LabelsCollection)
			{
				if (text.Equals(lbl.Text))
				{
					c1Chart1.ChartLabels.LabelsCollection.RemoveAt( index );
					find = true;
					break;
				}

				index++;
			}

			if (find)
			{
				C1.Win.C1Chart.ChartDataSeries series = c1Chart1.ChartGroups[0].ChartData.SeriesList[index + 5];
				nScore += 100 - (int)series.Y[0];
				c1Chart1.ChartGroups[0].ChartData.SeriesList.RemoveAt(index + 5);

				for(int i = index; i < c1Chart1.ChartLabels.LabelsCollection.Count; i++)
				{
					c1Chart1.ChartLabels.LabelsCollection[i].AttachMethodData.SeriesIndex -= 1;
				}
			}

			nHits++;
			SetStatusLabel();
		}

		/// <summary>
		/// Keydown event handler
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (c1Chart1.Footer.Text.Equals("Stop"))
				{
					string label = this.textBox1.Text.Trim();
					if (label.Length > 0)
						Hit(label);
				}

				this.textBox1.Text = "";
				this.textBox1.Focus();
			}

		}

		/// <summary>
		/// Mouse down event handler
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void c1Chart1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			C1.Win.C1Chart.ChartRegionEnum region = c1Chart1.ChartRegionFromCoord(e.X, e.Y);
			if (region == C1.Win.C1Chart.ChartRegionEnum.Footer)
			{
				if (c1Chart1.Footer.Text.Equals("Play"))
					StartGame();
				else
					StopGame();
			}

			this.textBox1.Focus();
		}

		/// <summary>
		/// Set the position of the header and footer
		/// </summary>
		private void SetHeaderAndFooterPos()
		{
			c1Chart1.Header.Location = new Point(10, 10);
			c1Chart1.Footer.Location = new Point(c1Chart1.Width - 100, 10);
		}

		/// <summary>
		/// SizeChanged event handler
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void c1Chart1_SizeChanged(object sender, System.EventArgs e)
		{
			SetHeaderAndFooterPos();		
		}
	}
}

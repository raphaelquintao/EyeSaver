namespace EyeSaver.Models {
    public struct TempGamma {
        public int temp;
        public RGB gamma;

        public TempGamma(int temp, RGB gamma) {
            this.temp  = temp;
            this.gamma = gamma;
        }
    }

    public static class GammaUtils {
        public static TempGamma[] gammas {
            get { return gammas1; }
        }

        private static readonly TempGamma[] gammas1 = {
            new TempGamma(1000, new RGB(1.0000d, 0.5470d, 0.2132d)),
            new TempGamma(1100, new RGB(1.0000d, 0.5582d, 0.2258d)),
            new TempGamma(1200, new RGB(1.0000d, 0.5693d, 0.2385d)),
            new TempGamma(1300, new RGB(1.0000d, 0.5802d, 0.2515d)),
            new TempGamma(1400, new RGB(1.0000d, 0.5910d, 0.2646d)),
            new TempGamma(1500, new RGB(1.0000d, 0.6017d, 0.2779d)),
            new TempGamma(1600, new RGB(1.0000d, 0.6122d, 0.2913d)),
            new TempGamma(1700, new RGB(1.0000d, 0.6227d, 0.3049d)),
            new TempGamma(1800, new RGB(1.0000d, 0.6330d, 0.3186d)),
            new TempGamma(1900, new RGB(1.0000d, 0.6433d, 0.3325d)),
            new TempGamma(2000, new RGB(1.0000d, 0.6534d, 0.3464d)),
            new TempGamma(2100, new RGB(1.0000d, 0.6634d, 0.3605d)),
            new TempGamma(2200, new RGB(1.0000d, 0.6732d, 0.3747d)),
            new TempGamma(2300, new RGB(1.0000d, 0.6829d, 0.3890d)),
            new TempGamma(2400, new RGB(1.0000d, 0.6926d, 0.4034d)),
            new TempGamma(2500, new RGB(1.0000d, 0.7021d, 0.4178d)),
            new TempGamma(2600, new RGB(1.0000d, 0.7115d, 0.4323d)),
            new TempGamma(2700, new RGB(1.0000d, 0.7208d, 0.4469d)),
            new TempGamma(2800, new RGB(1.0000d, 0.7299d, 0.4616d)),
            new TempGamma(2900, new RGB(1.0000d, 0.7390d, 0.4763d)),
            new TempGamma(3000, new RGB(1.0000d, 0.7479d, 0.4910d)),
            new TempGamma(3100, new RGB(1.0000d, 0.7568d, 0.5058d)),
            new TempGamma(3200, new RGB(1.0000d, 0.7655d, 0.5206d)),
            new TempGamma(3300, new RGB(1.0000d, 0.7741d, 0.5354d)),
            new TempGamma(3400, new RGB(1.0000d, 0.7826d, 0.5503d)),
            new TempGamma(3500, new RGB(1.0000d, 0.7910d, 0.5652d)),
            new TempGamma(3600, new RGB(1.0000d, 0.7993d, 0.5801d)),
            new TempGamma(3700, new RGB(1.0000d, 0.8075d, 0.5950d)),
            new TempGamma(3800, new RGB(1.0000d, 0.8156d, 0.6099d)),
            new TempGamma(3900, new RGB(1.0000d, 0.8237d, 0.6247d)),
            new TempGamma(4000, new RGB(1.0000d, 0.8315d, 0.6396d)),
            new TempGamma(4100, new RGB(1.0000d, 0.8393d, 0.6546d)),
            new TempGamma(4200, new RGB(1.0000d, 0.8470d, 0.6694d)),
            new TempGamma(4300, new RGB(1.0000d, 0.8546d, 0.6843d)),
            new TempGamma(4400, new RGB(1.0000d, 0.8622d, 0.6991d)),
            new TempGamma(4500, new RGB(1.0000d, 0.8696d, 0.7138d)),
            new TempGamma(4600, new RGB(1.0000d, 0.8769d, 0.7286d)),
            new TempGamma(4700, new RGB(1.0000d, 0.8841d, 0.7433d)),
            new TempGamma(4800, new RGB(1.0000d, 0.8913d, 0.7581d)),
            new TempGamma(4900, new RGB(1.0000d, 0.8984d, 0.7728d)),
            new TempGamma(5000, new RGB(1.0000d, 0.9053d, 0.7874d)),
            new TempGamma(5100, new RGB(1.0000d, 0.9122d, 0.8019d)),
            new TempGamma(5200, new RGB(1.0000d, 0.9190d, 0.8164d)),
            new TempGamma(5300, new RGB(1.0000d, 0.9258d, 0.8309d)),
            new TempGamma(5400, new RGB(1.0000d, 0.9323d, 0.8454d)),
            new TempGamma(5500, new RGB(1.0000d, 0.9388d, 0.8597d)),
            new TempGamma(5600, new RGB(1.0000d, 0.9453d, 0.8740d)),
            new TempGamma(5700, new RGB(1.0000d, 0.9517d, 0.8882d)),
            new TempGamma(5800, new RGB(1.0000d, 0.9580d, 0.9024d)),
            new TempGamma(5900, new RGB(1.0000d, 0.9642d, 0.9165d)),
            new TempGamma(6000, new RGB(1.0000d, 0.9704d, 0.9306d)),
            new TempGamma(6100, new RGB(1.0000d, 0.9764d, 0.9446d)),
            new TempGamma(6200, new RGB(1.0000d, 0.9824d, 0.9586d)),
            new TempGamma(6300, new RGB(1.0000d, 0.9884d, 0.9724d)),
            new TempGamma(6400, new RGB(1.0000d, 0.9942d, 0.9862d)),
            new TempGamma(6500, new RGB(1.0000d, 1.0000d, 1.0000d)),
            new TempGamma(6600, new RGB(0.9867d, 0.9923d, 1.0000d)),
            new TempGamma(6700, new RGB(0.9736d, 0.9847d, 1.0000d)),
            new TempGamma(6800, new RGB(0.9610d, 0.9773d, 1.0000d)),
            new TempGamma(6900, new RGB(0.9488d, 0.9701d, 1.0000d)),
            new TempGamma(7000, new RGB(0.9369d, 0.9630d, 1.0000d)),
            new TempGamma(7100, new RGB(0.9255d, 0.9561d, 1.0000d)),
            new TempGamma(7200, new RGB(0.9142d, 0.9493d, 1.0000d)),
            new TempGamma(7300, new RGB(0.9034d, 0.9428d, 1.0000d)),
            new TempGamma(7400, new RGB(0.8928d, 0.9365d, 1.0000d)),
            new TempGamma(7500, new RGB(0.8826d, 0.9303d, 1.0000d)),
            new TempGamma(7600, new RGB(0.8727d, 0.9242d, 1.0000d)),
            new TempGamma(7700, new RGB(0.8629d, 0.9182d, 1.0000d)),
            new TempGamma(7800, new RGB(0.8537d, 0.9125d, 1.0000d)),
            new TempGamma(7900, new RGB(0.8445d, 0.9068d, 1.0000d)),
            new TempGamma(8000, new RGB(0.8357d, 0.9013d, 1.0000d)),
            new TempGamma(8100, new RGB(0.8271d, 0.8960d, 1.0000d)),
            new TempGamma(8200, new RGB(0.8186d, 0.8907d, 1.0000d)),
            new TempGamma(8300, new RGB(0.8105d, 0.8856d, 1.0000d)),
            new TempGamma(8400, new RGB(0.8025d, 0.8805d, 1.0000d)),
            new TempGamma(8500, new RGB(0.7947d, 0.8757d, 1.0000d)),
            new TempGamma(8600, new RGB(0.7871d, 0.8708d, 1.0000d)),
            new TempGamma(8700, new RGB(0.7798d, 0.8661d, 1.0000d)),
            new TempGamma(8800, new RGB(0.7726d, 0.8615d, 1.0000d)),
            new TempGamma(8900, new RGB(0.7656d, 0.8570d, 1.0000d)),
            new TempGamma(9000, new RGB(0.7588d, 0.8526d, 1.0000d)),
            new TempGamma(9100, new RGB(0.7521d, 0.8483d, 1.0000d)),
            new TempGamma(9200, new RGB(0.7456d, 0.8441d, 1.0000d)),
            new TempGamma(9300, new RGB(0.7393d, 0.8400d, 1.0000d)),
            new TempGamma(9400, new RGB(0.7331d, 0.8359d, 1.0000d)),
            new TempGamma(9500, new RGB(0.7271d, 0.8320d, 1.0000d)),
            new TempGamma(9600, new RGB(0.7212d, 0.8281d, 1.0000d)),
            new TempGamma(9700, new RGB(0.7155d, 0.8243d, 1.0000d)),
            new TempGamma(9800, new RGB(0.7098d, 0.8206d, 1.0000d)),
            new TempGamma(9900, new RGB(0.7043d, 0.8169d, 1.0000d)),
            new TempGamma(10000, new RGB(0.6989d, 0.8133d, 1.0000d))
        };

        private static readonly TempGamma[] gammas2 = {
            new TempGamma(1000, new RGB(1.00000000d, 0.18172716d, 0.00000000d)),
            new TempGamma(1100, new RGB(1.00000000d, 0.25503671d, 0.00000000d)),
            new TempGamma(1400, new RGB(1.00000000d, 0.39091524d, 0.00000000d)),
            new TempGamma(1500, new RGB(1.00000000d, 0.42322816d, 0.00000000d)),
            new TempGamma(1600, new RGB(1.00000000d, 0.45159884d, 0.00000000d)),
            new TempGamma(1700, new RGB(1.00000000d, 0.47675916d, 0.00000000d)),
            new TempGamma(1800, new RGB(1.00000000d, 0.49923747d, 0.00000000d)),
            new TempGamma(1900, new RGB(1.00000000d, 0.51943421d, 0.00000000d)),
            new TempGamma(2000, new RGB(1.00000000d, 0.54360078d, 0.08679949d)),
            new TempGamma(2100, new RGB(1.00000000d, 0.56618736d, 0.14065513d)),
            new TempGamma(2200, new RGB(1.00000000d, 0.58734976d, 0.18362641d)),
            new TempGamma(2300, new RGB(1.00000000d, 0.60724493d, 0.22137978d)),
            new TempGamma(2400, new RGB(1.00000000d, 0.62600248d, 0.25591950d)),
            new TempGamma(2500, new RGB(1.00000000d, 0.64373109d, 0.28819679d)),
            new TempGamma(2600, new RGB(1.00000000d, 0.66052319d, 0.31873863d)),
            new TempGamma(2700, new RGB(1.00000000d, 0.67645822d, 0.34786758d)),
            new TempGamma(2800, new RGB(1.00000000d, 0.69160518d, 0.37579588d)),
            new TempGamma(2900, new RGB(1.00000000d, 0.70602449d, 0.40267128d)),
            new TempGamma(3000, new RGB(1.00000000d, 0.71976951d, 0.42860152d)),
            new TempGamma(3100, new RGB(1.00000000d, 0.73288760d, 0.45366838d)),
            new TempGamma(3200, new RGB(1.00000000d, 0.74542112d, 0.47793608d)),
            new TempGamma(3300, new RGB(1.00000000d, 0.75740814d, 0.50145662d)),
            new TempGamma(3400, new RGB(1.00000000d, 0.76888303d, 0.52427322d)),
            new TempGamma(3500, new RGB(1.00000000d, 0.77987699d, 0.54642268d)),
            new TempGamma(3600, new RGB(1.00000000d, 0.79041843d, 0.56793692d)),
            new TempGamma(3700, new RGB(1.00000000d, 0.80053332d, 0.58884417d)),
            new TempGamma(3800, new RGB(1.00000000d, 0.81024551d, 0.60916971d)),
            new TempGamma(3900, new RGB(1.00000000d, 0.81957693d, 0.62893653d)),
            new TempGamma(4000, new RGB(1.00000000d, 0.82854786d, 0.64816570d)),
            new TempGamma(4100, new RGB(1.00000000d, 0.83717703d, 0.66687674d)),
            new TempGamma(4200, new RGB(1.00000000d, 0.84548188d, 0.68508786d)),
            new TempGamma(4300, new RGB(1.00000000d, 0.85347859d, 0.70281616d)),
            new TempGamma(4400, new RGB(1.00000000d, 0.86118227d, 0.72007777d)),
            new TempGamma(4500, new RGB(1.00000000d, 0.86860704d, 0.73688797d)),
            new TempGamma(4600, new RGB(1.00000000d, 0.87576611d, 0.75326132d)),
            new TempGamma(4700, new RGB(1.00000000d, 0.88267187d, 0.76921169d)),
            new TempGamma(4800, new RGB(1.00000000d, 0.88933596d, 0.78475236d)),
            new TempGamma(4900, new RGB(1.00000000d, 0.89576933d, 0.79989606d)),
            new TempGamma(5000, new RGB(1.00000000d, 0.90198230d, 0.81465502d)),
            new TempGamma(5100, new RGB(1.00000000d, 0.90963069d, 0.82838210d)),
            new TempGamma(5200, new RGB(1.00000000d, 0.91710889d, 0.84190889d)),
            new TempGamma(5300, new RGB(1.00000000d, 0.92441842d, 0.85523742d)),
            new TempGamma(5400, new RGB(1.00000000d, 0.93156127d, 0.86836903d)),
            new TempGamma(5500, new RGB(1.00000000d, 0.93853986d, 0.88130458d)),
            new TempGamma(5600, new RGB(1.00000000d, 0.94535695d, 0.89404470d)),
            new TempGamma(5700, new RGB(1.00000000d, 0.95201559d, 0.90658983d)),
            new TempGamma(5800, new RGB(1.00000000d, 0.95851906d, 0.91894041d)),
            new TempGamma(5900, new RGB(1.00000000d, 0.96487079d, 0.93109690d)),
            new TempGamma(6000, new RGB(1.00000000d, 0.97107439d, 0.94305985d)),
            new TempGamma(6100, new RGB(1.00000000d, 0.97713351d, 0.95482993d)),
            new TempGamma(6200, new RGB(1.00000000d, 0.98305189d, 0.96640795d)),
            new TempGamma(6300, new RGB(1.00000000d, 0.98883326d, 0.97779486d)),
            new TempGamma(6400, new RGB(1.00000000d, 0.99448139d, 0.98899179d)),
            new TempGamma(6500, new RGB(1.00000000d, 1.00000000d, 1.00000000d)),
            new TempGamma(6600, new RGB(0.98947904d, 0.99348723d, 1.00000000d)),
            new TempGamma(6700, new RGB(0.97940448d, 0.98722715d, 1.00000000d)),
            new TempGamma(6800, new RGB(0.96975025d, 0.98120637d, 1.00000000d)),
            new TempGamma(6900, new RGB(0.96049223d, 0.97541240d, 1.00000000d)),
            new TempGamma(7000, new RGB(0.95160805d, 0.96983355d, 1.00000000d)),
            new TempGamma(7100, new RGB(0.94303638d, 0.96443333d, 1.00000000d)),
            new TempGamma(7200, new RGB(0.93480451d, 0.95923080d, 1.00000000d)),
            new TempGamma(7300, new RGB(0.92689056d, 0.95421394d, 1.00000000d)),
            new TempGamma(7400, new RGB(0.91927697d, 0.94937330d, 1.00000000d)),
            new TempGamma(7500, new RGB(0.91194747d, 0.94470005d, 1.00000000d)),
            new TempGamma(7600, new RGB(0.90488690d, 0.94018594d, 1.00000000d)),
            new TempGamma(7700, new RGB(0.89808115d, 0.93582323d, 1.00000000d)),
            new TempGamma(7800, new RGB(0.89151710d, 0.93160469d, 1.00000000d)),
            new TempGamma(7900, new RGB(0.88518247d, 0.92752354d, 1.00000000d)),
            new TempGamma(8000, new RGB(0.87906581d, 0.92357340d, 1.00000000d)),
            new TempGamma(8100, new RGB(0.87315640d, 0.91974827d, 1.00000000d)),
            new TempGamma(8200, new RGB(0.86744421d, 0.91604254d, 1.00000000d)),
            new TempGamma(8300, new RGB(0.86191983d, 0.91245088d, 1.00000000d)),
            new TempGamma(8400, new RGB(0.85657444d, 0.90896831d, 1.00000000d)),
            new TempGamma(8500, new RGB(0.85139976d, 0.90559011d, 1.00000000d)),
            new TempGamma(8600, new RGB(0.84638799d, 0.90231183d, 1.00000000d)),
            new TempGamma(8700, new RGB(0.84153180d, 0.89912926d, 1.00000000d)),
            new TempGamma(8800, new RGB(0.83682430d, 0.89603843d, 1.00000000d)),
            new TempGamma(8900, new RGB(0.83225897d, 0.89303558d, 1.00000000d)),
            new TempGamma(9000, new RGB(0.82782969d, 0.89011714d, 1.00000000d)),
            new TempGamma(9100, new RGB(0.82353066d, 0.88727974d, 1.00000000d)),
            new TempGamma(9200, new RGB(0.81935641d, 0.88452017d, 1.00000000d)),
            new TempGamma(9300, new RGB(0.81530175d, 0.88183541d, 1.00000000d)),
            new TempGamma(9400, new RGB(0.81136180d, 0.87922257d, 1.00000000d)),
            new TempGamma(9500, new RGB(0.80753191d, 0.87667891d, 1.00000000d)),
            new TempGamma(9600, new RGB(0.80380769d, 0.87420182d, 1.00000000d)),
            new TempGamma(9700, new RGB(0.80018497d, 0.87178882d, 1.00000000d)),
            new TempGamma(9800, new RGB(0.79665980d, 0.86943756d, 1.00000000d)),
            new TempGamma(9900, new RGB(0.79322843d, 0.86714579d, 1.00000000d)),
            new TempGamma(10000, new RGB(0.78988728d, 0.86491137d, 1.00000000d)),
            new TempGamma(10100, new RGB(0.78663296d, 0.86273225d, 1.00000000d)),
            new TempGamma(10200, new RGB(0.78346225d, 0.86060650d, 1.00000000d)),
            new TempGamma(10300, new RGB(0.78037207d, 0.85853224d, 1.00000000d)),
            new TempGamma(10400, new RGB(0.77735950d, 0.85650771d, 1.00000000d)),
            new TempGamma(10500, new RGB(0.77442176d, 0.85453121d, 1.00000000d)),
            new TempGamma(10600, new RGB(0.77155617d, 0.85260112d, 1.00000000d)),
            new TempGamma(10700, new RGB(0.76876022d, 0.85071588d, 1.00000000d)),
            new TempGamma(10800, new RGB(0.76603147d, 0.84887402d, 1.00000000d)),
            new TempGamma(10900, new RGB(0.76336762d, 0.84707411d, 1.00000000d)),
            new TempGamma(11000, new RGB(0.76076645d, 0.84531479d, 1.00000000d)),
            new TempGamma(11100, new RGB(0.75822586d, 0.84359476d, 1.00000000d)),
            new TempGamma(11200, new RGB(0.75574383d, 0.84191277d, 1.00000000d)),
            new TempGamma(11300, new RGB(0.75331843d, 0.84026762d, 1.00000000d)),
            new TempGamma(11400, new RGB(0.75094780d, 0.83865816d, 1.00000000d)),
            new TempGamma(11500, new RGB(0.74863017d, 0.83708329d, 1.00000000d)),
            new TempGamma(11600, new RGB(0.74636386d, 0.83554194d, 1.00000000d)),
            new TempGamma(11700, new RGB(0.74414722d, 0.83403311d, 1.00000000d)),
            new TempGamma(11800, new RGB(0.74197871d, 0.83255582d, 1.00000000d)),
            new TempGamma(11900, new RGB(0.73985682d, 0.83110912d, 1.00000000d)),
            new TempGamma(12000, new RGB(0.73778012d, 0.82969211d, 1.00000000d)),
            new TempGamma(12100, new RGB(0.73574723d, 0.82830393d, 1.00000000d)),
            new TempGamma(12200, new RGB(0.73375683d, 0.82694373d, 1.00000000d)),
            new TempGamma(12300, new RGB(0.73180765d, 0.82561071d, 1.00000000d)),
            new TempGamma(12400, new RGB(0.72989845d, 0.82430410d, 1.00000000d)),
            new TempGamma(12500, new RGB(0.72802807d, 0.82302316d, 1.00000000d)),
            new TempGamma(12600, new RGB(0.72619537d, 0.82176715d, 1.00000000d)),
            new TempGamma(12700, new RGB(0.72439927d, 0.82053539d, 1.00000000d)),
            new TempGamma(12800, new RGB(0.72263872d, 0.81932722d, 1.00000000d)),
            new TempGamma(12900, new RGB(0.72091270d, 0.81814197d, 1.00000000d)),
            new TempGamma(13000, new RGB(0.71922025d, 0.81697905d, 1.00000000d)),
            new TempGamma(13100, new RGB(0.71756043d, 0.81583783d, 1.00000000d)),
            new TempGamma(13200, new RGB(0.71593234d, 0.81471775d, 1.00000000d)),
            new TempGamma(13300, new RGB(0.71433510d, 0.81361825d, 1.00000000d)),
            new TempGamma(13400, new RGB(0.71276788d, 0.81253878d, 1.00000000d)),
            new TempGamma(13500, new RGB(0.71122987d, 0.81147883d, 1.00000000d)),
            new TempGamma(13600, new RGB(0.70972029d, 0.81043789d, 1.00000000d)),
            new TempGamma(13700, new RGB(0.70823838d, 0.80941546d, 1.00000000d)),
            new TempGamma(13800, new RGB(0.70678342d, 0.80841109d, 1.00000000d)),
            new TempGamma(13900, new RGB(0.70535469d, 0.80742432d, 1.00000000d)),
            new TempGamma(14000, new RGB(0.70395153d, 0.80645469d, 1.00000000d)),
            new TempGamma(14100, new RGB(0.70257327d, 0.80550180d, 1.00000000d)),
            new TempGamma(14200, new RGB(0.70121928d, 0.80456522d, 1.00000000d)),
            new TempGamma(14300, new RGB(0.69988894d, 0.80364455d, 1.00000000d)),
            new TempGamma(14400, new RGB(0.69858167d, 0.80273941d, 1.00000000d)),
            new TempGamma(14500, new RGB(0.69729688d, 0.80184943d, 1.00000000d)),
            new TempGamma(14600, new RGB(0.69603402d, 0.80097423d, 1.00000000d)),
            new TempGamma(14700, new RGB(0.69479255d, 0.80011347d, 1.00000000d)),
            new TempGamma(14800, new RGB(0.69357196d, 0.79926681d, 1.00000000d)),
            new TempGamma(14900, new RGB(0.69237173d, 0.79843391d, 1.00000000d)),
            new TempGamma(15000, new RGB(0.69119138d, 0.79761446d, 1.00000000d)),
            new TempGamma(15100, new RGB(0.69003044d, 0.79680814d, 1.00000000d)),
            new TempGamma(15200, new RGB(0.68888844d, 0.79601466d, 1.00000000d)),
            new TempGamma(15300, new RGB(0.68776494d, 0.79523371d, 1.00000000d)),
            new TempGamma(15400, new RGB(0.68665951d, 0.79446502d, 1.00000000d)),
            new TempGamma(15500, new RGB(0.68557173d, 0.79370830d, 1.00000000d)),
            new TempGamma(15600, new RGB(0.68450119d, 0.79296330d, 1.00000000d)),
            new TempGamma(15700, new RGB(0.68344751d, 0.79222975d, 1.00000000d)),
            new TempGamma(15800, new RGB(0.68241029d, 0.79150740d, 1.00000000d)),
            new TempGamma(15900, new RGB(0.68138918d, 0.79079600d, 1.00000000d)),
            new TempGamma(16000, new RGB(0.68038380d, 0.79009531d, 1.00000000d)),
            new TempGamma(16100, new RGB(0.67939381d, 0.78940511d, 1.00000000d)),
            new TempGamma(16200, new RGB(0.67841888d, 0.78872517d, 1.00000000d)),
            new TempGamma(16300, new RGB(0.67745866d, 0.78805526d, 1.00000000d)),
            new TempGamma(16400, new RGB(0.67651284d, 0.78739518d, 1.00000000d)),
            new TempGamma(16500, new RGB(0.67558112d, 0.78674472d, 1.00000000d)),
            new TempGamma(16600, new RGB(0.67466317d, 0.78610368d, 1.00000000d)),
            new TempGamma(16700, new RGB(0.67375872d, 0.78547186d, 1.00000000d)),
            new TempGamma(16800, new RGB(0.67286748d, 0.78484907d, 1.00000000d)),
            new TempGamma(16900, new RGB(0.67198916d, 0.78423512d, 1.00000000d)),
            new TempGamma(17000, new RGB(0.67112350d, 0.78362984d, 1.00000000d)),
            new TempGamma(17100, new RGB(0.67027024d, 0.78303305d, 1.00000000d)),
            new TempGamma(17200, new RGB(0.66942911d, 0.78244457d, 1.00000000d)),
            new TempGamma(17300, new RGB(0.66859988d, 0.78186425d, 1.00000000d)),
            new TempGamma(17400, new RGB(0.66778228d, 0.78129191d, 1.00000000d)),
            new TempGamma(17500, new RGB(0.66697610d, 0.78072740d, 1.00000000d)),
            new TempGamma(17600, new RGB(0.66618110d, 0.78017057d, 1.00000000d)),
            new TempGamma(17700, new RGB(0.66539706d, 0.77962127d, 1.00000000d)),
            new TempGamma(17800, new RGB(0.66462376d, 0.77907934d, 1.00000000d)),
            new TempGamma(17900, new RGB(0.66386098d, 0.77854465d, 1.00000000d)),
            new TempGamma(18000, new RGB(0.66310852d, 0.77801705d, 1.00000000d)),
            new TempGamma(18100, new RGB(0.66236618d, 0.77749642d, 1.00000000d)),
            new TempGamma(18200, new RGB(0.66163375d, 0.77698261d, 1.00000000d)),
            new TempGamma(18300, new RGB(0.66091106d, 0.77647551d, 1.00000000d)),
            new TempGamma(18400, new RGB(0.66019791d, 0.77597498d, 1.00000000d)),
            new TempGamma(18500, new RGB(0.65949412d, 0.77548090d, 1.00000000d)),
            new TempGamma(18600, new RGB(0.65879952d, 0.77499315d, 1.00000000d)),
            new TempGamma(18700, new RGB(0.65811392d, 0.77451161d, 1.00000000d)),
            new TempGamma(18800, new RGB(0.65743716d, 0.77403618d, 1.00000000d)),
            new TempGamma(18900, new RGB(0.65676908d, 0.77356673d, 1.00000000d)),
            new TempGamma(19000, new RGB(0.65610952d, 0.77310316d, 1.00000000d)),
            new TempGamma(19100, new RGB(0.65545831d, 0.77264537d, 1.00000000d)),
            new TempGamma(19200, new RGB(0.65481530d, 0.77219324d, 1.00000000d)),
            new TempGamma(19300, new RGB(0.65418036d, 0.77174669d, 1.00000000d)),
            new TempGamma(19400, new RGB(0.65355332d, 0.77130560d, 1.00000000d)),
            new TempGamma(19500, new RGB(0.65293404d, 0.77086988d, 1.00000000d)),
            new TempGamma(19600, new RGB(0.65232240d, 0.77043944d, 1.00000000d)),
            new TempGamma(19700, new RGB(0.65171824d, 0.77001419d, 1.00000000d)),
            new TempGamma(19800, new RGB(0.65112144d, 0.76959404d, 1.00000000d)),
            new TempGamma(19900, new RGB(0.65053187d, 0.76917889d, 1.00000000d)),
            new TempGamma(20000, new RGB(0.64994941d, 0.76876866d, 1.00000000d)),
            new TempGamma(20100, new RGB(0.64937392d, 0.76836326d, 1.00000000d)),
            new TempGamma(20200, new RGB(0.64880528d, 0.76796263d, 1.00000000d)),
            new TempGamma(20300, new RGB(0.64824339d, 0.76756666d, 1.00000000d)),
            new TempGamma(20400, new RGB(0.64768812d, 0.76717529d, 1.00000000d)),
            new TempGamma(20500, new RGB(0.64713935d, 0.76678844d, 1.00000000d)),
            new TempGamma(20600, new RGB(0.64659699d, 0.76640603d, 1.00000000d)),
            new TempGamma(20700, new RGB(0.64606092d, 0.76602798d, 1.00000000d)),
            new TempGamma(20800, new RGB(0.64553103d, 0.76565424d, 1.00000000d)),
            new TempGamma(20900, new RGB(0.64500722d, 0.76528472d, 1.00000000d)),
            new TempGamma(21000, new RGB(0.64448939d, 0.76491935d, 1.00000000d)),
            new TempGamma(21100, new RGB(0.64397745d, 0.76455808d, 1.00000000d)),
            new TempGamma(21200, new RGB(0.64347129d, 0.76420082d, 1.00000000d)),
            new TempGamma(21300, new RGB(0.64297081d, 0.76384753d, 1.00000000d)),
            new TempGamma(21400, new RGB(0.64247594d, 0.76349813d, 1.00000000d)),
            new TempGamma(21500, new RGB(0.64198657d, 0.76315256d, 1.00000000d)),
            new TempGamma(21600, new RGB(0.64150261d, 0.76281076d, 1.00000000d)),
            new TempGamma(21700, new RGB(0.64102399d, 0.76247267d, 1.00000000d)),
            new TempGamma(21800, new RGB(0.64055061d, 0.76213824d, 1.00000000d)),
            new TempGamma(21900, new RGB(0.64008239d, 0.76180740d, 1.00000000d)),
            new TempGamma(22000, new RGB(0.63961926d, 0.76148010d, 1.00000000d)),
            new TempGamma(22100, new RGB(0.63916112d, 0.76115628d, 1.00000000d)),
            new TempGamma(22200, new RGB(0.63870790d, 0.76083590d, 1.00000000d)),
            new TempGamma(22300, new RGB(0.63825953d, 0.76051890d, 1.00000000d)),
            new TempGamma(22400, new RGB(0.63781592d, 0.76020522d, 1.00000000d)),
            new TempGamma(22500, new RGB(0.63737701d, 0.75989482d, 1.00000000d)),
            new TempGamma(22600, new RGB(0.63694273d, 0.75958764d, 1.00000000d)),
            new TempGamma(22700, new RGB(0.63651299d, 0.75928365d, 1.00000000d)),
            new TempGamma(22800, new RGB(0.63608774d, 0.75898278d, 1.00000000d)),
            new TempGamma(22900, new RGB(0.63566691d, 0.75868499d, 1.00000000d)),
            new TempGamma(23000, new RGB(0.63525042d, 0.75839025d, 1.00000000d)),
            new TempGamma(23100, new RGB(0.63483822d, 0.75809849d, 1.00000000d)),
            new TempGamma(23200, new RGB(0.63443023d, 0.75780969d, 1.00000000d)),
            new TempGamma(23300, new RGB(0.63402641d, 0.75752379d, 1.00000000d)),
            new TempGamma(23400, new RGB(0.63362667d, 0.75724075d, 1.00000000d)),
            new TempGamma(23500, new RGB(0.63323097d, 0.75696053d, 1.00000000d)),
            new TempGamma(23600, new RGB(0.63283925d, 0.75668310d, 1.00000000d)),
            new TempGamma(23700, new RGB(0.63245144d, 0.75640840d, 1.00000000d)),
            new TempGamma(23800, new RGB(0.63206749d, 0.75613641d, 1.00000000d)),
            new TempGamma(23900, new RGB(0.63168735d, 0.75586707d, 1.00000000d)),
            new TempGamma(24000, new RGB(0.63131096d, 0.75560036d, 1.00000000d)),
            new TempGamma(24100, new RGB(0.63093826d, 0.75533624d, 1.00000000d)),
            new TempGamma(24200, new RGB(0.63056920d, 0.75507467d, 1.00000000d)),
            new TempGamma(24300, new RGB(0.63020374d, 0.75481562d, 1.00000000d)),
            new TempGamma(24400, new RGB(0.62984181d, 0.75455904d, 1.00000000d)),
            new TempGamma(24500, new RGB(0.62948337d, 0.75430491d, 1.00000000d)),
            new TempGamma(24600, new RGB(0.62912838d, 0.75405319d, 1.00000000d)),
            new TempGamma(24700, new RGB(0.62877678d, 0.75380385d, 1.00000000d)),
            new TempGamma(24800, new RGB(0.62842852d, 0.75355685d, 1.00000000d)),
            new TempGamma(24900, new RGB(0.62808356d, 0.75331217d, 1.00000000d)),
            new TempGamma(25000, new RGB(0.62774186d, 0.75306977d, 1.00000000d))
        };
    }
}
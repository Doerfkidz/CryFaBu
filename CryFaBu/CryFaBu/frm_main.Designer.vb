<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_main
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.Cbox_coin = New System.Windows.Forms.ComboBox()
        Me.tbox_gewinn = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_start
        '
        Me.btn_start.Location = New System.Drawing.Point(111, 244)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(317, 154)
        Me.btn_start.TabIndex = 0
        Me.btn_start.Text = "Start"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'Cbox_coin
        '
        Me.Cbox_coin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbox_coin.FormattingEnabled = True
        Me.Cbox_coin.Items.AddRange(New Object() {"2GIVE/2GIVE", "8bit/8BIT", "AdEx/ADX", "adToken/ADT", "Aeon/AEON", "AeroME/AM", "AmsterdamCoin/AMS", "ApexCoin/APEX", "Apx/APX", "Aragon/ANT", "ArbitCoin/ARB", "Ardor/ARDR", "Ark/ARK", "ArtByte/ABY", "AudioCoin/ADC", "Augur/REP", "AuroraCoin/AUR", "Bancor/BNT", "Basic Attention Token/BA", "Bata/BTA", "BitBay/BAY", "BitBean/BITB", "BitCNY/BITCNY", "Bitcoin Cash/BCC", "Bitcoin/BTC", "BitcoinDark/BTCD", "BitCrystals" & Global.Microsoft.VisualBasic.ChrW(9) & "/BCY", "BitSeeds/XSEED", "BitSend/BSD", "BitShares/BTS", "BitStarCoin/BITS", "Bitswift/SWIFT", "Bittrex Test Currency/TROLL", "Bitz/BITZ", "BlackCoin/BLK", "BlakeCoin/BLC", "Blitzcash/BLITZ", "BlockNet/BLOCK", "Boolberry/XBB", "Breakout Stake/BRX", "Breakout/BRK", "BURST/BURST", "Bytecent/BYC", "Bytes/GBYTE", "CannabisCoin/CANN", "CannaCoin/CCN", "CapriCoin/CPC", "Chronobank Time/TIME", "Circuits of Value/COVAL", "Civic/CVC", "CLAMs/CLAM", "CloakCoin/CLOAK", "ClubCoin/CLUB", "Cofound.it/CFI", "Counterparty/XCP", "CreditBit/CRB", "CreditBit/CRBIT", "Crown/CRW", "CryptCoin/CRYPT", "CureCoin/CURE", "Darcrus/DAR", "Dash/DASH", "Databits/DTB", "DayTraderCoin/DTC", "DECENT/DCT", "Decred/DCR", "Diamond/DMD", "Digibyte/DGB", "DigitalCoin/DGC", "DigitalNote/XDN", "Digix DAO/DGD", "Dirac/XDQ", "DobbsCoin/BOB", "Dogecoin/DOGE", "DopeCoin/DOPE", "DT Token/DRACO", "Dynamic/DYN", "eBoost/EBST", "Edgeless/EDG", "Einsteinium/EMC2", "Elastic/XEL", "ElectronicGulden/EFL", "EmerCoin/EMC", "EnergyCoin/ENRG", "Ethereum Classic/ETC", "Ethereum/ETH", "EuropeCoin/ERC", "EverGreenCoin/EGC", "ExclusiveCoin/EXCL", "Expanse/EXP", "Factom/FCT", "FairCoin/FAIR", "Feathercoin/FTC", "Firstblood" & Global.Microsoft.VisualBasic.ChrW(9) & "/1ST", "Florin/FLO", "FoldingCoin/FLDC", "Franko/FRK", "FriendshipCoin2/FSC2", "FuelCoin/FC2", "FunFair/FUN", "Gambit/GAM", "GameCredits/GAME", "GamerholicCoin/GHC", "Gbg/GBG", "Gemz/GEMZ", "GeoCoin/GEO", "GlobalBoost-Y/BSTY", "GlobalCurrencyReserve/GCR", "Gnosis/GNO", "GoldCoin/GLD", "GoldPieces/GP", "Golem/GNT", "Golos/GOLOS", "Grantcoin/GRT", "GridCoin/GRC", "Groestlcoin/GRS", "Gulden/NLG", "Guppy/GUP", "HackerGold/HKG", "HempCoin/THC", "Horizon/HZ", "Humaniq/HMQ", "Hyper/HYPER", "I/OCoin/IOC", "IDNI Agoras/AGRS", "iEx.ec/RLC", "Incent/INCNT", "InfluxCoin/INFX", "Internet Of People/IOP", "Ion/ION", "JoinCoin/J", "Komodo/KMD", "KoreCoin/KORE", "Krypton/KR", "LBRY Credits/LBC", "Legends/LGD", "LibrexCoin/LXC", "Lisk/LSK", "Litecoin/LTC", "Lomocoin/LMC", "Lumen/XLM", "Lunyr/LUN", "Magi/XMG", "MaidSafeCoin/MAID", "MasterTraderCoin/MTR", "MaxCoin/MAX", "MazaCoin/MZC", "MegaCoin/MEC", "Melon/MLN", "Memetic/MEME", "METAL/MTL", "MetalCoin/METAL", "MindCoin/MND", "Monaco/MCO", "MonaCoin/MONA", "Monero/XMR", "MonetaryUnit/MUE", "Musicoin/MUSIC", "Myriad/XMY", "Mysterium/MYST", "NautilusCoin/NAUT", "NAVCoin/NAV", "Neo/NEO", "NeosCoin/NEOS", "NetCoin/NET", "NeuCoin/NEU", "Neutron/NTRN", "NewEconomyMovement/XEM", "Nexium/NXC", "Nexus/NXS", "Nubits/NBT", "Numeraire/NMR", "NXT/NXT", "OkCash/OK", "OmiseGO/OMG", "OmniCoin/OMNI", "OrangeCoin/OC", "OrbitCoin/ORB", "ParkByte/PKB", "Particl/PART", "Patientory/PTOY", "Paycoin/XPY", "Peercoin/PPC", "PesetaCoin/PTC", "PinkCoin/PINK", "Pivx/PIVX", "PotCoin/POT", "Prime-XI/PXI", "PrimeChain/PRIME", "Project Decorum/PDC", "Qtum/QTUM", "Quantum Resistant Ledger/QRL", "Quotient/XQN", "Qwark/QWARK", "Radium/RADS", "ReddCoin/RDD", "Ripple/XRP", "Rise/RISE", "RootCoin/ROOT", "RubyCoin/RBY", "SafeExchangeCoin/SAFEX", "SaffronCoin/SFR", "SaluS/SLS", "SativaCoin/STV", "ScotCoin/SCOT", "SecretCoin/SCRT", "Sequence/SEQ", "Shift/SHIFT", "Siacoin/SC", "Siberian Chervonets/SIB", "SingularDTV/SNGLS", "Sling/SLING", "SolarCoin/SLR", "SonicCoin/SSD", "SoonCoin/SOON", "Sphere/SPHR", "SpreadCoin/SPR", "Sprouts/SPRTS", "StartCoin/START", "Status Network Token/SNT", "StealthCoin/XST", "STEEM/STEEM", "SteemDollars/SBD", "Steps/STEPS", "Sterlingcoin/SLG", "STORJ/STORJ", "Stratis/STRAT", "Swarm City Token/SWT", "SwingCoin/SWING", "Syndicate/SYNX", "SynereoAmp/AMP", "Synergy/SNRG", "SysCoin/SYS", "TenX Pay Token/PAY", "TeslaCoin/TES", "Tether/USDT", "TileCoin/XTC", "TitCoin/TIT", "TokenCard/TKN", "Tokes/TKS", "TransferCoin/TX", "Triangles/TRI", "TRIG Token/TRIG", "TruckCoin/TRK", "Trustcoin/TRST", "TrustPlus/TRUST", "Ubiq/UBQ", "UCoin/U", "UFOCoin/UFO", "UltraCoin/UTC", "UnbreakableCoin/UNB", "Uniqredit/UNIQ", "UniversalCurrency/UNIT", "Unobtanium/UNO", "Vcash/XVC", "Verge/XVG", "VeriCoin/VRC", "Verium/VRM", "Vertcoin/VTC", "ViaCoin/VIA", "ViorCoin/VIOR", "Viral/VIRAL", "Voxels/VOX", "VPNCoin/VPN", "vTorrent/VTR", "WarpCoin/WARP", "Waves/WAVES", "WhiteCoin/XWC", "Wings DAO/WINGS", "X-Coin/XCO", "Xaurum/XAUR", "XCurrency" & Global.Microsoft.VisualBasic.ChrW(9) & "/XC", "YBCoin/YBC", "ZCash/ZEC", "Zclassic/ZCL", "ZCoin/XZC", "ZenCash/ZEN"})
        Me.Cbox_coin.Location = New System.Drawing.Point(95, 68)
        Me.Cbox_coin.Name = "Cbox_coin"
        Me.Cbox_coin.Size = New System.Drawing.Size(93, 21)
        Me.Cbox_coin.Sorted = True
        Me.Cbox_coin.TabIndex = 2
        '
        'tbox_gewinn
        '
        Me.tbox_gewinn.Location = New System.Drawing.Point(111, 141)
        Me.tbox_gewinn.Name = "tbox_gewinn"
        Me.tbox_gewinn.Size = New System.Drawing.Size(100, 20)
        Me.tbox_gewinn.TabIndex = 3
        Me.tbox_gewinn.Text = "Wie viel % Gewinn?"
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 419)
        Me.Controls.Add(Me.tbox_gewinn)
        Me.Controls.Add(Me.Cbox_coin)
        Me.Controls.Add(Me.btn_start)
        Me.Name = "frm_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_start As Button
    Friend WithEvents Cbox_coin As ComboBox
    Friend WithEvents tbox_gewinn As TextBox
End Class

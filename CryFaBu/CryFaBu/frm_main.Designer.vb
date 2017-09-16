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
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Cbox_coin = New System.Windows.Forms.ComboBox()
        Me.tbox_gewinn = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_start
        '
        Me.btn_start.Location = New System.Drawing.Point(280, 253)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(317, 154)
        Me.btn_start.TabIndex = 0
        Me.btn_start.Text = "Start"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(136, 390)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(62, 17)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "Sicher?"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Cbox_coin
        '
        Me.Cbox_coin.FormattingEnabled = True
        Me.Cbox_coin.Items.AddRange(New Object() {"Firstblood" & Global.Microsoft.VisualBasic.ChrW(9) & "/1ST" & Global.Microsoft.VisualBasic.ChrW(9), "2GIVE/2GIVE", "8bit/8BIT" & Global.Microsoft.VisualBasic.ChrW(9), "ArtByte/ABY", "AudioCoin/ADC", "adToken/ADT", "AdEx/ADX", "Aeon/AEON", "IDNI Agoras/AGRS", "AeroME/AM", "SynereoAmp/AMP", "AmsterdamCoin/AMS", "Aragon/ANT" & Global.Microsoft.VisualBasic.ChrW(9), "ApexCoin/APEX", "Apx/APX" & Global.Microsoft.VisualBasic.ChrW(9), "ArbitCoin/ARB" & Global.Microsoft.VisualBasic.ChrW(9), "Ardor/ARDR", "Ark/ARK", "AuroraCoin/AUR" & Global.Microsoft.VisualBasic.ChrW(9), "Basic Attention Token/BAT", "BitBay/BAY" & Global.Microsoft.VisualBasic.ChrW(9), "Bitcoin Cash/BCC", "BitCrystals" & Global.Microsoft.VisualBasic.ChrW(9) & "/BCY" & Global.Microsoft.VisualBasic.ChrW(9), "BitBean/BITB" & Global.Microsoft.VisualBasic.ChrW(9), "BitCNY/BITCNY" & Global.Microsoft.VisualBasic.ChrW(9), "BitStarCoin/BITS", "Bitz/BITZ" & Global.Microsoft.VisualBasic.ChrW(9), "BlakeCoin/BLC" & Global.Microsoft.VisualBasic.ChrW(9), "Blitzcash/BLITZ" & Global.Microsoft.VisualBasic.ChrW(9), "BlackCoin/BLK" & Global.Microsoft.VisualBasic.ChrW(9), "BlockNet/BLOCK" & Global.Microsoft.VisualBasic.ChrW(9), "Bancor/BNT" & Global.Microsoft.VisualBasic.ChrW(9), "DobbsCoin/BOB", "Breakout/BRK", "Breakout Stake/BRX" & Global.Microsoft.VisualBasic.ChrW(9), "BitSend/BSD" & Global.Microsoft.VisualBasic.ChrW(9), "GlobalBoost-Y/BSTY" & Global.Microsoft.VisualBasic.ChrW(9), "Bata/BTA", "Bitcoin/BTC" & Global.Microsoft.VisualBasic.ChrW(9), "BitcoinDark/BTCD" & Global.Microsoft.VisualBasic.ChrW(9), "BitShares/BTS" & Global.Microsoft.VisualBasic.ChrW(9), "BURST/BURST" & Global.Microsoft.VisualBasic.ChrW(9), "Bytecent/BYC" & Global.Microsoft.VisualBasic.ChrW(9), "CannabisCoin/CANN", "CannaCoin/CCN", "Cofound.it/CFI" & Global.Microsoft.VisualBasic.ChrW(9), "CLAMs/CLAM" & Global.Microsoft.VisualBasic.ChrW(9), "CloakCoin/CLOAK", "ClubCoin/CLUB" & Global.Microsoft.VisualBasic.ChrW(9), "Circuits of Value/COVAL" & Global.Microsoft.VisualBasic.ChrW(9), "CapriCoin/CPC" & Global.Microsoft.VisualBasic.ChrW(9), "CreditBit/CRB" & Global.Microsoft.VisualBasic.ChrW(9), "CreditBit/CRBIT" & Global.Microsoft.VisualBasic.ChrW(9), "Crown/CRW", "CryptCoin/CRYPT", "CureCoin/CURE", "Civic/CVC" & Global.Microsoft.VisualBasic.ChrW(9), "Darcrus/DAR" & Global.Microsoft.VisualBasic.ChrW(9), "Dash/DASH" & Global.Microsoft.VisualBasic.ChrW(9), "Decred/DCR", "DECENT/DCT", "Digibyte/DGB", "DigitalCoin/DGC" & Global.Microsoft.VisualBasic.ChrW(9), "Digix DAO/DGD" & Global.Microsoft.VisualBasic.ChrW(9), "Diamond/DMD" & Global.Microsoft.VisualBasic.ChrW(9), "Dogecoin/DOGE", "DopeCoin/DOPE" & Global.Microsoft.VisualBasic.ChrW(9), "DT Token/DRACO" & Global.Microsoft.VisualBasic.ChrW(9), "Databits/DTB" & Global.Microsoft.VisualBasic.ChrW(9), "DayTraderCoin/DTC" & Global.Microsoft.VisualBasic.ChrW(9), "Dynamic/DYN" & Global.Microsoft.VisualBasic.ChrW(9), "eBoost/EBST", "Edgeless/EDG" & Global.Microsoft.VisualBasic.ChrW(9), "ElectronicGulden/EFL" & Global.Microsoft.VisualBasic.ChrW(9), "EverGreenCoin/EGC" & Global.Microsoft.VisualBasic.ChrW(9), "EmerCoin/EMC" & Global.Microsoft.VisualBasic.ChrW(9), "Einsteinium/EMC2" & Global.Microsoft.VisualBasic.ChrW(9), "EnergyCoin/ENRG" & Global.Microsoft.VisualBasic.ChrW(9), "EuropeCoin/ERC", "Ethereum Classic/ETC" & Global.Microsoft.VisualBasic.ChrW(9), "Ethereum/ETH" & Global.Microsoft.VisualBasic.ChrW(9), "ExclusiveCoin/EXCL" & Global.Microsoft.VisualBasic.ChrW(9), "Expanse/EXP" & Global.Microsoft.VisualBasic.ChrW(9), "FairCoin/FAIR" & Global.Microsoft.VisualBasic.ChrW(9), "FuelCoin/FC2", "Factom/FCT", "FoldingCoin/FLDC" & Global.Microsoft.VisualBasic.ChrW(9), "Florin/FLO" & Global.Microsoft.VisualBasic.ChrW(9), "Franko/FRK" & Global.Microsoft.VisualBasic.ChrW(9), "FriendshipCoin2/FSC2" & Global.Microsoft.VisualBasic.ChrW(9), "Feathercoin/FTC" & Global.Microsoft.VisualBasic.ChrW(9), "FunFair/FUN" & Global.Microsoft.VisualBasic.ChrW(9), "Gambit/GAM" & Global.Microsoft.VisualBasic.ChrW(9), "GameCredits/GAME", "Gbg/GBG" & Global.Microsoft.VisualBasic.ChrW(9), "Bytes/GBYTE" & Global.Microsoft.VisualBasic.ChrW(9), "GlobalCurrencyReserve/GCR", "Gemz/GEMZ" & Global.Microsoft.VisualBasic.ChrW(9), "GeoCoin/GEO", "GamerholicCoin/GHC", "GoldCoin/GLD" & Global.Microsoft.VisualBasic.ChrW(9), "Gnosis/GNO" & Global.Microsoft.VisualBasic.ChrW(9), "Golem/GNT" & Global.Microsoft.VisualBasic.ChrW(9), "Golos/GOLOS", "GoldPieces/GP" & Global.Microsoft.VisualBasic.ChrW(9), "GridCoin/GRC" & Global.Microsoft.VisualBasic.ChrW(9), "Groestlcoin/GRS" & Global.Microsoft.VisualBasic.ChrW(9), "Grantcoin/GRT" & Global.Microsoft.VisualBasic.ChrW(9), "Guppy/GUP" & Global.Microsoft.VisualBasic.ChrW(9), "HackerGold/HKG", "Humaniq/HMQ", "Hyper/HYPER", "Horizon/HZ" & Global.Microsoft.VisualBasic.ChrW(9), "Incent/INCNT", "InfluxCoin/INFX" & Global.Microsoft.VisualBasic.ChrW(9), "I/OCoin/IOC", "Ion/ION" & Global.Microsoft.VisualBasic.ChrW(9), "Internet Of People/IOP" & Global.Microsoft.VisualBasic.ChrW(9), "JoinCoin/J" & Global.Microsoft.VisualBasic.ChrW(9), "Komodo/KMD" & Global.Microsoft.VisualBasic.ChrW(9), "KoreCoin/KORE" & Global.Microsoft.VisualBasic.ChrW(9), "Krypton/KR", "LBRY Credits/LBC" & Global.Microsoft.VisualBasic.ChrW(9), "Legends/LGD", "Lomocoin/LMC", "Lisk/LSK" & Global.Microsoft.VisualBasic.ChrW(9), "Litecoin/LTC" & Global.Microsoft.VisualBasic.ChrW(9), "Lunyr/LUN", "LibrexCoin/LXC", "MaidSafeCoin/MAID", "MaxCoin/MAX" & Global.Microsoft.VisualBasic.ChrW(9), "Monaco/MCO", "MegaCoin/MEC", "Memetic/MEME", "MetalCoin/METAL", "Melon/MLN", "MindCoin/MND", "MonaCoin/MONA" & Global.Microsoft.VisualBasic.ChrW(9), "METAL/MTL" & Global.Microsoft.VisualBasic.ChrW(9), "MasterTraderCoin/MTR" & Global.Microsoft.VisualBasic.ChrW(9), "MonetaryUnit/MUE" & Global.Microsoft.VisualBasic.ChrW(9), "Musicoin/MUSIC", "Mysterium/MYST" & Global.Microsoft.VisualBasic.ChrW(9), "MazaCoin/MZC" & Global.Microsoft.VisualBasic.ChrW(9), "NautilusCoin/NAUT", "NAVCoin/NAV", "Nubits/NBT" & Global.Microsoft.VisualBasic.ChrW(9), "Neo/NEO", "NeosCoin/NEOS", "NetCoin/NET", "NeuCoin/NEU" & Global.Microsoft.VisualBasic.ChrW(9), "Gulden/NLG", "Numeraire/NMR" & Global.Microsoft.VisualBasic.ChrW(9), "Neutron/NTRN" & Global.Microsoft.VisualBasic.ChrW(9), "Nexium/NXC" & Global.Microsoft.VisualBasic.ChrW(9), "Nexus/NXS" & Global.Microsoft.VisualBasic.ChrW(9), "NXT/NXT" & Global.Microsoft.VisualBasic.ChrW(9), "OrangeCoin/OC", "OkCash/OK" & Global.Microsoft.VisualBasic.ChrW(9), "OmiseGO/OMG", "OmniCoin/OMNI", "OrbitCoin/ORB", "Particl/PART", "TenX Pay Token/PAY", "Project Decorum/PDC" & Global.Microsoft.VisualBasic.ChrW(9), "PinkCoin/PINK", "Pivx/PIVX" & Global.Microsoft.VisualBasic.ChrW(9), "ParkByte/PKB" & Global.Microsoft.VisualBasic.ChrW(9), "PotCoin/POT" & Global.Microsoft.VisualBasic.ChrW(9), "Peercoin/PPC" & Global.Microsoft.VisualBasic.ChrW(9), "PrimeChain/PRIME", "PesetaCoin/PTC" & Global.Microsoft.VisualBasic.ChrW(9), "Patientory/PTOY" & Global.Microsoft.VisualBasic.ChrW(9), "Prime-XI/PXI" & Global.Microsoft.VisualBasic.ChrW(9), "Quantum Resistant Ledger/QRL", "Qtum/QTUM" & Global.Microsoft.VisualBasic.ChrW(9), "Qwark/QWARK" & Global.Microsoft.VisualBasic.ChrW(9), "Radium/RADS" & Global.Microsoft.VisualBasic.ChrW(9), "RubyCoin/RBY" & Global.Microsoft.VisualBasic.ChrW(9), "ReddCoin/RDD" & Global.Microsoft.VisualBasic.ChrW(9), "Augur/REP" & Global.Microsoft.VisualBasic.ChrW(9), "Rise/RISE", "iEx.ec/RLC", "RootCoin/ROOT", "SafeExchangeCoin/SAFEX" & Global.Microsoft.VisualBasic.ChrW(9), "SteemDollars/SBD" & Global.Microsoft.VisualBasic.ChrW(9), "Siacoin/SC" & Global.Microsoft.VisualBasic.ChrW(9), "ScotCoin/SCOT" & Global.Microsoft.VisualBasic.ChrW(9), "SecretCoin/SCRT", "Sequence/SEQ" & Global.Microsoft.VisualBasic.ChrW(9), "SaffronCoin/SFR" & Global.Microsoft.VisualBasic.ChrW(9), "Shift/SHIFT" & Global.Microsoft.VisualBasic.ChrW(9), "Siberian Chervonets/SIB" & Global.Microsoft.VisualBasic.ChrW(9), "Sterlingcoin/SLG" & Global.Microsoft.VisualBasic.ChrW(9), "Sling/SLING" & Global.Microsoft.VisualBasic.ChrW(9), "SolarCoin/SLR" & Global.Microsoft.VisualBasic.ChrW(9), "SaluS/SLS" & Global.Microsoft.VisualBasic.ChrW(9), "SingularDTV/SNGLS", "Synergy/SNRG" & Global.Microsoft.VisualBasic.ChrW(9), "Status Network Token/SNT", "SoonCoin/SOON" & Global.Microsoft.VisualBasic.ChrW(9), "Sphere/SPHR", "SpreadCoin/SPR" & Global.Microsoft.VisualBasic.ChrW(9), "Sprouts/SPRTS" & Global.Microsoft.VisualBasic.ChrW(9), "SonicCoin/SSD" & Global.Microsoft.VisualBasic.ChrW(9), "StartCoin/START" & Global.Microsoft.VisualBasic.ChrW(9), "STEEM/STEEM", "Steps/STEPS" & Global.Microsoft.VisualBasic.ChrW(9), "STORJ/STORJ" & Global.Microsoft.VisualBasic.ChrW(9), "Stratis/STRAT" & Global.Microsoft.VisualBasic.ChrW(9), "SativaCoin/STV" & Global.Microsoft.VisualBasic.ChrW(9), "Bitswift/SWIFT", "SwingCoin/SWING" & Global.Microsoft.VisualBasic.ChrW(9), "Swarm City Token/SWT" & Global.Microsoft.VisualBasic.ChrW(9), "Syndicate/SYNX" & Global.Microsoft.VisualBasic.ChrW(9), "SysCoin/SYS" & Global.Microsoft.VisualBasic.ChrW(9), "TeslaCoin/TES" & Global.Microsoft.VisualBasic.ChrW(9), "HempCoin/THC", "Chronobank Time/TIME", "TitCoin/TIT" & Global.Microsoft.VisualBasic.ChrW(9), "TokenCard/TKN" & Global.Microsoft.VisualBasic.ChrW(9), "Tokes/TKS", "Triangles/TRI" & Global.Microsoft.VisualBasic.ChrW(9), "TRIG Token/TRIG" & Global.Microsoft.VisualBasic.ChrW(9), "TruckCoin/TRK" & Global.Microsoft.VisualBasic.ChrW(9), "Bittrex Test Currency/TROLL", "Trustcoin/TRST" & Global.Microsoft.VisualBasic.ChrW(9), "TrustPlus/TRUST" & Global.Microsoft.VisualBasic.ChrW(9), "TransferCoin/TX" & Global.Microsoft.VisualBasic.ChrW(9), "UCoin/U" & Global.Microsoft.VisualBasic.ChrW(9), "Ubiq/UBQ", "UFOCoin/UFO" & Global.Microsoft.VisualBasic.ChrW(9), "UnbreakableCoin/UNB", "Uniqredit/UNIQ" & Global.Microsoft.VisualBasic.ChrW(9), "UniversalCurrency/UNIT", "Unobtanium/UNO", "Tether/USDT" & Global.Microsoft.VisualBasic.ChrW(9), "UltraCoin/UTC" & Global.Microsoft.VisualBasic.ChrW(9), "ViaCoin/VIA" & Global.Microsoft.VisualBasic.ChrW(9), "ViorCoin/VIOR" & Global.Microsoft.VisualBasic.ChrW(9), "Viral/VIRAL", "Voxels/VOX" & Global.Microsoft.VisualBasic.ChrW(9), "VPNCoin/VPN" & Global.Microsoft.VisualBasic.ChrW(9), "VeriCoin/VRC", "Verium/VRM", "Vertcoin/VTC" & Global.Microsoft.VisualBasic.ChrW(9), "vTorrent/VTR" & Global.Microsoft.VisualBasic.ChrW(9), "WarpCoin/WARP", "Waves/WAVES", "Wings DAO/WINGS", "Xaurum/XAUR", "Boolberry/XBB" & Global.Microsoft.VisualBasic.ChrW(9), "XCurrency" & Global.Microsoft.VisualBasic.ChrW(9) & "/XC" & Global.Microsoft.VisualBasic.ChrW(9), "X-Coin/XCO", "Counterparty/XCP" & Global.Microsoft.VisualBasic.ChrW(9), "DigitalNote/XDN" & Global.Microsoft.VisualBasic.ChrW(9), "Dirac/XDQ" & Global.Microsoft.VisualBasic.ChrW(9), "Elastic/XEL", "NewEconomyMovement/XEM", "Lumen/XLM" & Global.Microsoft.VisualBasic.ChrW(9), "Magi/XMG" & Global.Microsoft.VisualBasic.ChrW(9), "Monero/XMR" & Global.Microsoft.VisualBasic.ChrW(9), "Myriad/XMY" & Global.Microsoft.VisualBasic.ChrW(9), "Paycoin/XPY" & Global.Microsoft.VisualBasic.ChrW(9), "Quotient/XQN" & Global.Microsoft.VisualBasic.ChrW(9), "Ripple/XRP", "BitSeeds/XSEED", "StealthCoin/XST", "TileCoin/XTC" & Global.Microsoft.VisualBasic.ChrW(9), "Vcash/XVC" & Global.Microsoft.VisualBasic.ChrW(9), "Verge/XVG" & Global.Microsoft.VisualBasic.ChrW(9), "WhiteCoin/XWC" & Global.Microsoft.VisualBasic.ChrW(9), "ZCoin/XZC" & Global.Microsoft.VisualBasic.ChrW(9), "YBCoin/YBC" & Global.Microsoft.VisualBasic.ChrW(9), "Zclassic/ZCL" & Global.Microsoft.VisualBasic.ChrW(9), "ZCash/ZEC", "ZenCash/ZEN"})
        Me.Cbox_coin.Location = New System.Drawing.Point(280, 79)
        Me.Cbox_coin.Name = "Cbox_coin"
        Me.Cbox_coin.Size = New System.Drawing.Size(121, 21)
        Me.Cbox_coin.TabIndex = 2
        '
        'tbox_gewinn
        '
        Me.tbox_gewinn.Location = New System.Drawing.Point(497, 80)
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
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btn_start)
        Me.Name = "frm_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "^^"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_start As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Cbox_coin As ComboBox
    Friend WithEvents tbox_gewinn As TextBox
End Class

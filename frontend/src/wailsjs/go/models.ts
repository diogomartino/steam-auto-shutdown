export namespace net {
	
	export class IOCountersStat {
	    name: string;
	    bytesSent: number;
	    bytesRecv: number;
	    packetsSent: number;
	    packetsRecv: number;
	    errin: number;
	    errout: number;
	    dropin: number;
	    dropout: number;
	    fifoin: number;
	    fifoout: number;
	
	    static createFrom(source: any = {}) {
	        return new IOCountersStat(source);
	    }
	
	    constructor(source: any = {}) {
	        if ('string' === typeof source) source = JSON.parse(source);
	        this.name = source["name"];
	        this.bytesSent = source["bytesSent"];
	        this.bytesRecv = source["bytesRecv"];
	        this.packetsSent = source["packetsSent"];
	        this.packetsRecv = source["packetsRecv"];
	        this.errin = source["errin"];
	        this.errout = source["errout"];
	        this.dropin = source["dropin"];
	        this.dropout = source["dropout"];
	        this.fifoin = source["fifoin"];
	        this.fifoout = source["fifoout"];
	    }
	}
	export class InterfaceAddr {
	    addr: string;
	
	    static createFrom(source: any = {}) {
	        return new InterfaceAddr(source);
	    }
	
	    constructor(source: any = {}) {
	        if ('string' === typeof source) source = JSON.parse(source);
	        this.addr = source["addr"];
	    }
	}
	export class InterfaceStat {
	    index: number;
	    mtu: number;
	    name: string;
	    hardwareaddr: string;
	    flags: string[];
	    addrs: InterfaceAddr[];
	
	    static createFrom(source: any = {}) {
	        return new InterfaceStat(source);
	    }
	
	    constructor(source: any = {}) {
	        if ('string' === typeof source) source = JSON.parse(source);
	        this.index = source["index"];
	        this.mtu = source["mtu"];
	        this.name = source["name"];
	        this.hardwareaddr = source["hardwareaddr"];
	        this.flags = source["flags"];
	        this.addrs = this.convertValues(source["addrs"], InterfaceAddr);
	    }
	
		convertValues(a: any, classs: any, asMap: boolean = false): any {
		    if (!a) {
		        return a;
		    }
		    if (a.slice) {
		        return (a as any[]).map(elem => this.convertValues(elem, classs));
		    } else if ("object" === typeof a) {
		        if (asMap) {
		            for (const key of Object.keys(a)) {
		                a[key] = new classs(a[key]);
		            }
		            return a;
		        }
		        return new classs(a);
		    }
		    return a;
		}
	}

}


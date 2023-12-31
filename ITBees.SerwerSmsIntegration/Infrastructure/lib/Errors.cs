﻿/*
 * Created by SharpDevelop.
 * User: Przemek
 * Date: 18.01.2016
 * Time: 14:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Collections;
using ITBees.SerwerSmsIntegration.Infrastructure;
using serwersms;

namespace serwersms.lib
{
	
	public class Errors
	{
		private SerwerSmsPL obj = null;
		
		public Errors(SerwerSmsPL obj )
		{
			this.obj = obj;
		}
		
		/**
		 * Preview error
		 * 
		 * @param int code
		 * @return array
		 *      @option int "code"
		 *      @option String "type"
		 *      @option String "message"
		 */
		public Object view( String code ) {
	        	
			var data = new Dictionary<String, String>();
			
	        return this.obj.call("error/"+code,data);
	    
	    }
	}
	
}

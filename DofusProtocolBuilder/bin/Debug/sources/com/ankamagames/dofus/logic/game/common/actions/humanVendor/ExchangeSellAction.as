﻿package com.ankamagames.dofus.logic.game.common.actions.humanVendor
{

    public class ExchangeSellAction extends Object implements Action
    {
        public var objectUID:uint;
        public var quantity:uint;

        public function ExchangeSellAction()
        {
            return;
        }// end function

        public static function create(param1:uint, param2:uint) : ExchangeSellAction
        {
            var _loc_3:* = new ExchangeSellAction;
            _loc_3.objectUID = param1;
            _loc_3.quantity = param2;
            return _loc_3;
        }// end function

    }
}
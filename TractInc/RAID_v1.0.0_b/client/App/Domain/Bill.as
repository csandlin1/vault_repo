
      package App.Domain
      {
        import App.Domain.Codegen.*;
        import weborb.data.ActiveCollection;
        import mx.collections.ArrayCollection;
        import mx.rpc.Responder;
        import weborb.data.DynamicLoadEvent;
        import mx.events.CollectionEvent;
        import mx.rpc.events.FaultEvent;
        import mx.events.CollectionEventKind;
        
        [Bindable]
        [RemoteClass(alias="TractInc.Expense.Domain.Bill")]
        public dynamic class Bill extends _Bill
        {
            private var _relatedNotes:ActiveCollection = new ActiveCollection();
            private var _newNotes:ArrayCollection = new ArrayCollection();
            
            public function get relatedNotes():ActiveCollection 
            {
            	return _relatedNotes;
            }

	        public function loadNotes():void 
	        {
	        	_newNotes.removeAll();

	        	if (BillId != 0 && !_relatedNotes.IsLoaded) {
	        		if (!_relatedNotes.IsLoading) {
						_relatedNotes = ActiveRecords.Note.findByRelatedItemIdAndItemType(BillId, Note.NOTE_TYPE_BILL, {Monitored:false});
	        		}
					_relatedNotes.addEventListener("loaded", onNotesLoaded);
	        	}
	        }
	        
	        public function saveNotes(responder:Responder=null):void 
	        {
	        	_newNotes.removeAll();

	        	for each (var note:Note in _relatedNotes) {
	        		note.RelatedItemId = BillId;
	        		note.save(false, responder);
	        	}
	        }
	        
	        public function cancelNotes(responder:Responder=null):void 
	        {
	        	for each (var note:Note in _newNotes) {
	        		note.remove(new Responder(
	        			function (event:*):void {
	        				if (_newNotes.length == 0 && responder != null) {
	        					responder.result(this);
	        				}
	        			}, 
	        			function (event:FaultEvent):void {
	        				if (responder != null) {
		        				responder.fault(event);
	        				}
	        			}));
	        	}
	        }
	        
	        private function onNotesLoaded(event:DynamicLoadEvent):void 
	        {
				_relatedNotes.removeEventListener("loaded", onNotesLoaded);
	        	_relatedNotes.addEventListener(CollectionEvent.COLLECTION_CHANGE, onRelatedNotesChanged);
	        }
	        
	        private function onRelatedNotesChanged(event:CollectionEvent):void 
	        {
	        	if (event.kind == CollectionEventKind.ADD) {
	        		for each (var note:Note in event.items) {
	        			_newNotes.addItem(note);
	        		}
	        	}
	        }
	        
            public function isBillEditable():Boolean {
                return (Status == BillStatus.BILL_STATUS_NEW)
                    || (Status == BillStatus.BILL_STATUS_REJECTED)
                    || (Status == BillStatus.BILL_STATUS_CHANGED);
            }
            
            public var toSubmit:Boolean = false;
            
            public var isSaved:Boolean = false;
            
            public var statusTemp:BillStatus;
            public var notesTemp:String;
            
            public function toTempFields():void {
            	statusTemp = RelatedBillStatus;
            	notesTemp = Notes;
            }
            
            public function fromTempFields():void {
            	RelatedBillStatus = statusTemp;
            	Notes = notesTemp;
            }

        }
      }
    
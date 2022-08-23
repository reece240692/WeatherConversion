import { Component} from '@angular/core';
import { mockHistoryItems } from './mockHistoryItems';


@Component({
  selector: 'app-history-panel',
  templateUrl: './history-panel.component.html',
  styleUrls: ['./history-panel.component.scss']
})
export class HistoryPanelComponent  {

  HI = mockHistoryItems;

  constructor() {}
 

}

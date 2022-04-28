import 'reflect-metadata';
import {h} from "@stencil/core";
import {Container, Service} from "typedi";
import {ActivityTraits} from '../../models';
import {ActivityDisplayContext, ActivityDriver, ActivityIcon, ActivityIconRegistry} from '../../services';

@Service()
export class DefaultActivityDriver implements ActivityDriver {
  private readonly iconRegistry: ActivityIconRegistry;

  constructor() {
    this.iconRegistry = Container.get(ActivityIconRegistry);
  }

  display(context: ActivityDisplayContext): any {
    const iconRegistry = this.iconRegistry;
    const activityDescriptor = context.activityDescriptor;
    const activityType = activityDescriptor.activityType;
    const activity = context.activity;
    const canStartWorkflow = activity?.canStartWorkflow;
    const text = activityDescriptor?.displayName;
    const isTrigger = (activityDescriptor?.traits & ActivityTraits.Trigger) == ActivityTraits.Trigger;
    const borderColor = canStartWorkflow ? isTrigger ? 'border-green-600' : 'border-blue-600' : 'border-gray-300';
    const backgroundColor = canStartWorkflow ? isTrigger ? 'bg-green-400' : 'bg-blue-400' : 'bg-white';
    const textColor = canStartWorkflow ? 'text-white' : 'text-gray-700';
    const iconBackgroundColor = isTrigger ? 'bg-green-500' : 'bg-blue-500';
    const icon = iconRegistry.has(activityType) ? iconRegistry.get(activityType) : null;

    return (`
          <div>
            <div class="activity-wrapper border ${borderColor} ${backgroundColor} rounded text-white overflow-hidden">
              <div class="activity-content-wrapper flex flex-row">
                <div class="flex flex-shrink items-center ${iconBackgroundColor}">
                ${this.renderIcon(icon)}
                </div>
                <div class="flex items-center">
                  <div class="px-4 py-4">
                    <span class=${textColor}>${text}</span>
                  </div>
                </div>
              </div>
            </div>
          </div>
        `);
  }

  private renderIcon = (icon?: ActivityIcon): string => {

    if(!icon)
      return ''; //return '<div class="px-1 py-1"><span></span></div>';

    return (
      `<div class="px-4 py-1">
        ${icon()}
      </div>`
    );
  }

}
